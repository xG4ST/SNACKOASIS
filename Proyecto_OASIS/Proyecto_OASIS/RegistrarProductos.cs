using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_OASIS.ModelsDB;
using Proyecto_OASIS.MySql;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS
{
    public partial class RegistrarProductos : Form
    {
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand("SELECT id_prov, name_prov FROM provider", conexion);
            //MySqlDataAdapter da = new MySqlDataAdapter(cm);
            MySqlDataReader consultar = cm.ExecuteReader();

            providerAccount proveedor = new providerAccount();
            List<providerAccount> listaProveedores;

            while (consultar.Read())
            {
                //proveedor.id_prov = consultar.GetInt32(0);
                //proveedor.name_prov = consultar.GetString(1);
                Console.WriteLine(consultar);
            }

            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //conexion.Close();

            //DataRow fila = dt.NewRow();
            //fila["name_prov"] = "Seleccionar";
            //dt.Rows.InsertAt(fila, 0);

            //comboBox1.ValueMember = "id_prod";
            //comboBox1.DisplayMember = "name_prod";
            //comboBox1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductAccount newProductAccount = new ProductAccount();
            newProductAccount.name_prod = name_textbox.Text.Trim();
            newProductAccount.des_prod = textBox2.Text.Trim();

            //if (Single.TryParse(textBox1.Text, out float result))
            //{
            //    MessageBox.Show("El campo solo acepta números flotantes", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //}
            newProductAccount.price_prod = Convert.ToSingle(textBox1.Text.Trim());

            //if (Single.TryParse(textBox3.Text, out float result2))
            //{
            //    MessageBox.Show("El campo solo acepta números flotantes", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //}
            newProductAccount.purchasePrice_prod = Convert.ToSingle(textBox3.Text.Trim());

            //float val = 0;
            //if (Single.TryParse(textBox1.Text, out val))
            //{

            //}
            //else
            //{
            //    textBox1.Text = val.ToString();
            //}

            newProductAccount.stock_prod = 0;

            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conexion = Connection.GetConnection();

                MySqlCommand registerNewProduct = new MySqlCommand();
                registerNewProduct.CommandText = "SELECT * FROM product WHERE name_prod = @newProductAccount.name_prod";
                registerNewProduct.Parameters.AddWithValue("@newProductAccount.name_prod", newProductAccount.name_prod);
                registerNewProduct.Parameters.AddWithValue("@newProductAccount.des_prod", newProductAccount.des_prod);
                registerNewProduct.Parameters.AddWithValue("@newProductAccount.price_prod", newProductAccount.price_prod);
                registerNewProduct.Parameters.AddWithValue("@newProductAccount.purchasePrice_prod", newProductAccount.purchasePrice_prod);
                registerNewProduct.Parameters.AddWithValue("@newProductAccount.stock_prod", newProductAccount.stock_prod);
                registerNewProduct.Connection = conexion;

                MySqlDataReader leer = registerNewProduct.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                else
                {
                    int resultado = RegisterNewProduct.agregar(newProductAccount);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el Producto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
