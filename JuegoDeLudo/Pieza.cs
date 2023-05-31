using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuegoDeLudo
{
    public class Pieza
    {
        public Jugador Propietario { get; set; }
        public int Posicion { get; set; }
        public bool EnCasa { get; set; }
        public bool Terminado { get; set; }

        public Pieza(Jugador propietario)
        {
            Propietario = propietario;
            Posicion = 0;
            EnCasa = true;
            Terminado = false;
        }

        public void Mover(int pasos, List<Pieza> todasLasPiezas)
        {
            // Implementar lógica del movimiento
            if (EnCasa && pasos == 6) 
            {
                EnCasa = false;
                Posicion = 0;
            }
            else if (!EnCasa && !Terminado)
            {
                int nuevaPosicion = Posicion + pasos;

                // Controlar capturas
                foreach (Pieza otraPieza in todasLasPiezas)
                {
                    if (otraPieza != this && otraPieza.Propietario != Propietario && otraPieza.Posicion == nuevaPosicion)
                    {
                        otraPieza.EnCasa = true;
                        otraPieza.Posicion = 0;
                        break;
                    }
                }

                Posicion = nuevaPosicion;
                // Revisa si la pieza llegó a la posición final
                if (Posicion >= 52)
                {
                    Posicion = 52;
                    Terminado = true;
                }
            }
        }
    }
}
