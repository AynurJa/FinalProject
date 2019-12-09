using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.Models;
namespace MagicHome.ViewModel
{
    public class HomeVM
    {
        public List<Advert> aPrice { get; set;}
        public List<Advert> aRent { get; set;}
        public List<Advert> aNewHome { get; set;}
        public List<Advert> aSale { get; set; }
        public List<Advert> aVip { get; set; }
        public List<int> LikeIdList { get; set; }
    }
}
