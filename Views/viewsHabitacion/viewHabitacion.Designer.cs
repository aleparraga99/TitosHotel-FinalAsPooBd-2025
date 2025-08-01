namespace Tito_s_Hotel.Views
{
    partial class viewHabitacion
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
            dataGridView1 = new DataGridView();
            buttonModificarHabitacion = new Button();
            buttonEliminarHabitacion = new Button();
            label1 = new Label();
            buttonVolver = new Button();
            buttonAgregarHabitacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 192);
            dataGridView1.TabIndex = 0;
       
            // 
            // buttonModificarHabitacion
            // 
            buttonModificarHabitacion.Location = new Point(381, 84);
            buttonModificarHabitacion.Name = "buttonModificarHabitacion";
            buttonModificarHabitacion.Size = new Size(75, 23);
            buttonModificarHabitacion.TabIndex = 1;
            buttonModificarHabitacion.Text = "Modificar";
            buttonModificarHabitacion.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarHabitacion
            // 
            buttonEliminarHabitacion.Location = new Point(381, 139);
            buttonEliminarHabitacion.Name = "buttonEliminarHabitacion";
            buttonEliminarHabitacion.Size = new Size(75, 23);
            buttonEliminarHabitacion.TabIndex = 2;
            buttonEliminarHabitacion.Text = "Eliminar";
            buttonEliminarHabitacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de habitaciones";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(381, 259);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(91, 33);
            buttonVolver.TabIndex = 4;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonAgregarHabitacion
            // 
            buttonAgregarHabitacion.Location = new Point(42, 264);
            buttonAgregarHabitacion.Name = "buttonAgregarHabitacion";
            buttonAgregarHabitacion.Size = new Size(137, 23);
            buttonAgregarHabitacion.TabIndex = 12;
            buttonAgregarHabitacion.Text = "Agregar habitacion";
            buttonAgregarHabitacion.UseVisualStyleBackColor = true;
            buttonAgregarHabitacion.Click += buttonAgregarHabitacion_Click;
            // 
            // viewHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 304);
            Controls.Add(buttonAgregarHabitacion);
            Controls.Add(buttonVolver);
            Controls.Add(label1);
            Controls.Add(buttonEliminarHabitacion);
            Controls.Add(buttonModificarHabitacion);
            Controls.Add(dataGridView1);
            Name = "viewHabitacion";
            Text = "viewHabitacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonModificarHabitacion;
        private Button buttonEliminarHabitacion;
        private Label label1;
        private Button buttonVolver;
        private Button buttonAgregarHabitacion;
    }
}