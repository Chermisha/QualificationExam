using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ServiceAccounting
{
    public partial class ServiceForm : Form
    {
        private List<Service> _services = ServiceList.Services;
        public ServiceForm()
        {
            InitializeComponent();
            UpdateServiceList();

        }

        private void addServisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServiceForm form1 = new AddServiceForm();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void UpdateServiceList()
        {
            servicesListBox.Items.Clear();
            foreach (Service service in _services)
            {
                servicesListBox.Items.Add(service);
            }          

        }


        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Services");
                    // Заголовки столбцов
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Name";
                    worksheet.Cells[1, 3].Value = "Cost";
                    worksheet.Cells[1, 4].Value = "Description";
                    // Данные услуг
                    for (int i = 0; i < _services.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = _services[i].Id; // ID
                        worksheet.Cells[i + 2, 2].Value = _services[i].Name; // Название услуги
                        worksheet.Cells[i + 2, 3].Value = _services[i].Cost; // Стоимость услуги
                        worksheet.Cells[i + 2, 4].Value = _services[i].Description; // Описание услуги
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                        worksheet.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[1, i + 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    }
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                    MessageBox.Show("Данные успешно экспортированы в Excel.");
                }
            }
        }
        private void ImportFromExcelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    { 
                        string serviceName = worksheet.Cells[row, 2].Value.ToString();
                        double serviceCost = double.Parse(worksheet.Cells[row, 3].Value.ToString());
                        string serviceDescription = worksheet.Cells[row, 4].Value.ToString();
                        Service newService = new Service(serviceName, serviceCost, serviceDescription);

                        _services.Add(newService);
                    }
                    foreach (Service service in _services)
                    {
                        servicesListBox.Items.Add(service);
                    }
                    MessageBox.Show("Данные успешно импортированы из Excel.");
                }
            }
        }

        private void checkDescriptionButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedItem != null)
            {
                string pattern = @"\d+";

                Match match = Regex.Match(servicesListBox.SelectedItem.ToString(), pattern);
                if (match.Success)
                {
                    int idInfo = int.Parse(match.Value);
                    ServiceDescription form1 = new ServiceDescription(idInfo);
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();

                }

            }

        }

        private void deleteAllButton1_Click(object sender, EventArgs e)
        {
            ServiceList.Services.Clear();
            UpdateServiceList();
        }
    }
}
