using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCegitimi.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string Sehir{ get; set; }
        public string ilce { get; set; }
        public string AcikAdres { get; set; }

    }
}