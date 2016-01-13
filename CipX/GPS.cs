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
        public static double accuracyIdeal = 15;
        public static DateTime gpsTime { get; set; }
        public static string msg { get; set; }
        public static DateTime gpsOldTime { get; set; }
        public static string gpgga { get; set; }
        public static string error { get; set; }

    }
}
