using Builder.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void MakeSUV()
        {
            IEngine Engine = new NormalEngine();
            _builder.setSeats(5);
            _builder.setEngine(Engine);
            _builder.setGPS();
        }

        public void MakeSportCar()
        {
            IEngine Engine = new SportEngine();
            _builder.setSeats(2);
            _builder.setEngine(Engine);
            _builder.setGPS();
            _builder.setTripComputer();
        }
    }
}
