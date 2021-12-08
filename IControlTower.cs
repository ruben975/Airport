using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public interface IControlTower
    {
        public void Register(IAirplane airplane);
        
        public void TakeOffRequest(IAirplane airplane);
        public void LandRequest(IAirplane airplane);



    }
}
