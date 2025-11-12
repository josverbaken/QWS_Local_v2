using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;


namespace QWS_Local
{
    class WeighbridgeRead
    {
        private  int iLoopDelay = 200;
        private  decimal decWeight = System.Convert.ToDecimal(0.00);
        private  Boolean blContinue = true;
        private  decimal CurrentWeight = 222.22M;

        public decimal getCurrentWeight()
        {
            if (CurrentWeight != 222.22M)
            {
                return CurrentWeight;
            }
            return 0.00M;
        }

        public decimal CurrentWeightSync(string WB)
        {
            ReadOnceSync(WB);
            return CurrentWeight;
        }

        public void StopMonitoring()
        {
            blContinue = false;
        }


        public async  void ReadWeighbridge(string WB)
        {
            blContinue = true;
            CurrentWeight = 11.11M;
            while (blContinue)
            {
                await ReadOnce( iLoopDelay, WB);
            }
        }

        public async Task<decimal> GetSingleWeight(string WB)
        {
            await ReadOnce(10, WB);
            return CurrentWeight;
        }
        private async Task ReadOnce(int myDelay, string WB)
        {
            string strDecode = "";
            string strStatus = "x";
            TcpClient tcpClient = new TcpClient();
           
            await Task.Delay(myDelay);
            if (WB == "NQWB1")
            {
                tcpClient.Connect("192.168.61.29", 2223); // Rinstrum at NQ
            }
            else if (WB == "NQWB2")
            {
                 tcpClient.Connect("192.168.61.34", 1900); // Systec at NQ
            }
            else if (WB == "NQWB3")
            {
                tcpClient.Connect("192.168.61.43", 2223); // Rinstrum at NQ April 2023

            }
            else if (WB == "SQWB1")
            {
                 tcpClient.Connect("192.168.2.49", 2223); // Rinstrum at SQ
            }
            else
            {
                // error
            }
            // Uses the GetStream public method to return the NetworkStream.
            tcpClient.ReceiveBufferSize = 24; //256
            NetworkStream netStream = tcpClient.GetStream();

            if (netStream.CanRead)
            {
                // Reads NetworkStream into a byte buffer.
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];

                // Read can return anything from 0 to numBytesToRead. 
                // This method blocks until at least one byte is read.
                netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

                // Returns the data received from the host to the console.
                //string returndata = Encoding.UTF8.GetString(bytes);
                string returndata = Encoding.ASCII.GetString(bytes);

                if (WB == "NQWB1")
                {
                    //decode - start with hardcoded for NQ
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        strDecode = newString.Substring(0, 8); 
                        strStatus= newString.Substring(8, 1);
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                        else if (strStatus == "M")
                        {
                            strStatus = "Moving";
                        }
                    }
                    catch (Exception)
                    {
                        // 20220713 do nothing because occuring too often and 999 triggers inhibit mode
                        //CurrentWeight = System.Convert.ToDecimal(999.99);

                        //throw;
                    }
                }
                if (WB == "NQWB2")
                {
                //decode - start with hardcoded for NQ Ultra
                    strDecode = returndata.Substring(5, 7);
                    strStatus = returndata.Substring(0, 2);
                    decWeight = System.Convert.ToDecimal(strDecode);
                    CurrentWeight = decWeight;
                    if (strStatus == "S ") // note trailing space
                    {
                    strStatus = "GOOD";
                    }
                    else if (strStatus == "SD")
                    {
                        strStatus = "Moving";
                    }
                }
                if (WB == "NQWB3")
                {
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        strDecode = newString.Substring(0, 8);
                        strStatus = newString.Substring(8, 1);
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                        else if (strStatus == "M")
                        {
                            strStatus = "Moving";
                        }
                    }
                    catch (Exception)
                    {
                        // 20220713 do nothing because occuring too often and 999 triggers inhibit mode
                        //CurrentWeight = System.Convert.ToDecimal(999.99);

                        //throw;
                    }
                }
                if (WB == "SQWB1")
                {
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        int iLen = newString.Length;//iLen = 9,  must be some non printing or else " are counted
                        strDecode = newString.Substring(0, iLen - 1);//(1, 6);
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight * 1000;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                    }
                    catch (Exception)
                    {
                        // Do nothing, line below is for debugging
                        //CurrentWeight = System.Convert.ToDecimal(999.99);
                        //throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot read data from this stream.");
                tcpClient.Close();
                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return;
            }
            tcpClient.Close();

