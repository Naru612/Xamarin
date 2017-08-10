using Xamarin.Forms;
using System;

namespace SampleApp
{
    public partial class SampleAppPage : ContentPage
    {
        public SampleAppPage()
        {
            InitializeComponent();
        }
		private void btn1_Clicked(object sender, System.EventArgs e)
		{
			this.lblResultMessage.Text = DateTime.Now.ToString();
		}
		private void btn2_Clicked(object sender, System.EventArgs e)
		{
			this.lblResultMessage.Text = this.ent1.Text;
		}

		private void btn3_Clicked(object sender, System.EventArgs e)
		{
			//Sample2画面に直接遷移する場合
			//Application.Current.MainPage = new Sample2AppPage();

			//NavigationPageを用いて遷移する場合
			Navigation.PushAsync(new Sample2AppPage(), true);
		}
    }
}
