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
using System.IO;

namespace UchPractics
{
    public partial class Autorization : Form
    {
        int EntryCol = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IJHI4LO\SQLEXPRESS;Initial Catalog=StudentsBD;Integrated Security=True");



        public Autorization()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Password = null;
            string Role = null;
            if (EntryCol > 2)
            {
                if (textBox3.Text == "MWR")
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("select * from [User] where Login ='" + textBox1.Text + "';", con);
                        con.Open();
                        SqlDataReader data = command.ExecuteReader();
                        if (data.Read())
                        {
                            Password = data[5].ToString();
                            Role = data[6].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Логин не верен");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка соединения");
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Ошибка в заполнене капчи");
                }
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select * from [User] where Login ='" + textBox1.Text + "'; ", con);
                    con.Open();
                    SqlDataReader data = command.ExecuteReader();
                    if (data.Read())
                    {
                        Password = data[5].ToString();
                        Role = data[6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в логине или пароле");
                    }
                }
               /* catch (Exception ex)
                {
                    MessageBox.Show("Ошибка соед с БД (Catch Errors in DB)");

                }*/
                finally
                {
                    con.Close();
                }


                if (Password != null && Role != null)
                {

                    Aus(Password, Role);
                }

            }

            if (EntryCol > 2)
            {
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                textBox3.Enabled = true;
                textBox3.Visible = true;
            }
            if (EntryCol > 5)
            {
                MessageBox.Show("Исчерпан лимит попыток входа, попробуйте позже");

                Application.Exit();
            }

            EntryCol++;
        }

        private void Aus(string Password, string Role)
        {
            if (textBox2.Text.Equals(Password))
            {
                switch (Role)
                {
                    case "Admin":
                        {
                            Ad_form ad = new Ad_form();
                            ad.Show();
                            this.Hide();
                            break;
                        }
                    case "Student":
                        {
                            St_form st = new St_form();
                            st.Show();
                            this.Hide();
                            break;
                        }
                    case "Teacher":
                        {
                            Tc_form tc = new Tc_form();
                            tc.Show();
                            this.Hide();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
