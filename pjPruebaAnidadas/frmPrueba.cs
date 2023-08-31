using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPruebaAnidadas
{
    public partial class frmPrueba : Form
    {
        Employee objE = new();
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objE.Id=int.Parse(txtid.Text);

            }
            catch (validationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                objE.Firstname =txtnombre.Text;

            }
            catch (validationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                objE.Lastname = txtLastnombre.Text;

            }
            catch (validationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
