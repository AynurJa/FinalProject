using MagicHome.Models;
using System.Collections.Generic;

namespace MagicHome.ViewModel.RequestModels
{
    public class AdvertSearchOutputModel : BaseOutputModel
    {
        public List<Advert> SearchResult { get; set; }
    }
}
