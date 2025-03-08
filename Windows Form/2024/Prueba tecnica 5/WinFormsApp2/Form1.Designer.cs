namespace WinFormsApp2
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
            btn_abrirarchivo = new Button();
            rtb_texto = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            txt_hijos = new TextBox();
            btn_calcular = new Button();
            txt_total = new TextBox();
            txt_sueldo = new TextBox();
            txt_nombre = new TextBox();
            cbox_cargo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            txt_tota = new TextBox();
            txt_isr = new TextBox();
            txt_sfs = new TextBox();
            txt_afp = new TextBox();
            txt_sueldoneto = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dgv_elementos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Hijos = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_elementos).BeginInit();
            SuspendLayout();
            // 
            // btn_abrirarchivo
            // 
            btn_abrirarchivo.Location = new Point(706, 312);
            btn_abrirarchivo.Name = "btn_abrirarchivo";
            btn_abrirarchivo.Size = new Size(92, 31);
            btn_abrirarchivo.TabIndex = 0;
            btn_abrirarchivo.Text = "Mostrar";
            btn_abrirarchivo.UseVisualStyleBackColor = true;
            btn_abrirarchivo.Click += btn_abrirarchivo_Click;
            // 
            // rtb_texto
            // 
            rtb_texto.BackColor = SystemColors.InactiveCaption;
            rtb_texto.Location = new Point(340, 345);
            rtb_texto.Name = "rtb_texto";
            rtb_texto.Size = new Size(448, 289);
            rtb_texto.TabIndex = 1;
            rtb_texto.Text = "";
            rtb_texto.TextChanged += rtb_texto_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(301, 435);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(txt_hijos);
            tabPage1.Controls.Add(btn_calcular);
            tabPage1.Controls.Add(txt_total);
            tabPage1.Controls.Add(txt_sueldo);
            tabPage1.Controls.Add(txt_nombre);
            tabPage1.Controls.Add(cbox_cargo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(293, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(20, 378);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_hijos
            // 
            txt_hijos.Location = new Point(121, 207);
            txt_hijos.Name = "txt_hijos";
            txt_hijos.Size = new Size(100, 23);
            txt_hijos.TabIndex = 12;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(167, 370);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(120, 31);
            btn_calcular.TabIndex = 11;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(121, 301);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(100, 23);
            txt_total.TabIndex = 9;
            txt_total.TextChanged += txt_total_TextChanged;
            // 
            // txt_sueldo
            // 
            txt_sueldo.Location = new Point(121, 146);
            txt_sueldo.Name = "txt_sueldo";
            txt_sueldo.Size = new Size(100, 23);
            txt_sueldo.TabIndex = 7;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(121, 29);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 6;
            // 
            // cbox_cargo
            // 
            cbox_cargo.FormattingEnabled = true;
            cbox_cargo.Items.AddRange(new object[] { "Gerente", "Limpieza", "Caja", "Administracion" });
            cbox_cargo.Location = new Point(121, 86);
            cbox_cargo.Name = "cbox_cargo";
            cbox_cargo.Size = new Size(121, 23);
            cbox_cargo.TabIndex = 5;
            cbox_cargo.SelectedIndexChanged += cbox_cargo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 14.25F);
            label5.Location = new Point(20, 301);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 14.25F);
            label4.Location = new Point(20, 202);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Hijos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.25F);
            label3.Location = new Point(20, 146);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Sueldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 14.25F);
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F);
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txt_tota);
            tabPage2.Controls.Add(txt_isr);
            tabPage2.Controls.Add(txt_sfs);
            tabPage2.Controls.Add(txt_afp);
            tabPage2.Controls.Add(txt_sueldoneto);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(293, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(47, 344);
            button1.Name = "button1";
            button1.Size = new Size(132, 50);
            button1.TabIndex = 14;
            button1.Text = "guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txt_tota
            // 
            txt_tota.Location = new Point(152, 172);
            txt_tota.Name = "txt_tota";
            txt_tota.Size = new Size(100, 23);
            txt_tota.TabIndex = 8;
            txt_tota.TextChanged += txt_tota_TextChanged;
            // 
            // txt_isr
            // 
            txt_isr.Location = new Point(88, 116);
            txt_isr.Name = "txt_isr";
            txt_isr.Size = new Size(100, 23);
            txt_isr.TabIndex = 7;
            txt_isr.TextChanged += textBox6_TextChanged;
            // 
            // txt_sfs
            // 
            txt_sfs.Location = new Point(88, 80);
            txt_sfs.Name = "txt_sfs";
            txt_sfs.Size = new Size(100, 23);
            txt_sfs.TabIndex = 6;
            // 
            // txt_afp
            // 
            txt_afp.Location = new Point(88, 34);
            txt_afp.Name = "txt_afp";
            txt_afp.Size = new Size(100, 23);
            txt_afp.TabIndex = 5;
            // 
            // txt_sueldoneto
            // 
            txt_sueldoneto.Location = new Point(136, 251);
            txt_sueldoneto.Name = "txt_sueldoneto";
            txt_sueldoneto.Size = new Size(100, 23);
            txt_sueldoneto.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 14.25F);
            label10.Location = new Point(6, 245);
            label10.Name = "label10";
            label10.Size = new Size(111, 26);
            label10.TabIndex = 4;
            label10.Text = "sueldo neto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 14.25F);
            label9.Location = new Point(3, 166);
            label9.Name = "label9";
            label9.Size = new Size(143, 26);
            label9.TabIndex = 3;
            label9.Text = "total deduccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 14.25F);
            label8.Location = new Point(47, 116);
            label8.Name = "label8";
            label8.Size = new Size(32, 26);
            label8.TabIndex = 2;
            label8.Text = "isr";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 14.25F);
            label7.Location = new Point(47, 80);
            label7.Name = "label7";
            label7.Size = new Size(34, 26);
            label7.TabIndex = 1;
            label7.Text = "sfs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 14.25F);
            label6.Location = new Point(47, 37);
            label6.Name = "label6";
            label6.Size = new Size(41, 26);
            label6.TabIndex = 0;
            label6.Text = "Afp";
            // 
            // dgv_elementos
            // 
            dgv_elementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_elementos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Hijos, Sueldo });
            dgv_elementos.Location = new Point(315, 36);
            dgv_elementos.Name = "dgv_elementos";
            dgv_elementos.Size = new Size(483, 274);
            dgv_elementos.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Hijos
            // 
            Hijos.HeaderText = "Hijos";
            Hijos.Name = "Hijos";
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            // 
            // button3
            // 
            button3.Location = new Point(328, 312);
            button3.Name = "button3";
            button3.Size = new Size(96, 27);
            button3.TabIndex = 10;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(button3);
            Controls.Add(dgv_elementos);
            Controls.Add(tabControl1);
            Controls.Add(rtb_texto);
            Controls.Add(btn_abrirarchivo);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_elementos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_abrirarchivo;
        private RichTextBox rtb_texto;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txt_total;
        private TextBox txt_sueldo;
        private TextBox txt_nombre;
        private ComboBox cbox_cargo;
        private Label label5;
        private Label label4;
        private Button btn_calcular;
        private TextBox txt_hijos;
        private TextBox txt_tota;
        private TextBox txt_isr;
        private TextBox txt_sfs;
        private TextBox txt_afp;
        private TextBox txt_sueldoneto;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private DataGridView dgv_elementos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Hijos;
        private DataGridViewTextBoxColumn Sueldo;
        private Button button2;
        private Button button3;
    }
}
