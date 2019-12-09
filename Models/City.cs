using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MagicHome.Models
{
    public class City
    {
        public City()
        {
            Adverts = new HashSet<Advert>();
        }
        public int Id { get; set; }

       
        [StringLength(30,ErrorMessage ="Enter correct City Name")]
        [MinLength (4,ErrorMessage = "must be Minimum characters are 4")]
        public string CityName { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }

    }
}
