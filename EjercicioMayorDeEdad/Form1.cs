using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMayorDeEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtedad.Text);
            if ( edad >=18) {
                MessageBox.Show("Es usted mayor de edad"); 
            }
            else
            {
                MessageBox.Show("Es usted aún menor de edad");
            }
        }
    }
}
