using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Drawing.Chart;
using System.IO;

namespace ServiceAccounting
{
    public partial class AddServiceForm : Form
    {
        private List<Service> _services = ServiceList.Services;
        public AddServiceForm()
        {
            InitializeComponent();
        }


        private void addServiceButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string cost = costTextBox.Text;
            string description = descriptionTextBox.Text;
            var newService = SaveValidation(name, cost, description);

            if (newService != null)
            {
                _services.Add(newService);
                nameTextBox.Text = "";
                costTextBox.Text = "";
                descriptionTextBox.Text = "";
            }

        }

      


        private void allServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm form2 = new ServiceForm();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private Service SaveValidation(string newName, string newCost, string newDescription)
        {

            if (newName == null)
            {
                MessageBox.Show("Неправильно указанны параметры услуги. Убедитесь, что значение поля \"наименование\" не является пустым. ");
                return null;
            }

            try
            {
                Service newService = new Service(newName, double.Parse(newCost), newDescription);
                MessageBox.Show("Услуга успешно сохранена");
                return newService;
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно указанны параметры услуги. Убедитесь, что значение поля \"стоимость\" является числом. ");
                return null;
            }

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            ServiceForm form2 = new ServiceForm();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
   