            netStream.Close();
        }
        private string BuildString(byte[] bytes)
        {
            // STX = 2
            // ETX = 3
            bool blBuildString = false;
            int msgLength = 0;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var value in bytes)
            {
                if (value == 3)  // ETX
                {
                    blBuildString = false;
                    break;
                }
                if (value == 71) // G
                {
                    sb.Append(System.Convert.ToChar(value));
                    blBuildString = false;
                    break;
                }
                if (value == 77) // M
                {
                    sb.Append(System.Convert.ToChar(value));
                    blBuildString = false;
                    break;
                }
                if (blBuildString == true) // ? restrict to 0-9, space and .
                {
                    sb.Append(System.Convert.ToChar(value));
                    msgLength += 1;
                }
                if (value == 2) // STX
                {
                    blBuildString = true;
                }
            }


            string newString = sb.ToString();
            return newString;


        }


        private void ReadOnceSync(string WB)
        {
            string strDecode = "";
            string strStatus = "x";
            TcpClient tcpClient = new TcpClient();

            if (WB == "NQWB1")
            {
                tcpClient.Connect("192.168.61.29", 2223); // Rinstrum at NQ
            }
            else if (WB == "NQWB2")
            {
                tcpClient.Connect("192.168.61.34", 1900); // Systec at NQ
            }
            else if (WB == "NQWB3")
            {
                tcpClient.Connect("192.168.61.43", 2223); // Rinstrum at NQ April 2023

            }
            else if (WB == "SQWB1")
            {
                tcpClient.Connect("192.168.2.49", 2223); // Rinstrum at SQ
            }
            else
            {
                // error
            }
            // Uses the GetStream public method to return the NetworkStream.
            tcpClient.ReceiveBufferSize = 24; //256
            NetworkStream netStream = tcpClient.GetStream();

            if (netStream.CanRead)
            {
                // Reads NetworkStream into a byte buffer.
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];

                // Read can return anything from 0 to numBytesToRead. 
                // This method blocks until at least one byte is read.
                netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

                // Returns the data received from the host to the console.
                //string returndata = Encoding.UTF8.GetString(bytes);
                string returndata = Encoding.ASCII.GetString(bytes);

                if (WB == "NQWB1")
                {
                    //decode - start with hardcoded for NQ
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        strDecode = newString.Substring(0, 8);
                        strStatus = newString.Substring(8, 1);
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                        else if (strStatus == "M")
                        {
                            strStatus = "Moving";
                        }
                    }
                    catch (Exception)
                    {
                        // 20220713 do nothing because occuring too often and 999 triggers inhibit mode
                        //CurrentWeight = System.Convert.ToDecimal(999.99);

                        //throw;
                    }
                }
                if (WB == "NQWB2")
                {
                    //decode - start with hardcoded for NQ Ultra
                    strDecode = returndata.Substring(5, 7);
                    strStatus = returndata.Substring(0, 2);
                    decWeight = System.Convert.ToDecimal(strDecode);
                    CurrentWeight = decWeight;
                    if (strStatus == "S ") // note trailing space
                    {
                        strStatus = "GOOD";
                    }
                    else if (strStatus == "SD")
                    {
                        strStatus = "Moving";
                    }
                }
                if (WB == "NQWB3")
                {
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        strDecode = newString.Substring(0, 8);
                        strStatus = newString.Substring(8, 1);
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                        else if (strStatus == "M")
                        {
                            strStatus = "Moving";
                        }
                    }
                    catch (Exception)
                    {
                        // 20220713 do nothing because occuring too often and 999 triggers inhibit mode
                        //CurrentWeight = System.Convert.ToDecimal(999.99);

                        //throw;
                    }
                }
                if (WB == "SQWB1")
                {
                    try
                    {
                        string newString;
                        newString = BuildString(bytes);
                        int iLen = newString.Length;//iLen = 9 e.g. "/   0.00G"
                        strDecode = newString.Substring(0, iLen - 1); // strip off trailing G
                        decWeight = System.Convert.ToDecimal(strDecode);
                        CurrentWeight = decWeight * 1000;
                        if (strStatus == "G")
                        {
                            strStatus = "GOOD";
                        }
                    }
                    catch (Exception)
                    {
                        // Do nothing, line below is for debugging
                        //CurrentWeight = System.Convert.ToDecimal(999.99);
                        //throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot read data from this stream.");
                tcpClient.Close();
                // Closing the tcpClient instance does not close the network stream.
                netStream.Close();
                return;
            }
            tcpClient.Close();

            netStream.Close();
        }

    }
}

