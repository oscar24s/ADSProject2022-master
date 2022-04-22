﻿using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class GrupoRepository : IGrupoRepository
    {

        private readonly List<GrupoViewModel> lstGrupos;

        public GrupoRepository()
        {
            lstGrupos = new List<GrupoViewModel>
            {
               new GrupoViewModel {idGrupo = 1, idCarrera= 1, idMateria = 1, idProfesor = 1, ciclo = "01", anio = 2022 }
            };
        }

        public int agregarGrupo(GrupoViewModel grupoViewModel)
        {
            try
            {
                if (lstGrupos.Count > 0)
                {
                    grupoViewModel.idGrupo = lstGrupos.Last().idGrupo + 1;
                }
                else
                {
                    grupoViewModel.idGrupo = 1;
                }
                lstGrupos.Add(grupoViewModel);
                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel)
        {
            try
            {
                lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = grupoViewModel;
                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarGrupo(int idGrupo)
        {
            lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));
            return true;
        }

        public GrupoViewModel obtenerGrupoPorID(int idGrupo)
        {
            try
            {
                var item = lstGrupos.Find(x => x.idGrupo == idGrupo);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GrupoViewModel> obtenerGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
