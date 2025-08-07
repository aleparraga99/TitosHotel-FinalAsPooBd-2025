namespace Tito_s_Hotel.Views.viewsPasajero
{
    partial class viewPasajeroNoEncontrado
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 0;
            label1.Text = "No se encontró un pasajero con el DNI ingresado";
            // 
            // button1
            // 
            button1.Location = new Point(82, 60);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 1;
            button1.Text = "Ingresar nuevo DNI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewPasajeroNoEncontrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 110);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "viewPasajeroNoEncontrado";
            Text = "pasajeroNoEncontrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}