using System.Collections.ObjectModel;
using DMSkin.Core.MVVM;
using WebAPP.Model;

namespace WebAPP.ViewModel
{
    public class PageCloudMusicViewModel : ViewModelBase
    {
        private double cloudMaxSize = 100;

        private double cloudSize = 90;

        private ObservableCollection<Music> musicList;

        public PageCloudMusicViewModel()
        {
            //这里添加几个 测试的云盘歌曲

            MusicList.Add(new Music
            {
                Album = "SoundLift s High State Mix",
                Title = "Summer Kisses (SoundLift s High State Mix)",
                Artist = "Eric de la Vega",
                Size = 4946933,
                TimeStr = "05:09",
                Index = "01",
                Url =
                    "https://raw.githubusercontent.com/944095635/TEST/master/Eric%20de%20la%20Vega%20-%20Summer%20Kisses%20(SoundLift%20s%20High%20State%20Mix)%20Midnight%20Coast.mp3",
                FileName = "Summer Kisses.mp3"
            });
            MusicList.Add(new Music
            {
                Album = "变形金刚",
                Title = "变形金刚塞伯特传奇",
                Artist = "变形金刚",
                Size = 641184,
                TimeStr = "00:32",
                Index = "02",
                Url = "https://raw.githubusercontent.com/944095635/TEST/master/Transformers30secsR3.mp3",
                FileName = "Transformers30secsR3.mp3"
            });
        }

        public ObservableCollection<Music> MusicList
        {
            get
            {
                if (musicList == null) musicList = new ObservableCollection<Music>();
                return musicList;
            }
            set
            {
                musicList = value;
                OnPropertyChanged("MusicList");
            }
        }

        /// <summary>
        ///     最大云盘容量
        /// </summary>
        public double CloudMaxSize
        {
            get => cloudMaxSize;
            set
            {
                cloudMaxSize = value;
                OnPropertyChanged("CloudMaxSize");
            }
        }

        /// <summary>
        ///     云盘容量
        /// </summary>
        public double CloudSize
        {
            get => cloudSize;
            set
            {
                cloudSize = value;
                OnPropertyChanged("CloudSize");
            }
        }
    }
}