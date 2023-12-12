using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursova1
{
    public partial class AddDiseaseWindow : Window
    {
        public Disease NewDisease { get; set; }

        public AddDiseaseWindow(Disease newDisease)
        {
            InitializeComponent();
            NewDisease = newDisease;
            DataContext = newDisease;
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
