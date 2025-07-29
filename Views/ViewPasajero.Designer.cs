namespace Tito_s_Hotel.Views
{
    partial class ViewPasajero
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
            textBoxIntDni = new TextBox();
            textBoxIntTelefono = new TextBox();
            textBoxStringCorreo = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            labelStringHabitacion = new Label();
            textBoxHabitacion = new TextBox();
            labelDateCheckIn = new Label();
            labelDateCheckOut = new Label();
            dateTimePickerChekIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            labelStringAdelanto = new Label();
            textBoxIntAdelanto = new TextBox();
            labelStringDiasTotales = new Label();
            label11 = new Label();
            textBoxFloatTotalDeEstadia = new TextBox();
            labelIntCantidadDeDias = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(40, 32);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(40, 67);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Location = new Point(40, 98);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(30, 15);
            labelDni.TabIndex = 2;
            labelDni.Text = "DNI:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(39, 128);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(40, 158);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 4;
            labelCorreo.Text = "Correo:";
            // 
            // textBoxStringNombre
            // 
            textBoxStringNombre.Location = new Point(100, 29);
            textBoxStringNombre.Name = "textBoxStringNombre";
            textBoxStringNombre.Size = new Size(100, 23);
            textBoxStringNombre.TabIndex = 5;
            // 
            // textBoxStringApellido
            // 
            textBoxStringApellido.Location = new Point(100, 64);
            textBoxStringApellido.Name = "textBoxStringApellido";
            textBoxStringApellido.Size = new Size(100, 23);
            textBoxStringApellido.TabIndex = 6;
            // 
            // textBoxIntDni
            // 
            textBoxIntDni.Location = new Point(100, 91);
            textBoxIntDni.Name = "textBoxIntDni";
            textBoxIntDni.Size = new Size(100, 23);
            textBoxIntDni.TabIndex = 7;
            // 
            // textBoxIntTelefono
            // 
            textBoxIntTelefono.Location = new Point(100, 120);
            textBoxIntTelefono.Name = "textBoxIntTelefono";
            textBoxIntTelefono.Size = new Size(100, 23);
            textBoxIntTelefono.TabIndex = 8;
            // 
            // textBoxStringCorreo
            // 
            textBoxStringCorreo.Location = new Point(100, 158);
            textBoxStringCorreo.Name = "textBoxStringCorreo";
            textBoxStringCorreo.Size = new Size(100, 23);
            textBoxStringCorreo.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(148, 232);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(81, 43);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(275, 232);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(89, 43);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelStringHabitacion
            // 
            labelStringHabitacion.AutoSize = true;
            labelStringHabitacion.Location = new Point(253, 35);
            labelStringHabitacion.Name = "labelStringHabitacion";
            labelStringHabitacion.Size = new Size(68, 15);
            labelStringHabitacion.TabIndex = 12;
            labelStringHabitacion.Text = "Habitación:";
            // 
            // textBoxHabitacion
            // 
            textBoxHabitacion.Location = new Point(318, 32);
            textBoxHabitacion.Name = "textBoxHabitacion";
            textBoxHabitacion.Size = new Size(46, 23);
            textBoxHabitacion.TabIndex = 13;
            // 
            // labelDateCheckIn
            // 
            labelDateCheckIn.AutoSize = true;
            labelDateCheckIn.Location = new Point(256, 72);
            labelDateCheckIn.Name = "labelDateCheckIn";
            labelDateCheckIn.Size = new Size(56, 15);
            labelDateCheckIn.TabIndex = 14;
            labelDateCheckIn.Text = "Check In:";
            // 
            // labelDateCheckOut
            // 
            labelDateCheckOut.AutoSize = true;
            labelDateCheckOut.Location = new Point(256, 99);
            labelDateCheckOut.Name = "labelDateCheckOut";
            labelDateCheckOut.Size = new Size(66, 15);
            labelDateCheckOut.TabIndex = 15;
            labelDateCheckOut.Text = "Check Out:";
            // 
            // dateTimePickerChekIn
            // 
            dateTimePickerChekIn.Location = new Point(318, 67);
            dateTimePickerChekIn.Name = "dateTimePickerChekIn";
            dateTimePickerChekIn.Size = new Size(200, 23);
            dateTimePickerChekIn.TabIndex = 16;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(321, 96);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(200, 23);
            dateTimePickerCheckOut.TabIndex = 17;
            // 
            // labelStringAdelanto
            // 
            labelStringAdelanto.AutoSize = true;
            labelStringAdelanto.Location = new Point(256, 158);
            labelStringAdelanto.Name = "labelStringAdelanto";
            labelStringAdelanto.Size = new Size(67, 15);
            labelStringAdelanto.TabIndex = 18;
            labelStringAdelanto.Text = "Adelanto: $";
            // 
            // textBoxIntAdelanto
            // 
            textBoxIntAdelanto.Location = new Point(321, 155);
            textBoxIntAdelanto.Name = "textBoxIntAdelanto";
            textBoxIntAdelanto.Size = new Size(67, 23);
            textBoxIntAdelanto.TabIndex = 19;
            // 
            // labelStringDiasTotales
            // 
            labelStringDiasTotales.AutoSize = true;
            labelStringDiasTotales.Location = new Point(401, 192);
            labelStringDiasTotales.Name = "labelStringDiasTotales";
            labelStringDiasTotales.Size = new Size(70, 15);
            labelStringDiasTotales.TabIndex = 20;
            labelStringDiasTotales.Text = "Días totales:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(253, 128);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 22;
            label11.Text = "Total de estadía: $";
            // 
            // textBoxFloatTotalDeEstadia
            // 
            textBoxFloatTotalDeEstadia.Location = new Point(359, 126);
            textBoxFloatTotalDeEstadia.Name = "textBoxFloatTotalDeEstadia";
            textBoxFloatTotalDeEstadia.Size = new Size(67, 23);
            textBoxFloatTotalDeEstadia.TabIndex = 23;
            // 
            // labelIntCantidadDeDias
            // 
            labelIntCantidadDeDias.AutoSize = true;
            labelIntCantidadDeDias.Location = new Point(468, 192);
            labelIntCantidadDeDias.Name = "labelIntCantidadDeDias";
            labelIntCantidadDeDias.Size = new Size(12, 15);
            labelIntCantidadDeDias.TabIndex = 24;
            labelIntCantidadDeDias.Text = "-";
            // 
            // ViewPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 297);
            Controls.Add(labelIntCantidadDeDias);
            Controls.Add(textBoxFloatTotalDeEstadia);
            Controls.Add(label11);
            Controls.Add(labelStringDiasTotales);
            Controls.Add(textBoxIntAdelanto);
            Controls.Add(labelStringAdelanto);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerChekIn);
            Controls.Add(labelDateCheckOut);
            Controls.Add(labelDateCheckIn);
            Controls.Add(textBoxHabitacion);
            Controls.Add(labelStringHabitacion);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxStringCorreo);
            Controls.Add(textBoxIntTelefono);
            Controls.Add(textBoxIntDni);
            Controls.Add(textBoxStringApellido);
            Controls.Add(textBoxStringNombre);
            Controls.Add(labelCorreo);
            Controls.Add(labelTelefono);
            Controls.Add(labelDni);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Name = "ViewPasajero";
            Text = "ViewPasajero";
            Load += ViewPasajero_Load;
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
        private TextBox textBoxIntDni;
        private TextBox textBoxIntTelefono;
        private TextBox textBoxStringCorreo;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private Label labelStringHabitacion;
        private TextBox textBoxHabitacion;
        private Label labelDateCheckIn;
        private Label labelDateCheckOut;
        private DateTimePicker dateTimePickerChekIn;
        private DateTimePicker dateTimePickerCheckOut;
        private Label labelStringAdelanto;
        private TextBox textBoxIntAdelanto;
        private Label labelStringDiasTotales;
        private Label label11;
        private TextBox textBoxFloatTotalDeEstadia;
        private Label labelIntCantidadDeDias;
    }
}