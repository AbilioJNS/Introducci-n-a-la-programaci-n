using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciación_a_la_programación
{
    internal class ReferenciaOValor
    {
        class LaClase
        {
            public string variableClase;
        }

        struct LaEstructura
        {
            public string variableEstructura;
        }

        class TestDeClaseYEstructura
        {

            public void CambiarClase(LaClase clase)
            {
                clase.variableClase = "Cambiado en CambiarClase";
            }

            public void CambiarEstructura(LaEstructura estructura)
            {
                estructura.variableEstructura = "Cambiado en CambiarEstructura";
            }
        }
    }
}
