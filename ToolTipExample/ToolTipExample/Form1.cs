using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTipExample
{
    public partial class Form1 : Form
    {
        ToolTip toolTip1;

        public Form1()
        {
            InitializeComponent();

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 500;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.IsBalloon = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button1, "Botooon 1!");
            toolTip1.SetToolTip(this.checkBox1, "Eres un robot??");
            toolTip1.SetToolTip(this.textBox1, "Introduzca su nombre");
            toolTip1.SetToolTip(this.textBox2, "Introduzca su apellido");
            toolTip1.SetToolTip(this.textBox3, "Introduzca su Dni");
            toolTip1.SetToolTip(this.label1, "Name");
            toolTip1.SetToolTip(this.label2, "SurName");
            toolTip1.SetToolTip(this.label3, "Identification");

            // Modificamos el icono del toopTip
            toolTip1.ToolTipIcon=ToolTipIcon.Info;

            //Cambiamos el color del toolTip NO FUMCIONA
            toolTip1.OwnerDraw = false;
            toolTip1.BackColor = System.Drawing.Color.Red;

        }


        

    }
}
