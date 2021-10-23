using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Account { Saving, Current } //Задание 1

        struct BankAccount //Задание 2
        {
            public int number;
            public string type;
            public int balance;
        }
        enum University //Задание 3
        {
            КемГУ, НГАХА, МФТИ, ТУСУР
        }
        struct Student
        {
            public string name;
            public string university;
            public Student(string name, string university)
            {
                this.name = name;
                this.university = university;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Account accSav = Account.Saving;
            Account accCur = Account.Current;
            textBox1.Text = Convert.ToString(accSav);
            textBox2.Text = Convert.ToString(accCur);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankAccount bankinfo1 = new BankAccount
            {
                number = 1,
                type = "Сберегательный",
                balance = 5000
            };
            BankAccount bankinfo2 = new BankAccount
            {
                number = 2,
                type = "Текущий",
                balance = 666
            };

            richTextBox1.Text = $"Номер счета: {bankinfo1.number}\nТип счета: {bankinfo1.type}\nБаланс: {bankinfo1.balance}$\n";
            richTextBox1.Text += $"\nНомер счета: {bankinfo2.number}\nТип счета: {bankinfo2.type}\nБаланс: {bankinfo2.balance}$\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student1 = new Student("Кирилл", Convert.ToString(University.КемГУ));
            Student student2 = new Student("Никита", Convert.ToString(University.МФТИ));
            Student student3 = new Student("Андрей", Convert.ToString(University.НГАХА));
            Student student4 = new Student("Арсений", Convert.ToString(University.ТУСУР));
           
            richTextBox2.Text = $"Имя студента: {student1.name}\nУниверситет: {student1.university}\n";
            richTextBox2.Text += $"\nИмя студента: {student2.name}\nУниверситет: {student2.university}\n";
            richTextBox2.Text += $"\nИмя студента: {student3.name}\nУниверситет: {student3.university}\n";
            richTextBox2.Text += $"\nИмя студента: {student4.name}\nУниверситет: {student4.university}\n";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
