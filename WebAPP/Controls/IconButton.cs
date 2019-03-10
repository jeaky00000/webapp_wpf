using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WebAPP.Controls
{
    public class IconButton : RadioButton
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(IconButton),
                new PropertyMetadata(null));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(IconButton), new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(IconButton), new PropertyMetadata(12.0));

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(IconButton), new PropertyMetadata(12.0));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius) GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }


        /// <summary>
        ///     图标
        /// </summary>
        [Description("图标")]
        [Category("DMSkin")]
        public Geometry Icon
        {
            get => (Geometry) GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        /// <summary>
        ///     图标宽度
        /// </summary>
        public double IconWidth
        {
            get => (double) GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }


        /// <summary>
        ///     图标高度
        /// </summary>
        public double IconHeight
        {
            get => (double) GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }
    }
}