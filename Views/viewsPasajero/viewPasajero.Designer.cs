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
            dataGridViewListaDePasajeros = new DataGridView();
            label1 = new Label();
            buttonModificarPasajero = new Button();
            buttonEliminarPasajero = new Button();
            buttonAgregarPasajero = new Button();
            buttonBuscarPasajeroPorDni = new Button();
            label2 = new Label();
            textBoxDNIPasajero = new TextBox();
            buttonVolver = new Button();
            buttonRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDePasajeros).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaDePasajeros
            // 
            dataGridViewListaDePasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDePasajeros.Location = new Point(25, 50);
            dataGridViewListaDePasajeros.Name = "dataGridViewListaDePasajeros";
            dataGridViewListaDePasajeros.Size = new Size(630, 177);
            dataGridViewListaDePasajeros.TabIndex = 0;
            dataGridViewListaDePasajeros.CellContentClick += dataGridViewListaDePasajeros_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de pasajeros";
            // 
            // buttonModificarPasajero
            // 
            buttonModificarPasajero.Location = new Point(136, 251);
            buttonModificarPasajero.Name = "buttonModificarPasajero";
            buttonModificarPasajero.Size = new Size(102, 39);
            buttonModificarPasajero.TabIndex = 2;
            buttonModificarPasajero.Text = "Modificar";
            buttonModificarPasajero.UseVisualStyleBackColor = true;
            buttonModificarPasajero.Click += buttonModificarPasajero_Click;
            // 
            // buttonEliminarPasajero
            // 
            buttonEliminarPasajero.Location = new Point(474, 251);
            buttonEliminarPasajero.Name = "buttonEliminarPasajero";
            buttonEliminarPasajero.Size = new Size(90, 39);
            buttonEliminarPasajero.TabIndex = 3;
            buttonEliminarPasajero.Text = "Eliminar";
            buttonEliminarPasajero.UseVisualStyleBackColor = true;
            buttonEliminarPasajero.Click += buttonEliminarPasajero_Click;
            // 
            // buttonAgregarPasajero
            // 
            buttonAgregarPasajero.Location = new Point(708, 162);
            buttonAgregarPasajero.Name = "buttonAgregarPasajero";
            buttonAgregarPasajero.Size = new Size(143, 43);
            buttonAgregarPasajero.TabIndex = 4;
            buttonAgregarPasajero.Text = "Agregar pasajero";
            buttonAgregarPasajero.UseVisualStyleBackColor = true;
            buttonAgregarPasajero.Click += buttonAgregarPasajero_Click;
            // 
            // buttonBuscarPasajeroPorDni
            // 
            buttonBuscarPasajeroPorDni.Location = new Point(739, 114);
            buttonBuscarPasajeroPorDni.Name = "buttonBuscarPasajeroPorDni";
            buttonBuscarPasajeroPorDni.Size = new Size(75, 23);
            buttonBuscarPasajeroPorDni.TabIndex = 5;
            buttonBuscarPasajeroPorDni.Text = "Buscar";
            buttonBuscarPasajeroPorDni.UseVisualStyleBackColor = true;
            buttonBuscarPasajeroPorDni.Click += buttonBuscarPasajeroPorDni_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(725, 50);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Buscar por DNI:";
            // 
            // textBoxDNIPasajero
            // 
            textBoxDNIPasajero.Location = new Point(708, 85);
            textBoxDNIPasajero.Name = "textBoxDNIPasajero";
            textBoxDNIPasajero.Size = new Size(125, 23);
            textBoxDNIPasajero.TabIndex = 7;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(763, 251);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(104, 49);
            buttonVolver.TabIndex = 8;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefrescar.Location = new Point(613, 240);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(42, 46);
            buttonRefrescar.TabIndex = 18;
            buttonRefrescar.Text = "🔄";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // viewPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 312);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonVolver);
            Controls.Add(textBoxDNIPasajero);
            Controls.Add(label2);
            Controls.Add(buttonBuscarPasajeroPorDni);
            Controls.Add(buttonAgregarPasajero);
            Controls.Add(buttonEliminarPasajero);
            Controls.Add(buttonModificarPasajero);
            Controls.Add(label1);
            Controls.Add(dataGridViewListaDePasajeros);
            Name = "viewPasajero";
            Text = "viewPasajero";
            Load += viewPasajero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDePasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaDePasajeros;
        private Label label1;
        private Button buttonModificarPasajero;
        private Button buttonEliminarPasajero;
        private Button buttonAgregarPasajero;
        private Button buttonBuscarPasajeroPorDni;
        private Label label2;
        private TextBox textBoxDNIPasajero;
        private Button buttonVolver;
        private Button buttonRefrescar;
    }
}