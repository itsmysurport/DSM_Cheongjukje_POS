using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO.Ports;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Threading;

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
        string PORTNUM = "COM";
        string boothNamed = "";
        string playerNamed = "";
        int playerPoint = 0;
        SerialPort port = new SerialPort();
        delegate void SetTextCallback(string  ext);
        private static readonly HttpClient client = new HttpClient();

        string id = "";

        private void sportRCV(object sender, EventArgs e)
        {
            String s = "";
            s = port.ReadExisting();
            id += s;
            Console.WriteLine(s);
            if (s.Contains("Z"))
            {
                string[] text1 = id.Split('Z');
                string[] text = text1[0].Split(',');
                Console.Write("SUCCESS!!! :");
                Console.WriteLine(text1[0]);
                id = "";
                playerNamed = text[0];
                boothNamed = text[1];
                if (text[0].Length > 8)
                {
                    return;
                }

                Getting(text[0]);
            }
        }
        private void Adruino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(sportRCV));                
        }
        private void Getting(string text)
        {
            string url = $"http://52.78.51.109:5000/info/{text}";  //테스트 사이트
            string responseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000; // 30초
            request.Headers.Add("Authorization", "BASIC SGVsbG8="); // 헤더 추가 방법

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);  // 정상이면 "OK"

                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }
            Console.WriteLine(responseText);
            string[] aRes = responseText.Split(',');
            string label2asT = aRes[0] + " " + aRes[1];
            SetText(label2asT);
            playerPoint = System.Convert.ToInt32(aRes[2]);
        }


        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (this.label2.Text != text)
                {
                    this.label2.Text = text;
                }
            }
        }

        private void initMethod(object sender, object sender1)
        {
            try
            {
                label1.Text = sender.ToString();
                this.PORTNUM += sender1.ToString();
                if (port.IsOpen == false)
                {
                    port = new SerialPort(this.PORTNUM, 9600);
                    port.Encoding = Encoding.Default;
                    port.Parity = Parity.None;
                    port.DataBits = 8;
                    port.StopBits = StopBits.One;
                    
                    port.DataReceived += new SerialDataReceivedEventHandler(Adruino_DataReceived);
                    port.Open();
                }
            }
            catch
            {
                MessageBox.Show("포트를 확인한 후 다시 실행해주세요.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro42.Text);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro52.Text);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            priceSendEvent(this.macro62.Text);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            playerPoint = playerPoint + System.Convert.ToInt32(label4.Text);
            label4.Text = "0";
            this.label4.ForeColor = System.Drawing.Color.Black;
            if (playerPoint < 0)
                MessageBox.Show("잔액이 부족합니다!!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string uri = "http://52.78.51.109:5000/pay";
                int boothId = System.Convert.ToInt32(boothNamed);
                int point = System.Convert.ToInt32(playerPoint);
                string requestJson = $"{{\"rfid\": \"{playerNamed}\", \"boothId\": {boothId}, \"point\": {point}}}";
                WebClient webClient = new WebClient();
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                webClient.Encoding = UTF8Encoding.UTF8;
                string responseJSON = webClient.UploadString(uri, requestJson);
                MessageBox.Show("전송 성공.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
