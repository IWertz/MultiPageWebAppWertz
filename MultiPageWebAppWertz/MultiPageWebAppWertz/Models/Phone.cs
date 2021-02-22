using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppWertz.Models
{
    public class Phone
    {
        //EF Core will configure the database to generate this value
        public int PhoneId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [Range(0000000000, 9999999999, ErrorMessage = "Number must be written as 0000000000 - 9999999999")]
        public long? PNumber { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        public string Note { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower().ToString();
    }
}
