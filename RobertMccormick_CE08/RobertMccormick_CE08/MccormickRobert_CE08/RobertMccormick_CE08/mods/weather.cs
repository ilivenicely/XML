using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace MccormickRobert_JSONandAPI.mods

{

    public class Weather
    {
        public string UniqueKey { get; set; }
     
        public decimal CurrTemp { get; set; }

        public decimal FeelsTemp { get; set; }

        public decimal RelativeHumidity { get; set; }

        public decimal WindSpeed { get; set; }

        public string Direction { get; set; }


          public string City { get; set; }
        public string State { get; set; }
    }
}
