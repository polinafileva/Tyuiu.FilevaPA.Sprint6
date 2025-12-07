using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tyuiu.FilevaPA.Sprint6.Task0.V1;
using Tyuiu.FilevaPA.Sprint6.Task0.V1.Lib;
{
    public partial class Form1 : Form
    { // Объявляем элементы управления как поля класса
        private PictureBox pictureBoxFormula_SIS;
        private Label labelVarA_SIS;
        private TextBox textBoxVarA_SIS;
        private Label labelResult_SIS;
        private TextBox textBoxResult_SIS;
        private Button buttonDone_SIS;
        private Button buttonInfo_SIS;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SIS_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значение x из текстового поля
                int x = Convert.ToInt32(textBoxVarA_SIS.Text);

                // Создаем экземпляр сервиса и вычисляем результат
                DataService ds = new DataService();
                double y = ds.Calculate(x);

                // Выводим результат с округлением до 3 знаков
                textBoxResult_SIS.Text = y.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное целое значение X.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxVarA_SIS.Focus();
                textBoxVarA_SIS.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание 0 | Вариант 1\n\n" +
                "Вычислить значение функции s(x) = x / (x³ + 2) при x = 3.\n" +
                "Результат вывести в текстовое поле, округлив до трёх знаков после запятой.\n\n" +
                "Пример расчета для x = 3:\n" +
                "s(3) = 3 / (3³ + 2) = 3 / (27 + 2) = 3 / 29 ≈ 0.103",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Устанавливаем значение по умолчанию x = 3
            textBoxVarA_SIS.Text = "3";
            textBoxVarA_SIS.Focus();
            textBoxVarA_SIS.SelectAll();
        }
    }
    }
}
