using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WebAPP.Controls
{
    public class ImageRadioButton : RadioButton
    {
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(Geometry), typeof(ImageRadioButton));

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(ImageRadioButton),
                new PropertyMetadata(15.0));

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(ImageRadioButton),
                new PropertyMetadata(15.0));

        public Geometry Image
        {
            get => (Geometry) GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }


        public double ImageWidth
        {
            get => (double) GetValue(ImageWidthProperty);
            set => SetValue(ImageWidthProperty, value);
        }

        public double ImageHeight
        {
            get => (double) GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }
    }
}