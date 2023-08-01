using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadLine();
            try
            {
                string connect2SAP = "xxx";
                Console.WriteLine(connect2SAP);
                connect2SAP = ConfigurationManager.AppSettings.Get("appSetting1");
                Console.WriteLine(connect2SAP);
                connect2SAP = ConfigurationManager.ConnectionStrings["cnSAP"].ToString();
                Console.WriteLine(connect2SAP);
                Console.ReadLine();
                string data = GetData().GetAwaiter().GetResult();
                Console.Write($"returned data: {data}");
                Console.WriteLine("Now try to login to SAP");
                Console.ReadLine();
                data = " waiting ";
                data = SAPLogin().GetAwaiter().GetResult();
                Console.Write($"returned data: {data}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        static async Task<string> GetData()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://ch-sapsvr-02:50000");
            var textContent = await response.Content.ReadAsStringAsync();

            httpClient.Dispose();

            return textContent;
        }

        static async Task<string> SAPLogin()
        {

            var content = new StringContent("{\"CompanyDB\":\"SBO_Dockets\",\"Password\":\"Basalt231\",\"Username\":\"manager\"}", Encoding.UTF8, "application/json");
            var _httpClient = new HttpClient();
            var result = await _httpClient.PostAsync("https://ch-sapsvr-02:50000/Login", content); //or PostAsync for POST

            return result.ToString();
        }
    }
}
