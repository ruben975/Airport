using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlTower = new ControlTower();

            var plane1 = new Airplane("plane1",controlTower);
            var plane2 = new Airplane("plane2", controlTower);
            var plane3 = new Airplane("plane3", controlTower);
            var plane4 = new Airplane("plane4", controlTower);

            plane3.RequestLanding();
            plane2.RequestLanding();
            plane4.RequestTakeOff();
            plane1.RequestTakeOff();

            controlTower.CompleteRequests();
        
           
           

        }
    }
}
