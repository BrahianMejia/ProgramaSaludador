using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_saludador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text;
            MessageBox.Show("Hola " + nombre);
        }
    }
}
