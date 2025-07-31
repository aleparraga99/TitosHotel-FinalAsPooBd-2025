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
            button1 = new Button();
            dataGridViewListaDeReservas = new DataGridView();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonAgregarHabitacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeReservas).BeginInit();
            SuspendLayout();
            // 
            // buttonVerDisponibilidad
            // 
            buttonVerDisponibilidad.Location = new Point(337, 58);
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
            label1.Location = new Point(232, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Tito´s Hotel";
            // 
            // button1
            // 
            button1.Location = new Point(69, 58);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 5;
            button1.Text = "Nueva reserva";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewListaDeReservas
            // 
            dataGridViewListaDeReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDeReservas.Location = new Point(69, 110);
            dataGridViewListaDeReservas.Name = "dataGridViewListaDeReservas";
            dataGridViewListaDeReservas.Size = new Size(403, 132);
            dataGridViewListaDeReservas.TabIndex = 8;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(493, 139);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(493, 185);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregarHabitacion
            // 
            buttonAgregarHabitacion.Location = new Point(69, 248);
            buttonAgregarHabitacion.Name = "buttonAgregarHabitacion";
            buttonAgregarHabitacion.Size = new Size(137, 23);
            buttonAgregarHabitacion.TabIndex = 11;
            buttonAgregarHabitacion.Text = "Agregar habitacion";
            buttonAgregarHabitacion.UseVisualStyleBackColor = true;
            buttonAgregarHabitacion.Click += buttonAgregarHabitacion_Click;
            // 
            // viewGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 285);
            Controls.Add(buttonAgregarHabitacion);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(dataGridViewListaDeReservas);
            Controls.Add(buttonVerDisponibilidad);
            Controls.Add(label1);
            Controls.Add(button1);
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
        private Button button1;
        private DataGridView dataGridViewListaDeReservas;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonAgregarHabitacion;
    }
}