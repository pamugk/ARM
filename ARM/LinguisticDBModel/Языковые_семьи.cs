namespace ARM.LinguisticDBModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Языковые семьи")]
    public class Языковые_семьи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Языковые_семьи()
        {
            Языки = new HashSet<Языки>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Column("ID языковой макросемьи")]
        public int? ID_языковой_макросемьи { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Языки> Языки { get; set; }

        public virtual Языковые_макросемьи Языковые_макросемьи { get; set; }
    }
}