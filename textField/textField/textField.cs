using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textField
{
    public partial class textField: UserControl
    {
        public int CharacterLimit
        {
            get
            {
                return textBox.MaxLength;
            }
            set
            {
                textBox.MaxLength = value;
                setLabelLimit();
            }
        }
        public string Text
        {
            get
            {
                return labelFieldName.Text;
            }
            set
            {
                labelFieldName.Text = value;
            }
        }
        public textField()
        {
            InitializeComponent();
        }

        private void textField_Load(object sender, EventArgs e)
        {

        }

        private void setLabelLimit()
        {
            labelLimit.Text = textBox.Text.Length + " / " + textBox.MaxLength;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            setLabelLimit();
        }
    }
}
