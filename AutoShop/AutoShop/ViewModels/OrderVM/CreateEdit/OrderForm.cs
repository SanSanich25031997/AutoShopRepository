using System.ComponentModel.DataAnnotations;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderForm
    {
        [Display(Name = "Введите имя"), Required(ErrorMessage = "Имя должно быть введено!")]
        public string FirstName { get; set; }
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
