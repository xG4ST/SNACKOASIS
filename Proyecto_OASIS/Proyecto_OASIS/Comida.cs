using MySql.Data.MySqlClient;
using Proyecto_OASIS.MySql;
using System;
using System.Data;
using System.Windows.Forms;


namespace Proyecto_OASIS
{
    public partial class Comida : Form
    {
      MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database= snack_db; Uid = root; pwd = 2000;");

        public Comida()
        {
            InitializeComponent();
        }

        public void cargar_datos_alitas()
        {
            //SELECT* FROM snack_db.product, name_product
            //snack_db.product
            //SELECT id_product,name_product FROM product

            string product = "Alitas";

            Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["des_prod"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "id_prod";
            comboBox2.DisplayMember = "des_prod";
            comboBox2.DataSource = dt;
        }

        public void cargar_datos_hamburguesa()
        {
            string product = "Hamburguesa";

            conexion.Open();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["des_prod"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "id_prod";
            comboBox2.DisplayMember = "des_prod";
            comboBox2.DataSource = dt;
        }

        public void cargar_datos_papas()
        {
            string product = "Papas";

            conexion.Open();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["des_prod"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "id_prod";
            comboBox2.DisplayMember = "des_prod";
            comboBox2.DataSource = dt;
        }

        public void cargar_datos_bebida()
        {
            string product = "Bebida";

            conexion.Open();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["des_prod"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "id_prod";
            comboBox2.DisplayMember = "des_prod";
            comboBox2.DataSource = dt;
        }

        public void cargar_datos_postres()
        {
            string product = "Postres";

            conexion.Open();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["des_prod"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            comboBox2.ValueMember = "id_prod";
            comboBox2.DisplayMember = "des_prod";
            comboBox2.DataSource = dt;
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
            comboBox1.Items.Add("Alitas");
            comboBox1.Items.Add("Hamburguesa");
            comboBox1.Items.Add("Papas");
            comboBox1.Items.Add("Bebida");
            comboBox1.Items.Add("Postres");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Alitas")
            {
                cargar_datos_alitas();
            }
            else
            {
            }

            if (comboBox1.SelectedItem.ToString() == "Hamburguesa")
            {
                cargar_datos_hamburguesa();
            }
            else
            {
            }

            if (comboBox1.SelectedItem.ToString() == "Papas")
            {
                cargar_datos_papas();
            }
            else
            {
            }

            if (comboBox1.SelectedItem.ToString() == "Bebida")
            {
                cargar_datos_bebida();
            }
            else
            {
            }

            if (comboBox1.SelectedItem.ToString() == "Postres")
            {
                cargar_datos_postres();
            }
            else
            {
            }

            // if (comboBox1.SelectedValue.ToString() != null)
            //{
            //  String name_prod = comboBox1.SelectedValue.ToString();
            // cargar_datos(price_product)
            // }




            //conexion.Open();
            //MySqlCommand cm = new MySqlCommand("SELECT id_product, name_product, des_product FROM product WHERE name_product = Alita");
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(cm);
            //DataSet ds = new DataSet();
            //adaptador.Fill(ds);



            //MySqlDataReader leer = cm.ExecuteReader();
            //if (leer.Read())
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    conexion.Close();
            //}



        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
