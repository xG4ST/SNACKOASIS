using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_OASIS.MySql;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS
{
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            clientAccount newClientAccount = new clientAccount();
            newClientAccount.name_client = client_textbox.Text.Trim();
            newClientAccount.email_client = email_textbox.Text.Trim();
            newClientAccount.tel_client = tel_textbox.Text.Trim();

            if (string.IsNullOrEmpty(client_textbox.Text) || string.IsNullOrEmpty(email_textbox.Text) || string.IsNullOrEmpty(tel_textbox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = snack_db; Uid = root; pwd = 2000;");
                conexion.Open();

                MySqlCommand compareClient = new MySqlCommand();
                compareClient.CommandText = "SELECT * FROM client WHERE name_client = @newClientAccount.name_client";
                compareClient.Parameters.AddWithValue("@newClientAccount.name_client", newClientAccount.name_client);
                compareClient.Parameters.AddWithValue("@newClientAccount.email_client", newClientAccount.email_client);
                compareClient.Parameters.AddWithValue("@newClientAccount.tel_client", newClientAccount.tel_client);
                compareClient.Connection = conexion;

                MySqlDataReader leer = compareClient.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                else
                {
                    int resultado = registerNewClient.agregar(newClientAccount);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Menu ToMenu = new Menu();
                        //this.Hide();
                        //ToMenu.Show();
                        Comida ToComida = new Comida();
                        this.Hide();
                        ToComida.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar a el Cliente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tel_textbox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void tel_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
