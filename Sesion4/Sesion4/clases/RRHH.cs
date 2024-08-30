using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{
    internal class RRHH
    {
        public RRHH() { }
        public double CalcularSalario(Empleado empleado, double deducciones)
        {
            return empleado.Salary - deducciones;
        }
        //Aumentar el salario en un x% si un slario base es menor a 10,
        public void AumentarSalario(Empleado empleado, double porcentaje, double techo )
        {
            empleado.Salary = (empleado.Salary <= techo) ? empleado.Salary =
                 (empleado.Salary * (1 + porcentaje)) : empleado.Salary;

            if (empleado.Salary <= 10)
            {
                empleado.Salary = empleado.Salary + (empleado.Salary * porcentaje);
            }
            else
            {
                empleado.Salary = empleado.Salary;
            }
        }
    }
}
