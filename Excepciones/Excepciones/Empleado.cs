using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Empleado
    {
        private string _strNombre;
        private int _intEdad;


        public string nombre
        {
            get { return _strNombre; }
            set
            {
                _strNombre = value;
                if (_strNombre == "")
                {
                    throw new Exception("No debe dejar en blanco el nombre");
                }
            }
        }

        public int edad
        {
            get { return _intEdad; }
            set
            {
                _intEdad = value;
                if (_intEdad < 0 || _intEdad > 70)
                {
                    throw new Exception("Edad fuera de rango");
                }
            }
        }
    }
}
