using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Car {
        public Engine CarEngine { get; set; }
        public Car(Engine e)
        {
            this.CarEngine = e;
        }
    }

    //Custom Datatype
    public class Engine {
        public string Brand { get; set; }
        public string EngineType { get; set; }
        public int HorsePower { get; set; }

    }
}
