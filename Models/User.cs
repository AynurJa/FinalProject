using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;



namespace MagicHome.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            Adverts = new HashSet<Advert>();
        }

       [Required,StringLength(100)]
        public string firstname { get; set;}
       [Required,StringLength(150)]
        public string lastname { get; set; }

        public bool Status { get; set; }


        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
