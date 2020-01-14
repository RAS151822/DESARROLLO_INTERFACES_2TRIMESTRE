using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtrosMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ImagenSeleccionada = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                    ImagenSeleccionada = dialog.FileName;
                    pictureBox1.ImageLocation = ImagenSeleccionada;
                    Estado.Text = "Imagen Seleccionada !";
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Oh NO algo malo ha ocurrido!! ");
            }
           
        }

        private void Estado_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado.Text = "Editar ";
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado.Text = "Herramientas";
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado.Text = "Ayuda";
            Help.ShowHelp(this, "C:/Users/Ras/Documents/HelpNDoc/Output/Crear documentación chm/Titulo de este proyecto de ayuda.chm", "C:/Users/Ras/Documents/HelpNDoc/Output/Crear documentación html/Titulo de este proyecto de ayuda.html");

        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/Ras/Documents/HelpNDoc/Output/Crear documentación chm/Titulo de este proyecto de ayuda.chm", "C:/Users/Ras/Documents/HelpNDoc/Output/Crear documentación html/Titulo de este proyecto de ayuda.html");
        }
    }

       
    }
