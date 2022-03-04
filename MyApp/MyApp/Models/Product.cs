using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }

        [Required]
        [DisplayName("Название")]
        public virtual string Name { get; set; }

        [Required]
        [DisplayName("Описание")]
        public virtual string Description { get; set; }

        [Required]
        [DisplayName("Цена")]
        public virtual double Price { get; set; }
    }
}