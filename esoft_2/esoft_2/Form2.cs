using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace esoft_2
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = 303-3\\SQLEXPRESS; Initial Catalog = esoft_2; Integrated Security = true;");
        public int ИД_менеджера = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM dbo.salary Джуниор, Сеньор, " +
                " Коэффициент_для_Анализ_и_проектирование, Коэффициент_для_Установка_оборудования, Коэффициент_для_Техническое_обслуживание_и_сопровождение, Коэффициент_сложности, Коэффициент_времени, Коэффициент_для_перевода_в_денежный_эквивалент "  
                + $"WHERE id = '{ИД_менеджера}'", con);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();
            textBox5.Text = dr[4].ToString();
            textBox6.Text = dr[5].ToString();
            textBox7.Text = dr[6].ToString();
            textBox9.Text = dr[7].ToString();
            textBox9.Text = dr[8].ToString();
            dr.Close();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
