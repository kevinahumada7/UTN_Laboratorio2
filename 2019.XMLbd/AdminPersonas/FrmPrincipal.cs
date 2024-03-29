﻿using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        DataTable tablaPersonas;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.tablaPersonas = new DataTable("Personas");
        }

        private void  CargarDataTable()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM Personas";
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            tablaPersonas.Load(dataReader);

            dataReader.Close();
            sqlConnection.Close();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                OpenFileDialog path = new OpenFileDialog();
                path.ShowDialog();

                TextReader textReader = new StreamReader(path.FileName);

                this.lista = (List<Persona>)xml.Deserialize(textReader);

                textReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                SaveFileDialog path = new SaveFileDialog();
                path.ShowDialog();

                TextWriter textWriter = new StreamWriter(path.FileName);

                xml.Serialize(textWriter, this.lista);

                textWriter.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }   
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);
            frm.StartPosition = FormStartPosition.CenterScreen;

            this.lista = frm.ListaFrm;

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText= "SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]"; //"SELECT * FROM[personas_bd].[dbo].[personas]"
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                this.lista.Clear();

                while(dataReader.Read() != false)
                {
                    Persona buffer = new Persona((string)dataReader["nombre"], (string)dataReader["apellido"], (int)dataReader["edad"]);
                    this.lista.Add(buffer);
                    MessageBox.Show(buffer.ToString());
                }

                MessageBox.Show("Base de Datos conectada con exito.");
                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
