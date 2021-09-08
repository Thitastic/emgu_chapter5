using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoFaceDetect
{
    public partial class frmInput : Form
    {
        private int p1X, p2X, p1Y, p2Y;
        public frmInput()
        {
            InitializeComponent();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtP1X.TextLength != 0 && txtP2X.TextLength != 0 && txtP1Y.TextLength !=0 && txtP2Y.TextLength != 0)
            {
                p1X = int.Parse(txtP1X.Text);
                p1Y = int.Parse(txtP1Y.Text);
                p2X = int.Parse(txtP2X.Text);
                p2Y = int.Parse(txtP2Y.Text);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
        }

        public int getP1X()
        {
            return p1X;
        }

        public int getP1Y()
        {
            return p1Y;
        }

        public int getP2X()
        {
            return p2X;
        }

        public int getP2Y()
        {
            return p2Y;
        }

    }
}
