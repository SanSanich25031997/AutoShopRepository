using System.ComponentModel.DataAnnotations;

namespace AutoShop.ViewModels.OrderVM
{
    public class OrderForm
    {
        public int Id { get; set; }
        [Display(Name = "Введите имя"), Required(ErrorMessage = "Имя должно быть введено!")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию"), Required(ErrorMessage = "Фамилия должна быть введена!")]
        public string LastName { get; set; }
        [Display(Name = "Ваш адрес"), Required(ErrorMessage = "Адрес должен быть введен")]
        public string Address { get; set; }
        [Display(Name = "Номер телефона"), Required(ErrorMessage = "Телефон должен быть введен!")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Ваш E-mail"), Required(ErrorMessage = "Email должен быть введен!")]
        public string Email { get; set; }
    }
}
