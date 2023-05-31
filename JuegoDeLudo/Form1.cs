using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoDeLudo
{
    public partial class Form1 : Form
    {
        private List<Jugador> jugadores;
        private Jugador jugadorActual;
        private int jugadorActualIndice;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            InitializeJuego();
        }

        private void InitializeJuego()
        {
            jugadores = new List<Jugador>
            {
                new Jugador("Jugador 1", Color.Red),
                new Jugador("Jugador 2", Color.Blue),
                new Jugador("Jugador 3", Color.Green),
                new Jugador("Jugador 4", Color.Yellow),
            };

            jugadorActualIndice = 0;
            jugadorActual = jugadores[jugadorActualIndice];
            random = new Random();

            jugadorActualIndice = 0;
            jugadorActual = jugadores[jugadorActualIndice];
            ActualizarJugadorActual();
        }

        private void ActualizarJugadorActual()
        {
            lblCurrentPlayer.Text = $"Jugador actual: {jugadorActual.Nombre}";
        }

        private void btnTirarDado_Click(object sender, EventArgs e)
        {
            // Cambiar nombre int
            int valorDado = random.Next(1, 7);
            lblDadoValor.Text = $"Dado: {valorDado}";

            // Cambiar al siguiente jugador si el dado no da 6
            if (valorDado != 6)
            {
                jugadorActualIndice = (jugadorActualIndice + 1) % jugadores.Count;
                jugadorActual = jugadores[jugadorActualIndice];
            }
        }
        private void rojoPieza1_Click(object sender, EventArgs e)
        {
            if (jugadorActual.Color == Color.Red)
            {
                MoverPieza(jugadorActual.Piezas[0]);
            }
        }
        private void MoverPieza(Pieza pieza)
        {
            int valorDado = random.Next(1, 7);
            lblDadoValor.Text = $"Dado: {valorDado}";

            List<Pieza> todasLasPiezas = new List<Pieza>();
            foreach (Jugador jugador in jugadores)
            {
                todasLasPiezas.AddRange(jugador.Piezas);
            }

            pieza.Mover(valorDado, todasLasPiezas);

            // Cambia al siguiente jugador si el valor no es 6
            if (valorDado != 6)
            {
                jugadorActualIndice = (jugadorActualIndice + 1) % jugadores.Count;
                jugadorActual = jugadores[jugadorActualIndice];
                ActualizarJugadorActual();
            }
            if (RevisarVictoria(jugadorActual))
            {
                MessageBox.Show($"{jugadorActual.Nombre} ha ganado el juego!");
                InitializeJuego();
            }
        }
        private bool RevisarVictoria(Jugador jugador)
        {
            return jugador.Piezas.Count(pieza => pieza.Terminado) == 4;
        }
    }
}