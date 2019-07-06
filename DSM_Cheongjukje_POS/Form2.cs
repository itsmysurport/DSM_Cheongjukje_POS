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
        public delegate void FormSendDataHandler(string sendstring, string sendstring2);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("완료.");
            this.FormSendEvent(textBox1.Text, textBox2.Text);
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
        public void received2(string str)
        {
            if (str.Contains("\n"))
            {
                string[] arr = str.Split('\n'); 
                this.textBox1.Text = arr[0];
                this.textBox2.Text = arr[1].Replace("원", "");
            }
            textBox1.Invalidate();
            textBox2.Invalidate();
        }
    }
}
