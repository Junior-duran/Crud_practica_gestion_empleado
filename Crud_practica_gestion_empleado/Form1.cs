using System;
using System.Windows.Forms;

namespace Crud_practica_gestion_empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbladministrativo = new System.Windows.forms.checkbox();
            lbladministrativo.Text = "Administrativo";
            this.Controls.Add(lbladministrativo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Apellido.Text) ||
                string.IsNullOrEmpty(txt_Edad.Text) || string.IsNullOrEmpty(txt_Cargo.Text) ||
                string.IsNullOrEmpty(txt_Salario.Text))
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Edad;
            Decimal Salario;
            if (!int.TryParse(txt_Edad.Text, out Edad) || !decimal.TryParse(txt_Salario.Text, out Salario))
            {
                MessageBox.Show("Edad y Salario deben ser valores numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Empleado empleado;
            if (rbAdministrativo.Checked)
            {
                empleado = new Administrativo(txt_Nombre.Text, txt_Apellido.Text, Edad, txt_Cargo.Text, Salario);
            }
            else if (rbOperario.Checked)
            {
                empleado = new Operario(txt_Nombre.Text, txt_Apellido.Text, Edad, txt_Cargo.Text, Salario);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmpleadoService.RegistrarEmpleado(empleado);
            ActualizarLista();
        }
    }
}