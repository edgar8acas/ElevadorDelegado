using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevador
{
    class Elevador
    {
        private int _pisosTotales;

        public int PisosTotales
        {
            get { return _pisosTotales; }
        }

        private int _pisoActual;

        public int PisoActual
        {
            get { return _pisoActual; }
        }

        private bool _estadoPuerta;

        public bool EstadoPuerta
        {
            get { return _estadoPuerta; }
        }

        public Elevador(int pisosTotales)
        {
            _pisosTotales = _pisoActual = pisosTotales;
            _estadoPuerta = false;
        }

        private void subirPiso()
        {
            _pisoActual++;
        }

        private void bajarPiso()
        {
            _pisoActual--;
        }

        public void abrirPuerta()
        {
            if(!_estadoPuerta)
                _estadoPuerta = true;
        }

        public void cerrarPuerta()
        {
            if(_estadoPuerta)
                _estadoPuerta = false;
        }

        public void irAPiso(int pisoDestino, Form1.DelegadoActualizarEstado actualizarEstado)
        {
            cerrarPuerta();
            if (_pisoActual != pisoDestino)
            {
                
                if (_pisoActual < pisoDestino)
                    for (int i = _pisoActual; i <= pisoDestino; i++)
                    {
                        
                        subirPiso();
                        Thread.Sleep(1000);
                        actualizarEstado(ToString());
                    }
                else
                    for (int i = _pisoActual; i >= pisoDestino; i--)
                    {
                        
                        bajarPiso();
                        Thread.Sleep(1000);
                        actualizarEstado(ToString());
                    }
                _pisoActual = pisoDestino;
            }
            else
                Console.WriteLine("Estás en el mismo piso");

            abrirPuerta();
        }

        public void irAPiso(int pisoDestino)
        {
            cerrarPuerta();
            if (_pisoActual != pisoDestino)
            {
                if (_pisoActual < pisoDestino)
                    for (int i = _pisoActual; i <= pisoDestino; i++)
                    {
                        subirPiso();
                    }
                else
                    for (int i = _pisoActual; i >= pisoDestino; i--)
                    {
                        bajarPiso();
                    }
                _pisoActual = pisoDestino;
            }
            else
                Console.WriteLine("Estás en el mismo piso");

            abrirPuerta();
        }

        public override string ToString()
        {
            return "Piso " + _pisoActual + " de " + _pisosTotales + ". Estado puerta: " + _estadoPuerta.ToString();
        }


    }
}
