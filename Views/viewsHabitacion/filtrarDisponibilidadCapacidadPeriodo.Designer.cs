namespace Tito_s_Hotel
{
    partial class filtrarDisponibilidadCapacidadPeriodo
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
            label1 = new Label();
            label2 = new Label();
            textBoxCapacidad = new TextBox();
            label3 = new Label();
            dateTimePickerIn = new DateTimePicker();
            dateTimePickerOut = new DateTimePicker();
            buttonBuscar = new Button();
            dataGridViewListaDeHabitacionesDisponibles = new DataGridView();
            buttonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeHabitacionesDisponibles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 67);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Check In:";
            // 
            // textBoxCapacidad
            // 
            textBoxCapacidad.Location = new Point(116, 25);
            textBoxCapacidad.Name = "textBoxCapacidad";
            textBoxCapacidad.Size = new Size(37, 23);
            textBoxCapacidad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Check Out:";
            // 
            // dateTimePickerIn
            // 
            dateTimePickerIn.Location = new Point(106, 61);
            dateTimePickerIn.Name = "dateTimePickerIn";
            dateTimePickerIn.Size = new Size(210, 23);
            dateTimePickerIn.TabIndex = 4;
            // 
            // dateTimePickerOut
            // 
            dateTimePickerOut.Location = new Point(116, 108);
            dateTimePickerOut.Name = "dateTimePickerOut";
            dateTimePickerOut.Size = new Size(212, 23);
            dateTimePickerOut.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(55, 323);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewListaDeHabitacionesDisponibles
            // 
            dataGridViewListaDeHabitacionesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDeHabitacionesDisponibles.Location = new Point(23, 151);
            dataGridViewListaDeHabitacionesDisponibles.Name = "dataGridViewListaDeHabitacionesDisponibles";
            dataGridViewListaDeHabitacionesDisponibles.Size = new Size(338, 150);
            dataGridViewListaDeHabitacionesDisponibles.TabIndex = 7;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(253, 323);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 8;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // filtrarDisponibilidadCapacidadPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 364);
            Controls.Add(buttonVolver);
            Controls.Add(dataGridViewListaDeHabitacionesDisponibles);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerOut);
            Controls.Add(dateTimePickerIn);
            Controls.Add(label3);
            Controls.Add(textBoxCapacidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "filtrarDisponibilidadCapacidadPeriodo";
            Text = "filtrarDisponibilidadCapacidadPeriodo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeHabitacionesDisponibles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCapacidad;
        private Label label3;
        private DateTimePicker dateTimePickerIn;
        private DateTimePicker dateTimePickerOut;
        private Button buttonBuscar;
        private DataGridView dataGridViewListaDeHabitacionesDisponibles;
        private Button buttonVolver;
    }
}