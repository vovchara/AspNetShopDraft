using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetShop.Data.Models
{
    public class OrderModel
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name="Введіть ім'я")]
        [StringLength(10)]
        [Required(ErrorMessage ="Довжина не менше 5 символів")]
        public string Name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина не менше 5 символів")]
        public string SurName { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина не менше 10 символів")]
        public string Adress { get; set; }

        [Display(Name = "Введіть телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина не менше 10 символів")]
        public string Phone { get; set; }

        [Display(Name = "Введіть email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина не менше 5 символів")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetailModel> OrderDetails { get; set; }
    }
}
