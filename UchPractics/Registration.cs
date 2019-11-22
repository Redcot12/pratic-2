using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UchPractics
{
    public partial class Registration : Form
    {
        int Role = 2;
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization aut = new Autorization();
            aut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IJHI4LO\SQLEXPRESS;Initial Catalog=Stlist;Integrated Security=True");
            con.Open();

            //SqlCommand us = new SqlCommand("insert into AUser (Login, Password, IDInform, IDRole) values('" + textBox1.Text + "', '" + textBox2.Text + "', '2' )", con);
            string insertcmd = ("insert into AUser (Login, Password, IDInform, IDRole) values(@Login, @Password, IDInform, IDRole);");

            using (SqlCommand us = new SqlCommand(insertcmd))
            {
                us.Parameters.Add("@Login", SqlDbType.NVarChar, 100).Value = textBox1.Text;
                us.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value = textBox2.Text;
                us.Parameters.Add("@IDInform", SqlDbType.BigInt).Value = textBox1.Text;
                us.Parameters.Add("@IDRole", SqlDbType.BigInt).Value = textBox1.Text;
            }


           /* us.ExecuteNonQuery();
            SqlCommand inf = new SqlCommand("insert into Information (Name, Password, Surname, Patronymic, Email) values('" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", con);
            inf.ExecuteNonQuery();*/
        }
    }
}