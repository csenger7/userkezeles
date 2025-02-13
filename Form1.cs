using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace userkezeles
{
    public partial class Form1 : Form
    {
        internal static Connect Conn = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jelszo = (string)textBox3.Text;
            string veznev = (string)textBox1.Text;
            string keznev = (string)textBox2.Text;
            Conn.Connection.Open();

            string sql = "SELECT `FirstName`, `LastName`, `Password` FROM `data` WHERE 1";

            MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            bool regisztralt = false;

            dr.Read();

            do
            {
                var felhasznalo = new
                {
                    VeznevAdatbazis = dr.GetString(0),
                    KeresztnevAdatbazis = dr.GetString(1),
                    JelszoAdatbazis = dr.GetString(2),
                };

                if (veznev == felhasznalo.VeznevAdatbazis && keznev == felhasznalo.KeresztnevAdatbazis && jelszo == felhasznalo.JelszoAdatbazis)
                {
                    regisztralt = true;
                }


            }
            while (dr.Read());

            if (regisztralt == true)
            {
                MessageBox.Show("Regisztrált tag");
            }
            else
            {

                label2.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                button2.Visible = true;
                label1.Visible = false;
                label4.Visible = false;
                textBox3.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                MessageBox.Show("Nincs felhasználó");

            }

            dr.Close();



            Conn.Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vezeteknev = (string)textBox4.Text;
            string keresztnev = (string)textBox5.Text;
            string jelszo = (string)textBox6.Text;

            try
            {

                Conn.Connection.Open();

                string sql = $"INSERT INTO `data`(`FirstName`, `LastName`, `Password`) VALUES ('{vezeteknev}','{keresztnev}','{jelszo}')";

                MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);
                cmd.ExecuteNonQuery();

                Conn.Connection.Close();

                MessageBox.Show("Sikeres Regisztráció");
            }
            catch (Exception)
            {
                MessageBox.Show("Nem jó az adatbázis kapcsolódása");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn.Connection.Open();

            string sql = "SELECT `ID`, `FirstName`, `LastName`, `CreatedTime`, `UpdatedTime` FROM `data` WHERE 1";

            MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();


            dr.Read();

            do
            {
                var felhasznalo = new
                {
                    IDAdatbazis = dr.GetInt32(0),
                    VezeteknevAdatbazis = dr.GetString(1),
                    KeresztnevAdatbazis = dr.GetString(2),
                    CreatedTimeAdatbazis = dr.GetMySqlDateTime(3),
                    UpdatedTimeAdatbazis = dr.GetMySqlDateTime(4),

                };

                listBox1.Items.Add(felhasznalo.IDAdatbazis + " , " + felhasznalo.VezeteknevAdatbazis + " , " + felhasznalo.KeresztnevAdatbazis + " , " + felhasznalo.CreatedTimeAdatbazis + " , " + felhasznalo.UpdatedTimeAdatbazis);

            }
            while (dr.Read());


            dr.Close();
            Conn.Connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string sor = listBox1.SelectedItem.ToString();

                string[] felvag = sor.Split(',');

                string id = "";
                if (felvag.Length > 0)
                {
                    id = felvag[0].Trim();
                }
                Conn.Connection.Open();

                string sql = $"DELETE FROM `data` WHERE `ID` = {id};";

                MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);
                cmd.ExecuteNonQuery();

                Conn.Connection.Close();

                MessageBox.Show("Sikeres Törlés");
                listBox1.Items.Remove(sor);
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az ID ban");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sor = listBox1.SelectedItem.ToString();

                string[] felvag = sor.Split(',');

                string id = "";
                if (felvag.Length > 0)
                {
                    id = felvag[0].Trim();
                }
                string vezeteknev = (string)textBox7.Text;
                string keresztnev = (string)textBox8.Text;
                string jelszo = (string)textBox9.Text;
                Conn.Connection.Open();
                string sql = $"UPDATE `data` SET `FirstName`= '{vezeteknev}',`LastName`= '{keresztnev}',`Password`= '{jelszo}' WHERE `ID` = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);
                cmd.ExecuteNonQuery();
                Conn.Connection.Close();
                MessageBox.Show("Sikeres Frissítés");
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az ID ban");
            }
        }
    }
}
