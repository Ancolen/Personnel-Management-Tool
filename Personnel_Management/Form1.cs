using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ILKER;Initial Catalog=Personel_veri_tabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void List_Button_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_veri_tabaniDataSet.Tbl_Personel);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(" insert into Tbl_Personel (PerAd, PerSoyad,permaas,perdurum,persehir,permeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", Name_txt.Text);
            command.Parameters.AddWithValue("@p2", Surname_txt.Text);
            command.Parameters.AddWithValue("@p3", Wage_txt.Text);
            if (Married.Checked)
                command.Parameters.AddWithValue("@p4", true);
            else
                command.Parameters.AddWithValue("@p4", false);
            command.Parameters.AddWithValue("@p5", City_Combo.Text);
            command.Parameters.AddWithValue("@p6", Job_txt.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personal Saved!");
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Id_txt.Clear();
            Name_txt.Clear();
            Surname_txt.Clear();
            Wage_txt.Clear();
            Married.Checked = false;
            Single.Checked = false;
            City_Combo.Text = string.Empty;
            Job_txt.Clear();
            Name_txt.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            Id_txt.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            Name_txt.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            Surname_txt.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            Wage_txt.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            if ("True" == dataGridView1.Rows[selected].Cells[5].Value.ToString())
                Married.Checked = true;
            else
                Single.Checked = true;
            City_Combo.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            Job_txt.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command_del = new SqlCommand("delete from tbl_Personel where perid =@k1", connection);
            command_del.Parameters.AddWithValue("@k1", Id_txt.Text);
            command_del.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Deleted!");
        }

        private void Upgrade_Button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command_up = new SqlCommand("update Tbl_personel set perad=@a1,persoyad=@a2,permaas=@a3,perdurum=@a4,persehir=@a5,permeslek=@a6 where perid=@a7", connection);
            command_up.Parameters.AddWithValue("@a1", Name_txt.Text);
            command_up.Parameters.AddWithValue("@a2", Surname_txt.Text);
            command_up.Parameters.AddWithValue("@a3", Wage_txt.Text);
            if (Married.Checked)
                command_up.Parameters.AddWithValue("@a4", true);
            else
                command_up.Parameters.AddWithValue("@a4", false);
            command_up.Parameters.AddWithValue("@a5", City_Combo.Text);
            command_up.Parameters.AddWithValue("@a6", Job_txt.Text);
            command_up.Parameters.AddWithValue("@a7", Id_txt.Text);
            command_up.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated!");
        }

        private void St_Button_Click(object sender, EventArgs e)
        {
            istatistic Fr_Statistic = new istatistic();
            Fr_Statistic.Show();
        }

        private void Id_txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
