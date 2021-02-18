using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_DataBank
    {
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        SqlCommand cmd;

        //Conexion para el modulo Cliente
        public void insertarCliente(E_Cliente e_Cliente)
        {
            cmd = new SqlCommand("sp_insertar_cliente", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@nom", e_Cliente.nom);
            cmd.Parameters.AddWithValue("@ape", e_Cliente.ape);
            cmd.Parameters.AddWithValue("@dir", e_Cliente.dir);
            cmd.Parameters.AddWithValue("@tel", e_Cliente.tel);
            cmd.Parameters.AddWithValue("@ced", e_Cliente.ced);
            
            cmd.ExecuteNonQuery();
            conex.Close();

        }

        public void actualizarCliente (E_Cliente e_Cliente)
        {

            cmd = new SqlCommand("sp_actualizar_cliente", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@nom", e_Cliente.nom);
            cmd.Parameters.AddWithValue("@ape", e_Cliente.ape);
            cmd.Parameters.AddWithValue("@dir", e_Cliente.dir);
            cmd.Parameters.AddWithValue("@tel", e_Cliente.tel);
            cmd.Parameters.AddWithValue("@ced", e_Cliente.ced);
           
            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void eliminarCliente(E_Cliente e_Cliente)
        {
            cmd = new SqlCommand("sp_eliminar_cliente", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();
            cmd.Parameters.AddWithValue("@ced", e_Cliente.ced);

            cmd.ExecuteNonQuery();
            conex.Close();
        }
        
        public List<E_Cliente> listarCliente(string buscar)
        {
            SqlDataReader leerFilas;
            cmd = new SqlCommand("sp_listar_cliente", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@oper", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Cliente> listar = new List<E_Cliente>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Cliente
                {
                    idCli = leerFilas.GetInt32(0),
                    cod = leerFilas.GetString(1),
                    nom = leerFilas.GetString(2),
                    ape = leerFilas.GetString(3),
                    dir = leerFilas.GetString(4),
                    tel = leerFilas.GetString(5),
                    ced = leerFilas.GetString(6)
                });
            }

            conex.Close();
            leerFilas.Close();
            return listar;
        }

        //Conexion para el modulo Prestamo

        public void insertarPrestamo(E_Prestamo e_Prestamo)
        {
            cmd = new SqlCommand("sp_insertar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();
            cmd.Parameters.AddWithValue("@ced", e_Prestamo.ced);
            cmd.Parameters.AddWithValue("@mont", e_Prestamo.monto);
            cmd.Parameters.AddWithValue("@inte", e_Prestamo.inte);
            cmd.Parameters.AddWithValue("@tie", e_Prestamo.temp);
            cmd.Parameters.AddWithValue("@cuo", e_Prestamo.cuo);
            cmd.Parameters.AddWithValue("@mon_deu", e_Prestamo.deu);

            cmd.ExecuteNonQuery();
            conex.Close();

        }

        public void actualizarPrestamo(E_Prestamo e_Prestamo)
        {

            cmd = new SqlCommand("sp_actualizar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@ced", e_Prestamo.ced);
            cmd.Parameters.AddWithValue("@mont", e_Prestamo.monto);
            cmd.Parameters.AddWithValue("@inte", e_Prestamo.inte);
            cmd.Parameters.AddWithValue("@tie", e_Prestamo.temp);
            cmd.Parameters.AddWithValue("@cuo", e_Prestamo.cuo);
            cmd.Parameters.AddWithValue("@mon_deu", e_Prestamo.deu);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void eliminarPrestamo(E_Prestamo e_Prestamo)
        {
            cmd = new SqlCommand("sp_eliminar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();
            cmd.Parameters.AddWithValue("@ced", e_Prestamo.ced);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public List<E_Prestamo> listarPrestamo(string buscar)
        {
            SqlDataReader leerFilas;
            cmd = new SqlCommand("sp_listar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@oper", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Prestamo> listar = new List<E_Prestamo>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Prestamo
                {
                    idPre = leerFilas.GetInt32(0),
                    codP = leerFilas.GetString(1),
                    ced = leerFilas.GetString(2),
                    monto = leerFilas.GetDecimal(3),
                    inte = leerFilas.GetInt32(4),
                    temp = leerFilas.GetInt32(5),
                    cuo = leerFilas.GetDecimal(6),
                    deu = leerFilas.GetDecimal(7)
                });

            }

            conex.Close();
            leerFilas.Close();
            return listar;
        }
        

        //Conexion para el modulo Consultar

        public List<E_Prestamo> listarConsulta(string buscar)
        {
            SqlDataReader leerFilas;
            cmd = new SqlCommand("sp_listar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();

            cmd.Parameters.AddWithValue("@oper", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Prestamo> listar = new List<E_Prestamo>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Prestamo
                {
                    idPre = leerFilas.GetInt32(0),
                    codP = leerFilas.GetString(1),
                    ced = leerFilas.GetString(2),
                    monto = leerFilas.GetDecimal(3),
                    inte = leerFilas.GetInt32(4),
                    temp = leerFilas.GetInt32(5),
                    cuo = leerFilas.GetDecimal(6),
                    deu = leerFilas.GetDecimal(7)
                });

            }

            conex.Close();
            leerFilas.Close();
            return listar;
        }

        public void eliminarPrestamoConsultado(E_Prestamo e_Prestamo)
        {
            cmd = new SqlCommand("sp_eliminar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();
            cmd.Parameters.AddWithValue("@ced", e_Prestamo.ced);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        public void Pagar(E_Prestamo e_Prestamo)
        {

            cmd = new SqlCommand("sp_pagar_prestamo", conex);
            cmd.CommandType = CommandType.StoredProcedure;

            conex.Open();
            cmd.Parameters.AddWithValue("@ced", e_Prestamo.ced);
            
            cmd.Parameters.AddWithValue("@mon_deu", e_Prestamo.deu);

            cmd.ExecuteNonQuery();
            conex.Close();
        }

        
    }
}