using System;
using Xamarin.Forms;
using kdc.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace kdc
{
	public partial class App : Application
	{
		public static string KdcURL = "";
        public static string SpotURL = "";

        public App ()
		{
			InitializeComponent();

            
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
