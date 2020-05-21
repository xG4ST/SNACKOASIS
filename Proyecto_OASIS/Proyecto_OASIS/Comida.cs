using iText.Layout.Element;
using MySql.Data.MySqlClient;
using Proyecto_OASIS.ModelsDB;
using Proyecto_OASIS.MySql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Proyecto_OASIS
{
    public partial class Comida : Form
    {
        MySqlConnection conexion;
        clientAccount cliente;
        List<ProductAccount> listaProductos;
        List<ProductAccount> carrito;
        int n;

        public Comida()
        {
            cliente = new clientAccount();
            cliente.name_client = "XXXX";
            InitializeComponent();
        }
        public Comida(clientAccount cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Comida_Load(object sender, EventArgs e)
        {
            carrito = new List<ProductAccount>();
            listaProductos = new List<ProductAccount>();
            label1.Text = cliente.name_client;
            comboBox1.Items.Add("Alitas");
            comboBox1.Items.Add("Hamburguesa");
            comboBox1.Items.Add("Papas");
            comboBox1.Items.Add("Bebida");
            comboBox1.Items.Add("Postres");
            comboBox1.SelectedIndex = 0;
        }

        private void cargarAlimentos(string product)
        {
            comboBox2.Items.Clear();
            listaProductos.Clear();
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod, price_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataReader consultar = cm.ExecuteReader();
            while (consultar.Read())
            {
                ProductAccount producto = new ProductAccount();
                producto.id_prod = consultar.GetInt32(0);
                producto.name_prod = consultar.GetString(1);
                producto.des_prod = consultar.GetString(2);
                producto.price_prod = consultar.GetDouble(3);
                listaProductos.Add(producto);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{producto.des_prod}";
                item.Value = producto.id_prod;

                comboBox2.Items.Add(item);
                comboBox2.SelectedIndex = 0;
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Text = "";
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAlimentos(comboBox1.SelectedItem.ToString());
            if(comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Confirmacion_de_pedido ToMenu = new Confirmacion_de_pedido();
            this.Hide();
            ToMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                //agregamos al carrito
                carrito.Add(listaProductos[comboBox2.SelectedIndex]);
                ProductAccount producto = listaProductos[comboBox2.SelectedIndex];
                //mostrar en datagrid
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = producto.id_prod;
                dataGridView1.Rows[n].Cells[1].Value = producto.name_prod;
                dataGridView1.Rows[n].Cells[2].Value = producto.des_prod;
                dataGridView1.Rows[n].Cells[3].Value = producto.price_prod;

                sumarTotal(producto.price_prod);
            }
        }

        private void sumarTotal(double subtotal)
        {
            double nuevoTotal = Double.Parse(label5.Text.Replace("$", "")) + subtotal;
            string total = string.Format("{0:0.00}", nuevoTotal);
            label5.Text = $"${total}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(n);
                    sumarTotal(carrito[n].price_prod * -1);
                    Console.WriteLine(carrito[n].price_prod * -1);
                    carrito.RemoveAt(n);
                    for (int i = 0; i < carrito.Count; i++)
                    {
                        Console.WriteLine(carrito[i].name_prod);
                    }
                }
                catch (System.InvalidOperationException err)
                {
                    MessageBox.Show("La nueva fila sin confirmar no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            n = e.RowIndex;
            Console.WriteLine(n);
        }
    }
}
