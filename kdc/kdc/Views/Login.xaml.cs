using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace kdc.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            StartLogin();
            Debugger.Log(0,"Login","etes");
        }

        async Task StartLogin()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {

                // var items = await DataStore.GetItemsAsync(true);

                RestSharp.Http http = new RestSharp.Http();
                http.Url.AbsoluteUri = App.SpotURL;
                http.Parameters.Add(new RestSharp.HttpParameter("SessionID", "Test"));
                http.Parameters.Add(new RestSharp.HttpParameter("Username","Test"));
                await http.PostAsync(loginResponse);


            }
            catch (Exception ex)
            {
                Debugger.Log(0, "Login", ex.ToString());
            }
            finally
            {
                IsBusy = false;
            }

        }

        public Action<RestSharp.HttpResponse> loginResponse()
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                Debugger.Log(0, "Login", ex.ToString());
            }
            finally
            {
                IsBusy = false;
            }
        }


    }
}