using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane: IService<Plane>
    {

        public IList<Passenger> GetPassenger(Plane p);
        public IList<Flight> GetFlight(int n);
        public bool IsAvailableFlight(Flight f, int n);
        public void DeletePlanes();
    }
}
