namespace Tito_s_Hotel.Views.viewsReserva
{
    partial class viewCrearReserva
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonGuardarReserva = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(132, 139);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 110);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Check In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 135);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Check Out:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 192);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Adelanto: $";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 64);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI del pasajero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 30);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Habitacion:";
            // 
            // buttonGuardarReserva
            // 
            buttonGuardarReserva.Location = new Point(110, 237);
            buttonGuardarReserva.Name = "buttonGuardarReserva";
            buttonGuardarReserva.Size = new Size(122, 23);
            buttonGuardarReserva.TabIndex = 10;
            buttonGuardarReserva.Text = "Guardar reserva";
            buttonGuardarReserva.UseVisualStyleBackColor = true;
            buttonGuardarReserva.Click += buttonGuardarReserva_Click;
            // 
            // viewCrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 281);
            Controls.Add(buttonGuardarReserva);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "viewCrearReserva";
            Text = "viewCrearReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button buttonGuardarReserva;
    }
}