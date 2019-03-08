using DMSkin.Core.MVVM;

namespace WebAPP.Model
{
    public class UserInfo : ViewModelBase
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
    }
}