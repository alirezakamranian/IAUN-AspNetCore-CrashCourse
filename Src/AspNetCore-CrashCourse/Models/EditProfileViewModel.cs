using System.ComponentModel.DataAnnotations;

namespace AspNetCore_CrashCourse.Models
{
    public class EditProfileViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        public string LastName { get; set; }
    }
}
