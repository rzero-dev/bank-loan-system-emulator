using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class P_Cliente : Form
    {
        private string codeId;
        private bool editando = false;

        N_DataBank cnegocio = new N_DataBank();
        E_Cliente centidad = new E_Cliente();

        public P_Cliente()
        {
            InitializeComponent();
        }

        private void P_Cliente_Load(object sender, EventArgs e)
        {
            mostrarTabla("");
            accionesTabla();
        }

        public void mostrarTabla(string buscar)
        {
           
            dataGridViewCli.DataSource = cnegocio.listarCliente(buscar);

        }

        public void accionesTabla()
        {
            dataGridViewCli.Columns[0].Visible = false;
            dataGridViewCli.Columns[1].Width = 60;
            dataGridViewCli.Columns[2].Width = 120;
        }    
      
                        
       private void btnCerrar_Click_1(object sender, EventArgs e)
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
                    //centidad.idCli = int.Parse(codeId);
                    centidad.nom = tbxNom.Text.ToUpper();
                    centidad.ape = tbxApe.Text.ToUpper();
                    centidad.dir = tbxDir.Text.ToUpper();
                    centidad.tel = tbxTel.Text.ToUpper();
                    centidad.ced = tbxCed.Text.ToUpper();

                    cnegocio.insertarCliente(centidad);

                    MessageBox.Show("El registro ha sido insertado correctamente.");

                    Limpiar();
                    mostrarTabla("");

                }
                if (editando == true)
                {
                    centidad.nom = tbxNom.Text.ToUpper();
                    centidad.ape = tbxApe.Text.ToUpper();
                    centidad.dir = tbxDir.Text.ToUpper();
                    centidad.tel = tbxDir.Text.ToUpper();
                    centidad.ced = tbxCed.Text.ToUpper();

                    cnegocio.actualizarCliente(centidad);

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

        private void bunifuFlatBtnAct_Click(object sender, EventArgs e)
        {
            if (dataGridViewCli.SelectedRows.Count > 0)
            {
                editando = true;
                codeId = dataGridViewCli.CurrentRow.Cells[0].Value.ToString();
                tbxNom.Text = dataGridViewCli.CurrentRow.Cells[2].Value.ToString();
                tbxApe.Text = dataGridViewCli.CurrentRow.Cells[3].Value.ToString();
                tbxDir.Text = dataGridViewCli.CurrentRow.Cells[4].Value.ToString();
                tbxTel.Text = dataGridViewCli.CurrentRow.Cells[5].Value.ToString();
                tbxCed.Text = dataGridViewCli.CurrentRow.Cells[6].Value.ToString();
                            
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }

        private void bunifuFlatBtnBor_Click(object sender, EventArgs e)
        {
            if (dataGridViewCli.SelectedRows.Count > 0)
            {
                try
                {
                    centidad.ced = dataGridViewCli.CurrentRow.Cells[6].Value.ToString();

                    cnegocio.eliminarCliente(centidad);

                    MessageBox.Show("El registro ha sido eliminado correctamente");

                    mostrarTabla("");
                }
                catch(Exception error)
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
        /*-----------------------------------------------------------------*/
        public void Limpiar()//Metodo para limpiar los textBox
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    element.Text = "";
                }
            }

            tbxNom.Focus();
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarTabla(tbxBuscar.Text);
        }
    }
}
