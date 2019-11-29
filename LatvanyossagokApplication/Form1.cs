using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            tablaLetrehozas();
            VarosListazas();
        }

        public void tablaLetrehozas()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = File.ReadAllText("latvanyossagokdb.sql");
            cmd.ExecuteNonQuery();
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
            VarosListazas();
        }

        private void btnLatvanyossagHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxLatvanyossagNev.Text == " " || textBoxLatvanyossagNev.Text == "" || comboBoxVarosok.SelectedIndex<0)
            {
                MessageBox.Show("Hiányzó adat!");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO latvanyossagok(nev,leiras,ar,varos_id) VALUES(@nev,@leiras,@ar@varos_id)";
                cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@ar", nudAr.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagAr.Text);
                cmd.Parameters.AddWithValue("@varos_id", comboBoxVarosok.SelectedIndex);
                int erintettSorokSzama = cmd.ExecuteNonQuery();
            }
        }
        void VarosListazas()
        {
            listBoxVarosok.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,nev,lakossag FROM varosok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varos = new Varos(id, nev, lakossag);
                    listBoxVarosok.Items.Add(varos);
                }

            }
        }

        private void buttonVarosTorles_Click(object sender, EventArgs e)
        {
            if (listBoxVarosok.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kiválasztott város");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM varosok WHERE id=@id";

            var varos = (Varos)listBoxVarosok.SelectedItem;
            cmd.Parameters.AddWithValue("@id", varos.Id);

            cmd.ExecuteNonQuery();

            VarosListazas();
        }
    }
}
