namespace Tito_s_Hotel.Views.viewsPasajero
{
    partial class viewModificarPasajero
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
            buttonCancelar = new Button();
            buttonGuardarCambios = new Button();
            textBoxStringCorreo = new TextBox();
            textBoxStringTelefono = new TextBox();
            textBoxStringDni = new TextBox();
            textBoxStringApellido = new TextBox();
            textBoxStringNombre = new TextBox();
            labelCorreo = new Label();
            labelTelefono = new Label();
            labelDni = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(108, 269);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(73, 43);
            buttonCancelar.TabIndex = 23;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardarCambios
            // 
            buttonGuardarCambios.Location = new Point(76, 208);
            buttonGuardarCambios.Name = "buttonGuardarCambios";
            buttonGuardarCambios.Size = new Size(125, 43);
            buttonGuardarCambios.TabIndex = 22;
            buttonGuardarCambios.Text = "Guardar cambios";
            buttonGuardarCambios.UseVisualStyleBackColor = true;
            buttonGuardarCambios.Click += buttonGuardarCambios_Click;
            // 
            // textBoxStringCorreo
            // 
            textBoxStringCorreo.Location = new Point(122, 158);
            textBoxStringCorreo.Name = "textBoxStringCorreo";
            textBoxStringCorreo.Size = new Size(100, 23);
            textBoxStringCorreo.TabIndex = 21;
            // 
            // textBoxStringTelefono
            // 
            textBoxStringTelefono.Location = new Point(122, 120);
            textBoxStringTelefono.Name = "textBoxStringTelefono";
            textBoxStringTelefono.Size = new Size(100, 23);
            textBoxStringTelefono.TabIndex = 20;
            // 
            // textBoxStringDni
            // 
            textBoxStringDni.Location = new Point(122, 91);
            textBoxStringDni.Name = "textBoxStringDni";
            textBoxStringDni.Size = new Size(100, 23);
            textBoxStringDni.TabIndex = 19;
            // 
            // textBoxStringApellido
            // 
            textBoxStringApellido.Location = new Point(122, 64);
            textBoxStringApellido.Name = "textBoxStringApellido";
            textBoxStringApellido.Size = new Size(100, 23);
            textBoxStringApellido.TabIndex = 18;
            // 
            // textBoxStringNombre
            // 
            textBoxStringNombre.Location = new Point(122, 29);
            textBoxStringNombre.Name = "textBoxStringNombre";
            textBoxStringNombre.Size = new Size(100, 23);
            textBoxStringNombre.TabIndex = 17;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(62, 158);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 16;
            labelCorreo.Text = "Correo:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(61, 128);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 15;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Location = new Point(62, 98);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(30, 15);
            labelDni.TabIndex = 14;
            labelDni.Text = "DNI:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(62, 67);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 13;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(62, 32);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 12;
            labelNombre.Text = "Nombre:";
            // 
            // viewModificarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 330);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardarCambios);
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
            Name = "viewModificarPasajero";
            Text = "viewModificarPasajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardarCambios;
        private TextBox textBoxStringCorreo;
        private TextBox textBoxStringTelefono;
        private TextBox textBoxStringDni;
        private TextBox textBoxStringApellido;
        private TextBox textBoxStringNombre;
        private Label labelCorreo;
        private Label labelTelefono;
        private Label labelDni;
        private Label labelApellido;
        private Label labelNombre;
    }
}