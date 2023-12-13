using System.ComponentModel.DataAnnotations;

namespace eticaret_uygula.Dto
{
    public class AppUserRegisterDto
    {
        [Display(Name ="Adınız")]
        [Required(ErrorMessage ="Adınızı Boş Geçemezsiniz")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadınız Girin")]
        [Required(ErrorMessage = "Soyadınızı Boş Geçemezsiniz")]
        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adını Girin")]
        [Required(ErrorMessage = "Kullanıcı Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Display(Name = "Şehiri Girin")]
        [Required(ErrorMessage = "Şehiri Boş Geçemezsiniz")]
        public string City { get; set; }
        [Display(Name = "Email Girin")]
        [Required(ErrorMessage = "Email Boş Geçemezsiniz")]
        public string Email { get; set; }
        [Display(Name = "Telefon Girin")]
        [Required(ErrorMessage = "Telefon Boş Geçemezsiniz")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şifrenizi Girin")]
        [Required(ErrorMessage = "Şifrenizi Boş Geçemezsiniz")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
}
