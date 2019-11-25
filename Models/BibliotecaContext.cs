using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proiect5_MTP.Models
{
    public class BibliotecaContext: DbContext
    {
        public BibliotecaContext() : base("BibliotecaContext")
        {

        }
        public virtual DbSet<Client> Clienti { get; set; }
        public virtual DbSet<Carte> Carti { get; set; }
        public virtual DbSet<Imprumut> Imprumuturi { get; set; }
    }
}