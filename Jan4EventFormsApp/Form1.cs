using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jan4EventFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" we are in form load event");
            Button b1 = new Button();
            b1.Text = "Click Me";
            b1.Height = 50;
            b1.Width = 100;
            b1.ForeColor = Color.White;
            b1.BackColor = Color.Green;
            b1.Location = new Point(100, 100);
            b1.Click += B1_Click; ;
            this.Controls.Add(b1);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
