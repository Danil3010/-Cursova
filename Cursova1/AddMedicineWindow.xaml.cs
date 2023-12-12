using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursova1
{
    public partial class AddMedicineWindow : Window
    {
        public Medicine NewMedicine { get; set; }

        public AddMedicineWindow(Medicine newMedicine)
        {
            InitializeComponent();
            NewMedicine = newMedicine;
            DataContext = newMedicine;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }

}
