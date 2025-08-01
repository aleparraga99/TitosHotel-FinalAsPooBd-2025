namespace Tito_s_Hotel.Views
{
    partial class excepcionNoHayHabitaciones
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
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 0;
            label1.Text = "No hay habitaciones cargadas en el sistema. \r\nAgregue alguna habitacion y vuelva a intentar";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(89, 124);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // excepcionNoHayHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 183);
            Controls.Add(buttonOk);
            Controls.Add(label1);
            Name = "excepcionNoHayHabitaciones";
            Text = "excepcionNoHayHabitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOk;
    }
}