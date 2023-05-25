using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game100Classes;


namespace Game100WinForms
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Player player2 = new Player();
        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(form2.game1.PlayerNameValid(textBox1.Text,textBox2.Text) == true)
            {
                form2.player1.NameAdd(textBox1.Text);
                player2.NameAdd(textBox2.Text);
                this.Hide();
                new Form3(form2,this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный формат");
            }
        }
    }
}
