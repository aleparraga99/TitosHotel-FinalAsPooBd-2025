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
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeReservas).BeginInit();
            SuspendLayout();
            // 
            // buttonVerDisponibilidad
            // 
            buttonVerDisponibilidad.Location = new Point(375, 207);
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
            label1.Location = new Point(253, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Tito´s Hotel";
            // 
            // button1
            // 
            button1.Location = new Point(78, 207);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 5;
            button1.Text = "Nueva reserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaDeReservas
            // 
            dataGridViewListaDeReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDeReservas.Location = new Point(78, 53);
            dataGridViewListaDeReservas.Name = "dataGridViewListaDeReservas";
            dataGridViewListaDeReservas.Size = new Size(432, 132);
            dataGridViewListaDeReservas.TabIndex = 8;
            // 
            // viewGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 285);
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
    }
}