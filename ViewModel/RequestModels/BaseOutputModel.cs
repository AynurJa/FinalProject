using System.Collections.Generic;

namespace MagicHome.ViewModel.RequestModels
{
    public class BaseOutputModel
    {
        public List<string> CustomErrorMessage { get; set; }
        public bool HasError { get; set; }
    }
}
