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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo desde " + ((Button)sender).Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form2()
        {
            InitializeComponent();
        }
    }
}
