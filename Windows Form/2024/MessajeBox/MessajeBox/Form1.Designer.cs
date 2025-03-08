namespace MessajeBox
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
            components = new System.ComponentModel.Container();
            btn_mostrarmensaje = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_mostrarmensaje
            // 
            btn_mostrarmensaje.BackColor = SystemColors.AppWorkspace;
            btn_mostrarmensaje.Location = new Point(23, 58);
            btn_mostrarmensaje.Name = "btn_mostrarmensaje";
            btn_mostrarmensaje.Size = new Size(139, 43);
            btn_mostrarmensaje.TabIndex = 0;
            btn_mostrarmensaje.Text = "Check";
            btn_mostrarmensaje.UseVisualStyleBackColor = false;
            btn_mostrarmensaje.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresa un numero mayor a 5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(311, 70);
            button1.Name = "button1";
            button1.Size = new Size(116, 31);
            button1.TabIndex = 3;
            button1.Text = "Elige el texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 23);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 5;
            label2.Text = "si eliges si o no en la messagebox";
            // 
            // button2
            // 
            button2.Location = new Point(582, 58);
            button2.Name = "button2";
            button2.Size = new Size(120, 38);
            button2.TabIndex = 6;
            button2.Text = "leer archivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(504, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 245);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_mostrarmensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mostrarmensaje;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private RichTextBox richTextBox1;
    }
}
