using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;Pwd=;");
            conn.Open();
        }

        private void btnVarosHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxNev.Text==" " || textBoxNev.Text == "" || nudLakossag.Text=="0")
            {
                MessageBox.Show("Hiányzó adat!");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO varosok(nev,lakossag) VALUES(@nev,@lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
                cmd.Parameters.AddWithValue("@lakossag", nudLakossag.Text);
                int erintettSorokSzama = cmd.ExecuteNonQuery();
            }
        }
    }
}
