using Game100Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game100WinForms
{
    public partial class Form3 : Form
    {
        Form2 form2;
        Form1 form1;
        bool b;
        public Form3(Form2 form2, Form1 form1, bool b)
        {
            InitializeComponent();
            this.form2 = form2;
            this.form1 = form1;
            this.b = b;
        }
        public Form3(Form2 form2, Form1 form1)
        {
            InitializeComponent();
            this.form2 = form2;
            this.form1 = form1;
        }
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (form2.game1.CountWins() == true)
            {
                if (form2.n == true)
                {
                    if (b == false)
                    {
                        MessageBox.Show($"Победил {form1.player2.NameReturn()}");
                    }
                    else
                    {
                        MessageBox.Show($"Победил {form2.player1.NameReturn()}");
                    }
                }
                else
                {
                    MessageBox.Show($"Вы победили");
                }
                this.Hide();
                new Form2().ShowDialog();
            }
            if (form2.game1.ChekReturn() == 0)
            {
                b = form2.game1.MoveOrder();
            }
            if (form2.n == true)
            {
                if (b == false)
                {
                    label5.Text = $"Введите значения игрок {form1.player2.NameReturn()}";
                }
                else
                {
                    label5.Text = $"Введите значения игрок {form2.player1.NameReturn()}";
                }
                textBox1.Text = ($"Ваш счет: {form2.player1.ResultingValueReturn()}  \t Общий счет: {form2.game1.CountReturn()} \t Счет компьютера: {form1.player2.ResultingValueReturn()}");
            }
            if(form2.n == false)
            {
                if(b == false)
                {
                    int compvalue = form2.game1.MoveComputer(form2.computer1, form2.player1);
                    form2.game1.CountUpdate(compvalue);
                    if (form2.game1.CountWins() == true)
                    {
                        MessageBox.Show($"Победа компьютера");
                        this.Hide();
                        new Form2().ShowDialog();
                    }
                    form2.game1.ChekApp();
                }
                textBox1.Text = ($"Ваш счет: {form2.player1.ResultingValueReturn()}  \t Общий счет: {form2.game1.CountReturn()} \t Счет компьютера:  {form2.computer1.ResultingValueReturn()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox4.Text;
            if (form2.game1.ValidationValue(value) != true)
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            if(form2.n == false)
            {
                form2.player1.ResultingValue(form2.game1.ValueConvert(value));
                form2.game1.CountUpdate(form2.player1.ResultingValueReturn());
            }
            if(form2.n == true)
            {
                if(b == false)
                {
                    form1.player2.ResultingValue(form2.game1.ValueConvert(value));
                    form2.game1.CountUpdate(form1.player2.ResultingValueReturn());
                    b = true;
                }
                else
                {
                    form2.player1.ResultingValue(form2.game1.ValueConvert(value));
                    form2.game1.CountUpdate(form2.player1.ResultingValueReturn());
                    b = false;
                }
            }
            form2.game1.ChekApp();
            this.Hide();
            if (form2.n == false)
            {
                new Form3(form2).ShowDialog();
            }
            else
            {
                new Form3(form2, form1 , b).ShowDialog();
            }
        }
    }
}
