using BicycleApp_Lab5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleApp_Lab5
{
    public partial class fBicycle : Form
    {
        public Bicycle TheBicycle { get; set; }

        public fBicycle()
        {
            InitializeComponent(); // Конструктор за замовчуванням
        }

        public fBicycle(Bicycle bicycle) : this() // Викликаємо конструктор за замовчуванням
        {
            this.TheBicycle = bicycle;
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            // Перевірка на заповнені поля та числові значення
            if (string.IsNullOrWhiteSpace(tbBrand.Text) || string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbMileage.Text) || string.IsNullOrWhiteSpace(tbDistance.Text) ||
                string.IsNullOrWhiteSpace(tbTime.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            if (!double.TryParse(tbMileage.Text, out double mileage) ||
                !double.TryParse(tbDistance.Text, out double distance) ||
                !double.TryParse(tbTime.Text, out double time))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення для пробігу, відстані та часу.");
                return;
            }

            // Передача введених даних у властивість `Tag` як об'єкт Bicycle
            this.Tag = new Bicycle
            {
                Brand = tbBrand.Text,
                Model = tbModel.Text,
                Type = tbType.Text, // поле для типу велосипеда
                Weight = double.Parse(tbWeight.Text), // поле для ваги велосипеда
                Gears = int.Parse(tbGearsCount.Text), // поле для кількості передач, використовується правильне ім'я властивості
                Mileage = mileage,
                Distance = distance,
                Time = time
            };


            this.DialogResult = DialogResult.OK; // Закриваємо форму
            this.Close(); // Закриття форми
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
