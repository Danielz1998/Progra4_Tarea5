using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;

namespace Tarea5
{
    public partial class Form1 : Form
    {
        public static string id_pelicula = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            if (Auxiliar.conn.Conectar(".", "Tareas", "sa", "ceutec11"))
            {
                MessageBox.Show("Conectadoa la Base de Datos");
            }
            else
            {
                MessageBox.Show("Error al conectarse.! " + Auxiliar.conn.SQLError());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conectar();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            Peliculas P = new Peliculas();
            P.ShowDialog(this);
            txtIDPelicula.Text = id_pelicula;

        }

        private void Guardar()
        {
            string query = @"INSERT INTO Tickets(id_pelicula, fecha_funcion, precio_pelicula)
                             values({0},'{1}',{2})";

            query = string.Format(query,
                                  txtIDPelicula.Text,
                                  dtpFecha.Text,
                                  txtPrecio.Text);
            //MessageBox.Show(query);
            if (Auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Ticket Registrado");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
