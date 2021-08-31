using System.ComponentModel.DataAnnotations;

namespace AddressBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}