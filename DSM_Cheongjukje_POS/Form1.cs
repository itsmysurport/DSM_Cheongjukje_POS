using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM_Cheongjukje_POS
{
    public partial class Main : Form
    {
          public Main()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DieaseUpdateEventMethod(object sender, object sender1)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            macro1.Text = sender.ToString();
            macro1.Text += "\n" + sender1.ToString() + "원";
        }

        private void Macro1_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro2.Text);
        }
        private void priceSendEvent(string str)
        {
            if (str.Length != 0)
            {
                string[] arr = str.Split('\n');
                if (this.textBox1.Text.Length == 0)
                    this.textBox1.Text = arr[1];
                else
                {
                    int value1 = Convert.ToInt32(this.textBox1.Text.Replace("원", ""));
                    int value2 = Convert.ToInt32(arr[1].Replace("원", ""));
                    int result = value1 + value2;
                    this.textBox1.Text = (result.ToString() + "원");
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
        private void Edit1_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            editor.received2(macro1.Text);
            editor.ShowDialog();
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            editor.received2(macro2.Text);
            editor.ShowDialog();
        }
    }
}
