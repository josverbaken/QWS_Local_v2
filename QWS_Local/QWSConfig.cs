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
        // cnQWSLocal required throughout program; be sure to update on program load based on QWSLogin form
        private static string _cnQWSLocal = "Data Source=tba;Initial Catalog=tba;Integrated Security=true;TrustServerCertificate=true;";
        public static int DefaultFeeCode { get; set; } = 99;
        public static string DefaultAxleConfig { get; set; } = "tba";
        public static int RetareInterval { get; set; } = 99;
        public static int OverloadMinor { get; set; } = 99;
        public static int OverloadSubstantial { get; set; } = 99;
        public static int OverloadSevere { get; set; } = 99;
        public static int SanctionToday { get; set; } = 99;
        public static int SanctionThisWeek { get; set; } = 99;
        public static int ImportedGrpCode { get; set; } = 99;
        public static int ImportedPickUpGrpCode { get; set; } = 99;
        public static int ClearTIQDelay { get; set; } = 99;
        public static decimal MinimumMaterial { get; set; } = 99.0M;
        public static decimal MinimumCart { get; set; } = 99.0M;
        public static string ShortLoadFee { get; set; } = "tba";
        public static bool EnableSMS { get; set; } = true;
        public static string cnQWSLocal
        {
            get
            {
                return _cnQWSLocal;
            }
            set
            {
                // Enforce data security and validation rules
                _cnQWSLocal = value;
            }

        }
        public static string cnVerkada 
        { get
            {
                return _cnVerkada;
            }
            set
            {
                _cnVerkada = value;
            }
        }

        public static bool LPREnabled { get; private set; } = true;

    }
}
