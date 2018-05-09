using CarouselView.FormsPlugin.Abstractions;
using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleCarousel.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePageCarousel : RelativeLayout
	{

        public HomePageCarousel ()
		{
			InitializeComponent ();


            myCarouselView.ItemsSource = new ObservableCollection<View>()
            {
                new CachedImage() { Source = "http://via.placeholder.com/250/f44191/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "http://via.placeholder.com/250/41f459/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "http://via.placeholder.com/250/41eef4/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
            };
        }
	}
}