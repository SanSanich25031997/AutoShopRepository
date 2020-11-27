using System.Collections.Generic;

namespace DataLayer.Dictonaries
{
    public static class CarsMathing
    {
        public static Dictionary<string, string> CarsMatchingDictionary { get; set; }
        = new Dictionary<string, string> { { "Electro", "Электромобили" }, { "Fuel", "Топливные автомобили" } };
    }
}
