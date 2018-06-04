namespace ProjekatAsgardiansWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Putnik")]
    public partial class Putnik
    {
        public int PutnikId { get; set; }

        public bool Kontaktiran { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Brtel { get; set; }

        public string Adresa { get; set; }

        public int? Lokacija_LokacijaId { get; set; }

        public virtual Lokacija Lokacija { get; set; }
    }
}
