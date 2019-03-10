using System;
using DMSkin.Core.MVVM;

namespace WebAPP.Model
{
    public class Music : ViewModelBase
    {
        private string album;


        private string artist;


        private bool download;
        private string index;

        private double size;


        private string timeStr;


        private string title;

        private string url;

        /// <summary>
        ///     序号
        /// </summary>
        public string Index
        {
            get => index;
            set
            {
                index = value;
                OnPropertyChanged("Index");
            }
        }

        /// <summary>
        ///     路径
        /// </summary>
        public string Url
        {
            get => url;
            set
            {
                url = value;
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        ///     标题
        /// </summary>
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        ///     体积
        /// </summary>
        public double Size
        {
            get => size;
            set
            {
                size = value;
                OnPropertyChanged("Size");
            }
        }

        /// <summary>
        ///     体积-MB
        /// </summary>
        public string SizeStr => HumanReadableFilesize(size);

        /// <summary>
        ///     专辑
        /// </summary>
        public string Album
        {
            get => album;
            set
            {
                album = value;
                OnPropertyChanged("Album");
            }
        }

        /// <summary>
        ///     作者
        /// </summary>
        public string Artist
        {
            get => artist;
            set
            {
                artist = value;
                OnPropertyChanged("Artist");
            }
        }

        /// <summary>
        /// </summary>
        public string TimeStr
        {
            get => timeStr;
            set
            {
                timeStr = value;
                OnPropertyChanged("TimeStr");
            }
        }

        public string FileName { get; internal set; }

        /// <summary>
        ///     是否在下载
        /// </summary>
        public bool DownLoad
        {
            get => download;
            set
            {
                download = value;
                OnPropertyChanged("DownLoad");
            }
        }

        private string HumanReadableFilesize(double size)
        {
            string[] units = {"B", "KB", "MB", "GB", "TB", "PB"};
            var mod = 1024.0;
            var i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }

            return Math.Round(size, 2) + units[i];
        }
    }
}