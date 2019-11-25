using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proiect5_MTP.Models
{
    public class Imprumut
    {
        public int ImprumutId { get; set; }
        public int ClientId { get; set; }
        public int CarteId { get; set; }
        [Display(Name = "Data imprumut"), DataType(DataType.Date)]
        public DateTime DataImprumut { get; set; }
        public virtual Client Client { get; set; }
        public virtual Carte Carte { get; set; }
    }
}