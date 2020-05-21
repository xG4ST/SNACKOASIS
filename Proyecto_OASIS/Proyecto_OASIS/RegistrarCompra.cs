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

using MySql.Data.MySqlClient;
using Proyecto_OASIS.MySql;

namespace Proyecto_OASIS
{
    public partial class RegistrarCompra : Form
    {
        List<providerAccount> listaProveedores;
        List<ProductAccount> listaProductos;
        List<providerAccount> carrito;

        public RegistrarCompra()
        {
            InitializeComponent();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            listaProductos = new List<ProductAccount>();
            listaProveedores = new List<providerAccount>(); ;

            MySqlConnection conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand("SELECT id_prov, name_prov FROM provider", conexion);
            MySqlDataReader consultar = cm.ExecuteReader();

            while (consultar.Read())
            {
                providerAccount proveedor = new providerAccount();
                proveedor.id_prov = consultar.GetInt32(0);
                proveedor.name_prov = consultar.GetString(1);
                listaProveedores.Add(proveedor);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{proveedor.id_prov} - {proveedor.name_prov}";
                item.Value = proveedor.id_prov;

                comboBox1.Items.Add(item);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //TODO: Hacer transacciones
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            listaProductos.Clear();
            //TODO: Mostrar productos del nuevo proveedor
            int id = listaProveedores[comboBox1.SelectedIndex].id_prov;
            MySqlConnection conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, stock_prod FROM product WHERE provider_id_prov = @id && stock_prod > 0", conexion);
            cm.Parameters.AddWithValue("@id", id);
            MySqlDataReader consultar = cm.ExecuteReader();

            while (consultar.Read())
            {
                ProductAccount producto = new ProductAccount();
                producto.id_prod = consultar.GetInt32(0);
                producto.name_prod = consultar.GetString(1);
                producto.stock_prod = consultar.GetInt32(2);
                listaProductos.Add(producto);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{producto.id_prod} - {producto.name_prod}";
                item.Value = producto.id_prod;

                comboBox2.Items.Add(item);
                comboBox2.SelectedIndex = 0;
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (comboBox2.Text != "" && )
            //{

            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = listaProductos[comboBox2.SelectedIndex].stock_prod;
        }
    }
}
