namespace Tito_s_Hotel.Views
{
    partial class viewCrearHabitacion
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
            label2 = new Label();
            label3 = new Label();
            textBoxNumero = new TextBox();
            label4 = new Label();
            textBoxPrecioPorNoche = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            groupBoxCamasSingle = new GroupBox();
            radioButtonCamasSingle3 = new RadioButton();
            radioButtonCamasSingle2 = new RadioButton();
            radioButtonCamasSingle1 = new RadioButton();
            radioButtonCamasSingle0 = new RadioButton();
            groupBoxCamaDoble = new GroupBox();
            radioButtonCamaDoble1 = new RadioButton();
            radioButtonCamaDoble0 = new RadioButton();
            groupBoxCamasSingle.SuspendLayout();
            groupBoxCamaDoble.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 29);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Camas Single:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio por noche: $";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(69, 29);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(52, 23);
            textBoxNumero.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 85);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Cama Doble:";
            // 
            // textBoxPrecioPorNoche
            // 
            textBoxPrecioPorNoche.Location = new Point(127, 84);
            textBoxPrecioPorNoche.Name = "textBoxPrecioPorNoche";
            textBoxPrecioPorNoche.Size = new Size(71, 23);
            textBoxPrecioPorNoche.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(92, 170);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(106, 44);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(301, 170);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(106, 44);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // groupBoxCamasSingle
            // 
            groupBoxCamasSingle.Controls.Add(radioButtonCamasSingle3);
            groupBoxCamasSingle.Controls.Add(radioButtonCamasSingle2);
            groupBoxCamasSingle.Controls.Add(radioButtonCamasSingle1);
            groupBoxCamasSingle.Controls.Add(radioButtonCamasSingle0);
            groupBoxCamasSingle.Location = new Point(318, 12);
            groupBoxCamasSingle.Name = "groupBoxCamasSingle";
            groupBoxCamasSingle.Size = new Size(176, 46);
            groupBoxCamasSingle.TabIndex = 14;
            groupBoxCamasSingle.TabStop = false;
            // 
            // radioButtonCamasSingle3
            // 
            radioButtonCamasSingle3.AutoSize = true;
            radioButtonCamasSingle3.Location = new Point(138, 16);
            radioButtonCamasSingle3.Name = "radioButtonCamasSingle3";
            radioButtonCamasSingle3.Size = new Size(31, 19);
            radioButtonCamasSingle3.TabIndex = 15;
            radioButtonCamasSingle3.TabStop = true;
            radioButtonCamasSingle3.Text = "3";
            radioButtonCamasSingle3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamasSingle2
            // 
            radioButtonCamasSingle2.AutoSize = true;
            radioButtonCamasSingle2.Location = new Point(101, 16);
            radioButtonCamasSingle2.Name = "radioButtonCamasSingle2";
            radioButtonCamasSingle2.Size = new Size(31, 19);
            radioButtonCamasSingle2.TabIndex = 14;
            radioButtonCamasSingle2.TabStop = true;
            radioButtonCamasSingle2.Text = "2";
            radioButtonCamasSingle2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamasSingle1
            // 
            radioButtonCamasSingle1.AutoSize = true;
            radioButtonCamasSingle1.Location = new Point(54, 15);
            radioButtonCamasSingle1.Name = "radioButtonCamasSingle1";
            radioButtonCamasSingle1.Size = new Size(31, 19);
            radioButtonCamasSingle1.TabIndex = 13;
            radioButtonCamasSingle1.TabStop = true;
            radioButtonCamasSingle1.Text = "1";
            radioButtonCamasSingle1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamasSingle0
            // 
            radioButtonCamasSingle0.AutoSize = true;
            radioButtonCamasSingle0.Location = new Point(7, 14);
            radioButtonCamasSingle0.Name = "radioButtonCamasSingle0";
            radioButtonCamasSingle0.Size = new Size(31, 19);
            radioButtonCamasSingle0.TabIndex = 12;
            radioButtonCamasSingle0.TabStop = true;
            radioButtonCamasSingle0.Text = "0";
            radioButtonCamasSingle0.UseVisualStyleBackColor = true;
            // 
            // groupBoxCamaDoble
            // 
            groupBoxCamaDoble.Controls.Add(radioButtonCamaDoble1);
            groupBoxCamaDoble.Controls.Add(radioButtonCamaDoble0);
            groupBoxCamaDoble.Location = new Point(312, 64);
            groupBoxCamaDoble.Name = "groupBoxCamaDoble";
            groupBoxCamaDoble.Size = new Size(91, 45);
            groupBoxCamaDoble.TabIndex = 15;
            groupBoxCamaDoble.TabStop = false;
            // 
            // radioButtonCamaDoble1
            // 
            radioButtonCamaDoble1.AutoSize = true;
            radioButtonCamaDoble1.Location = new Point(51, 17);
            radioButtonCamaDoble1.Name = "radioButtonCamaDoble1";
            radioButtonCamaDoble1.Size = new Size(31, 19);
            radioButtonCamaDoble1.TabIndex = 15;
            radioButtonCamaDoble1.TabStop = true;
            radioButtonCamaDoble1.Text = "1";
            radioButtonCamaDoble1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamaDoble0
            // 
            radioButtonCamaDoble0.AutoSize = true;
            radioButtonCamaDoble0.Location = new Point(4, 16);
            radioButtonCamaDoble0.Name = "radioButtonCamaDoble0";
            radioButtonCamaDoble0.Size = new Size(31, 19);
            radioButtonCamaDoble0.TabIndex = 14;
            radioButtonCamaDoble0.TabStop = true;
            radioButtonCamaDoble0.Text = "0";
            radioButtonCamaDoble0.UseVisualStyleBackColor = true;
            // 
            // ViewHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 241);
            Controls.Add(groupBoxCamaDoble);
            Controls.Add(groupBoxCamasSingle);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxPrecioPorNoche);
            Controls.Add(label4);
            Controls.Add(textBoxNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewHabitacion";
            Text = "ViewHabitacion";
            groupBoxCamasSingle.ResumeLayout(false);
            groupBoxCamasSingle.PerformLayout();
            groupBoxCamaDoble.ResumeLayout(false);
            groupBoxCamaDoble.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNumero;
        private Label label4;
        private TextBox textBoxPrecioPorNoche;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private GroupBox groupBoxCamasSingle;
        private RadioButton radioButtonCamasSingle3;
        private RadioButton radioButtonCamasSingle2;
        private RadioButton radioButtonCamasSingle1;
        private RadioButton radioButtonCamasSingle0;
        private GroupBox groupBoxCamaDoble;
        private RadioButton radioButtonCamaDoble1;
        private RadioButton radioButtonCamaDoble0;
    }
}