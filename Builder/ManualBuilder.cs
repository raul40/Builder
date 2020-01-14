using Builder.Builder.Interfaces;
using Builder.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class ManualBuilder : IBuilder
    {
        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void setEngine(IEngine _engine)
        {
            throw new NotImplementedException();
        }

        public void setGPS()
        {
            throw new NotImplementedException();
        }

        public void setSeats(int _number)
        {
            throw new NotImplementedException();
        }

        public void setTripComputer()
        {
            throw new NotImplementedException();
        }
    }
}
