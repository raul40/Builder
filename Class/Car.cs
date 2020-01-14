using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public class Car
    {
        public int iNumSeats { get; set; }

        public IEngine entEngine { get; set; }

        public bool lHaveTripComputer { get; set; }

        public bool lHaveGPS { get; set; }

        public string ListParts()
        {
            string str = string.Empty;

            str += "Number of Seats: " + iNumSeats.ToString();
            str += ", Engine Type: " + entEngine.cEngineType;
            str += lHaveTripComputer ? ", Trip Computer" : "";
            str += lHaveGPS ? ", GPS" : "";


            return "Product Parts: " + str + "\n";
        }
    }
}
