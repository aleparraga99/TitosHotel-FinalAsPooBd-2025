namespace Tito_s_Hotel
{
    partial class viewGeneral
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
            buttonVerDisponibilidad = new Button();
            label1 = new Label();
            dataGridViewListaDeReservas = new DataGridView();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonHabitaciones = new Button();
            buttonPasajeros = new Button();
            label2 = new Label();
            buttonNuevaReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeReservas).BeginInit();
            SuspendLayout();
            // 
            // buttonVerDisponibilidad
            // 
            buttonVerDisponibilidad.Location = new Point(12, 163);
            buttonVerDisponibilidad.Name = "buttonVerDisponibilidad";
            buttonVerDisponibilidad.Size = new Size(135, 23);
            buttonVerDisponibilidad.TabIndex = 7;
            buttonVerDisponibilidad.Text = "Ver disponibilidad";
            buttonVerDisponibilidad.UseVisualStyleBackColor = true;
            buttonVerDisponibilidad.Click += buttonVerDisponibilidad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Tito´s Hotel";
            // 
            // dataGridViewListaDeReservas
            // 
            dataGridViewListaDeReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDeReservas.Location = new Point(183, 36);
            dataGridViewListaDeReservas.Name = "dataGridViewListaDeReservas";
            dataGridViewListaDeReservas.Size = new Size(377, 181);
            dataGridViewListaDeReservas.TabIndex = 8;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(322, 239);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(198, 239);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonHabitaciones
            // 
            buttonHabitaciones.Location = new Point(21, 58);
            buttonHabitaciones.Name = "buttonHabitaciones";
            buttonHabitaciones.Size = new Size(94, 23);
            buttonHabitaciones.TabIndex = 12;
            buttonHabitaciones.Text = "Habitaciones";
            buttonHabitaciones.UseVisualStyleBackColor = true;
            buttonHabitaciones.Click += buttonHabitaciones_Click;
            // 
            // buttonPasajeros
            // 
            buttonPasajeros.Location = new Point(21, 118);
            buttonPasajeros.Name = "buttonPasajeros";
            buttonPasajeros.Size = new Size(94, 23);
            buttonPasajeros.TabIndex = 13;
            buttonPasajeros.Text = "Pasajeros";
            buttonPasajeros.UseVisualStyleBackColor = true;
            buttonPasajeros.Click += buttonPasajeros_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 14;
            label2.Text = "Lista de reservas";
            // 
            // buttonNuevaReserva
            // 
            buttonNuevaReserva.Location = new Point(436, 239);
            buttonNuevaReserva.Name = "buttonNuevaReserva";
            buttonNuevaReserva.Size = new Size(115, 23);
            buttonNuevaReserva.TabIndex = 15;
            buttonNuevaReserva.Text = "Nueva reserva";
            buttonNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // viewGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 285);
            Controls.Add(buttonNuevaReserva);
            Controls.Add(label2);
            Controls.Add(buttonPasajeros);
            Controls.Add(buttonHabitaciones);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(dataGridViewListaDeReservas);
            Controls.Add(buttonVerDisponibilidad);
            Controls.Add(label1);
            Name = "viewGeneral";
            Text = "viewGeneral";
            Load += viewGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVerDisponibilidad;
        private Label label1;
        private DataGridView dataGridViewListaDeReservas;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonHabitaciones;
        private Button buttonPasajeros;
        private Label label2;
        private Button buttonNuevaReserva;
    }
}