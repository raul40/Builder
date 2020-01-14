using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public class SportEngine : IEngine
    {
        public string _cEngineType = "Sport Engine";

        string IEngine.cEngineType { get; set; }
    }
}
