namespace ARM.LinguisticDBModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Языки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Языки()
        {
            Число_носителей_языков = new HashSet<Число_носителей_языков>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Column("ID языковой семьи")]
        public int? ID_языковой_семьи { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Число_носителей_языков> Число_носителей_языков { get; set; }

        public virtual Языковые_семьи Языковые_семьи { get; set; }
    }
}