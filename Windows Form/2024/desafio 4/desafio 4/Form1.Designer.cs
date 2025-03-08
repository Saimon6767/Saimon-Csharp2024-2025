namespace desafio_4
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
            dgv_productos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ID_Producto = new DataGridViewTextBoxColumn();
            label2 = new Label();
            labelTotal = new Label();
            cbox_productos = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            txt_precioproducto = new TextBox();
            txt_cantidadproducto = new TextBox();
            txt_ID_Poducto = new TextBox();
            label6 = new Label();
            btn_nfacturar = new Button();
            dateTimePicker1 = new DateTimePicker();
            txt_nfactura = new TextBox();
            label7 = new Label();
            btn_guardarfactura = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Tienda la Paja";
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, ID_Producto });
            dgv_productos.Location = new Point(27, 291);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.Size = new Size(563, 211);
            dgv_productos.TabIndex = 1;
            dgv_productos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 200;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // ID_Producto
            // 
            ID_Producto.HeaderText = "ID_Producto";
            ID_Producto.Name = "ID_Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 505);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(412, 505);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(22, 21);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "...";
            // 
            // cbox_productos
            // 
            cbox_productos.FormattingEnabled = true;
            cbox_productos.Items.AddRange(new object[] { "refresco de piña", "botella de agua", "malta morena", "cerveza presidente" });
            cbox_productos.Location = new Point(41, 138);
            cbox_productos.Name = "cbox_productos";
            cbox_productos.Size = new Size(121, 23);
            cbox_productos.TabIndex = 4;
            cbox_productos.SelectedIndexChanged += cbox_productos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 114);
            label3.Name = "label3";
            label3.Size = new Size(188, 21);
            label3.TabIndex = 5;
            label3.Text = "Selecciona el producto";
            // 
            // button1
            // 
            button1.Location = new Point(221, 206);
            button1.Name = "button1";
            button1.Size = new Size(97, 33);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(221, 114);
            label4.Name = "label4";
            label4.Size = new Size(164, 21);
            label4.TabIndex = 7;
            label4.Text = "Precio del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 114);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 8;
            label5.Text = "Cantidad";
            // 
            // txt_precioproducto
            // 
            txt_precioproducto.Location = new Point(242, 138);
            txt_precioproducto.Name = "txt_precioproducto";
            txt_precioproducto.ReadOnly = true;
            txt_precioproducto.Size = new Size(100, 23);
            txt_precioproducto.TabIndex = 9;
            // 
            // txt_cantidadproducto
            // 
            txt_cantidadproducto.Location = new Point(412, 138);
            txt_cantidadproducto.Name = "txt_cantidadproducto";
            txt_cantidadproducto.Size = new Size(67, 23);
            txt_cantidadproducto.TabIndex = 10;
            txt_cantidadproducto.TextChanged += txt_cantidadproducto_TextChanged;
            // 
            // txt_ID_Poducto
            // 
            txt_ID_Poducto.Location = new Point(47, 216);
            txt_ID_Poducto.Name = "txt_ID_Poducto";
            txt_ID_Poducto.ReadOnly = true;
            txt_ID_Poducto.Size = new Size(100, 23);
            txt_ID_Poducto.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(47, 192);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 12;
            label6.Text = "ID_Producto";
            // 
            // btn_nfacturar
            // 
            btn_nfacturar.Location = new Point(427, 543);
            btn_nfacturar.Name = "btn_nfacturar";
            btn_nfacturar.Size = new Size(119, 31);
            btn_nfacturar.TabIndex = 13;
            btn_nfacturar.Text = "nueva factura";
            btn_nfacturar.UseVisualStyleBackColor = true;
            btn_nfacturar.Click += btn_facturar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(427, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // txt_nfactura
            // 
            txt_nfactura.Location = new Point(115, 60);
            txt_nfactura.Name = "txt_nfactura";
            txt_nfactura.Size = new Size(100, 23);
            txt_nfactura.TabIndex = 15;
            txt_nfactura.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 68);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 16;
            label7.Text = "ID_Factura";
            // 
            // btn_guardarfactura
            // 
            btn_guardarfactura.Location = new Point(223, 543);
            btn_guardarfactura.Name = "btn_guardarfactura";
            btn_guardarfactura.Size = new Size(119, 31);
            btn_guardarfactura.TabIndex = 17;
            btn_guardarfactura.Text = "Guardar factura";
            btn_guardarfactura.UseVisualStyleBackColor = true;
            btn_guardarfactura.Click += btn_guardarfactura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 597);
            Controls.Add(btn_guardarfactura);
            Controls.Add(label7);
            Controls.Add(txt_nfactura);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_nfacturar);
            Controls.Add(label6);
            Controls.Add(txt_ID_Poducto);
            Controls.Add(txt_cantidadproducto);
            Controls.Add(txt_precioproducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbox_productos);
            Controls.Add(labelTotal);
            Controls.Add(label2);
            Controls.Add(dgv_productos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_productos;
        private Label label2;
        private Label labelTotal;
        private ComboBox cbox_productos;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox txt_precioproducto;
        private TextBox txt_cantidadproducto;
        private TextBox txt_ID_Poducto;
        private Label label6;
        private DataGridViewTextBoxColumn ID_Producto;
        private Button btn_nfacturar;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nfactura;
        private Label label7;
        private Button btn_guardarfactura;
    }
}
