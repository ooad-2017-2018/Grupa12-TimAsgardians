namespace ProjekatAsgardiansWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uposlenik")]
    public partial class Uposlenik
    {
        public int UposlenikId { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Brtel { get; set; }

        public string Adresa { get; set; }
    }
}
