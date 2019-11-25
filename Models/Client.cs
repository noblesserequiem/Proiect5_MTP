﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proiect5_MTP.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nume { get; set; }
        [MaxLength(13), MinLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "CNP invalid")]
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public virtual ICollection<Imprumut> Imprumuturi { get; set; }
    }
}