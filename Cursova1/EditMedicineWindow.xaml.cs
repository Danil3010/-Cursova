using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursova1
{
    public partial class EditMedicineWindow : Window
    {
        public Medicine EditedMedicine { get; set; }

        public EditMedicineWindow(Medicine editedMedicine)
        {
            InitializeComponent();
            EditedMedicine = editedMedicine;
            DataContext = editedMedicine;
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
