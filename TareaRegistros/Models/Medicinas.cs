using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaRegistros.Models
{
    public class Medicinas
    {
        [key]
        public int MedicinaId { get; set; }
        public string NombreMedicina { get; set; }
        public int CantidadExistencia { get; set; }
        public int PrecioCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}