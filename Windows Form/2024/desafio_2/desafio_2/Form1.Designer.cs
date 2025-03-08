namespace desafio_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            RA1 = new TextBox();
            RA2 = new TextBox();
            RA4 = new TextBox();
            RA3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_total = new TextBox();
            label12 = new Label();
            txt_estado = new TextBox();
            Ejecutar = new Button();
            borrartodo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 18);
            label1.TabIndex = 0;
            label1.Text = "Registros de calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 138);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 182);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Seccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 222);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Area";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Location = new Point(126, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "4to", "5to", "6to" });
            comboBox1.Location = new Point(126, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.InactiveCaption;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox2.Location = new Point(126, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.InactiveCaption;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "informatica", "electricidad", "gastronomia", "enfermeria", "contabilidad" });
            comboBox3.Location = new Point(126, 222);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 23);
            comboBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 289);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 9;
            label6.Text = "Sexo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(121, 287);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hombre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(217, 287);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mujer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 349);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "RA1";
            // 
            // RA1
            // 
            RA1.BackColor = SystemColors.InactiveCaption;
            RA1.Location = new Point(109, 341);
            RA1.Name = "RA1";
            RA1.Size = new Size(68, 23);
            RA1.TabIndex = 13;
            // 
            // RA2
            // 
            RA2.BackColor = SystemColors.InactiveCaption;
            RA2.Location = new Point(109, 370);
            RA2.Name = "RA2";
            RA2.Size = new Size(68, 23);
            RA2.TabIndex = 14;
            // 
            // RA4
            // 
            RA4.BackColor = SystemColors.InactiveCaption;
            RA4.Location = new Point(109, 428);
            RA4.Name = "RA4";
            RA4.Size = new Size(68, 23);
            RA4.TabIndex = 16;
            // 
            // RA3
            // 
            RA3.BackColor = SystemColors.InactiveCaption;
            RA3.Location = new Point(109, 399);
            RA3.Name = "RA3";
            RA3.Size = new Size(68, 23);
            RA3.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 378);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 18;
            label8.Text = "RA2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 407);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 19;
            label9.Text = "RA3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 436);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 20;
            label10.Text = "RA4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(227, 349);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 21;
            label11.Text = "Total";
            // 
            // txt_total
            // 
            txt_total.BackColor = SystemColors.InactiveCaption;
            txt_total.Location = new Point(265, 341);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(68, 23);
            txt_total.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(217, 436);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 23;
            label12.Text = "Estado";
            // 
            // txt_estado
            // 
            txt_estado.BackColor = SystemColors.InactiveCaption;
            txt_estado.Location = new Point(265, 428);
            txt_estado.Name = "txt_estado";
            txt_estado.ReadOnly = true;
            txt_estado.Size = new Size(147, 23);
            txt_estado.TabIndex = 24;
            // 
            // Ejecutar
            // 
            Ejecutar.BackColor = Color.FromArgb(128, 255, 128);
            Ejecutar.Location = new Point(69, 520);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(121, 38);
            Ejecutar.TabIndex = 25;
            Ejecutar.Text = "Calcular";
            Ejecutar.UseVisualStyleBackColor = false;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // borrartodo
            // 
            borrartodo.BackColor = Color.IndianRed;
            borrartodo.Location = new Point(227, 520);
            borrartodo.Name = "borrartodo";
            borrartodo.Size = new Size(105, 38);
            borrartodo.TabIndex = 26;
            borrartodo.Text = "Borrar";
            borrartodo.UseVisualStyleBackColor = false;
            borrartodo.Click += borrartodo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 671);
            Controls.Add(borrartodo);
            Controls.Add(Ejecutar);
            Controls.Add(txt_estado);
            Controls.Add(label12);
            Controls.Add(txt_total);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(RA3);
            Controls.Add(RA4);
            Controls.Add(RA2);
            Controls.Add(RA1);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private TextBox RA1;
        private TextBox RA2;
        private TextBox RA4;
        private TextBox RA3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_total;
        private Label label12;
        private TextBox txt_estado;
        private Button Ejecutar;
        private Button borrartodo;
    }
}
