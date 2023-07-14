using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2
{
    public partial class Form1 : Form
    {
        Torneo unTorneo = null;
        int posicion;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            unTorneo = new Torneo(rnd.Next(6) + 5);
            lbRonda.Text = "Rondas totales: " + unTorneo.Rondas.ToString();
            //Size = new Size(283, 488);
            this.MaximumSize = Size;
            this.MinimumSize = Size;
            gbListaTorneo.Text = "Ronda actual: " + (unTorneo.Rondas + 1);
        }
        public void TestCarga()
        {
            btnEmpezarTorneo.Enabled = true;
            int edad;
            string nombre,
                club;
            nombre = "Pancho";
            club = "Paracao";
            edad = 54;
            unTorneo.CargarCompetidor(nombre, club, edad);
            lstbParticipantes.Items.Add(nombre + " - " + club + " (" + edad + ")");
            nombre = "Fernando";
            club = "Talleres";
            edad = 38;
            unTorneo.CargarCompetidor(nombre, club, edad);
            lstbParticipantes.Items.Add(nombre + " - " + club + " (" + edad + ")");
            nombre = "Gustavo";
            club = "Patronato";
            edad = 60;
            unTorneo.CargarCompetidor(nombre, club, edad);
            lstbParticipantes.Items.Add(nombre + " - " + club + " (" + edad + ")");
        }
        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            /*Ventana_Agregar VAgregar = new Ventana_Agregar();
            int edad;
            string nombre, 
                club;
            bool error,
                cancel;
            do
            {
                error = false;
                cancel = false;
                if (VAgregar.ShowDialog() != DialogResult.OK)
                {
                    cancel = true;
                }
                if(!cancel)
                {
                    if (VAgregar.tbEdad.Text.CompareTo("") == 0 ||
                    VAgregar.tbNombre.Text.CompareTo("") == 0 ||
                    VAgregar.tbClub.Text.CompareTo("") == 0)
                    {
                        MessageBox.Show("No debe dejar campos vacios", "Campos vacios", MessageBoxButtons.OK);
                        error = true;
                    }
                    else
                    {
                        if(!Int32.TryParse(VAgregar.tbEdad.Text, out edad))
                        {
                            MessageBox.Show("La edad debe ser numérica", "Edad incorrecta", MessageBoxButtons.OK);
                            error = true;
                        }
                        else
                        {
                            btnEmpezarTorneo.Enabled = true;
                            nombre = VAgregar.tbNombre.Text;
                            club = VAgregar.tbClub.Text;
                            unTorneo.CargarCompetidor(nombre, club, edad);
                            lstbParticipantes.Items.Add(nombre + " - " + club + " (" + edad + ")");
                        }
                    }
                }
            } while (!cancel && error);
            VAgregar.Dispose();
            */
            TestCarga();
        }
        private void btnEmpezarTorneo_Click(object sender, EventArgs e)
        {
            gbInscripcion.Enabled = false;
            Size Size = new Size(539, 488);
            this.MaximumSize = Size;
            this.MinimumSize = Size;
            for(int i = 0; i < lstbParticipantes.Items.Count; i++) 
            {
                lbPuntos.Items.Add(lstbParticipantes.Items[i]);
            }
            gbListaTorneo.Text = "Ronda actual: " + (unTorneo.Rondas + 1);
            gbListaTorneo.Enabled = true;
        }
        private void lbPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicion = lbPuntos.SelectedIndex;
            button1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            VentanaCargarPuntos unaVentana = new VentanaCargarPuntos();
            unaVentana.lbNombre.Text = unTorneo.getCompetidor(posicion).Nombre;
            unaVentana.lbClub.Text = unTorneo.getCompetidor(posicion).Club;
            unaVentana.lbEdad.Text = unTorneo.getCompetidor(posicion).Edad.ToString();
            if (unaVentana.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
