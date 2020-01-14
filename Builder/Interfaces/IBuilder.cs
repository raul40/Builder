using Builder.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder.Interfaces
{
    public interface IBuilder
    {
        void Reset();
        void setSeats(int _number);
        void setEngine(IEngine _engine);
        void setTripComputer();
        void setGPS();
    }
}
