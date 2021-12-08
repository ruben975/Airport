using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class ControlTower : IControlTower
    {
        public int order = 0;
        private List<IAirplane> _airplanes = new List<IAirplane>();
        private List<IAirplane> _orderPlanes = new List<IAirplane>();


        public void CompleteRequests()
        {
            while (_orderPlanes.Any()) {
                var firstPlane = _orderPlanes.FirstOrDefault();
                if (firstPlane.Status == "WantsLand")
                { Console.WriteLine(firstPlane.Name + " You can land now"); firstPlane.Status = "Landed"; }
                else
                { Console.WriteLine(firstPlane.Name + " You can take off now"); firstPlane.Status = "InAir"; }
                _orderPlanes.Remove(firstPlane);
                foreach (IAirplane plane in _orderPlanes)
                {

                    Console.WriteLine(plane.Name + " sorry you need to wait because " + firstPlane.Name + " use the landing");

                }
            }
           
        }

       

        public void TakeOffRequest(IAirplane airplane)
        {
            _orderPlanes.Add(airplane); airplane.Status = "WantsTakeOff";
        }

        public void LandRequest(IAirplane airplane)
        {
            _orderPlanes.Add(airplane); airplane.Status = "WantsLand";
        }

        public void Register(IAirplane airplane)
        {
            _airplanes.Add(airplane); Console.WriteLine($"{airplane.Name} is on the radar");

        }

   
    }
}
