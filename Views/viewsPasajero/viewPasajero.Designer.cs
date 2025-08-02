namespace Tito_s_Hotel.Views.Pasajero
{
    partial class viewPasajero
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
            label1 = new Label();
            buttonModificarPasajero = new Button();
            buttonEliminarPasajero = new Button();
            buttonNuevoPasajero = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de pasajeros";
            // 
            // buttonModificarPasajero
            // 
            buttonModificarPasajero.Location = new Point(37, 211);
            buttonModificarPasajero.Name = "buttonModificarPasajero";
            buttonModificarPasajero.Size = new Size(75, 23);
            buttonModificarPasajero.TabIndex = 2;
            buttonModificarPasajero.Text = "Modificar";
            buttonModificarPasajero.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarPasajero
            // 
            buttonEliminarPasajero.Location = new Point(312, 211);
            buttonEliminarPasajero.Name = "buttonEliminarPasajero";
            buttonEliminarPasajero.Size = new Size(75, 23);
            buttonEliminarPasajero.TabIndex = 3;
            buttonEliminarPasajero.Text = "Eliminar";
            buttonEliminarPasajero.UseVisualStyleBackColor = true;
            // 
            // buttonNuevoPasajero
            // 
            buttonNuevoPasajero.Location = new Point(134, 258);
            buttonNuevoPasajero.Name = "buttonNuevoPasajero";
            buttonNuevoPasajero.Size = new Size(124, 23);
            buttonNuevoPasajero.TabIndex = 4;
            buttonNuevoPasajero.Text = "Agregar pasajero";
            buttonNuevoPasajero.UseVisualStyleBackColor = true;
            // 
            // viewPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 307);
            Controls.Add(buttonNuevoPasajero);
            Controls.Add(buttonEliminarPasajero);
            Controls.Add(buttonModificarPasajero);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "viewPasajero";
            Text = "viewPasajero";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonModificarPasajero;
        private Button buttonEliminarPasajero;
        private Button buttonNuevoPasajero;
    }
}