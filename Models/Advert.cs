using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MagicHome.Models;
using Microsoft.AspNetCore.Http;

namespace MagicHome.Models
{
    public class Advert
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter number")]
        [Range(100, 700000, ErrorMessage = "Please enter a valid number")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter Room Count")]
        [Range(1, 15, ErrorMessage = "Max 15 Room Count!")]
        public int RoomCount { get; set; }

        [Required(ErrorMessage = "Please enter Bath Room Count")]
        [Range(1, 5, ErrorMessage = "Max 5 bath Room")]
        public int BathRoom { get; set; }

        [Required(ErrorMessage = "Please enter Bed Room Count")]
        [Range(1, 5, ErrorMessage = "Max 5 bath Room")]
        public int BedRoom { get; set; }

        [Required(ErrorMessage = "Enter address!")]
        [StringLength(200, ErrorMessage = "Maximum length is 200")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Home Area")]
        [Range(70, 8000, ErrorMessage = "Max area 8000m2")]
        public int RoomArea { get; set; }

        [Required(ErrorMessage = "Enter description!")]
        [StringLength(600, ErrorMessage = "Maximum length is 600")]
        public string Description { get; set; }

        public bool IsNew { get; set; }

        public bool IsVip { get; set; }

        public DateTime CreateAt { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
       
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [Required(ErrorMessage ="Choose Advert Type")]
        public int AdvertTypeId { get; set; }

        public string UserId { get; set; } 
        [Required(ErrorMessage ="Enter City name")]

        public int CityId { get; set; }

        public virtual AdvertType AdvertType { get; set; }

        public virtual User User { get; set; }

        public virtual City City { get; set; }



    }
}
