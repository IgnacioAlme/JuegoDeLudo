using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuegoDeLudo
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Color Color { get; set; }
        public List<Pieza> Piezas { get; set; }

        public Jugador(string nombre, Color color) 
        {
            Nombre = nombre;
            Color = color;
            Piezas = new List<Pieza>();
            InitializePiezas();
        }

        private void InitializePiezas()
        {
            for (int i = 0; i < 4; i++) 
            {
                Piezas.Add(new Pieza(this));
            }
        }
    }
}
