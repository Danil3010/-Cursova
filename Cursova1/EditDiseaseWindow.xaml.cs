using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursova1
{
    public partial class EditDiseaseWindow : Window
    {
        public Disease EditedDisease { get; set; }

        public EditDiseaseWindow(Disease editedDisease)
        {
            InitializeComponent();
            EditedDisease = editedDisease;
            DataContext = editedDisease;
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
