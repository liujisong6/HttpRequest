using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace HttpMethod
{
    public partial class Form1 : Form
    {
        //1.声明自适应类实例
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Form1()
        {
            InitializeComponent();
            List<MethodEntity> lst = new List<MethodEntity>();
            MethodEntity info = new MethodEntity();
            info.name = "get";
            info.value = "GET";
            lst.Add(info);
            info = new MethodEntity();
            info.name = "post";
            info.value = "POST";
            lst.Add(info);
            cbb_method.DataSource = lst;
            cbb_method.DisplayMember = "name";

            cbb_method.ValueMember = "value";
            cbb_method.SelectedIndex = 0;
            //foreach (var info1 in lst) {
            //    cbb_method.Items.Add(info1);
            //}
            lst = new List<MethodEntity>();
            foreach (var item in Encoding.GetEncodings())
            {
                lst.Add(new MethodEntity() { name = item.Name, value = item.Name });
            };

            //info = new MethodEntity();
            //info.name = "UTF-8";
            //info.value = "UTF-8";
            //lst.Add(info);
            //info = new MethodEntity();
            //info.name = "GB2312";
            //info.value = "GB2312";
            //lst.Add(info);

            cbb_Type.DataSource = lst;

            cbb_Type.DisplayMember = "name";

            cbb_Type.ValueMember = "value";
            //cbb_Type.SelectedIndex = 0;
            cbb_Type.SelectedValue = Encoding.UTF8.BodyName;

            cbb_RequestType.DataSource = lst;
            cbb_RequestType.DisplayMember = "name";

            cbb_RequestType.ValueMember = "value";
            //cbb_Type.SelectedIndex = 0;
            cbb_RequestType.SelectedValue = Encoding.UTF8.BodyName;
            
        }
        //2. 为窗体添加Load事件，并在其方法Form1_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小
        private void Form1_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }
        //3.为窗体添加SizeChanged事件，并在其方法Form1_SizeChanged中，调用类的自适应方法，完成自适应
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        public class MethodEntity
        {
            public string name { get; set; }
            public string value { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string method=cbb_method.Text;
            string encoding = cbb_Type.Text;
            string url=tb_url.Text.Trim();
            string param = tb_Paramers.Text.Trim();
            Task s = new Task(() =>
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                string paramData = param;
                string postUrl = url;
                if (method.Equals("get"))
                {
                    txt_request.Text = GetUrltoHtml(postUrl, encoding);
                }
                else
                {
                    txt_request.Text = OpenReadWithHttps(postUrl, paramData, encoding, method, cbb_RequestType.Text);
                }
            });
            s.Start();

        }

        ///<summary>

        ///采用https协议访问网络

        ///</summary>

        ///<param name="URL">url地址</param>

        ///<param name="strPostdata">发送的数据</param>

        ///<param name="method">HTTP传输方式</param>

        ///<returns></returns>

        public string OpenReadWithHttps(string URL, string strPostdata, string strEncoding = "UTF-8", string method = "POST", string reponseEncoding = "UTF-8")
        {
            try
            {
                Encoding encoding = Encoding.GetEncoding(strEncoding);// Encoding.UTF8;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);

                request.Method = method.ToUpper(); //POST

                //request.Accept = "text/html, application/xhtml+xml, */*";

                //request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "text/xml; charset=utf-8";
                byte[] buffer = encoding.GetBytes(strPostdata);

                request.ContentLength = buffer.Length;

                request.GetRequestStream().Write(buffer, 0, buffer.Length);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(reponseEncoding))) //GB2312
                {

                    return response.Headers + reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string GetUrltoHtml(string Url, string encoding)
        {

            try
            {

                System.Net.WebRequest wReq = System.Net.WebRequest.Create(Url);

                // Get the response instance.

                System.Net.WebResponse wResp = wReq.GetResponse();

                System.IO.Stream respStream = wResp.GetResponseStream();

                // Dim reader As StreamReader = New StreamReader(respStream)
                using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream,Encoding.GetEncoding(encoding)))
                {
                    return wResp.Headers + reader.ReadToEnd();
                }

            }

            catch (System.Exception ex)
            {

                return ex.Message;

            }

            return "";

        }


        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            //退出提示，真的要退出，才允许退出 
            if (MessageBox.Show(this, "你真的要退出吗？", "提示信息：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;//Cancel为false，说明不取消窗口关闭操作，所以窗口关闭

                this.Dispose();
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void txt_request_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }  
        }

        private void tb_Paramers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }  
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }  
        }

    }
}