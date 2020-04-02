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
    public partial class Order : ContentPage
    {
        public Order()
        {
            InitializeComponent();

        }

        void OnOrderConfirm(object sender, EventArgs e)
        {
            (sender as Button).Text = "Order Confired";
            (sender as Button).IsEnabled = false;
        }

        
    }
}