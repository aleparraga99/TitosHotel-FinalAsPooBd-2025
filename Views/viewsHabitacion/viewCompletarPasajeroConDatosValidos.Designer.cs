namespace Tito_s_Hotel.Views.viewsHabitacion
{
    partial class viewCompletarPasajeroConDatosValidos
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
            buttonVolver = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(115, 71);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 27);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "Se deben ingresar datos validos";
            // 
            // viewCompletarPasajeroConDatosValidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 119);
            Controls.Add(label1);
            Controls.Add(buttonVolver);
            Name = "viewCompletarPasajeroConDatosValidos";
            Text = "viewCompletarPasajeroConDatosValidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label1;
    }
}