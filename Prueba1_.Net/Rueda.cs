using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1_.Net
{
    class Rueda : VehiculoComponentes
    {
        private string _recubrimiento;
        private int _menorDurometro;
        private int _mayorDurometro;

        public Rueda(string recubrimiento,
                    int menorDurometro, int mayorDurometro)

        {
            _recubrimiento = recubrimiento;
            _menorDurometro = menorDurometro;
            _mayorDurometro = mayorDurometro;

            if (menorDurometro < mayorDurometro)
            {
                _menorDurometro = menorDurometro;
                _mayorDurometro = mayorDurometro;
            }
            else
            {
                _menorDurometro = mayorDurometro;
                _mayorDurometro = menorDurometro;
            }
        }

        public string Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }
        public int MenorDurometro { get => _menorDurometro; set => _menorDurometro = value; }
        public int MayorDurometro { get => _mayorDurometro; set => _mayorDurometro = value; }
    }
}