using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchPractics
{
    public partial class Ad_form : Form
    {
        public Ad_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlUS cus = new ControlUS();
            cus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADJorn aj = new ADJorn();
            aj.Show();
        }
    }
}
