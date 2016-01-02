using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using OpenMRSWindowsApp.Classes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OpenMRSWindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        string HostName;
        string Username;
        string Password;
        
         
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HostName = txtHostName.Text;
            Username = txtUsername.Text;
            Password = txtPassword.Password;

            if (HostName.Trim() == "")
                HostName = "demo.openmrs.org/openmrs";

            string LoginURL = HostName.Trim() + "/ws/rest/v1/session/";

            //try
            //{
            //    using (HttpClient client = new HttpClient())
            //    {
            //        var post = client.PostAsync(LoginURL, Username Password);

            //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OMRSapi));
            //        OMRSapi reponse = (OMRSapi)serializer.ReadObject(post);
            //    }
            //}
            //catch (Exception ex) { }
                
                txtUsername.Text = "It actually Worked";
        }
    }
}
