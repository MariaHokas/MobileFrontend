using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFront.Models
{
    public class GpsLocationModel
    {
        //static tarkoittaa sitä että alla olevia tietoja on vaan yksi sovelluksessa
        public static double Latitude { get; set; }
        public static double Longitude { get; set; }
        public static double Altitude { get; set; }
    }
}
