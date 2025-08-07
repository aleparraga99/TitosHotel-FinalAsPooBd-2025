namespace Tito_s_Hotel.Views.viewsPasajero
{
    partial class confirmarEliminacionDePasajero
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
            buttonConfirmar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Desea eliminar al pasajero seleccionado?";
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(33, 60);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(75, 23);
            buttonConfirmar.TabIndex = 1;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(183, 60);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // confirmarEliminacionDePasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 109);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonConfirmar);
            Controls.Add(label1);
            Name = "confirmarEliminacionDePasajero";
            Text = "confirmarEliminacionDePasajero";
            Load += confirmarEliminacionDePasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConfirmar;
        private Button buttonCancelar;
    }
}