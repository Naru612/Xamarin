using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinMapPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public class XamarinMapPage: ContentPage{
            public XamarinMapPage(){
                var map = new Map(
                MapSpan.FromCenterAndRadius(
                    new Position(35.62982, 139.794242),
                        Distance.FromMiles(0.2))){
                    IsShowingUser = true,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };
                Content = new StackLayout
                {
                    Children = { map }
                };
            }
        }
    }
}
