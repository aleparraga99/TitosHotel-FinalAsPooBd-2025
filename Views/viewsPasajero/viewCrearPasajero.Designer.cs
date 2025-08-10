namespace Tito_s_Hotel.Views
{
    partial class viewCrearPasajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNombre = new Label();
            labelApellido = new Label();
            labelDni = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();
            textBoxStringNombre = new TextBox();
            textBoxStringApellido = new TextBox();
            textBoxStringDni = new TextBox();
            textBoxStringTelefono = new TextBox();
            textBoxStringCorreo = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(67, 34);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(67, 69);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Location = new Point(67, 100);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(30, 15);
            labelDni.TabIndex = 2;
            labelDni.Text = "DNI:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(66, 130);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(67, 160);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 4;
            labelCorreo.Text = "Correo:";
            // 
            // textBoxStringNombre
            // 
            textBoxStringNombre.Location = new Point(127, 31);
            textBoxStringNombre.Name = "textBoxStringNombre";
            textBoxStringNombre.Size = new Size(100, 23);
            textBoxStringNombre.TabIndex = 5;
            // 
            // textBoxStringApellido
            // 
            textBoxStringApellido.Location = new Point(127, 66);
            textBoxStringApellido.Name = "textBoxStringApellido";
            textBoxStringApellido.Size = new Size(100, 23);
            textBoxStringApellido.TabIndex = 6;
            // 
            // textBoxStringDni
            // 
            textBoxStringDni.Location = new Point(127, 93);
            textBoxStringDni.Name = "textBoxStringDni";
            textBoxStringDni.Size = new Size(100, 23);
            textBoxStringDni.TabIndex = 7;
            // 
            // textBoxStringTelefono
            // 
            textBoxStringTelefono.Location = new Point(127, 122);
            textBoxStringTelefono.Name = "textBoxStringTelefono";
            textBoxStringTelefono.Size = new Size(100, 23);
            textBoxStringTelefono.TabIndex = 8;
            // 
            // textBoxStringCorreo
            // 
            textBoxStringCorreo.Location = new Point(127, 160);
            textBoxStringCorreo.Name = "textBoxStringCorreo";
            textBoxStringCorreo.Size = new Size(100, 23);
            textBoxStringCorreo.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(39, 222);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(81, 43);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(170, 222);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(89, 43);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // viewCrearPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 285);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxStringCorreo);
            Controls.Add(textBoxStringTelefono);
            Controls.Add(textBoxStringDni);
            Controls.Add(textBoxStringApellido);
            Controls.Add(textBoxStringNombre);
            Controls.Add(labelCorreo);
            Controls.Add(labelTelefono);
            Controls.Add(labelDni);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Name = "viewCrearPasajero";
            Text = "ViewPasajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelApellido;
        private Label labelDni;
        private Label labelTelefono;
        private Label labelCorreo;
        private TextBox textBoxStringNombre;
        private TextBox textBoxStringApellido;
        private TextBox textBoxStringDni;
        private TextBox textBoxStringTelefono;
        private TextBox textBoxStringCorreo;
        private Button buttonGuardar;
        private Button buttonCancelar;
    }
}