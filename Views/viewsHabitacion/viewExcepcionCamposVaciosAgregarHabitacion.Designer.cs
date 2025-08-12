namespace Tito_s_Hotel.Views.viewsHabitacion
{
    partial class viewExcepcionCamposVaciosAgregarHabitacion
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
            buttonVolver.Location = new Point(106, 70);
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
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 1;
            label1.Text = "Los campos deben llenarse con datos válidos\r\n";
            // 
            // viewExcepcionCamposVaciosAgregarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 124);
            Controls.Add(label1);
            Controls.Add(buttonVolver);
            Name = "viewExcepcionCamposVaciosAgregarHabitacion";
            Text = "viewExcepcionCamposVaciosAgregarHabitacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label1;
    }
}