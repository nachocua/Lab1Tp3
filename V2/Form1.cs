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
            //unTorneo = new Torneo(1);
            lbRonda.Text = "Rondas totales: " + unTorneo.Rondas.ToString();
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
            lstbParticipantes.Items.Add(unTorneo.Participantes + " - " + nombre + " - " + club + " (" + edad + ")");
            nombre = "Fernando";
            club = "Talleres";
            edad = 38;
            unTorneo.CargarCompetidor(nombre, club, edad);
            lstbParticipantes.Items.Add(unTorneo.Participantes + " - " + nombre + " - " + club + " (" + edad + ")");
            nombre = "Gustavo";
            club = "Patronato";
            edad = 60;
            unTorneo.CargarCompetidor(nombre, club, edad);
            lstbParticipantes.Items.Add(unTorneo.Participantes + " - " + nombre + " - " + club + " (" + edad + ")");
        }
        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            Ventana_Agregar VAgregar = new Ventana_Agregar();
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
                            lstbParticipantes.Items.Add(unTorneo.Participantes + " - " + nombre + " - " + club + " (" + edad + ")");
                        }
                    }
                }
            } while (!cancel && error);
            VAgregar.Dispose();
            //TestCarga();
        }
        private void btnEmpezarTorneo_Click(object sender, EventArgs e)
        {
            gbInscripcion.Enabled = false;
            gbInscripcion.Visible = false;
            gbListaTorneo.Visible = true;
            gbListaTorneo.Enabled = true;
            for (int i = 0; i < lstbParticipantes.Items.Count; i++) 
            {
                lbPuntos.Items.Add(lstbParticipantes.Items[i]+" - 0 puntos.");
            }
            gbListaTorneo.Text = "Ronda actual: " + (unTorneo.RondaActual);
        }
        private void lbPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicion = lbPuntos.SelectedIndex;
            if (lbPuntos.SelectedIndex != -1)
            {
                button1.Enabled = true;
            }
        }
        private void button1_click(object sender, EventArgs e)
        {
            if(lbPuntos.SelectedIndex != -1)
            {
                VentanaCargarPuntos unaVentana = new VentanaCargarPuntos();
                Competidor auxCompetidor = unTorneo.getCompetidor
                    (posicion);
                int p1, p2, p3;
                bool error,
                    cancel,
                    state1,
                    state2,
                    state3;
                do
                {
                    unaVentana.lbNombre.Text = auxCompetidor.Nombre;
                    unaVentana.lbClub.Text = auxCompetidor.Club;
                    unaVentana.lbEdad.Text = auxCompetidor.Edad.ToString();
                    unaVentana.tbP1.Text = auxCompetidor.GetPuntaje(unTorneo.RondaActual - 1, 0);
                    unaVentana.tbP2.Text = auxCompetidor.GetPuntaje(unTorneo.RondaActual - 1, 1);
                    unaVentana.tbP3.Text = auxCompetidor.GetPuntaje(unTorneo.RondaActual - 1, 2);
                    error = false;
                    cancel = false;
                    if (unaVentana.ShowDialog() != DialogResult.OK)
                    {
                        cancel = true;
                    }
                    if (!cancel)
                    {
                        if (unaVentana.tbP1.Text.CompareTo("") == 0 ||
                        unaVentana.tbP2.Text.CompareTo("") == 0 ||
                        unaVentana.tbP3.Text.CompareTo("") == 0)
                        {
                            MessageBox.Show("No debe dejar campos vacios", "Campos vacios", MessageBoxButtons.OK);
                            error = true;
                        }
                        else
                        {
                            state1 = int.TryParse(unaVentana.tbP1.Text, out p1);
                            state2 = int.TryParse(unaVentana.tbP2.Text, out p2);
                            state3 = int.TryParse(unaVentana.tbP3.Text, out p3);
                            if (!state1 || !state2 || !state3)
                            {
                                if (!state1)
                                {
                                    if (unaVentana.tbP1.Text == "10x")
                                    {
                                        p1 = 11;
                                    }
                                    else
                                    {
                                        error = true;
                                    }
                                }
                                if (!state2)
                                {
                                    if (unaVentana.tbP2.Text == "10x")
                                    {
                                        p2 = 11;
                                    }
                                    else
                                    {
                                        error = true;
                                    }
                                }
                                if (!state3)
                                {
                                    if (unaVentana.tbP3.Text == "10x")
                                    {
                                        p3 = 11;
                                    }
                                    else
                                    {
                                        error = true;
                                    }
                                }
                                if (error)
                                {
                                    MessageBox.Show("Los puntajes deben ser del 0 al 10 o 10x", "Puntaje Incorrecto", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 0, p1);
                                    auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 1, p2);
                                    auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 2, p3);
                                    unTorneo.cargadoPuntaje(lbPuntos.SelectedIndex);
                                    btnEmpezarTorneo.Enabled = true;
                                    if (unTorneo.rondaCompleta())
                                    {
                                        btnSiguienteRonda.Enabled = true;
                                    }
                                    unTorneo.ordenar();
                                    actualizarLista();
                                }
                            }
                            else
                            {
                                auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 0, p1);
                                auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 1, p2);
                                auxCompetidor.AgregarPuntaje(unTorneo.RondaActual, 2, p3);
                                unTorneo.cargadoPuntaje(lbPuntos.SelectedIndex);
                                btnEmpezarTorneo.Enabled = true;
                                if (unTorneo.rondaCompleta())
                                {
                                    btnSiguienteRonda.Enabled = true;
                                }
                                unTorneo.ordenar();
                                actualizarLista();
                            }
                        }
                    }
                } while (!cancel && error);
                unaVentana.Dispose();
            }
        }
        private void btnSiguienteRonda_Click(object sender, EventArgs e)
        {
            if(unTorneo.Rondas != unTorneo.RondaActual)
            {
                unTorneo.siguienteRonda();
                btnSiguienteRonda.Enabled = false;
                gbListaTorneo.Text = "Ronda actual: " + unTorneo.RondaActual;
                unTorneo.ordenar();
                actualizarLista();
            }
            else
            {
                string aux = "1: " + unTorneo.getCompetidor(0).Nombre + " con " + unTorneo.getCompetidor(0).PuntosTotales + " puntos.\n" +
                    "2: " + unTorneo.getCompetidor(1).Nombre + " con " + unTorneo.getCompetidor(1).PuntosTotales + " puntos.\n" +
                    "3: " + unTorneo.getCompetidor(2).Nombre + " con " + unTorneo.getCompetidor(2).PuntosTotales + " puntos.";
                MessageBox.Show(aux, "El top 3 del torneo es");
            }
        }
        private void actualizarLista()
        {
            lbPuntos.Items.Clear();
            Competidor auxCompetidor;
            string aux;
            for (int i = 0; i < unTorneo.Participantes; i++)
            {
                auxCompetidor = unTorneo.getCompetidor(i);
                aux = (i + 1).ToString() + " - "
                    + auxCompetidor.Nombre + " - "
                    + auxCompetidor.Club + " ("
                    + auxCompetidor.Edad + ") - "
                    + auxCompetidor.PuntosTotales + " puntos.";
                lbPuntos.Items.Add(aux);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
