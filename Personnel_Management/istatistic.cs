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

namespace Personel_Kayit
{
    public partial class istatistic : System.Windows.Forms.Form
    {
        public istatistic()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ILKER;Initial Catalog=Personel_veri_tabani;Integrated Security=True");
        private void istatistic_Load(object sender, EventArgs e)
        {
            //total personnel
            connection.Open();
            SqlCommand command0 = new SqlCommand("select COUNT(*) from Tbl_Personel ", connection);
            SqlDataReader cmd0 = command0.ExecuteReader();
            while (cmd0.Read())
                total_per_label.Text = cmd0[0].ToString();
            connection.Close();

            //married personnel
            connection.Open();
            SqlCommand command1 = new SqlCommand("select COUNT(*) from Tbl_Personel where PerDurum = 1", connection);
            SqlDataReader cmd1 = command1.ExecuteReader();
            while(cmd1.Read())
                married_label.Text = cmd1[0].ToString();
            connection.Close();

            //Single personnel
            connection.Open();
            SqlCommand command2 = new SqlCommand("select count(*) from tbl_personel where perdurum = 0", connection);
            SqlDataReader cmd2 = command2.ExecuteReader();
            while(cmd2.Read())
                single_label.Text = cmd2[0].ToString();
            connection.Close();

            //total diff city
            connection.Open();
            SqlCommand command3 = new SqlCommand("select count(distinct(persehir)) from tbl_personel", connection);
            SqlDataReader cmd3 = command3.ExecuteReader();
            while(cmd3.Read())
                diff_city_label.Text = cmd3[0].ToString();
            connection.Close();

            //total wage
            connection.Open();
            SqlCommand command4 = new SqlCommand("select sum(permaas) from tbl_personel", connection);
            SqlDataReader cmd4 = command4.ExecuteReader();
            while(cmd4.Read())
                total_wage_lable.Text = cmd4[0].ToString();
            connection.Close();

            //average wage
            connection.Open();
            SqlCommand command5 = new SqlCommand("select avg(permaas) from tbl_personel", connection);
            SqlDataReader cmd5 = command5.ExecuteReader();
            while(cmd5.Read())
                average_wage_label.Text = cmd5[0].ToString();
            connection.Close();

            //total diff joob
            connection.Open();
            SqlCommand command6 = new SqlCommand("select count(distinct(permeslek)) from tbl_personel", connection);
            SqlDataReader cmd6 = command6.ExecuteReader();
            while(cmd6.Read())
                diff_job_label.Text = cmd6[0].ToString();
            connection.Close();
        }
    }
}
