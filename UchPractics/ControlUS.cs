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
    public partial class ControlUS : Form
    {
        List<string[]> data = new List<string[]>();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IJHI4LO\SQLEXPRESS;Initial Catalog=StudentsBD;Integrated Security=True");


        public ControlUS()
        {
            InitializeComponent();
            try
            {
                var Com = "SELECT        dbo.[User].* FROM dbo.[User]";

                SqlCommand cmd = new SqlCommand(Com, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = rd[0].ToString();
                    data[data.Count - 1][1] = rd[1].ToString();
                    data[data.Count - 1][2] = rd[2].ToString();
                    data[data.Count - 1][3] = rd[3].ToString();
                    data[data.Count - 1][4] = rd[4].ToString();
                    data[data.Count - 1][5] = rd[5].ToString();
                    data[data.Count - 1][6] = rd[6].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка связи с бд " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            foreach (string[] item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ad_form af = new Ad_form();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text != "" && textBox1.Text != "  ")
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("delet from [User] where ID ='" + textBox1.Text + "';", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(textBox1.Text))
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка соединения с бд" + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Введите название ID Пользователя, которого хотите удалить.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            //MessageBox.Show("Заполните ВСЕ ячейки!", "Внимание!");
            try
            {
                {
                    var selectQueryString = "SELECT * FROM [User]";
                    SqlDataAdapter ad = new SqlDataAdapter(selectQueryString, con);

                    SqlCommand cmd = new SqlCommand(selectQueryString, con);
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        data.Add(new string[7]);
                        data[data.Count - 1][0] = rd[0].ToString();
                        data[data.Count - 1][1] = rd[1].ToString();
                        data[data.Count - 1][2] = rd[2].ToString();
                        data[data.Count - 1][3] = rd[3].ToString();
                        data[data.Count - 1][4] = rd[4].ToString();
                        data[data.Count - 1][5] = rd[5].ToString();
                        data[data.Count - 1][6] = rd[6].ToString();


                        // DataTable dt = new DataTable();
                        var dataSet = new DataSet();
                       // ad.Fill();
                        BindingSource bins = new BindingSource();
                        bins.DataSource = cmd;

                        dataGridView1.DataSource = bins;
                        dataGridView1.Columns[0].Visible = false;



                       // ad.Update(cmd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
