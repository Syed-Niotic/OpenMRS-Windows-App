using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using System.Text;
using System;
using OpenMRSWindowsApp.Classes;
using Newtonsoft.Json;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OpenMRSWindowsApp
{



    public sealed partial class MainPage : Page
    {
        

        public object NavigationService { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
   



        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        private  void Button_Click(object sender, RoutedEventArgs e)
        {

 
            var HostName = txtHostName.Text;
            var Username = txtUsername.Text;
            var Password = txtPassword.Password;
            var sessionID = "";
            var authenticated = false;

            if (HostName.Trim() == "")
                HostName = "demo.openmrs.org/openmrs";

            string LoginURL = "http://" + HostName.Trim() + "/ws/rest/v1/session";

            getRequest(Username, Password, LoginURL, sessionID, authenticated);

            
    
            
            if (authenticated != false)
            {
               this.Frame.Navigate(typeof(MainMenuPage));
            }

            
        }
        static async void getRequest(string username, string password, string URL, string sessionID, bool authentication)
        {

            HttpClientHandler handler = new HttpClientHandler();

            // ... Use HttpClient.             
            HttpClient client = new HttpClient(handler);


            var byteArray = Encoding.UTF8.GetBytes(username + ":" + password);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));


            HttpResponseMessage response = await client.GetAsync(URL);
            HttpContent content = response.Content;

            // ... Read the string. 
            string feedback = await content.ReadAsStringAsync();
            dynamic sessionAuth = JsonConvert.DeserializeObject(feedback);

            sessionID = sessionAuth.sessionID;
            authentication = sessionAuth.authenticated;
           
        }


    }
}
 