namespace MagicHome.ViewModel.RequestModels
{
    public class AdvertSearchInputModel
    {
        public int? CategoryId { get; set; }
        public string SearchKey { get; set; }
        public int? FromPrice { get; set; }
        public int? ToPrice { get; set; }
    }
}
