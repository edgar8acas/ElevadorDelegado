using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Elevador elevador = new Elevador(6);
        public delegate void DelegadoActualizarEstado(String estado);
        

        private void btnPiso1_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(1, dae);
        }

        private void btnPiso2_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(2, dae);
            lblEstado.Text = elevador.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(3, dae);
            lblEstado.Text = elevador.ToString();
        }

        private void btnPiso4_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(4, dae);
            lblEstado.Text = elevador.ToString();
        }

        private void btnPiso5_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(5, dae);
            lblEstado.Text = elevador.ToString();
        }

        private void btnPiso6_Click(object sender, EventArgs e)
        {
            DelegadoActualizarEstado dae = actualizarLabelEstado;
            elevador.irAPiso(6, dae);
            lblEstado.Text = elevador.ToString();
        }

        private void btnPuerta_Click(object sender, EventArgs e)
        {
            elevador.abrirPuerta();
            lblEstado.Text = elevador.ToString();
        }

        private void btnCerrarPuerta_Click(object sender, EventArgs e)
        {
            elevador.cerrarPuerta();
            lblEstado.Text = elevador.ToString();
        }

        public void actualizarLabelEstado(String estado)
        {
            lblEstado.Text = estado;
        }
    }
}
