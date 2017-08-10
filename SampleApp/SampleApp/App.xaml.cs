using Xamarin.Forms;

namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			//通常表示
			//MainPage = new SamplePage();

			//NavigationPageを用いた表示
			MainPage = new NavigationPage(new SampleAppPage());
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
    }
}
