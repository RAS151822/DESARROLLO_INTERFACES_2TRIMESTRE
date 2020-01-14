using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonRas
{
    public partial class ButtonRas : UserControl
    {
        bool reserva;

        public ButtonRas()
        {
            reserva = false;
            InitializeComponent();
        }

        private void buttonRasnew_Click(object sender, EventArgs e)
        {
            if (reserva == false)
            {
                this.buttonRasnew.ForeColor = Color.Green;
                buttonRasnew.Text = "D";
                reserva = true;

            }
            else {

                this.buttonRasnew.ForeColor = Color.Red;
                buttonRasnew.Text = "O";
                reserva = false;
            }
        }
    }
}
