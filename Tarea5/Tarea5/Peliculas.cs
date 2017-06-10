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
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      id_pelicula,nombre_pelicula
                      FROM
                      Peliculas
                     ";

                if (Auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgPeliculas.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void DobleClick()
        {
            Form1.id_pelicula = dgPeliculas.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgPeliculas_DoubleClick(object sender, EventArgs e)
        {
            DobleClick();
            this.Close();

        }
    }
}
