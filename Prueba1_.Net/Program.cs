using System;
using System.Collections;

namespace Prueba1_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("LA Motors");
                Console.WriteLine("\n");
                Console.WriteLine("Plataforma de Ingreso de vehiculos");
                Console.WriteLine("\n");

                string usuario;
                string contrasena;

                Console.WriteLine("Ingrese su usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                contrasena = Console.ReadLine();
                while (usuario != "admin" && contrasena != "1234")
                {
                    Console.WriteLine("Vuelva a escribir su usuario");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Vuelva a escribir su contraseña");
                    usuario = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Bienvenido"+ " " + usuario);
                Console.WriteLine("\n");
                Console.WriteLine("Plataforma de Ingreso de vehiculos");

                Console.Clear();
                Console.WriteLine("LA Motors SA. ");

                ArrayList infoAuto = new ArrayList();
                int menu = 0;

                do
                {

                    Console.WriteLine("Plataformas de Ingreso de vehiculos\n");
                    Console.WriteLine("LA Motors\n" +
                   "\n1.- Ingresar Vehiculo." +
                   "\n2.- Lista de Vehiculos." +
                   "\n0.- Salir");
                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {

                        case 1:

                            Automovil _automovil;
                            Motor _motor;
                            Mezclador _mezclador;
                            Estanque _estanque;
                            Rueda _rueda;

                            Console.WriteLine("Ingrese marca de un automovil:");
                            string _nMarca = Console.ReadLine();
                            Console.WriteLine("Ingrese el año del automovil:");
                            float _nAno = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese kilometraje:");
                            float _nKilometraje = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Tipo de Motor\n" + " 1. DOS TIEMPOS\n" + "2. CUATRO TIEMPOS:");
                            string _nTipoMotor = Console.ReadLine();
                            if (_nTipoMotor == "1")
                                _nTipoMotor = "Dos Tiempos";
                            else if (_nTipoMotor == "2")
                                _nTipoMotor = "Cuatro Tiempos";                            
                            Console.WriteLine("Ingrese el ID numerico del motor:");
                            float _nId = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cilindrada:");
                            float _nCilindrada = float.Parse(Console.ReadLine());
                            _motor = new Motor(_nId,_nTipoMotor, _nCilindrada);                            
                            Console.WriteLine("Ingrese El tipo de Mezclador\n"+ "1. Carburador\n" + "2. Inyector");
                            string _nTipo = Console.ReadLine();
                            if (_nTipo == "1")
                                _nTipo = "Carburador";
                            else if (_nTipo == "2")
                                _nTipo = "Inyector";
                            _mezclador = new Mezclador( _nTipo);                      
                            Console.WriteLine("Capacidad del estanque:");
                            float capacidadEstanque = float.Parse(Console.ReadLine());
                            Console.WriteLine("Cantidad de litros en el estanque:");
                            float litrosEstanque = float.Parse(Console.ReadLine());
                            _estanque = new Estanque(capacidadEstanque, litrosEstanque);
                            Console.WriteLine("Su rueda puede tener recubrimiento\n" + "1. FENOL\n" + "2. HULE\n" + "3. POLIUTERANO");
                            Console.WriteLine("Ingrese el recubrimiento de las 4 ruedas que tendra su vehiculo:");
                            string _nRecubrimiento = Console.ReadLine();
                            if (_nRecubrimiento == "1")
                                _nRecubrimiento = "FENOL";
                            else if (_nRecubrimiento == "2")
                                _nRecubrimiento = "HULE";
                            else if (_nRecubrimiento == "3")
                                _nRecubrimiento = "POLIUTERANO";
                            Console.WriteLine("Ingrese el primer rango de dureza del neumatico:");
                            int _nDurometroMin = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo rango de dureza del neumatico:");
                            int _nDurometroMax = int.Parse(Console.ReadLine());
                            _rueda = new Rueda( _nRecubrimiento,
                                                    _nDurometroMin, _nDurometroMax);
                            _automovil = new Automovil(_estanque, _mezclador,
                                                            _rueda, _motor, _nMarca,
                                                            _nAno, _nKilometraje);
                            infoAuto.Add(_automovil);
                            
                            Console.WriteLine("¡Los Datos han sido Guardados Exitosamente!");
                            Console.WriteLine("Presione Alguna Tecla para finalizar");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            int numVehiculos = 0;
                            foreach (object item in infoAuto)
                            {
                                numVehiculos++;
                                Automovil auto2 = (Automovil)item;

                                Console.WriteLine("Numero de vehiculos guardados: " + numVehiculos);

                                Console.WriteLine("Marca del automovil: " + auto2.Marca);
                                Console.WriteLine("Año del automovil: " + auto2.Ano);
                                Console.WriteLine("Kilometraje del automovil: " + auto2.Kilometraje);
                                Console.WriteLine("ID numerico del motor: " + auto2.Motor.Id);
                                Console.WriteLine("Tipo del motor del vehiculo: " + auto2.Motor.Tipo);
                                Console.WriteLine("Volumen Cilindrada: " + auto2.Motor.Cilindrada);
                                Console.WriteLine("Tipo recubrimiento de las ruedas: " + auto2.Rueda.Recubrimiento);
                                Console.WriteLine("Capacidad del estanque: " + auto2.Estanque.Capacidad);
                                Console.WriteLine("\nCantidad de litros en el estanque: " + auto2.Estanque.Litros);
                                Console.WriteLine("El valor menor de dureza de la rueda: " + auto2.Rueda.MenorDurometro);
                                Console.WriteLine("\nEl valor mayor de dureza de la rueda: " + auto2.Rueda.MayorDurometro);
                               
                            }

                            break;

                        case 3:
                            Environment.Exit(0);

                            break;


                            

                    }
                } while (menu != 0);

                Console.ReadKey();
            }

            catch (Exception)
            {
                Console.WriteLine("OpenWrite() failed");
            }
        }
    }
}