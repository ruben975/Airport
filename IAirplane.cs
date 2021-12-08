using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public interface IAirplane
    {
        public int Id { get; }
        public string Name { get; }
        public string Status { get; set; }
        public bool TakeOffRequest { get; set; }
        public bool Landing { get; set; }

        public void RequestTakeOff();
        public void RequestLanding();
     

    }
}
