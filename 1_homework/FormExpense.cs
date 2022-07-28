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
    public partial class FormExpense : Form
    {
        private decimal totalMoney = 0;
        private int totalNum = 0;
        public FormExpense()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            this.textName.Text = "";
            this.textMoney.Text = "";
            this.textDescription.Text = "";
            this.textPrice.Text = "";
            this.textNum.Text = "";
        }

        //定义一个结构体，描述支出记录信息（包含名目名称、支出描述、单价、数量、金额）
        struct Expense
        {
            public string Name;
            public decimal Money;
            public string Description;
            public int Num;
            public decimal Price;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            // get info
            expense.Name = this.textName.Text;
            expense.Description = this.textDescription.Text;
            expense.Num = int.Parse(this.textNum.Text);
            expense.Price = decimal.Parse(this.textPrice.Text);
            expense.Money = expense.Price * expense.Num;

            totalMoney += expense.Money;
            totalNum += expense.Num;

            // show info
            this.labelTotalMoney.Text = totalMoney.ToString();
            this.labelTotalNum.Text = totalNum.ToString();
            this.labelAverage.Text = (totalMoney / totalNum).ToString("0.00");

            this.labelDetail.Text += $"{expense.Name}, {expense.Price}, {expense.Num}, {expense.Money}, {expense.Description}\r\n";

            this.resetValue();
        }
    }
}
