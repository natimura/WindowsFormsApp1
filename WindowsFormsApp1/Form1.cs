using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void actionButton_Click(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "クリックされました";
        }


        private void actionButton_MouseHover(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが乗りました";
        }

        private void actionButton_MouseLeave(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスがおりました";
        }
    }
}
