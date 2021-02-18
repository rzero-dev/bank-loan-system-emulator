using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_DataBank : Form
    {
        public P_DataBank()
        {
            InitializeComponent();
        }
            
        private void pbxDB2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileBtnCli_Click(object sender, EventArgs e)
        {
            P_Cliente fCliente = new P_Cliente();

            fCliente.Show();
            this.Hide();
        }

        private void bunifuTileBtnPre_Click(object sender, EventArgs e)
        {
            P_Prestamo fPrestamo = new P_Prestamo();

            fPrestamo.Show();
            this.Hide();
        }

        private void bunifuTileBtnCon_Click(object sender, EventArgs e)
        {
            P_Consultar fConsultar = new P_Consultar();

            fConsultar.Show();
            this.Hide();
        }
    }
}
