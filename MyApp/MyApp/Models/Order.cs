using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Order
    {
        public virtual int OrderId { get; set; }

        [Required]
        [DisplayName("Название продукта")]
        public virtual string ProductName { get; set; }

        [Required]
        [DisplayName("Количество")]
        public virtual int Amount { get; set; }

        [DisplayName("Цена")]
        public virtual double Price { get; set; }

        [Required]
        [DisplayName("Имя покупателя")]
        public virtual string CustomerName { get; set; }

        [Required]
        [DisplayName("Телефон покупателя")]
        public virtual string Phone { get; set; }

        [DisplayName("Адрес доставки")]
        public virtual string Address { get; set; }

        [DisplayName("Дата доставки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime Date { get; set; }
    }
}