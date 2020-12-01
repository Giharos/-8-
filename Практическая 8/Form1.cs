using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_8;

namespace Практическая_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Сумма
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(value1.Text, out int One) && Int32.TryParse(value2.Text, out int Two)){
                int x = Convert.ToInt32(value1.Text);
                int y = Convert.ToInt32(value2.Text);
                Lib_8.Pair PairNumbers = new Pair(x, y);
                //Сумма
                int sum = PairNumbers.Sum(x, y);
                //Вывод
                textBox1.Text = sum.ToString();
            }
            else MessageBox.Show("Введите правильное значение");
        }
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {       
        }
        //Произведение
        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(value1.Text, out int One) && Int32.TryParse(value2.Text, out int Two))
            {
                int x = Convert.ToInt32(value1.Text);
                int y = Convert.ToInt32(value2.Text);
                Lib_8.Pair PairNumbers = new Pair(x, y);
                //Сумма
                int proizv = PairNumbers.Proizv(x, y);
                //Вывод
                textBox3.Text = proizv.ToString();
            }
            else MessageBox.Show("Введите правильное значение");
        }
        //Разность
        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(value1.Text, out int One) && Int32.TryParse(value2.Text, out int Two))
            {
                int x = Convert.ToInt32(value1.Text);
                int y = Convert.ToInt32(value2.Text);
                Lib_8.Pair PairNumbers = new Pair(x, y);
                //Сумма
                int razn = PairNumbers.Razn(x, y);
                //Вывод
                textBox2.Text = razn.ToString();
            }
            else MessageBox.Show("Введите правильное значение");
        }
        //Деление
        private void button4_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(value1.Text, out int One) && Int32.TryParse(value2.Text, out int Two))
            {
                int x = Convert.ToInt32(value1.Text);
                int y = Convert.ToInt32(value2.Text);
                Lib_8.Pair PairNumbers = new Pair(x, y);
                //Сумма
                int del = PairNumbers.Delenie(x, y);
                //Вывод
                textBox4.Text = del.ToString();
            }
            else MessageBox.Show("Введите правильное значение");
        }
        //Очистка
        private void button5_Click(object sender, EventArgs e)
        {
            value1.Clear();
            value2.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        //выход
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //сравнение
        private void sravn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(value1.Text, out int One) && Int32.TryParse(value2.Text, out int Two) && Int32.TryParse(value3.Text, out int Three) && Int32.TryParse(value4.Text, out int Four))
            {
                int x1 = Convert.ToInt32(value1.Text);
                int y1 = Convert.ToInt32(value2.Text);
                int x2 = Convert.ToInt32(value3.Text);
                int y2 = Convert.ToInt32(value4.Text);
                Lib_8.Pair Pair1 = new Pair(x1, y1);
                Lib_8.Pair Pair2 = new Pair(x2, y2);
                if (Pair1.CompareTo(Pair2) == 0) Compare.Text = "Пары равны";
                else Compare.Text = "Пары не равны";
            }
            else MessageBox.Show("Введите правильные значения");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №8,вариант 12" +
                "Создать интерфейс – арифметические операции (+, -, *, /). Создать класс пара чисел. Класс должен включать конструктор, функцию для формирования строки с арифметической операцией. Сравнение производить по парам чисел." +
                "Платов Андрей ИСП-31");
        }
    }
}
