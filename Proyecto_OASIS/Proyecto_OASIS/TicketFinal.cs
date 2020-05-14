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
    public partial class TicketFinal : Form
    {
        public TicketFinal()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Confirmacion_de_pedido ToElegir = new Confirmacion_de_pedido();
            this.Hide();
            ToElegir.Show();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Juego ToElegir = new Juego();
            this.Hide();
            ToElegir.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
