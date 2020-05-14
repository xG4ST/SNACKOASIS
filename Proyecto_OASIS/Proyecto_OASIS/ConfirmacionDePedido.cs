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
    public partial class Confirmacion_de_pedido : Form
    {
        public Confirmacion_de_pedido()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TicketFinal ToTicketFinal = new TicketFinal();
            this.Hide();
            ToTicketFinal.Show();
        }

        private void Confirmacion_de_pedido_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Comida ToComida = new Comida();
            this.Hide();
            ToComida.Show();
        }
    }
}
