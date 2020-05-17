using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1_.Net
{
    class Estanque : VehiculoComponentes
    {
        private float _capacidad;
        private float _litros;

        public Estanque(float capacidad, float litros)
        {
            _capacidad = capacidad;
            _litros = litros;
        }

        public float Capacidad { get => _capacidad; set => _capacidad = value; }
        public float Litros { get => _litros; set => _litros = value; }

        public bool MitadCombustible()

        {
            float minimoCombustible = 10.5f * _capacidad / 100.0f;
            float maximoCombustible = 50.0f * _capacidad / 100.0f;


            if (_litros > minimoCombustible & _litros <= maximoCombustible)
            {
                return true;
            }

            else
            {
                return false;
            }


        }
        public bool BajoCombustible()
        {
            float minimoCombustible = 10.5f * _capacidad / 100.0f;

            if (_litros <= minimoCombustible)
            {

                return true;
            }

            else
            {

                return false;
            }
        }

    }
}