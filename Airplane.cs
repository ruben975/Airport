using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Airplane : IAirplane
    {

        public IControlTower ControlTower { get; set; }
        public int Id { get; }
        public string Name { get; }
        public string Status { get; set; } = "Without request";
        public bool TakeOffRequest { get; set; }
        public bool Landing { get; set; }

        public Airplane(string name, IControlTower controlTower)
        {
            ControlTower = controlTower;
            this.Name = name;
            ControlTower.Register(this);
        }

        public void RequestLanding()
        {
            ControlTower.LandRequest(this);
        }

        public void RequestTakeOff()
        {
            ControlTower.TakeOffRequest(this);
        }


    }
   
}
