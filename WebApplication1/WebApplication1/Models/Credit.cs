using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Название ")]
        [Required]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период ")]
        [Required]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Сумма")]
        [Required]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [DisplayName("Ставка%")]
        [Required]
        public virtual int Procent { get; set; }
    }
}