using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class CarreraRepository : ICarreraRepository
    {
        private readonly List<CarreraViewModel> lstCarreras;

        public CarreraRepository()
        {

        }

        public int agregarCarrera(CarreraViewModel carreraViewModel)
        {
            throw new NotImplementedException();
        }

        public int actualizarCarrera(int idCarrera, CarreraViewModel carreraViewModel)
        {
            throw new NotImplementedException();
        }


        public bool eliminarEstudiante(int idCarrera)
        {
            throw new NotImplementedException();
        }

        public CarreraViewModel obtenerCarreraPorID(int idCarrera)
        {
            throw new NotImplementedException();
        }

        public List<CarreraViewModel> obtenerCarrera()
        {
            throw new NotImplementedException();
        }

    }
}
