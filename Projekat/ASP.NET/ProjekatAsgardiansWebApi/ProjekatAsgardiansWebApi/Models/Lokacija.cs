namespace ProjekatAsgardiansWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lokacija")]
    public partial class Lokacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lokacija()
        {
            Putniks = new HashSet<Putnik>();
        }

        public int LokacijaId { get; set; }

        public string Informacije { get; set; }

        public double Cijena { get; set; }

        public string Ime { get; set; }

        public int? Vodic_VodicId { get; set; }

        public virtual Vodic Vodic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Putnik> Putniks { get; set; }
    }
}
