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
    public partial class Form2 : Form
    {
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring, string sendstring2, int nHost);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public Form2()
        {
            InitializeComponent();
        }
        int nHost = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"상품명 {textBox1.Text}\n가격 {textBox2.Text}\n 이 맞습니까?", "저장", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (checkBox1.Checked == true)
                    this.FormSendEvent(textBox1.Text, "-" + textBox2.Text, nHost);
                else
                    this.FormSendEvent(textBox1.Text, "+" + textBox2.Text, nHost);
                this.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
        public void received2(string str, int nHost)
        {
            this.nHost = nHost;
            if (str.Contains("\n"))
            {
                string[] arr = str.Split('\n'); 
                this.textBox1.Text = arr[0];
                this.textBox2.Text = arr[1].Replace("원", "");
            }
            textBox1.Invalidate();
            textBox2.Invalidate();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
        }
    }
}
