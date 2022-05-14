using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Models
{
    public class GrupoViewModel
    {
        [Key]
        [Display(Name = "ID Grupo")]
        public int idGrupo { get; set; }

        [Display(Name = "ID Carrera")]
        public int idCarrera { get; set; }

        [Display(Name = "ID Materia")]
        public int idMateria { get; set; }

        [Display(Name = "ID Profesor")]
        public int idProfesor { get; set; }

        [Display(Name = "Ciclo")]
        public String ciclo { get; set; }

        [Display(Name = "Anio")]
        public int anio { get; set; }

        public bool estado { get; set; }
    }
}
