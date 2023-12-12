using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Cursova1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Disease> Diseases { get; set; }
        public ObservableCollection<Medicine> Medicines { get; set; }

        private ICollectionView diseasesView;
        private ICollectionView medicinesView;

        public MainWindow()
        {
            InitializeComponent();

            Diseases = new ObservableCollection<Disease>
            {
                new Disease("Грип", "Лихоманка, кашель, нежить", "Прийом ліків, відпочинок", "Парацетамол - 2 таблетки"),
                new Disease("Головний біль", "Біль в голові, погане самопочуття", "Відпочинок, масаж", "Аспірин - 1 таблетка"),
                new Disease("Ангіна", "Біль у горлі, збільшені мигдали", "Прийом антибіотиків, полоскання горла", "Парацетамол - 1 таблетка, Ліжко"),
                new Disease("Діабет", "Часте сечовиділення, спрага, слабкість", "Інсулінотерапія, дієтотерапія", "Інсулін, Метформін"),
                new Disease("Алергія", "Сльози, свербіж, висип", "Прийом антигістамінних препаратів, обмеження контакту", "Цетиризин - 1 таблетка"),
                new Disease("Гастрит", "Біль в животі, втрата апетиту", "Дієта, прийом антацидів", "Омепразол - 1 таблетка, Маалокс"),

        };

            Medicines = new ObservableCollection<Medicine>
            {
                new Medicine("Аспірин", 50, "Так"),
                new Medicine("Парацетамол", 30, "Так"),
                new Medicine("Ібупрофен", 25, "Так"),
                new Medicine("Вітамін C", 100, "Так"),
                new Medicine("Інгалятор", 5, "Ні"),
                new Medicine("Антибіотик", 20, "Так"),
                new Medicine("Вазоконстріктор", 15, "Так"),

        };

            diseasesListView.ItemsSource = Diseases;
            medicinesListView.ItemsSource = Medicines;

            diseasesView = CollectionViewSource.GetDefaultView(Diseases);
            medicinesView = CollectionViewSource.GetDefaultView(Medicines);
        }

        private void SortDiseases_Click(object sender, RoutedEventArgs e)
        {
            diseasesView.SortDescriptions.Clear();
            diseasesView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void SortMedicines_Click(object sender, RoutedEventArgs e)
        {
            medicinesView.SortDescriptions.Clear();
            medicinesView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
        private void AddDisease_Click(object sender, RoutedEventArgs e)
        {
            // Створіть новий об'єкт для нової хвороби
            Disease newDisease = new Disease("Нова хвороба", "", "", "");

            // Створіть вікно або діалог для введення даних
            AddDiseaseWindow addDiseaseWindow = new AddDiseaseWindow(newDisease);

            // Відобразіть вікно або діалог модально
            bool? result = addDiseaseWindow.ShowDialog();

            // Якщо користувач натиснув "OK", додайте нову хворобу до колекції
            if (result == true)
            {
                Diseases.Add(newDisease);
            }
        }
        private void AddMedicine_Click(object sender, RoutedEventArgs e)
        {
            // Створіть новий об'єкт для нового медикаменту
            Medicine newMedicine = new Medicine("Новий медикамент", 0, "Так");

            // Створіть вікно або діалог для введення даних
            AddMedicineWindow addMedicineWindow = new AddMedicineWindow(newMedicine);

            // Відобразіть вікно або діалог модально
            bool? result = addMedicineWindow.ShowDialog();

            // Якщо користувач натиснув "OK", додайте новий медикамент до колекції
            if (result == true)
            {
                Medicines.Add(newMedicine);
            }
        }
        private void DeleteDisease_Click(object sender, RoutedEventArgs e)
        {
            // Отримайте виділену хворобу з ListView
            Disease selectedDisease = diseasesListView.SelectedItem as Disease;

            // Перевірте, чи є обрана хвороба і видаліть її
            if (selectedDisease != null)
            {
                Diseases.Remove(selectedDisease);
            }
        }
        private void DeleteMedicine_Click(object sender, RoutedEventArgs e)
        {
            // Отримайте виділений медикамент з ListView
            Medicine selectedMedicine = medicinesListView.SelectedItem as Medicine;

            // Перевірте, чи є обраний медикамент і видаліть його
            if (selectedMedicine != null)
            {
                Medicines.Remove(selectedMedicine);
            }
        }
        private void EditDisease_Click(object sender, RoutedEventArgs e)
        {
            // Отримайте виділену хворобу з ListView
            Disease selectedDisease = diseasesListView.SelectedItem as Disease;

            // Перевірте, чи є обрана хвороба
            if (selectedDisease != null)
            {
                // Створіть новий об'єкт для редагування хвороби, передаючи параметри
                Disease editedDisease = new Disease(selectedDisease.Name, selectedDisease.Symptoms, selectedDisease.Procedures, selectedDisease.Medicines);

                // Створіть вікно або діалог для редагування даних
                EditDiseaseWindow editDiseaseWindow = new EditDiseaseWindow(editedDisease);

                // Відобразіть вікно або діалог модально
                bool? result = editDiseaseWindow.ShowDialog();

                // Якщо користувач натиснув "OK", оновіть дані хвороби в колекції
                if (result == true)
                {
                    // Знайдіть індекс обраної хвороби в колекції
                    int index = Diseases.IndexOf(selectedDisease);

                    // Замініть обрану хворобу на оновлену
                    Diseases[index] = editedDisease;
                }
            }
        }
        private void EditMedicine_Click(object sender, RoutedEventArgs e)
        {
            // Отримайте виділений медикамент з ListView
            Medicine selectedMedicine = medicinesListView.SelectedItem as Medicine;

            // Перевірте, чи є обраний медикамент
            if (selectedMedicine != null)
            {
                // Створіть новий об'єкт для редагування медикаменту, передаючи параметри
                Medicine editedMedicine = new Medicine(selectedMedicine.Name, selectedMedicine.Quantity, selectedMedicine.Interchangeable);

                // Створіть вікно або діалог для редагування даних
                EditMedicineWindow editMedicineWindow = new EditMedicineWindow(editedMedicine);

                // Відобразіть вікно або діалог модально
                bool? result = editMedicineWindow.ShowDialog();

                // Якщо користувач натиснув "OK", оновіть дані медикаменту в колекції
                if (result == true)
                {
                    // Знайдіть індекс обраного медикаменту в колекції
                    int index = Medicines.IndexOf(selectedMedicine);

                    // Замініть обраний медикамент на оновлений
                    Medicines[index] = editedMedicine;
                }
            }
        }


    }

    public class Disease
    {
        public string Name { get; set; }
        public string Symptoms { get; set; }
        public string Procedures { get; set; }
        public string Medicines { get; set; }

        public Disease(string name, string symptoms, string procedures, string medicines)
        {
            Name = name;
            Symptoms = symptoms;
            Procedures = procedures;
            Medicines = medicines;
        }
    }

    public class Medicine
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Interchangeable { get; set; }

        public Medicine(string name, int quantity, string interchangeable)
        {
            Name = name;
            Quantity = quantity;
            Interchangeable = interchangeable;
        }
    }
}