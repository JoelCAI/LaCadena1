using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena1
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string nombre;

            nombre = Validador.ValidarString("\n Ingrese su nombre");
            Validador.ConcatenarTexto(nombre);
 
            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}