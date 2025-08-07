namespace Tito_s_Hotel.Views.viewsReserva
{
    partial class viewCrearReserva
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
            textBoxNumeroDeHabitacion = new TextBox();
            textBoxDNIDelPasajero = new TextBox();
            dateTimePickerCheckIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAdelanto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonGuardarReserva = new Button();
            buttonCancelar = new Button();
            label6 = new Label();
            textBoxNumeroReserva = new TextBox();
            SuspendLayout();
            // 
            // textBoxNumeroDeHabitacion
            // 
            textBoxNumeroDeHabitacion.Location = new Point(132, 30);
            textBoxNumeroDeHabitacion.Name = "textBoxNumeroDeHabitacion";
            textBoxNumeroDeHabitacion.Size = new Size(100, 23);
            textBoxNumeroDeHabitacion.TabIndex = 0;
            // 
            // textBoxDNIDelPasajero
            // 
            textBoxDNIDelPasajero.Location = new Point(132, 64);
            textBoxDNIDelPasajero.Name = "textBoxDNIDelPasajero";
            textBoxDNIDelPasajero.Size = new Size(100, 23);
            textBoxDNIDelPasajero.TabIndex = 1;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(132, 110);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(224, 23);
            dateTimePickerCheckIn.TabIndex = 2;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(132, 139);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(224, 23);
            dateTimePickerCheckOut.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 110);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Check In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 135);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Check Out:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 192);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Adelanto: $";
            // 
            // textBoxAdelanto
            // 
            textBoxAdelanto.Location = new Point(132, 189);
            textBoxAdelanto.Name = "textBoxAdelanto";
            textBoxAdelanto.Size = new Size(100, 23);
            textBoxAdelanto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 64);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI del pasajero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 30);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Habitacion:";
            // 
            // buttonGuardarReserva
            // 
            buttonGuardarReserva.Location = new Point(43, 237);
            buttonGuardarReserva.Name = "buttonGuardarReserva";
            buttonGuardarReserva.Size = new Size(122, 23);
            buttonGuardarReserva.TabIndex = 10;
            buttonGuardarReserva.Text = "Guardar reserva";
            buttonGuardarReserva.UseVisualStyleBackColor = true;
            buttonGuardarReserva.Click += buttonGuardarReserva_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(257, 237);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 12;
            label6.Text = "Numero de reserva:";
            // 
            // textBoxNumeroReserva
            // 
            textBoxNumeroReserva.Location = new Point(256, 30);
            textBoxNumeroReserva.Name = "textBoxNumeroReserva";
            textBoxNumeroReserva.Size = new Size(100, 23);
            textBoxNumeroReserva.TabIndex = 13;
            // 
            // viewCrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 281);
            Controls.Add(textBoxNumeroReserva);
            Controls.Add(label6);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardarReserva);
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
            Name = "viewCrearReserva";
            Text = "viewCrearReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumeroDeHabitacion;
        private TextBox textBoxDNIDelPasajero;
        private DateTimePicker dateTimePickerCheckIn;
        private DateTimePicker dateTimePickerCheckOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdelanto;
        private Label label4;
        private Label label5;
        private Button buttonGuardarReserva;
        private Button buttonCancelar;
        private Label label6;
        private TextBox textBoxNumeroReserva;
    }
}