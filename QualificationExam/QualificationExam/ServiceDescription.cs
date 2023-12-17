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
    public partial class ServiceDescription : Form
    {
        private int _idInfo;
        private Service _service;

        public ServiceDescription(int idInfo)
        {
            InitializeComponent();
            _idInfo = idInfo;
            serviceLabel.Text = "Услуга #"+ _idInfo;
            _service = Service.GetServiceObject(_idInfo);
            nameTextBox1.Text = _service.Name;
            costTextBox2.Text = (_service.Cost).ToString();
            descriptionTextBox3.Text = _service.Description;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            ServiceForm form1 = new ServiceForm();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void saveChangeButton1_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox1.Text;
            string newCost = costTextBox2.Text;
            string newDescription = descriptionTextBox3.Text;
            if (isSuccessfulValidation(newName, newCost, newDescription))
            {
                _service.Name = newName;
                _service.Cost = double.Parse(newCost);
                _service.Description = newDescription;
            }

        }

        private bool isSuccessfulValidation (string newName, string newCost, string newDescription)
        {

            if (newName == null)
            {
                MessageBox.Show("Неправильно указанны параметры услуги. Убедитесь, что значение поля \"наименование\" не является пустым. ");
                return false;
            }

            try
            {
                double newCostDouble = double.Parse(newCost);
                MessageBox.Show("Услуга успешно сохранена");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно указанны параметры услуги. Убедитесь, что значение поля \"стоимость\" не содержит цифр. ");
                return false;
            }

        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            ServiceList.Services.Remove(_service);
            ServiceForm form1 = new ServiceForm();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
