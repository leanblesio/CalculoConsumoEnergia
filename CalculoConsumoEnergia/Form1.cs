using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoConsumoEnergia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpFechaConsumo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsumoEnergia consumo = new ConsumoEnergia();
                consumo.CalculoConsumoEnergia(double.Parse(tbFase1.Text), double.Parse(tbFase2.Text), double.Parse(tbFaseD5.Text));

                lblConsumo.Text = consumo.ConsumoTotalEnergia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. " + "Error: " +ex.Message);
                //throw;
            }
            

        }
    }
}
