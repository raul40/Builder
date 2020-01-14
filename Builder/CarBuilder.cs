using Builder.Builder.Interfaces;
using Builder.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _entCar = new Car();

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._entCar = new Car();
        }

        public void setEngine(IEngine _engine)
        {
            _engine.cEngineType = "Normal";
        }

        public void setGPS()
        {
            _entCar.lHaveGPS = true;
        }

        public void setSeats(int _number)
        {
            _entCar.iNumSeats = _number;
        }

        public void setTripComputer()
        {
            _entCar.lHaveTripComputer = true;
        }

        public Car GetCar()
        {
            Car result = this._entCar;

            this.Reset();

            return result;
        }
    }
}
