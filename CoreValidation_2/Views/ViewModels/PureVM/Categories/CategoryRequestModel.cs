using System.ComponentModel.DataAnnotations;

namespace CoreValidation_2.Views.ViewModels.PureVM.Categories
{
    // PureVM
    // CategoryVM
    // CAtegoryRequestModel : Bizim ona yollayacağımız model (Serverin kullanıcıya)
    // CategoryResponseModel
    public class CategoryRequestModel
    {
        // DataAnnotation'da yer tutucu operatörleri sayılarla verilir... 0, ilgili property neyse direk o ismi alır...
        [Required(ErrorMessage = "{0} zorunlu bir alandır")]
        [Display(Name = "Kategori Ismi")] // Bizim property'miz kullanıcıya ne şekilde gözüksün.
        [MaxLength(15, ErrorMessage = "{0} en fazla {1} karakter alabilir")]
        [MinLength(5, ErrorMessage = "{0} minimum {1} karakter alabilir")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [Display(Name = "Aciklama")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter alabilir")]
        public string Description { get; set; }
    }
}
