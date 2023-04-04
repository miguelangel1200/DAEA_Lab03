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

namespace Lab03
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + bd + ";";

            // La cadena de  conexión cambia en función del estado CheckBox
            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";

            // Abrir una conexión con el servidor, usando la cadena de conexión
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada satisfactoriamente");
                }
                else
                    MessageBox.Show("La conexión esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la sesión: \n" + ex.ToString());
            }
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }

        private void chkAutenticacion_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnEstado_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del Servidor: " + conn.State + "\nVersión del Servidor: " + conn.ServerVersion + "\nBase de Datos: " + conn.State);
                else
                    MessageBox.Show("Estado del Servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" + ex.ToString());
            }
        }
    }
}
