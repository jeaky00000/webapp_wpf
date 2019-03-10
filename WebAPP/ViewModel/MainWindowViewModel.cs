using System.Windows.Controls;
using DMSkin.Core.MVVM;
using WebAPP.API;
using WebAPP.Model;

namespace WebAPP.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region 页面切换

        private Page currentPage = PageManager.page1;

        /// <summary>
        ///     当前页面
        /// </summary>
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        private LeftMenu selectMenu;

        /// <summary>
        ///     选中的菜单
        /// </summary>
        public LeftMenu SelectMenu
        {
            get => selectMenu;
            set
            {
                selectMenu = value;
                switch (selectMenu)
                {
                    case LeftMenu.page1:
                        CurrentPage = PageManager.page1;
                        break;
                    //跳转到本地音乐
                    case LeftMenu.page2:
                        CurrentPage = PageManager.page2;
                        break;
                }

                OnPropertyChanged("SelectMenu");
            }
        }

        #endregion
    }
}