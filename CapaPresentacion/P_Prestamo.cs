using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaPresentacion
{
    public partial class P_Prestamo : Form
    {
        private string codeId;
        private bool editando = false;

        N_DataBank cnegocio = new N_DataBank();
        E_Prestamo centidad = new E_Prestamo();

        public P_Prestamo()
        {
            InitializeComponent();
        }

        private void P_Prestamo_Load(object sender, EventArgs e)
        {
            mostrarTabla("");
            accionesTabla();
        }

        public void mostrarTabla(string buscar)
        {

            dataGridViewPres.DataSource = cnegocio.listarPrestamo(buscar);

        }

        public void accionesTabla()
        {
            dataGridViewPres.Columns[0].Visible = false;
            dataGridViewPres.Columns[1].Width = 60;
            dataGridViewPres.Columns[2].Width = 120;
        }
                      

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void bunifuFlatBtnGu_Click(object sender, EventArgs e)
        {
            try
            {

                if (editando == false)
                {


                    centidad.ced = tbxCed.Text.ToUpper();
                    centidad.monto = Convert.ToDecimal(tbxMonto.Text);
                    centidad.inte = Convert.ToInt32(tbxTasa.Text);
                    centidad.temp = Convert.ToInt32(tbxIntervalo.Text);
                    centidad.cuo = Convert.ToDecimal(lblCalcCuota.Text);
                    centidad.deu = Convert.ToDecimal(lblCalcTotal.Text);

                    cnegocio.insertarPrestamo(centidad);

                    MessageBox.Show("El registro ha sido insertado correctamente.");

                    Limpiar();
                    mostrarTabla("");
                }
                if (editando == true)
                {
                    centidad.ced = tbxCed.Text.ToUpper();
                    centidad.monto = Convert.ToDecimal(tbxMonto.Text);
                    centidad.inte = Convert.ToInt32(tbxTasa.Text);
                    centidad.temp = Convert.ToInt32(tbxIntervalo.Text);
                    centidad.cuo = Convert.ToDecimal(lblCalcCuota.Text);
                    centidad.deu = Convert.ToDecimal(lblCalcTotal.Text);

                    cnegocio.actualizarPrestamo(centidad);

                    MessageBox.Show("El registro ha sido actualizado correctamente.");

                    Limpiar();
                    mostrarTabla("");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bunifuFlatBtnAct_Click(object sender, EventArgs e)
        {
            if (dataGridViewPres.SelectedRows.Count > 0)
            {
                editando = true;
                codeId = dataGridViewPres.CurrentRow.Cells[0].Value.ToString();
                tbxCed.Text = dataGridViewPres.CurrentRow.Cells[2].Value.ToString();
                tbxMonto.Text = dataGridViewPres.CurrentRow.Cells[3].Value.ToString();
                tbxTasa.Text = dataGridViewPres.CurrentRow.Cells[4].Value.ToString();
                tbxIntervalo.Text = dataGridViewPres.CurrentRow.Cells[5].Value.ToString();
                lblCalcCuota.Text = dataGridViewPres.CurrentRow.Cells[6].Value.ToString();
                lblCalcTotal.Text = dataGridViewPres.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }

        private void bunifuFlatBtnBor_Click(object sender, EventArgs e)
        {
            if (dataGridViewPres.SelectedRows.Count > 0)
            {
                try
                {
                    centidad.ced = dataGridViewPres.CurrentRow.Cells[2].Value.ToString();

                    cnegocio.eliminarPrestamo(centidad);

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

        private void bunifuFlatBtnCal_Click(object sender, EventArgs e)
        {
            try
            {

                centidad.monto = decimal.Parse(tbxMonto.Text);
                centidad.inte = int.Parse(tbxTasa.Text);
                centidad.temp = int.Parse(tbxIntervalo.Text);

                decimal porcentaje = (centidad.monto * centidad.inte) / 100;

                centidad.deu = porcentaje + centidad.monto;

                centidad.cuo = centidad.deu / centidad.temp;

                lblCalcCuota.Text = centidad.cuo.ToString();
                lblCalcTotal.Text = centidad.deu.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       

        /*--------------------------------------------------------------------------------------------------*/

        public void Limpiar()//Metodo para limpiar los textBox
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    element.Text = "";
                }
            }

            tbxCed.Focus();
            
            lblCalcCuota.Text = "0";
            lblCalcTotal.Text = "0";

        }

        
    }
}


