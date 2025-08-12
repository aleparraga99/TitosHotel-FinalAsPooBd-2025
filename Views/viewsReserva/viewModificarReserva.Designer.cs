namespace Tito_s_Hotel.Views.viewsReserva
{
    partial class viewModificarReserva
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
            textBoxNumeroReserva = new TextBox();
            label6 = new Label();
            buttonCancelar = new Button();
            buttonGuardarCambiosDeReserva = new Button();
            label5 = new Label();
            label4 = new Label();
            textBoxAdelanto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            textBoxDNIDelPasajero = new TextBox();
            textBoxNumeroDeHabitacion = new TextBox();
            SuspendLayout();
            // 
            // textBoxNumeroReserva
            // 
            textBoxNumeroReserva.Location = new Point(322, 57);
            textBoxNumeroReserva.Name = "textBoxNumeroReserva";
            textBoxNumeroReserva.Size = new Size(57, 23);
            textBoxNumeroReserva.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 39);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 26;
            label6.Text = "Numero de reserva:\r\n";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(280, 244);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 37);
            buttonCancelar.TabIndex = 25;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardarCambiosDeReserva
            // 
            buttonGuardarCambiosDeReserva.Location = new Point(66, 244);
            buttonGuardarCambiosDeReserva.Name = "buttonGuardarCambiosDeReserva";
            buttonGuardarCambiosDeReserva.Size = new Size(126, 37);
            buttonGuardarCambiosDeReserva.TabIndex = 24;
            buttonGuardarCambiosDeReserva.Text = "Guardar cambios";
            buttonGuardarCambiosDeReserva.UseVisualStyleBackColor = true;
            buttonGuardarCambiosDeReserva.Click += buttonGuardarCambiosDeReserva_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 39);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 23;
            label5.Text = "Habitacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 73);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 22;
            label4.Text = "DNI del pasajero:";
            // 
            // textBoxAdelanto
            // 
            textBoxAdelanto.Location = new Point(155, 196);
            textBoxAdelanto.Name = "textBoxAdelanto";
            textBoxAdelanto.Size = new Size(100, 23);
            textBoxAdelanto.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 199);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 20;
            label3.Text = "Adelanto: $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 19;
            label2.Text = "Check Out:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 117);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 18;
            label1.Text = "Check In:";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(155, 146);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(224, 23);
            dateTimePickerCheckOut.TabIndex = 17;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(155, 117);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(224, 23);
            dateTimePickerCheckIn.TabIndex = 16;
            // 
            // textBoxDNIDelPasajero
            // 
            textBoxDNIDelPasajero.Location = new Point(172, 73);
            textBoxDNIDelPasajero.Name = "textBoxDNIDelPasajero";
            textBoxDNIDelPasajero.Size = new Size(100, 23);
            textBoxDNIDelPasajero.TabIndex = 15;
            // 
            // textBoxNumeroDeHabitacion
            // 
            textBoxNumeroDeHabitacion.Location = new Point(172, 39);
            textBoxNumeroDeHabitacion.Name = "textBoxNumeroDeHabitacion";
            textBoxNumeroDeHabitacion.Size = new Size(100, 23);
            textBoxNumeroDeHabitacion.TabIndex = 14;
            // 
            // viewModificarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 306);
            Controls.Add(textBoxNumeroReserva);
            Controls.Add(label6);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardarCambiosDeReserva);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxAdelanto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(textBoxDNIDelPasajero);
            Controls.Add(textBoxNumeroDeHabitacion);
            Name = "viewModificarReserva";
            Text = "viewModificarReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumeroReserva;
        private Label label6;
        private Button buttonCancelar;
        private Button buttonGuardarCambiosDeReserva;
        private Label label5;
        private Label label4;
        private TextBox textBoxAdelanto;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerCheckOut;
        private DateTimePicker dateTimePickerCheckIn;
        private TextBox textBoxDNIDelPasajero;
        private TextBox textBoxNumeroDeHabitacion;
    }
}