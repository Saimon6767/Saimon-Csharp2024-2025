using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V2._1
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           Administracion admin = new Administracion();
           Close();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string correo = txt_correo.Text;
            string nombre = Convert.ToString(txt_nombre.Text);
            string RCN = Convert.ToString(txt_rnc.Text);
            string ciudad = Convert.ToString(cbox_ciudad.SelectedItem);
            string telefono = Convert.ToString(txt_telefono.Text);
            string direcc = Convert.ToString(txt_direccion);


            if (txt_nombre.Text.Length > 0 && txt_correo.Text.Length > 0 && txt_rnc.Text.Length > 0 && txt_telefono.Text.Length > 0 && txt_direccion.Text.Length > 0)
            { 


                if (txt_correo.Text.Contains("@gmail.com"))
                { 




                

                   

                    DialogResult pregunta = MessageBox.Show("¿Deseas guardar estos datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        bool pe = false;
                        if (pregunta == DialogResult.Yes)
                        {
                            dataGridView1.Rows.Add(nombre, RCN, direcc, correo, ciudad);
                            pe = true;
                        }

                        else
                        {

                        }
                        if (pe == true)
                        {
                            DialogResult mensajedehecho = MessageBox.Show("Se ha agregado el registro", "hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    

                    
               
                }
                else
                {
                    DialogResult error = MessageBox.Show("Falto @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios", "advertencia jaja",    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {




            if (dataGridView1.Rows.Count > 0)
            {

                int fila = dataGridView1.Rows.Count - 1;

               dataGridView1.Rows.RemoveAt(fila);
                DialogResult eliminar = MessageBox.Show($"Has eliminado un registro ", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("No hay filas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            txt_correo.Clear();
            txt_nombre.Clear();
            txt_rnc.Clear();
            txt_telefono.Clear();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToAddRows = true;
            MessageBox.Show("Has activado la edicion de el DataGridView", "Opcion activada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

