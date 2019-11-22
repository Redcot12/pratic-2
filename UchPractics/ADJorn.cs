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
    public partial class ADJorn : Form
    {
        List<string[]> data = new List<string[]>();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IJHI4LO\SQLEXPRESS;Initial Catalog=StudentsBD;Integrated Security=True");


        public ADJorn()
        {
            InitializeComponent();
            try
            {
                var Com = "SELECT dbo.[User].Name, dbo.[User].Surname, dbo.[User].Patronic, dbo.Jornal.Ocenka, dbo.Predmet.Name AS Expr1, dbo.Jornal.Itog FROM dbo.Jornal INNER JOIN dbo.Predmet ON dbo.Jornal.IDPR = dbo.Predmet.ID INNER JOIN dbo.[User] ON dbo.Jornal.IDUser = dbo.[User].ID";

                SqlCommand cmd = new SqlCommand(Com, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = rd[0].ToString();
                    data[data.Count - 1][1] = rd[1].ToString();
                    data[data.Count - 1][2] = rd[2].ToString();
                    data[data.Count - 1][3] = rd[3].ToString();
                    data[data.Count - 1][4] = rd[4].ToString();
                    data[data.Count - 1][5] = rd[5].ToString();
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
            this.Show();
            Ad_form af = new Ad_form();
            af.Show();
        }

     /*   private void ADJorn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsBDDataSet.Jorn". При необходимости она может быть перемещена или удалена.
            this.jornTableAdapter1.Fill(this.studentsBDDataSet1.Jorn);

        }*/
    }
}
