using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedTest : TabbedPage
    {
        public TabbedTest(string username, string password)
        {
            InitializeComponent();
            if (username == "John")
            {
                Children.Add(new Order());
                Children.Add(new OlderOrders(username, password));
                Children.Add(new Settings());
            }
            else if(username == "Tyler")
            {
                Children.Add(new Order());
                Children.Add(new OlderOrders(username, password));
                Children.Add(new Settings());
            }
            else if(username =="Jacob")
            {
                this.Title = "LawnKing - Employee";
                Children.Add(new MainMenuEmployee(username));
                Children.Add(new CurrentOrders(username));
                Children.Add(new OlderOrders(username, password));
                Children.Add(new Settings());
            }
            //this.Children.Add(new MainPage());
            //this.Children.Add(new MainMenuCustomer());



        }
    }
}