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
    public partial class Form3 : Form
    {
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring, string sendstring2);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("부스명을 입력해주세요.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string itemText = listBox1.GetItemText(listBox1.SelectedItem);
                this.FormSendEvent(textBox1.Text, itemText);
                if(MessageBox.Show($"부스명 : {textBox1.Text}가 맞나요?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    this.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
