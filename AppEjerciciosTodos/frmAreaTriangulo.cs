using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosTodos
{
    public partial class frmAreaTriangulo : Form
    {
        public frmAreaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtA.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de A");
                this.txtA.Focus();
                return;
            }
            if (this.txtB.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de B");
                this.txtB.Focus();
                return;
            }
            if (this.txtC.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de C");
                this.txtC.Focus();
                return;
            }

            //double a = Double.Parse( this.txtA.Text);
            double a,b,c,result;
            if (Double.TryParse(this.txtA.Text, out result))
                a = result;
            else 
            { 
                MessageBox.Show("Debe ingresar valores numéricos");
                this.txtA.Focus();
                return;
            }

            
            if (Double.TryParse(this.txtB.Text, out result))
                b = result;
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos");
                this.txtB.Focus();
                return;
            }

            if (Double.TryParse(this.txtC.Text, out result))
                c = result;
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos");
                this.txtC.Focus();
                return;
            }

            this.txtAreaTriangulo.Text = fnAreaTriangulo(a, b, c).ToString("0.00001");

        }

        private double fnAreaTriangulo(double a, double b, double c)
        {
            double area,sp;
            sp = (a + b + c) / 2;

            area = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            return area;
        }        
    }
}
