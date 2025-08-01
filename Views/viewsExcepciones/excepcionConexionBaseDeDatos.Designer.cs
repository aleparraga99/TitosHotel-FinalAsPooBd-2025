namespace Tito_s_Hotel.Views.viewsExcepciones
{
    partial class excepcionConexionBaseDeDatos
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
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 0;
            label1.Text = "Error con la conexion a la base de datos";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(70, 44);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // excepcionConexionBaseDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk);
            Controls.Add(label1);
            Name = "excepcionConexionBaseDeDatos";
            Text = "excepcionConexionBaseDeDatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOk;
    }
}