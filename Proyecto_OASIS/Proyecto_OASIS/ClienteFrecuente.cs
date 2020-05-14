using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_OASIS
{
    public partial class ClienteFrecuente : Form
    {
        public ClienteFrecuente()
        {
            InitializeComponent();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Pedido_Externo ToMenu = new Pedido_Externo();
        //    this.Hide();
        //    ToMenu.Show();
        //}

        private void ClienteFrecuente_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Comida ToComida = new Comida();
            this.Hide();
            ToComida.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }
    }
}
