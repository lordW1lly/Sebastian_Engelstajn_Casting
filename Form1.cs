using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_Engelstajn_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnConvertir_Click(object sender, EventArgs e)
        {
            int integer = 10;
            Boolean booleano = true;
            double gravedad = 9.80;
            MessageBox.Show(Convert.ToString(integer)); //Conversion de un integer a un string para poder ser visualizado
            MessageBox.Show(Convert.ToString(booleano));// conversion tmb explicita de boolean --> string
            MessageBox.Show(Convert.ToString(gravedad));// conversion tmb explicita de double --> string
        }
    }
}
