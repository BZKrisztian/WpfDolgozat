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
using Microsoft.EntityFrameworkCore.Diagnostics;
using CsvReader.Data.Models;
using CsvReader.Data;

namespace WpfDolgozat.Tasks
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : UserControl
    {
        public Page3(string catchName)
        {
            InitializeComponent();
            LoadData(catchName);
        }

        private void LoadData(string catchName)
        {
            using (var context = new Context())
            {
                List<CsvData> data = context.CsvData_stuff
                    .Where(d => d.Name == catchName)
                    .ToList();
                databoxFromCsv.ItemsSource = data;
            }
        }
    }
}
