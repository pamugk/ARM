namespace ARM.UsersDBModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Пользователи
    {
        public Пользователи()
        {
            Дата_регистрации = DateTime.Now.Date;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Логин { get; set; }

        [Column("Хэш пароля")]
        [Required]
        [StringLength(88)]
        public string Хэш_пароля { get; set; }

        [Required]
        [StringLength(88)]
        public string Соль { get; set; }

        public bool Администратор { get; set; }

        [Column("Дата регистрации", TypeName = "date")]
        public DateTime Дата_регистрации { get; set; }
    }
}