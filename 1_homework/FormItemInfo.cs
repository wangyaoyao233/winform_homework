using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_homework
{
    public partial class FormItemInfo : Form
    {
        private int cnt = 0;
        public FormItemInfo()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            foreach(RadioButton rb in this.panel1.Controls)
            {
                rb.Checked = false;
            }
            this.textId.Text = "";
            this.textName.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string type = "";
            int id = 0;
            string name = "";
            
            // get info
            foreach(RadioButton rb in this.panel1.Controls)
            {
                if (rb.Checked)
                {
                    type = rb.Text;
                    break;
                }
            }
            id = int.Parse(this.textId.Text);
            name = this.textName.Text;

            cnt++;

            // show info
            this.labelNum.Text = cnt.ToString();
            this.labelDetail.Text += $"{id}, {name}, {type}\r\n";

            this.resetValue();
        }
    }
}
