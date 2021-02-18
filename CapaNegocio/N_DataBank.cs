using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class N_DataBank
    {

        D_DataBank cdatos = new D_DataBank();
        E_Cliente e = new E_Cliente();


        //Reglas del módulo Cliente

        public void insertarCliente(E_Cliente e_Cliente)
        {
            cdatos.insertarCliente(e_Cliente);
        }
        
        public void actualizarCliente(E_Cliente e_Cliente)
        {
            cdatos.actualizarCliente(e_Cliente);
        }

        public void eliminarCliente(E_Cliente e_Cliente)
        {
            cdatos.eliminarCliente(e_Cliente);
        }

        public List<E_Cliente> listarCliente(string buscar)
        {
           return cdatos.listarCliente(buscar);
        }


        //Reglas del módulo Prestamo

        public void insertarPrestamo(E_Prestamo e_Prestamo)
        {
            cdatos.insertarPrestamo(e_Prestamo);
        }

        public void actualizarPrestamo(E_Prestamo e_Prestamo)
        {
            cdatos.actualizarPrestamo(e_Prestamo);
        }

        public void eliminarPrestamo(E_Prestamo e_Prestamo)
        {
            cdatos.eliminarPrestamo(e_Prestamo);
        }

        public List<E_Prestamo> listarPrestamo(string buscar)
        {
            return cdatos.listarPrestamo(buscar);
        }

        //Modulo de consulta
        public List<E_Prestamo> listarConsulta(string buscar)
        {
            return cdatos.listarConsulta(buscar);
        }

        public void eliminarPrestamoConsultado(E_Prestamo e_Prestamo)
        {
            cdatos.eliminarPrestamoConsultado(e_Prestamo);
        }

        public void Pagar(E_Prestamo e_Prestamo)
        {
            cdatos.Pagar(e_Prestamo);
        }

    }
}
