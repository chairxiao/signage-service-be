using System.ComponentModel.DataAnnotations;

namespace Signage.Service.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}