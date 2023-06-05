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
        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e) => Application.Exit();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                form2.game.CreatePlayer(textBox1.Text, textBox2.Text);
                this.Hide();
                new Form3(form2, this).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
