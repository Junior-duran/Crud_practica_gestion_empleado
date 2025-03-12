using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Crud_practica_gestion_empleado
{
    // Capa de Entidades (modelos)
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        protected Empleado(string Nombre, string Apellido, int Edad, string Cargo, Decimal Salario)
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Edad = Edad;
            Cargo = Cargo;
            Salario = Salario;
        }
        public override string ToString()
        {
            return $"{Id} {Nombre} {Apellido} {Edad} {Cargo} {Salario}";
        }
    }
    public class Administrativo : Empleado
    {
        public Administrativo (string Nombre, string Apellido, int Edad, string Cargo, Decimal Salario) 
            : base(Nombre, Apellido, Edad, Cargo, Salario) { }  
    }
    public class Operario : Empleado
    {
        public Operario(string Nombre, string Apellido, int Edad, string Cargo, Decimal Salario)
            : base(Nombre, Apellido, Edad, Cargo, Salario) { }
    }
}