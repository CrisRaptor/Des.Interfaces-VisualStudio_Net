using System;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {

        }

        private void hasChildCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            childLayout.Visible = hasChildCheckBox.Checked;
        }
    }
}
