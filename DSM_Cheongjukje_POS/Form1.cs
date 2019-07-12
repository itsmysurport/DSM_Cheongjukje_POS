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
        int nState = 1;
          public Main()
        {
            InitializeComponent();
            this.label4.Text = "0";
            Form3 init = new Form3();
            init.FormSendEvent += new Form3.FormSendDataHandler(initMethod);
            init.ShowDialog();
        }

        private void initMethod(object sender)
        {
            label1.Text = sender.ToString();
        }

        private void InitMethod(object sender)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DieaseUpdateEventMethod(object sender, object sender1, int nHost)
        {
            if (sender.ToString().Length == 0) return;
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            switch(nHost)
            {
                case 1:
                    {
                        macro1.Text = sender.ToString();
                        macro12.Text += sender1.ToString();
                        if(macro12.Text.Contains("-"))
                        {
                            macro12.ForeColor = System.Drawing.Color.Red;
                        }
                        else if(macro12.Text.Contains("+"))
                        {
                            macro12.ForeColor = System.Drawing.Color.Blue;
                        }
                    }break;
                case 2:
                    {
                        macro2.Text = sender.ToString();
                        macro22.Text += sender1.ToString();
                        if(macro22.Text.Contains("-"))
                        {
                            macro22.ForeColor = System.Drawing.Color.Red;
                        }
                        else if (macro22.Text.Contains("+"))
                        {
                            macro22.ForeColor = System.Drawing.Color.Blue;
                        }
                    } break;
                case 3:
                    {
                        macro3.Text = sender.ToString();
                        macro32.Text += sender1.ToString();
                        if (macro32.Text.Contains("-"))
                        {
                            macro32.ForeColor = System.Drawing.Color.Red;
                        }
                        else if (macro32.Text.Contains("+"))
                        {
                            macro32.ForeColor = System.Drawing.Color.Blue;
                        }
                    }
                    break;
                case 4:
                    {
                        macro4.Text = sender.ToString();
                        macro42.Text += sender1.ToString();
                        if (macro42.Text.Contains("-"))
                        {
                            macro42.ForeColor = System.Drawing.Color.Red;
                        }
                        else if (macro42.Text.Contains("+"))
                        {
                            macro42.ForeColor = System.Drawing.Color.Blue;
                        }
                    }
                    break;
                case 5:
                    {
                        macro5.Text = sender.ToString();
                        macro52.Text += sender1.ToString();
                        if (macro52.Text.Contains("-"))
                        {
                            macro52.ForeColor = System.Drawing.Color.Red;
                        }
                        else if (macro52.Text.Contains("+"))
                        {
                            macro52.ForeColor = System.Drawing.Color.Blue;
                        }
                    }
                    break;
                case 6:
                    {
                        macro6.Text = sender.ToString();
                        macro62.Text += sender1.ToString();
                        if (macro62.Text.Contains("-"))
                        {
                            macro62.ForeColor = System.Drawing.Color.Red;
                        }
                        else if (macro62.Text.Contains("+"))
                        {
                            macro62.ForeColor = System.Drawing.Color.Blue;
                        }
                    }
                    break;
                default:    break;
            }
            nState++;
        }

        private void Macro1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
        private void Macro3_Click(object sender, EventArgs e)
        {
        }
        private void priceSendEvent(string str)
        {
            if (str.Length != 0)
            {
                if (this.label4.Text.Length == 0)
                {
                    this.label4.Text = str;
                }
                else
                {
                    int value1 = Convert.ToInt32(label4.Text);
                    int value2 = Convert.ToInt32(str);
                    int result = value1 + value2;
                    if (result > 0)
                    {
                        this.label4.Text = "+" + (result.ToString());
                        this.label4.ForeColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        this.label4.Text = result.ToString();
                        this.label4.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.label4.Text = "0";
        }
        private void Edit1_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            editor.received2(macro1.Text, 1);
            editor.ShowDialog();
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            editor.received2(macro2.Text, 2);
            editor.ShowDialog();
        }

        private void Edit3_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            editor.received2(macro3.Text, 3);
            editor.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            priceSendEvent(this.macro12.Text);
        }

        private void Macro2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro22.Text);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro32.Text);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.FormSendEvent += new Form2.FormSendDataHandler(DieaseUpdateEventMethod);
            if (nState <= 6)
            {
                editor.received2(macro1.Text, nState);
                editor.ShowDialog();
            }
            else
            {
                MessageBox.Show("만들 수 있는 개수를 초과했습니다.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
