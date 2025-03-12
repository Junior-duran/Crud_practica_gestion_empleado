using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crud_practica_gestion_empleado
{
    // Capa de logica de negocio
    public class EmpleadoService
    {
        private List<Empleado> empleados = new List<Empleado>();
        public void registrarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public void EliminarEmpleado(int index)
        {
            empleados.RemoveAt(index);
        }
        public List<string> ListarEmpleados()
        {
            return empleados.Select(e => e.ToString()).ToList();
        }
    }
}