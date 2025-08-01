namespace Tito_s_Hotel.Views
{
    partial class confirmacionDeReservaGuardadaView
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
            buttonOk = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(75, 63);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 2;
            label1.Text = "La reserva se guardo correctamente";
            // 
            // confirmacionDeReservaGuardadaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 114);
            Controls.Add(buttonOk);
            Controls.Add(label1);
            Name = "confirmacionDeReservaGuardadaView";
            Text = "confirmacionDeReservaGuardadaView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Label label1;
    }
}