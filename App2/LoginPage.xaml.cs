using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Mainpage is actually loginpage
            var assembly = typeof(MainPage);
            MainPageImage.Source = ImageSource.FromResource("App2.Assets.Images.Untitled.png", assembly);

            LoginButton.Clicked += async (sender, args) =>
            {
                if (EmailIDEntry.Text == "John" && PasswordEntry.Text == "Doe")
                {
                    await Navigation.PushAsync(new TabbedTest("Johndfdfsdfsdf", "Doe"));
                }
                else if (EmailIDEntry.Text == "Tyler" && PasswordEntry.Text == "Tyler")
                {
                    await Navigation.PushAsync(new TabbedTest("Tyler", "Tyler"));
                }
                else if (EmailIDEntry.Text == "Jacob" && PasswordEntry.Text == "Jacob")
                {
                    await Navigation.PushAsync(new TabbedTest("Jacob", "Jacob"));
                }
                else
                {
                    ErrorLogin.IsVisible = true;
                }
                
          
            };
            /*
            Button button = new Button
            {
                Text = "Log In",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Page1());
            };

            Content = button;
            */
        }


       






    }
}
