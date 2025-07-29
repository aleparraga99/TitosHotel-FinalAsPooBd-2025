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
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
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
            // textBox1
            // 
            textBox1.Location = new Point(116, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 2;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(116, 108);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(276, 323);
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
            buttonVolver.Location = new Point(25, 323);
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
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonBuscar;
        private DataGridView dataGridViewListaDeHabitacionesDisponibles;
        private Button buttonVolver;
    }
}