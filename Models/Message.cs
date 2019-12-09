using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicHome.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter name please!")]
        [StringLength(100)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Email please!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Please enter a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter Content please!")]
        [StringLength(650)]
        public string Content { get; set; }

        [Required(ErrorMessage ="Enter Title please!")]
        [StringLength(150)]
        public string Title { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsRead { get; set; }
    }
}
