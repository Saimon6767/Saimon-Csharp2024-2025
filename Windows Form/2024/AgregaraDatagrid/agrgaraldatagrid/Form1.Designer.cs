namespace Vorm_badelyn
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
            lbl_idcodigo = new Label();
            lbl_alimentos = new Label();
            lbl_comestible = new Label();
            cmbox_idcodigo = new ComboBox();
            cmbox_alimentos = new ComboBox();
            cmbox_comestibles = new ComboBox();
            dtgw_tabla = new DataGridView();
            btn_agregar = new Button();
            eliminar = new Button();
            id_codigo = new DataGridViewTextBoxColumn();
            alimentos = new DataGridViewTextBoxColumn();
            comestibles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgw_tabla).BeginInit();
            SuspendLayout();
            // 
            // lbl_idcodigo
            // 
            lbl_idcodigo.AutoSize = true;
            lbl_idcodigo.Location = new Point(95, 50);
            lbl_idcodigo.Name = "lbl_idcodigo";
            lbl_idcodigo.Size = new Size(62, 15);
            lbl_idcodigo.TabIndex = 0;
            lbl_idcodigo.Text = "ID_Codigo";
            // 
            // lbl_alimentos
            // 
            lbl_alimentos.AutoSize = true;
            lbl_alimentos.Location = new Point(95, 106);
            lbl_alimentos.Name = "lbl_alimentos";
            lbl_alimentos.Size = new Size(61, 15);
            lbl_alimentos.TabIndex = 1;
            lbl_alimentos.Text = "Alimentos";
            // 
            // lbl_comestible
            // 
            lbl_comestible.AutoSize = true;
            lbl_comestible.Location = new Point(84, 157);
            lbl_comestible.Name = "lbl_comestible";
            lbl_comestible.Size = new Size(72, 15);
            lbl_comestible.TabIndex = 2;
            lbl_comestible.Text = "Comestibles";
            // 
            // cmbox_idcodigo
            // 
            cmbox_idcodigo.FormattingEnabled = true;
            cmbox_idcodigo.Location = new Point(175, 47);
            cmbox_idcodigo.Name = "cmbox_idcodigo";
            cmbox_idcodigo.Size = new Size(121, 23);
            cmbox_idcodigo.TabIndex = 3;
            // 
            // cmbox_alimentos
            // 
            cmbox_alimentos.FormattingEnabled = true;
            cmbox_alimentos.Location = new Point(175, 103);
            cmbox_alimentos.Name = "cmbox_alimentos";
            cmbox_alimentos.Size = new Size(121, 23);
            cmbox_alimentos.TabIndex = 4;
            // 
            // cmbox_comestibles
            // 
            cmbox_comestibles.FormattingEnabled = true;
            cmbox_comestibles.Location = new Point(175, 157);
            cmbox_comestibles.Name = "cmbox_comestibles";
            cmbox_comestibles.Size = new Size(121, 23);
            cmbox_comestibles.TabIndex = 5;
            // 
            // dtgw_tabla
            // 
            dtgw_tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_tabla.Columns.AddRange(new DataGridViewColumn[] { id_codigo, alimentos, comestibles });
            dtgw_tabla.Location = new Point(132, 240);
            dtgw_tabla.Name = "dtgw_tabla";
            dtgw_tabla.Size = new Size(507, 198);
            dtgw_tabla.TabIndex = 6;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(517, 50);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 7;
            btn_agregar.Text = "agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(517, 157);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(75, 23);
            eliminar.TabIndex = 8;
            eliminar.Text = "eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // id_codigo
            // 
            id_codigo.HeaderText = "id_codigo";
            id_codigo.Name = "id_codigo";
            id_codigo.Width = 150;
            // 
            // alimentos
            // 
            alimentos.HeaderText = "alimentos";
            alimentos.Name = "alimentos";
            alimentos.Width = 150;
            // 
            // comestibles
            // 
            comestibles.HeaderText = "comestibles";
            comestibles.Name = "comestibles";
            comestibles.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(dtgw_tabla);
            Controls.Add(cmbox_comestibles);
            Controls.Add(cmbox_alimentos);
            Controls.Add(cmbox_idcodigo);
            Controls.Add(lbl_comestible);
            Controls.Add(lbl_alimentos);
            Controls.Add(lbl_idcodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgw_tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_idcodigo;
        private Label lbl_alimentos;
        private Label lbl_comestible;
        private ComboBox cmbox_idcodigo;
        private ComboBox cmbox_alimentos;
        private ComboBox cmbox_comestibles;
        private DataGridView dtgw_tabla;
        private Button btn_agregar;
        private Button eliminar;
        private DataGridViewTextBoxColumn id_codigo;
        private DataGridViewTextBoxColumn alimentos;
        private DataGridViewTextBoxColumn comestibles;
    }
}
