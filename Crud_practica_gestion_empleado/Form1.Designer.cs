namespace Crud_practica_gestion_empleado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btn_Guardar = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Edad = new TextBox();
            txt_Cargo = new TextBox();
            txt_Salario = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Edad = new Label();
            lbl_Cargo = new Label();
            lbl_Salario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 338);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(299, 392);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(110, 45);
            btn_Guardar.TabIndex = 1;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(550, 392);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(110, 45);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(781, 392);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(110, 45);
            btn_Eliminar.TabIndex = 3;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(128, 12);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(129, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(128, 90);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(129, 23);
            txt_Apellido.TabIndex = 5;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(128, 180);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(129, 23);
            txt_Edad.TabIndex = 6;
            // 
            // txt_Cargo
            // 
            txt_Cargo.Location = new Point(128, 252);
            txt_Cargo.Name = "txt_Cargo";
            txt_Cargo.Size = new Size(129, 23);
            txt_Cargo.TabIndex = 7;
            // 
            // txt_Salario
            // 
            txt_Salario.Location = new Point(128, 327);
            txt_Salario.Name = "txt_Salario";
            txt_Salario.Size = new Size(129, 23);
            txt_Salario.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(42, 20);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 9;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(42, 98);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 10;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(42, 183);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(33, 15);
            lbl_Edad.TabIndex = 11;
            lbl_Edad.Text = "Edad";
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.Location = new Point(42, 260);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(39, 15);
            lbl_Cargo.TabIndex = 12;
            lbl_Cargo.Text = "Cargo";
            // 
            // lbl_Salario
            // 
            lbl_Salario.AutoSize = true;
            lbl_Salario.Location = new Point(42, 335);
            lbl_Salario.Name = "lbl_Salario";
            lbl_Salario.Size = new Size(42, 15);
            lbl_Salario.TabIndex = 13;
            lbl_Salario.Text = "Salario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(903, 459);
            Controls.Add(lbl_Salario);
            Controls.Add(lbl_Cargo);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Salario);
            Controls.Add(txt_Cargo);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Guardar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Guardar;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Edad;
        private TextBox txt_Cargo;
        private TextBox txt_Salario;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Edad;
        private Label lbl_Cargo;
        private Label lbl_Salario;
    }
}
