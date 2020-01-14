using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuContextual
{
    public partial class Form1 : Form
    {
        int contadormayor = 0;
        int contadormenor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int ancho = MyButton.Width*2;
            int alto = MyButton.Height*2;

            if (contadormayor <= 2)
            {
                MyButton.Size = new Size(ancho, alto);

                
            }
            contadormayor ++;

            if (contadormayor == 2)
            {
                grandeToolStripMenuItem.Enabled = false;
                pequeñoToolStripMenuItem.Enabled = true;
                contadormayor = 0;
                
            }

            Console.WriteLine(contadormayor);

        }

        private void pequeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int ancho = MyButton.Width / 2;
            int alto = MyButton.Height / 2;

            if (contadormenor <= 2)
            {
                MyButton.Size = new Size(ancho, alto);

               
            }

            contadormenor++;

            if (contadormenor == 2)
            {
                pequeñoToolStripMenuItem.Enabled = false;
                grandeToolStripMenuItem.Enabled = true;
                contadormenor = 0;           
            }

          
            Console.WriteLine("Esto vale contador" + contadormenor);

            
        }

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.WhiteSmoke;
           
        }
        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.WhiteSmoke;
        }



        private void fondoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Black;
        }
        private void letraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Black;
        }



        private void fondoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Red;
        }
        private void letraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Red;
        }



        private void fondoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Blue;
        }
        private void letraToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Blue;
        }



        private void fondoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Green;
        }
        private void letraToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Green;
        }

        private void fondoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Purple;
        }

        private void letraToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Purple;
        }

        private void letraToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.Yellow;
        }

        private void letraToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MyButton.ForeColor = Color.Yellow;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
