﻿using ADSProject.Data;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class CarreraRepository : ICarreraRepository
    {
        //private readonly List<CarreraViewModel> lstCarreras;
        private readonly ApplicationDbContext applicationDbContext;

        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            /*lstCarreras = new List<CarreraViewModel>
            {
                new CarreraViewModel {idCarrera = 1, CodigoCarrera= "ADS001", NombreCarrera = "Análisis de sistemas"}
            };*/
            this.applicationDbContext = applicationDbContext;
        }

        public int agregarCarrera(CarreraViewModel carreraViewModel)
        {
            try
            {
                /*if(lstCarreras.Count > 0)
                {
                    carreraViewModel.idCarrera = lstCarreras.Last().idCarrera + 1;
                }
                else
                {
                    carreraViewModel.idCarrera = 1;
                }
                lstCarreras.Add(carreraViewModel);
                return carreraViewModel.idCarrera;*/
                applicationDbContext.Carreras.Add(carreraViewModel);
                applicationDbContext.SaveChanges();

                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarCarrera(int idCarrera, CarreraViewModel carreraViewModel)
        {
            try
            {
                //lstCarreras[lstCarreras.FindIndex(x => x.idCarrera == idCarrera)] = carreraViewModel;
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);


                applicationDbContext.Entry(item).CurrentValues.SetValues(carreraViewModel);

                applicationDbContext.SaveChanges();

                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public bool eliminarCarrera(int idCarrera)
        {
            try
            {
                //lstCarreras.RemoveAt(lstCarreras.FindIndex(x => x.idCarrera == idCarrera));
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);

                //Borrar registro por completo
                //applicationDbContext.Carreras.Remove(item);

                item.estado = false;
                applicationDbContext.Attach(item);

                applicationDbContext.Entry(item).Property(x => x.estado).IsModified = true;
                applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public CarreraViewModel obtenerCarreraPorID(int idCarrera)
        {
            try
            {
                //var item = lstCarreras.Find(x => x.idCarrera == idCarrera);
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<CarreraViewModel> obtenerCarrera()
        {
            try
            {
                //Obtener todos las Carreras sin filtro (estado =1)
                return applicationDbContext.Carreras.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
