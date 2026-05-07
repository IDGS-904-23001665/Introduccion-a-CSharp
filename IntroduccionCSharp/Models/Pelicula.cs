using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCSharp.Models
{
    public class Pelicula
    {
        public String Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion { get; set; }
        public String Pais { get; set; }
    }
}