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
    public partial class frmConvMetrosaPies : Form
    {
        public frmConvMetrosaPies()
        {
            InitializeComponent();
        }

        private void frmConvMetrosaPies_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtMetros.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los metros") ;
                this.txtMetros.Focus();
                return;
            }
            try
            {
                double metros = Double.Parse(this.txtMetros.Text);
                this.txtMetrosenPulgadas.Text = fnMetrosaPulgadas(metros).ToString();

                this.txtMetrosenPies.Text = fnMestrosaPies(metros).ToString("0.000");
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }


        }

        private double fnMetrosaPulgadas(double metros)
        {
            return (metros*39.37);
        }
        private double fnMestrosaPies(double metros)
        {
            return (metros * 3.28084);
        }
    }
}
