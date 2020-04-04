using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlderOrders : ContentPage
    {
 






        public class Employee
        {
            public string DisplayName { get; set; }
        }

        public OlderOrders(string username, string password)
        {
            InitializeComponent();

            //ListOfOrders.ItemsSource = "hellobeckycarson";
            EmployeeListPage(username);
        }

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public void EmployeeListPage(string username)
        {
            //This gets the full path for the "files" directory of your app, where you have permission to read/write.
            //var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //This creates the full file path to your "testfile.txt" file.
            //var filePath = System.IO.Path.Combine(documentsPath, "Accounts.txt");
            //Now create the file.
            //System.IO.File.Create(filePath);



            ListOfOrders.ItemsSource = employees;

            if (username == "John")
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("Accounts.txt"));

                //resourceName = "MyCompany.MyProduct.Accounts.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    employees.Add(new Employee { DisplayName = reader.ReadLine() });
                    //string result = reader.ReadLine();
                    //string result = reader.ReadToEnd();
                }
                // ObservableCollection allows items to be added after ItemsSource
                // is set and the UI will react to changes
                //employees.Add(new Employee { DisplayName = "3/22/2020 Ferne Rankin" });
                //employees.Add(new Employee { DisplayName = "3/23/2020 Daniaal Espinosa" });
                //employees.Add(new Employee { DisplayName = "3/25/2020 Geri-Beth Hooper" });
                //employees.Add(new Employee { DisplayName = "3/28/2020 Griffin Lara" });
                //employees.Add(new Employee { DisplayName = "3/29/2020 Heath Charles" });
                //employees.Add(new Employee { DisplayName = "3/31/2020 Alexie Justice" });
            }
            else if(username == "Jacob") 
            {
                employees.Add(new Employee { DisplayName = "3/22/2020 Jessie Rogers" });
                employees.Add(new Employee { DisplayName = "3/27/2020 Burt Indybrick" });
                employees.Add(new Employee { DisplayName = "3/28/2020 Girth Certificate" });
                employees.Add(new Employee { DisplayName = "3/29/2020 Coco Nut" });
                employees.Add(new Employee { DisplayName = "3/30/2020 Sheri Spruce" });
                employees.Add(new Employee { DisplayName = "3/31/2020 Bill Nye" });

            }
            else if(username == "Tyler")
            {
                employees.Add(new Employee { DisplayName = "3/22/2020 Nada Bostock" });
                employees.Add(new Employee { DisplayName = "3/27/2020 Scarlette Farrington" });
                employees.Add(new Employee { DisplayName = "3/28/2020 Girth Certificate" });
                employees.Add(new Employee { DisplayName = "3/29/2020 Coco Nut" });
                employees.Add(new Employee { DisplayName = "3/30/2020 Rees Sloan" });
                employees.Add(new Employee { DisplayName = "3/31/2020 Bill Nye" });
            }
        }
        public void AddOrder(string info)
        {
            employees.Add(new Employee { DisplayName = info });
        }
    }
}