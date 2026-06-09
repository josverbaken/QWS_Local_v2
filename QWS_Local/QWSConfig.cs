using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWS_Local
{
    public static class QWSConfig
    {
        private static string _cnVerkada = "Data Source=ch-sq-dc02;Initial Catalog=VerkadaSQ;Integrated Security=true;TrustServerCertificate=true;";
        private static string _cnQWSLocal = "Data Source=ch-sql02;Initial Catalog=QWS_SQ_Dev;Integrated Security=true;TrustServerCertificate=true;";
        public static int DefaultFeeCode { get; private set; } = 0;
        public static string DefaultAxleConfig { get; private set; } = "tba";
        public static int RetareInterval { get; private set; } = 180;
        public static int OverloadMinor { get; private set; } = 0;
        public static int OverloadSubstantial { get; private set; } = 10;
        public static int OverloadSevere { get; private set; } = 150;
        public static int SanctionToday { get; private set; } = 60;
        public static int SanctionThisWeek { get; private set; } = 120;
        public static int ImportedGrpCode { get; private set; } = 138;
        public static int ImportedPickUpGrpCode { get; private set; } = 139;
        public static int ClearTIQDelay { get; private set; } = 25;
        public static decimal MinimumMaterial { get; private set; } = 8.0M;
        public static decimal MinimumCart { get; private set; } = 12.0M;
        public static string ShortLoadFee { get; private set; } = "020-020-1";
        public static bool EnableSMS { get; private set; } = true;
        public static string cnQWSLocal
        { get
            {
                return _cnQWSLocal;
            }

        }
        public static string cnVerkada 
        { get
            {
                return _cnVerkada;
            } 
        }

        //public decimal Balance
        //{
        //    get
        //    {
        //        return _balance;
        //    }
        //    set
        //    {
        //        // Enforce data security and validation rules
        //        if (value >= 0)
        //        {
        //            _balance = value;
        //        }
        //    }
        //}


        public static bool LPREnabled { get; private set; } = true;

    }
}
