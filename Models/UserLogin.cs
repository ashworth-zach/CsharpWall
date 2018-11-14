using System;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Models
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
