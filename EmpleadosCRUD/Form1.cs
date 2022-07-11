using EmpleadosCRUD.Metodos;
using EmpleadosCRUD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosCRUD
{
    public partial class Form1 : Form
    {
        private static string consul;
        public Form1()
        {
            InitializeComponent();
            llenar();
        }
        bool consultado = false;
        private void butGuardar_Click(object sender, EventArgs e)
        {
            if(textID.Text.Trim().Length <= 1)
            {
            MessageBox.Show("Ingrese un ID valido");
            }else if (textNom.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Ingrese un nombre valido");
            }else if (textApe.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Ingrese un apellido valido");
            }
            else if (textEdad.Text.Trim().Length >= 3 || textEdad.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Ingrese una edad valida");
            }
            else if (textDir.Text.Trim().Length <= 8)
            {
                MessageBox.Show("Ingrese una direccion valida");
            }
            else
            {
                try
                {
                    Empleado em = new Empleado();
                    em.Id = textID.Text.Trim();
                    em.Nombres = textNom.Text;
                    em.Apellidos = textApe.Text;
                    em.Edad = Convert.ToInt32(textEdad.Text);
                    em.Direccion = textDir.Text;
                    em.Fecha_nac = dateTimeNac.Value.Year + "-" + dateTimeNac.Value.Month + "-" + dateTimeNac.Value.Day;

                    if (EmpleadoAD.guardar(em))
                    {
                        llenar();
                        MessageBox.Show("Empleado guardado correctamente");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el empleado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verifique que halla ingresado la edad correctamente");
                    MessageBox.Show("Error: " + ex);
                }
            }
        }
        private void llenar()
        {
            DataTable datos = EmpleadoAD.mostrar();

            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataGridView1.DataSource = datos.DefaultView;
            }
        }

        private void llenarCon()
        {
            DataTable datos2 = mostrarConsulta();

            if (datos2 == null)
            {
                MessageBox.Show("Verifique la sintaxis de la consulta");
            }
            else
            {
                dataGridView1.DataSource = datos2.DefaultView;
            }
        }

        private void limpiar()
        {
            textID.Text = " ";
            textNom.Text = " ";
            textApe.Text = " ";
            textEdad.Text = " ";
            textDir.Text = " ";
            dateTimeNac.Text = "12/31/2004";
        }
        private void butLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            if (textID.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Ingrese un ID valido");
            }
            else 
            {
                Empleado em = EmpleadoAD.buscar(textID.Text.Trim(),dateTimeNac.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el empleado con id: " + textID.Text + " y fecha de nacimiento: " + dateTimeNac.Text);
                    consultado = false;
                }
                else
                {
                    textID.Text = em.Id;
                    textNom.Text = em.Nombres;
                    textApe.Text = em.Apellidos;
                    textEdad.Text = em.Edad.ToString();
                    textDir.Text = em.Direccion;
                    dateTimeNac.Text = em.Fecha_nac;
                    consultado = true;
                }
            }
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el empleado que desea actualizar");
            }
            else if (textID.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Ingrese un ID valido");
            }
            else if (textNom.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Ingrese un nombre valido");
            }
            else if (textApe.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Ingrese un apellido valido");
            }
            else if (textEdad.Text.Trim().Length >= 3 || textEdad.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Ingrese una edad valida");
            }
            else if (textDir.Text.Trim().Length <= 8)
            {
                MessageBox.Show("Ingrese una direccion valida");
            }
            try
            {
                Empleado em = new Empleado();
                em.Id = textID.Text.Trim();
                em.Nombres = textNom.Text;
                em.Apellidos = textApe.Text;
                em.Edad = Convert.ToInt32(textEdad.Text);
                em.Direccion = textDir.Text;
                em.Fecha_nac = dateTimeNac.Value.Year + "-" + dateTimeNac.Value.Month + "-" + dateTimeNac.Value.Day;

                if (EmpleadoAD.actualizar(em))
                {
                    llenar();
                    MessageBox.Show("Empleado actualizado correctamente");
                    consultado = false;
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se actualizo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que halla ingresado la edad correctamente");
                MessageBox.Show("Error: " + ex);
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el empleado que desea actualizar");
            }
            else if (textID.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Ingrese un ID valido");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "¿Desea eliminar este registro?","Confirmacion",MessageBoxButtons.YesNo))
            {
            try
            {
                if (EmpleadoAD.eliminar(textID.Text.Trim()))
                {
                    llenar();
                    MessageBox.Show("Empleado eliminado correctamente");
                    consultado = false;
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se elimino");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
        public static DataTable mostrarConsulta()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = consul;
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

        private void butConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                consul = textConsulta.Text;
                llenarCon();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void butConsul_Click(object sender, EventArgs e)
        {
            try
            {
                llenar();
                textConsulta.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
    }

