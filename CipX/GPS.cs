using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CipX
{
    class GPS
    {
        public static string status { get; set; }
        public static double lat { get; set; }
        public static double lon { get; set; }
        public static int numberOfSatellites { get; set; }
        public static double accuracy { get; set; }
        public static DateTime gpsTtime { get; set; }
        public static string gpgga { get; set; }

    }
}
