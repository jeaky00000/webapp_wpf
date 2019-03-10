using System.Collections.Generic;
using DMSkin.Core.MVVM;
using WebAPP.Model;

namespace WebAPP.ViewModel
{
    public class MainWindowViewModel1 : ViewModelBase
    {
        public MainWindowViewModel1()
        {
            LoadUserInfoList();
        }

        public List<UserInfo> UserInfoList { get; set; }

        private void LoadUserInfoList()
        {
            UserInfoList = new List<UserInfo>();
            // Task.Factory.StartNew(() => { });
            for (var i = 50 - 1; i >= 0; i--)
                UserInfoList.Add(new UserInfo
                {
                    Index = i + 1,
                    Info = $"user name {i}",
                    Name = $"user name {i}",
                    Title = i % 2 == 0 ? "Teacher" : "Student"
                });
        }
    }
}