using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.models
{
    internal class Servicio
    {
        List<Persona> persona = new List<Persona>();
        public bool AgregarPersona(int dni,string nombre)
        {
            Persona pers = VerPersonaPorDni(dni);


            if (pers == null)
            {
                persona.Add(new Persona(dni, nombre));
                return true;
            }
            return false;

        }
        public int VerCantidadDePersonas()
        {
            
            return persona.Count;
        }
        public Persona VerPersona(int n)
        {
            if (n <= VerCantidadDePersonas())
            {
                return persona[n];
            }
            return null;
        }
        public Persona VerPersonaPorDni(int dni)
        {
            int idx = -1;
            int n = 0;
            while(idx ==-1 && n<persona.Count)
            {
                if(dni== persona[n].Dni)
                {
                    idx = n;
                }
                n++;
            }
            if(idx > -1)
            {
                return persona[idx];
            }
            else
            {
                return null;
            }
            
        }

        public void EliminarPersona(Persona persona)
        {
            if (VerPersonaPorDni(persona.Dni) !=null)
            {
                this.persona.Remove(persona);
            }
        }
    }
}
