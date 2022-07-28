using System;
using System.Windows.Forms;

namespace _1_homework
{
    public partial class FormIncoming : Form
    {
        private decimal totalMoney = 0;
        public FormIncoming()
        {
            InitializeComponent();
        }

        //将输入的支出信息封装成结构体。
        struct IncomingInfo
        {
            public string Name;
            public decimal Money;
            public string Description;
        }

        private void resetValue()
        {
            this.textName.Text = "";
            this.textMoney.Text = "";
            this.textDescription.Text = "";
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            IncomingInfo incomingInfo = new IncomingInfo();
            // get info
            incomingInfo.Name = this.textName.Text;
            incomingInfo.Money = decimal.Parse(this.textMoney.Text);
            incomingInfo.Description = this.textDescription.Text;

            totalMoney += incomingInfo.Money;

            // show info
            this.labelTotal.Text = totalMoney.ToString();
            this.labelDetail.Text += $"{incomingInfo.Name}, {incomingInfo.Money}, {incomingInfo.Description}\r\n";

            this.resetValue();
        }
    }
}
