namespace ARM.LinguisticDBModel
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Число носителей языков")]
    public class Число_носителей_языков
    {
        public Число_носителей_языков()
        {
            Дата_подсчёта = DateTime.Now;
        }

        [Column("ID языка", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? ID_языка { get; set; }

        [Column("Дата подсчёта", Order = 1, TypeName = "date")]
        public DateTime Дата_подсчёта { get; set; }

        [Column("ID организации, производившей подсчет", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? ID_организации__производившей_подсчет { get; set; }

        [Column("Число носителей")]
        public int Число_носителей { get; set; }

        public virtual Этнографические_организации Этнографические_организации { get; set; }

        public virtual Языки Языки { get; set; }
    }
}