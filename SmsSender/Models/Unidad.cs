using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsSender.Models
{
    public class Unidad
    {
        public string NumeroSerie { get; set; }
        public string Empresa { get; set; }
        public string Marca { get; set; }
        public string Telefono { get; set; }
        public bool EsSeleccionado { get; set; }
    }
}