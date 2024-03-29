﻿using MySql.Data.MySqlClient;
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
            LatvanyossagListazas();
        }

        public void tablaLetrehozas()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = File.ReadAllText("latvanyossagokdb.sql");
            cmd.ExecuteNonQuery();
        }

        private void btnVarosHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxNev.Text == " " || textBoxNev.Text == "" || nudLakossag.Text == "0")
            {
                MessageBox.Show("Hiányzó adat!");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO varosok(nev,lakossag) VALUES(@nev,@lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
                cmd.Parameters.AddWithValue("@lakossag", nudLakossag.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Már van ilyen város az adatbázisban");
                    }
                }
            }
            VarosListazas();
        }

        private void btnLatvanyossagHozzaad_Click(object sender, EventArgs e)
        {
            if (textBoxLatvanyossagNev.Text == " " || textBoxLatvanyossagNev.Text == "" || comboBoxVarosok.SelectedIndex == -1)
            {
                MessageBox.Show("Hiányzó adat!");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO latvanyossagok(nev,leiras,ar,varos_id) VALUES(@nev,@leiras,@ar,@varos_id)";
                cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@ar", nudAr.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagAr.Text);
                var varos = (Varos)comboBoxVarosok.SelectedItem;
                cmd.Parameters.AddWithValue("@varos_id", varos.Id);
                cmd.ExecuteNonQuery();
                LatvanyossagListazas();
            }
        }
        void VarosListazas()
        {
            listBoxVarosok.Items.Clear();
            comboBoxVarosok.Items.Clear();

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
                    comboBoxVarosok.Items.Add(varos);
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
            comboBoxVarosok.Items.Clear();
            VarosListazas();
        }

        void LatvanyossagListazas()
        {
            listBoxLatvanyossagok.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,nev,leiras,ar,varos_id FROM latvanyossagok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id = reader.GetInt32("varos_id");
                    var latvanyossag = new Latvanyossag(id, nev, leiras, ar, varos_id);
                    listBoxLatvanyossagok.Items.Add(latvanyossag);
                }

            }
        }

        void LatvanyossagListazasModositott()
        {
            listBoxLatvanyossagok.Items.Clear();
            if (listBoxVarosok.SelectedIndex!=-1)
            {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,nev,leiras,ar,varos_id FROM latvanyossagok WHERE varos_id=@varos_id ORDER BY nev ";
            var varos = (Varos)listBoxVarosok.SelectedItem;
            cmd.Parameters.AddWithValue("@varos_id", varos.Id);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id = reader.GetInt32("varos_id");
                    var latvanyossag = new Latvanyossag(id, nev, leiras, ar, varos_id);
                    listBoxLatvanyossagok.Items.Add(latvanyossag);
                }
            }

            }
        }
        private void listBoxVarosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            LatvanyossagListazasModositott();
        }

        private void buttonLatvanyossagTorles_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossagok.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kiválasztott látványosság");
                return;
            }
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM latvanyossagok WHERE id=@id";

                var latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", latvanyossag.Id);

                cmd.ExecuteNonQuery();

                LatvanyossagListazas();
            }

        private void ButtonVarosModosit_Click(object sender, EventArgs e)
        {
            listBoxLatvanyossagok.Items.Clear();
            if (!textBoxVarosNev.Text.Equals(""))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE varosok SET nev = @nev, lakossag = @lakossag WHERE id = @id";
                var varos = (Varos)listBoxVarosok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varos.Id);
                cmd.Parameters.AddWithValue("@nev", textBoxVarosNev.Text);
                cmd.Parameters.AddWithValue("@lakossag", nudVarosLakossag.Value);
                cmd.ExecuteNonQuery();
                VarosListazas();
                LatvanyossagListazas();
            }
            else
            {
                MessageBox.Show("Nincs valami kitöltve!");
            }


        }

        private void buttonLatvanyossagModositas_Click(object sender, EventArgs e)
        {
            if (!textBoxNevModosit.Text.Equals("") && !textBoxLeirasModosit.Text.Equals(""))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE latvanyossagok SET nev = @nev, leiras = @leiras, ar = @ar WHERE id = @id";
                var latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
                cmd.Parameters.AddWithValue("@id", latvanyossag.Id);
                cmd.Parameters.AddWithValue("@nev", textBoxNevModosit.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLeirasModosit.Text);
                cmd.Parameters.AddWithValue("@ar", nudLatvanyossagAr.Value);
                cmd.ExecuteNonQuery();
                LatvanyossagListazas();
            }
            else
            {
                MessageBox.Show("Nincs valami kitöltve!");
            }
        }

        private void ButtonModositVarosok_Click(object sender, EventArgs e)
        {
            groupBoxVarosok.Visible = true;
            textBoxVarosNev.Visible = true;
            nudVarosLakossag.Visible = true;
            buttonVarosModosit.Visible = true;
            var varos = (Varos)listBoxVarosok.SelectedItem;
            textBoxVarosNev.Text = varos.Nev;
            nudVarosLakossag.Value = varos.Lakossag;
        }

        private void buttonModositLatvanyossagok_Click(object sender, EventArgs e)
        {
            groupBoxLatvanyossagok.Visible = true;
            textBoxNevModosit.Visible = true;
            textBoxLeirasModosit.Visible = true;
            nudLatvanyossagAr.Visible = true;
            buttonLatvanyossagModositas.Visible = true;
            var latvanyossag = (Latvanyossag)listBoxLatvanyossagok.SelectedItem;
            textBoxNevModosit.Text = latvanyossag.Nev;
            textBoxLeirasModosit.Text = latvanyossag.Leiras;
            nudLatvanyossagAr.Value = latvanyossag.Ar;
        }
    }
 }
