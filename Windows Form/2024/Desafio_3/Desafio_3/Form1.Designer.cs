namespace Desafio_3
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
            txt_nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtmpkr_desde = new DateTimePicker();
            label5 = new Label();
            cbox_TipoHabitacion = new ComboBox();
            label6 = new Label();
            txt_precio = new TextBox();
            btn_agregar = new Button();
            btn_limpiar = new Button();
            btn_salir = new Button();
            lbox_reserva = new ListBox();
            txxt_hasta = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Reservas";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(123, 76);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 134);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 3;
            label3.Text = "Desde";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 187);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 4;
            label4.Text = "Hasta";
            // 
            // dtmpkr_desde
            // 
            dtmpkr_desde.Location = new Point(123, 132);
            dtmpkr_desde.Name = "dtmpkr_desde";
            dtmpkr_desde.Size = new Size(225, 23);
            dtmpkr_desde.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 241);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 7;
            label5.Text = "Tipo de habitacion";
            // 
            // cbox_TipoHabitacion
            // 
            cbox_TipoHabitacion.FormattingEnabled = true;
            cbox_TipoHabitacion.Items.AddRange(new object[] { "Grande", "Mediana", "Pequeña" });
            cbox_TipoHabitacion.Location = new Point(207, 239);
            cbox_TipoHabitacion.Name = "cbox_TipoHabitacion";
            cbox_TipoHabitacion.Size = new Size(121, 23);
            cbox_TipoHabitacion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 301);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 9;
            label6.Text = "Precio";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(123, 299);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(100, 23);
            txt_precio.TabIndex = 10;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Location = new Point(73, 442);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(105, 42);
            btn_agregar.TabIndex = 11;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.ActiveCaption;
            btn_limpiar.Location = new Point(266, 442);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(105, 42);
            btn_limpiar.TabIndex = 12;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = SystemColors.ActiveCaption;
            btn_salir.Location = new Point(462, 442);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(105, 42);
            btn_salir.TabIndex = 13;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbox_reserva
            // 
            lbox_reserva.FormattingEnabled = true;
            lbox_reserva.ItemHeight = 15;
            lbox_reserva.Location = new Point(394, 78);
            lbox_reserva.Name = "lbox_reserva";
            lbox_reserva.Size = new Size(395, 274);
            lbox_reserva.TabIndex = 14;
            // 
            // txxt_hasta
            // 
            txxt_hasta.Location = new Point(123, 185);
            txxt_hasta.Name = "txxt_hasta";
            txxt_hasta.Size = new Size(225, 23);
            txxt_hasta.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(627, 442);
            button1.Name = "button1";
            button1.Size = new Size(105, 42);
            button1.TabIndex = 16;
            button1.Text = "eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 641);
            Controls.Add(button1);
            Controls.Add(txxt_hasta);
            Controls.Add(lbox_reserva);
            Controls.Add(btn_salir);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_agregar);
            Controls.Add(txt_precio);
            Controls.Add(label6);
            Controls.Add(cbox_TipoHabitacion);
            Controls.Add(label5);
            Controls.Add(dtmpkr_desde);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nombre;
        public Label label2;
        public Label label3;
        public Label label4;
        private DateTimePicker dtmpkr_desde;
        public Label label5;
        private ComboBox cbox_TipoHabitacion;
        public Label label6;
        private TextBox txt_precio;
        private Button btn_agregar;
        private Button btn_limpiar;
        private Button btn_salir;
        private ListBox lbox_reserva;
        private DateTimePicker txxt_hasta;
        private Button button1;
    }
}
