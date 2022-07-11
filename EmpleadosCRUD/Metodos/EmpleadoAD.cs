using EmpleadosCRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosCRUD.Metodos
{
    class EmpleadoAD
    {

        public static bool guardar(Empleado em)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "insert into EMPLEADO values('" + em.Id + "', '" + em.Nombres + "', '" + em.Apellidos + "', " + em.Edad + ", '" + em.Direccion + "', '" + em.Fecha_nac + "')";
                SqlCommand comando = new SqlCommand(sql,con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if(cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
        public static DataTable mostrar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM EMPLEADO";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Empleado buscar(string id, string fecha_nac)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM EMPLEADO WHERE id = '" + id + "' and fecha_nac = '"+ fecha_nac +"';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
                Empleado em = new Empleado();
                if (dr.Read())
                {
                    em.Id = dr["id"].ToString();
                    em.Nombres = dr["nombres"].ToString();
                    em.Apellidos = dr["apellidos"].ToString();
                    em.Edad = Convert.ToInt32(dr["edad"].ToString());
                    em.Direccion = dr["direccion"].ToString();
                    em.Fecha_nac = dr["fecha_nac"].ToString();
                    con.desconectar();
                    return em;
                }
                else
                {
                    con.desconectar();
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool actualizar(Empleado em)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE EMPLEADO SET nombres='"+ em.Nombres + "',apellidos='" + em.Apellidos + "',edad=" + em.Edad + ",direccion='" + em.Direccion + "'  where id='" + em.Id + "' and fecha_nac='" + em.Fecha_nac + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool eliminar(string id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM EMPLEADO where id='" + id + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
