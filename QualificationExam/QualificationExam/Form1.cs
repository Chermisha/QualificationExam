using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAccounting
{
    public partial class MainForm : Form
    {
        public List<Service> services;
        public MainForm()
        {
            InitializeComponent();
            services = new List<Service>();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            string название = nameTextBox.Text;
            decimal стоимость = decimal.Parse(costTextBox.Text);
            Service newService = new Service(название, стоимость);
            services.Add(newService);
            UpdateServiceList();
            ClearInputFields();
        }
        private void UpdateServiceList()
        {
            servicesListBox.Items.Clear();
            foreach (Service service in services)
            {
                servicesListBox.Items.Add(service);
            }
        }
        private void ClearInputFields()
        {
            nameTextBox.Text = "";
            costTextBox.Text = "";
        }
    }
    public class Service
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public Service(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public override string ToString()
        {
            return Name + " - " + Cost.ToString("C");
        }
    }
}
   
