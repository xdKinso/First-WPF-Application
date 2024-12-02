using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data;
using System.ComponentModel;

namespace BnBList
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<BnB> BnBs { get; set; }
        public ObservableCollection<Owner> Owners { get; set; }
        public ObservableCollection<Customer> Customers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            BnBs = new ObservableCollection<BnB>();
            Owners = new ObservableCollection<Owner>();
            Customers = new ObservableCollection<Customer>();
            DataContext = this;
            Ownerslistview.DataContext = this;
            Customerslistview.DataContext = this;
           
           
            // Bnb bnb = Bnb.getInstance();
            BnBs.Add(new BnB() { PropertyName = "Krystian's Residence", Price = "$10,000", Type = "Small Bnb", Location = "London", OwnerName = "Krystian Mowinski", IsBooked = false });
            BnBs.Add(new BnB() { PropertyName = "Czochara Residence", Price = "$30,000", Type = "Big Bnb", Location = "Przemsl", OwnerName = "Anna Czochara", IsBooked = false });
            BnBs.Add(new BnB() { PropertyName = "Mickiewicz Residence", Price = "$15,000", Type = "Medium Bnb", Location = "Egham", OwnerName = "Szymon Mickiewicz", IsBooked = false });
            BnBs.Add(new BnB() { PropertyName = "Bayram's Dungeon", Price = "$40,000", Type = "Villa Bnb", Location = "Egham", OwnerName = "Bayram Tosun", IsBooked = false });
            Customers.Add(new Customer { customerName = "Gregory House", CustomerIncome = "£50,000" });
            Customers.Add(new Customer { customerName = "Michal Romero", CustomerIncome = "£40,000" });
            Customers.Add(new Customer { customerName = "Raphael Magrina", CustomerIncome = "£70,000" });
            Customers.Add(new Customer { customerName = "Lucas Felipe Brown", CustomerIncome = "£30,000" });
            Customers.Add(new Customer { customerName = "Jonaid Ahmad", CustomerIncome = "£100,000" });
            Owners.Add(new Owner { FullName = "Patrick Jane", OwnerIncome = "$70,000" });
            Owners.Add(new Owner { FullName = "Krystian Mowinski", OwnerIncome = "$120,000" });
            Owners.Add(new Owner { FullName = "Anna Czochara", OwnerIncome = "$320,000" });
            Owners.Add(new Owner { FullName = "Szymon Mickiewicz", OwnerIncome = "$150,000" });
            Owners.Add(new Owner { FullName = "Bayram Tosun", OwnerIncome = "$130,000" });
            



        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var propertyName = propertyNameTextBox1.Text;
            var price = priceTextBox1.Text;
            var location = locationTextBox1.Text;
            var ownerName = ownerNameTextBox1.Text;
            var type = typeTextBox.Text;
            BnB newBnB = new BnB()
            {
                PropertyName = propertyName,
                Price = price,
                Location = location,
                OwnerName = ownerName,
                Type = type
            };
            BnBs.Add(newBnB);
            propertyNameTextBox1.Clear();
            priceTextBox1.Clear();
            locationTextBox1.Clear();
            ownerNameTextBox1.Clear();
        }

        private void View_click(object sender, RoutedEventArgs e)
        {
            BnB selectedBnb = bnbListView1.SelectedItem as BnB;
            MessageBox.Show("The "+selectedBnb.PropertyName+" is located in " +selectedBnb.Location+ " It costs " +selectedBnb.Price+ " .It is owned by "+selectedBnb.OwnerName);

        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            BnB selectedBnb = bnbListView1.SelectedItem as BnB;

            if (selectedBnb.IsBooked == true)
            {
                MessageBox.Show("This " + selectedBnb.PropertyName + " is already Booked");
            }
            else
            {
                MessageBox.Show("you have booked " + selectedBnb.PropertyName);
                selectedBnb.IsBooked = true;
            }
        }

        private void unbookButton_click(object sender, RoutedEventArgs e)
        {
            BnB selectedBnb = bnbListView1.SelectedItem as BnB;
            
            if(selectedBnb.IsBooked == false)
            {
                MessageBox.Show(selectedBnb.PropertyName + " Is Already unbooked");
            }
            else
            {
                MessageBox.Show(selectedBnb.PropertyName + " Is now Unbooked");
                selectedBnb.IsBooked = false;
            }
        }

        private void AddOwner_click(object sender, RoutedEventArgs e)
        {
            var fullName = OwnerNametextbox.Text;
            var ownerIncome = OwnerIncometextbox.Text;
            Owner newOwner = new Owner()
            {
                FullName = fullName,
                OwnerIncome = ownerIncome,

            };
            Owners.Add(newOwner);
            OwnerNametextbox.Clear();
            OwnerIncometextbox.Clear();
            
        }

        private void customeradd_click(object sender, RoutedEventArgs e)
        {
            var customerName = customerNameTextBox.Text;
            var income = customerIncomeTextBox.Text;
            Customer newCustomer = new Customer()
            {
                CustomerName = customerName,
                CustomerIncome = income,

            };
            Customers.Add(newCustomer);
            customerNameTextBox.Clear();
            customerIncomeTextBox.Clear();
        }
    }
    public class Customer : INotifyPropertyChanged
    {
        public string customerName;
        public string income;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("FullName");
            }
        }
        public string CustomerIncome
        {
            get { return income; }
            set
            {
                income = value;
                OnPropertyChanged("income");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    public class Owner : INotifyPropertyChanged
    {
        private string fullName;
        private string ownerIncome;

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }

        }
        public string OwnerIncome
        {
            get { return ownerIncome; }
            set
            {
                ownerIncome = value;
                OnPropertyChanged("Income");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
    public class BnB : INotifyPropertyChanged
    {
        private string propertyName;
        private string price;
        private string type;
        private string location;
        private string ownerName;
        private bool isBooked;

        public string PropertyName
        {
            get { return propertyName; }
            set
            {
                propertyName = value;
                OnPropertyChanged("PropertyName");
            }

        }

        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                ownerName = value;
                OnPropertyChanged("OwnerName");
            }
        }

        public bool IsBooked
        {
            get { return isBooked; }
            set
            {
                isBooked = value;
                OnPropertyChanged("IsBooked");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}