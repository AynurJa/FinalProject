using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MagicHome.Models
{
    public class AdvertType
    {
        public AdvertType()
        {
            Adverts = new HashSet<Advert>();
        }
        public int Id { get; set;}
        [StringLength(30,ErrorMessage ="Please Write correct Type")]
        [MinLength(7,ErrorMessage ="Must be Min-length 4")]
        public string SaleType { get; set;}
        public virtual ICollection<Advert> Adverts { get; set;}
    }
}
