namespace Tito_s_Hotel.Views.viewsHabitacion
{
    partial class viewHabitacionNoEncontrada
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
            buttonIngresarOtroNumero = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Habitación no encontrada";
            // 
            // buttonIngresarOtroNumero
            // 
            buttonIngresarOtroNumero.Location = new Point(46, 57);
            buttonIngresarOtroNumero.Name = "buttonIngresarOtroNumero";
            buttonIngresarOtroNumero.Size = new Size(143, 23);
            buttonIngresarOtroNumero.TabIndex = 1;
            buttonIngresarOtroNumero.Text = "Ingresar otro número";
            buttonIngresarOtroNumero.UseVisualStyleBackColor = true;
            buttonIngresarOtroNumero.Click += buttonIngresarOtroNumero_Click;
            // 
            // viewHabitacionNoEncontrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 107);
            Controls.Add(buttonIngresarOtroNumero);
            Controls.Add(label1);
            Name = "viewHabitacionNoEncontrada";
            Text = "viewHabitacionNoEncontrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonIngresarOtroNumero;
    }
}