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
    public partial class Form2 : Form
    {
        public Game game;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game = new Game(false);
            this.Hide();
            new Form1(this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game = new Game(true);
            game.CreatePlayer("Игрок");
            this.Hide();
            new Form3(this).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) => Application.Exit();
    }
}
