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
        private void button1_Click(object sender, EventArgs e) => Application.Exit();
        private void Form3_Load(object sender, EventArgs e)
        {
            form2.game.MoveOrder();
            UpdateGame();
        }

        public void UpdateGame()
        {
            if (form2.game.GetGameBots() && !form2.game.GetMovePlayer1())
                form2.game.CountUpdate();
            else
            {
                if (form2.game.GetMovePlayer1())
                    label5.Text = $"Введите значения {form2.game.player1.GetName()}";
                else
                    label5.Text = $"Введите значения {form2.game.player2.GetName()}";
            }
            textBox1.Text = ($"Счет  {form2.game.player1.GetName()}: {form2.game.player1.GetStep()}  \t Общий счет: {form2.game.GetCount()} \t Счет  {form2.game.player2.GetName()}: {form2.game.player2.GetStep()}");
            if (form2.game.CountWins())
            {
                if (form2.game.GetMovePlayer1())
                    MessageBox.Show($"Победил {form2.game.player2.GetName()}");
                else
                    MessageBox.Show($"Победил {form2.game.player1.GetName()}");
                this.Hide();
                new Form2().ShowDialog();
            }
    }
        private void button2_Click(object sender, EventArgs e)
        {
            form2.game.CountUpdate();
            UpdateGame();
        }
    }
}
