namespace ARM.LinguisticDBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Этнографические организации")]
    public class Этнографические_организации
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Этнографические_организации()
        {
            Дата_основания = DateTime.Now;
            Число_носителей_языков = new HashSet<Число_носителей_языков>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Column("Дата основания", TypeName = "date")]
        public DateTime Дата_основания { get; set; }

        [Column("Штаб-квартира")]
        [Required]
        [StringLength(160)]
        public string Штаб_квартира { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Число_носителей_языков> Число_носителей_языков { get; set; }
    }
}