using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1_.Net
{
    abstract class Vehiculo
    {
        private Estanque _estanque;
        private Mezclador _mezclador;
        private Rueda _rueda;
        private Motor _motor;

        protected Vehiculo(Estanque estanque, Mezclador mezclador,
                    Rueda rueda, Motor motor)

        {
            _estanque = estanque;
            _mezclador = mezclador;
            _rueda = rueda;
            _motor = motor;
        }


        public Rueda Rueda { get => _rueda; set => _rueda = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
        internal Motor Motor { get => _motor; set => _motor = value; }

    }
}