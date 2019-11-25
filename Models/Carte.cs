using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proiect5_MTP.Models
{
    public class Carte
    {
        public int CarteId { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        [Range(1900, 2016), Display(Name = "Anul aparitiei")]
        public int AnAparitie { get; set; }
    }
}