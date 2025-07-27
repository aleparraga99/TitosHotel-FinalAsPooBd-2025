namespace Tito_s_Hotel
{
    partial class confirmacionDePasajeroGuardadoView
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
            label1.Location = new Point(51, 23);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 3;
            label1.Text = "El pasajero se guardó correctamente";
            // 
            // button1
            // 
            button1.Location = new Point(127, 62);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // confirmacionDePasajeroGuardadoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 119);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "confirmacionDePasajeroGuardadoView";
            Text = "confirmacionDePasajeroGuardadoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}