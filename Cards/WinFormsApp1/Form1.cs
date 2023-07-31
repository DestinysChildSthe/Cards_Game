using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Twoclublabel_Click_1(object sender, EventArgs e)
        {
            cardlabel.Text = "Two of Clubs";
        }

        private void Aceheartslabel_Click(object sender, EventArgs e)
        {
            cardlabel.Text = "Ace of Hearts";
        }

        private void Queenspadelabel_Click(object sender, EventArgs e)
        {
            cardlabel.Text = "Queen of Spades";
        }

        private void Jacksdiamondlabel_Click(object sender, EventArgs e)
        {
            cardlabel.Text = "Jacks of Diamonds";
        }

        private void Redjokerlabel_Click(object sender, EventArgs e)
        {
            cardlabel.Text = "Red Joker";
        }
    }
}
