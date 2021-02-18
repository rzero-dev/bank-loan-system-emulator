using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class P_Consultar : Form
    {
        private string codeId;
        private bool editando = false;

        E_Prestamo centidad = new E_Prestamo();
        N_DataBank cnegocio = new N_DataBank();
        public P_Consultar()
        {
            InitializeComponent();
        }

        private void P_Consultar_Load(object sender, EventArgs e)
        {
            

            mostrarTabla("");
            accionesTabla();
        }

        public void mostrarTabla(string buscar)
        {

            dataGridViewCons.DataSource = cnegocio.listarConsulta(buscar);

        }

        public void accionesTabla()
        {
            dataGridViewCons.Columns[0].Visible = false;
            dataGridViewCons.Columns[1].Width = 60;
            dataGridViewCons.Columns[2].Width = 120;
        }

     

        


        private void bunifuFlatBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatBtnAtras_Click(object sender, EventArgs e)
        {
            P_DataBank fDataBank = new P_DataBank();

            fDataBank.Show();
            this.Hide();
        }

        private void bunifuFlatBtnPag_Click(object sender, EventArgs e)
        {
            try
            {
                if (editando == true)
                {

                    string ced;
                    decimal pago;
                    decimal deuda;
                    decimal nuevaDeuda;

                    ced = tbxCed.Text;
                    pago = decimal.Parse(tbxPago.Text);
                    deuda = decimal.Parse(tbxMontoA.Text);

                    nuevaDeuda = deuda - pago;


                    centidad.ced = ced;

                    centidad.deu = nuevaDeuda;
                    
                    cnegocio.Pagar(centidad);

                    MessageBox.Show("El registro ha sido actualizado correctamente");

                    Limpiar();
                    mostrarTabla("");

                    editando = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    

        private void bunifuFlatBtnBor_Click(object sender, EventArgs e)
        {
            if (dataGridViewCons.SelectedRows.Count > 0)
            {
                try
                {
                    centidad.ced = dataGridViewCons.CurrentRow.Cells[2].Value.ToString();

                    cnegocio.eliminarPrestamoConsultado(centidad);

                    MessageBox.Show("El registro ha sido eliminado correctamente");

                    mostrarTabla("");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea eliminar.");
            }
        }
    

        private void bunifuFlatBtnLim_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Limpiar()//Metodo para limpiar los textBox
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    element.Text = "";
                }
            }
            tbxBuscar.Focus();
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarTabla(tbxBuscar.Text);
        }

        private void bunifuFlatBtnSel_Click(object sender, EventArgs e)
        {
            if (dataGridViewCons.SelectedRows.Count > 0)
            {
                editando = true;
                codeId = dataGridViewCons.CurrentRow.Cells[0].Value.ToString();
                tbxCed.Text = dataGridViewCons.CurrentRow.Cells[2].Value.ToString();
                tbxMonto.Text = dataGridViewCons.CurrentRow.Cells[3].Value.ToString();
                tbxCuota.Text = dataGridViewCons.CurrentRow.Cells[6].Value.ToString();
                tbxMontoA.Text = dataGridViewCons.CurrentRow.Cells[7].Value.ToString();
                

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }
    }
 }

