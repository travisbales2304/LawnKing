using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentOrders : ContentPage
    {
        public class Employee
        {
            public string DisplayName { get; set; }
        }
        public CurrentOrders(string username)
        {
            InitializeComponent();
            EmployeeListPage(username);
        }

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public void EmployeeListPage(string username)
        {
            ListOfOrders.ItemsSource = employees;
            if (username == "Jacob")
            {
                employees.Add(new Employee { DisplayName = "Nada Bostock" });
                employees.Add(new Employee { DisplayName = "Scarlette Farrington" });
                employees.Add(new Employee { DisplayName = "Girth Certificate" });
                employees.Add(new Employee { DisplayName = "Coco Nut" });
                employees.Add(new Employee { DisplayName = "Rees Sloan" });
                employees.Add(new Employee { DisplayName = "Bill Nye" });
            }
        }
    }
}