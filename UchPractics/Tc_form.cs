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
    public partial class Tc_form : Form
    {
        public Tc_form()
        {
            InitializeComponent();
        }

        private void Tc_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsBDDataSet1.Jorn". При необходимости она может быть перемещена или удалена.
            this.jornTableAdapter1.Fill(this.studentsBDDataSet1.Jorn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsBDDataSet.Jorn". При необходимости она может быть перемещена или удалена.
            this.jornTableAdapter1.Fill(this.studentsBDDataSet1.Jorn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jornTableAdapter1.Update(studentsBDDataSet1);
            //Имя_ТаблицыTableAdapter.Update(имя_БДDataSet);
            MessageBox.Show("Изменения сохранены", "Работа с БД");
        }
    }
}
