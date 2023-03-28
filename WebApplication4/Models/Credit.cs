using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Оглавление")]
        [Required]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период кредита")]
        [Required]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Сумма кредита")]
        [Required]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [DisplayName("Процент")]
        [Required]
        public virtual int Procent { get; set; }
    }
}
