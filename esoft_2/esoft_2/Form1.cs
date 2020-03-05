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
using System.Data.Sql;

namespace esoft_2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = 303-3\\SQLEXPRESS; Initial Catalog = esoft_2; Integrated Security = true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com_man = new SqlCommand("SELECT * FROM dbo.managers WHERE Логин_менеджера = '" + textBox1.Text + "' AND Пароль_менеджера = '" + textBox2.Text + "'", con);            
            SqlDataReader drman = com_man.ExecuteReader();
            if (drman.HasRows)
            {
                drman.Read();
                MessageBox.Show("Успешная авторизация");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

            else MessageBox.Show("Неправильный логин и пароль");

            con.Close();
        }
    }
}
