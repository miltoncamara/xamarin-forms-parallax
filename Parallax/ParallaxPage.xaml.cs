using Xamarin.Forms;

namespace Parallax
{
    public partial class ParallaxPage : ContentPage
    {
        public ParallaxPage()
        {
            InitializeComponent();
            MainScroll.ParallaxView = HeaderView;
        }
    }
}
