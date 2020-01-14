using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFORME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'worldDataSet1.countrylanguage' Puede moverla o quitarla según sea necesario.
            this.countrylanguageTableAdapter.Fill(this.worldDataSet1.countrylanguage);
            // TODO: esta línea de código carga datos en la tabla 'worldDataSet.city' Puede moverla o quitarla según sea necesario.
            this.cityTableAdapter.Fill(this.worldDataSet.city);

            this.reportViewer1.RefreshReport();
        }
    }
}
