namespace Tito_s_Hotel.Views
{
    partial class viewGeneral2
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
            button1NuevaReserva2 = new Button();
            label1 = new Label();
            buttonVerDisponibilidad2 = new Button();
            button1 = new Button();
            buttonAgregarPasajero = new Button();
            SuspendLayout();
            // 
            // button1NuevaReserva2
            // 
            button1NuevaReserva2.Location = new Point(37, 67);
            button1NuevaReserva2.Name = "button1NuevaReserva2";
            button1NuevaReserva2.Size = new Size(123, 23);
            button1NuevaReserva2.TabIndex = 6;
            button1NuevaReserva2.Text = "Nueva reserva";
            button1NuevaReserva2.UseVisualStyleBackColor = true;
            button1NuevaReserva2.Click += button1NuevaReserva2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 7;
            label1.Text = "Tito´s Hotel";
            // 
            // buttonVerDisponibilidad2
            // 
            buttonVerDisponibilidad2.Location = new Point(37, 96);
            buttonVerDisponibilidad2.Name = "buttonVerDisponibilidad2";
            buttonVerDisponibilidad2.Size = new Size(123, 23);
            buttonVerDisponibilidad2.TabIndex = 8;
            buttonVerDisponibilidad2.Text = "Ver disponibilidad";
            buttonVerDisponibilidad2.UseVisualStyleBackColor = true;
            buttonVerDisponibilidad2.Click += buttonVerDisponibilidad2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 125);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar habitacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAgregarPasajero
            // 
            buttonAgregarPasajero.Location = new Point(37, 154);
            buttonAgregarPasajero.Name = "buttonAgregarPasajero";
            buttonAgregarPasajero.Size = new Size(123, 23);
            buttonAgregarPasajero.TabIndex = 10;
            buttonAgregarPasajero.Text = "Agregar pasajero";
            buttonAgregarPasajero.UseVisualStyleBackColor = true;
            buttonAgregarPasajero.Click += buttonAgregarPasajero_Click;
            // 
            // viewGeneral2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 206);
            Controls.Add(buttonAgregarPasajero);
            Controls.Add(button1);
            Controls.Add(buttonVerDisponibilidad2);
            Controls.Add(label1);
            Controls.Add(button1NuevaReserva2);
            Name = "viewGeneral2";
            Text = "viewGeneral2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1NuevaReserva2;
        private Label label1;
        private Button buttonVerDisponibilidad2;
        private Button button1;
        private Button buttonAgregarPasajero;
    }
}