namespace App
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
            operaciones = new Button();
            resultados = new Label();
            label1 = new Label();
            num1 = new TextBox();
            label2 = new Label();
            num2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            resta = new Label();
            multipli = new Label();
            mostrarmulti = new Label();
            SuspendLayout();
            // 
            // operaciones
            // 
            operaciones.BackColor = Color.Lime;
            operaciones.Cursor = Cursors.Cross;
            operaciones.Font = new Font("Microsoft Sans Serif", 15.75F);
            operaciones.ForeColor = Color.FromArgb(255, 128, 128);
            operaciones.Location = new Point(450, 102);
            operaciones.Margin = new Padding(5, 6, 5, 6);
            operaciones.Name = "operaciones";
            operaciones.Size = new Size(235, 94);
            operaciones.TabIndex = 0;
            operaciones.Text = "Operaciones";
            operaciones.UseVisualStyleBackColor = false;
            operaciones.Click += Sumar_Click;
            // 
            // resultados
            // 
            resultados.AutoSize = true;
            resultados.BorderStyle = BorderStyle.FixedSingle;
            resultados.Font = new Font("Microsoft Sans Serif", 15.75F);
            resultados.ForeColor = Color.FromArgb(255, 128, 128);
            resultados.Location = new Point(464, 256);
            resultados.Margin = new Padding(5, 0, 5, 0);
            resultados.Name = "resultados";
            resultados.Size = new Size(2, 27);
            resultados.TabIndex = 1;
            resultados.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(79, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 25);
            label1.TabIndex = 2;
            label1.Text = "Ingresa el primer numero";
            label1.Click += label1_Click_1;
            // 
            // num1
            // 
            num1.Font = new Font("Microsoft Sans Serif", 15.75F);
            num1.ForeColor = Color.FromArgb(255, 128, 128);
            num1.Location = new Point(35, 93);
            num1.Name = "num1";
            num1.Size = new Size(346, 31);
            num1.TabIndex = 3;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(796, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 4;
            label2.Text = "ingresa el segundo numero";
            // 
            // num2
            // 
            num2.Font = new Font("Microsoft Sans Serif", 15.75F);
            num2.ForeColor = Color.FromArgb(255, 128, 128);
            num2.Location = new Point(769, 93);
            num2.Name = "num2";
            num2.Size = new Size(346, 31);
            num2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(464, 226);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 6;
            label3.Text = "Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(702, 226);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 7;
            label4.Text = "Resta";
            // 
            // resta
            // 
            resta.AutoSize = true;
            resta.BorderStyle = BorderStyle.FixedSingle;
            resta.Font = new Font("Microsoft Sans Serif", 15.75F);
            resta.ForeColor = Color.FromArgb(255, 128, 128);
            resta.Location = new Point(711, 256);
            resta.Margin = new Padding(5, 0, 5, 0);
            resta.Name = "resta";
            resta.Size = new Size(2, 27);
            resta.TabIndex = 8;
            resta.Click += resta_Click;
            // 
            // multipli
            // 
            multipli.AutoSize = true;
            multipli.Font = new Font("Microsoft Sans Serif", 15.75F);
            multipli.ForeColor = Color.FromArgb(255, 128, 128);
            multipli.Location = new Point(450, 329);
            multipli.Margin = new Padding(5, 0, 5, 0);
            multipli.Name = "multipli";
            multipli.Size = new Size(142, 25);
            multipli.TabIndex = 9;
            multipli.Text = "multiplicacion";
            multipli.Click += label5_Click;
            // 
            // mostrarmulti
            // 
            mostrarmulti.AutoSize = true;
            mostrarmulti.BorderStyle = BorderStyle.FixedSingle;
            mostrarmulti.Font = new Font("Microsoft Sans Serif", 15.75F);
            mostrarmulti.ForeColor = Color.FromArgb(255, 128, 128);
            mostrarmulti.Location = new Point(464, 391);
            mostrarmulti.Margin = new Padding(5, 0, 5, 0);
            mostrarmulti.Name = "mostrarmulti";
            mostrarmulti.Size = new Size(2, 27);
            mostrarmulti.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 655);
            Controls.Add(mostrarmulti);
            Controls.Add(multipli);
            Controls.Add(resta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(num2);
            Controls.Add(label2);
            Controls.Add(num1);
            Controls.Add(label1);
            Controls.Add(resultados);
            Controls.Add(operaciones);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button operaciones;
        public Label resultados;
        private Label label1;
        private TextBox num1;
        private Label label2;
        private TextBox num2;
        private Label label3;
        private Label label4;
        public Label resta;
        private Label multipli;
        public Label mostrarmulti;
    }
}
