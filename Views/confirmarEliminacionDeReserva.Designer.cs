namespace Tito_s_Hotel
{
    partial class confirmarEliminacionDeReserva
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
            buttonConfirmarEliminarDeReserva = new Button();
            buttonCancelarEliminacionDeReserva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 42);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Desea eliminar esta reserva?";
            // 
            // buttonConfirmarEliminarDeReserva
            // 
            buttonConfirmarEliminarDeReserva.Location = new Point(22, 84);
            buttonConfirmarEliminarDeReserva.Name = "buttonConfirmarEliminarDeReserva";
            buttonConfirmarEliminarDeReserva.Size = new Size(75, 23);
            buttonConfirmarEliminarDeReserva.TabIndex = 1;
            buttonConfirmarEliminarDeReserva.Text = "Si";
            buttonConfirmarEliminarDeReserva.UseVisualStyleBackColor = true;
            buttonConfirmarEliminarDeReserva.Click += buttonConfirmarEliminarDeReserva_Click;
            // 
            // buttonCancelarEliminacionDeReserva
            // 
            buttonCancelarEliminacionDeReserva.Location = new Point(183, 84);
            buttonCancelarEliminacionDeReserva.Name = "buttonCancelarEliminacionDeReserva";
            buttonCancelarEliminacionDeReserva.Size = new Size(75, 23);
            buttonCancelarEliminacionDeReserva.TabIndex = 2;
            buttonCancelarEliminacionDeReserva.Text = "Cancelar";
            buttonCancelarEliminacionDeReserva.UseVisualStyleBackColor = true;
            buttonCancelarEliminacionDeReserva.Click += buttonCancelarEliminacionDeReserva_Click;
            // 
            // confirmarEliminacionDeReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 140);
            Controls.Add(buttonCancelarEliminacionDeReserva);
            Controls.Add(buttonConfirmarEliminarDeReserva);
            Controls.Add(label1);
            Name = "confirmarEliminacionDeReserva";
            Text = "confirmarEliminacionDeReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConfirmarEliminarDeReserva;
        private Button buttonCancelarEliminacionDeReserva;
    }
}