namespace HttpMethod
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_Paramers = new System.Windows.Forms.TextBox();
            this.cbb_method = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.txt_request = new System.Windows.Forms.TextBox();
            this.cbb_RequestType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "method:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "response:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "request paramers:";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(117, 19);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(569, 21);
            this.tb_url.TabIndex = 5;
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
            // 
            // tb_Paramers
            // 
            this.tb_Paramers.Location = new System.Drawing.Point(116, 116);
            this.tb_Paramers.Multiline = true;
            this.tb_Paramers.Name = "tb_Paramers";
            this.tb_Paramers.Size = new System.Drawing.Size(570, 72);
            this.tb_Paramers.TabIndex = 6;
            this.tb_Paramers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Paramers_KeyDown);
            // 
            // cbb_method
            // 
            this.cbb_method.FormattingEnabled = true;
            this.cbb_method.Location = new System.Drawing.Point(117, 47);
            this.cbb_method.Name = "cbb_method";
            this.cbb_method.Size = new System.Drawing.Size(121, 20);
            this.cbb_method.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "ContentType:";
            // 
            // cbb_Type
            // 
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Location = new System.Drawing.Point(116, 70);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(121, 20);
            this.cbb_Type.TabIndex = 10;
            // 
            // txt_request
            // 
            this.txt_request.Location = new System.Drawing.Point(118, 201);
            this.txt_request.Multiline = true;
            this.txt_request.Name = "txt_request";
            this.txt_request.Size = new System.Drawing.Size(568, 265);
            this.txt_request.TabIndex = 11;
            this.txt_request.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_request_KeyDown);
            // 
            // cbb_RequestType
            // 
            this.cbb_RequestType.FormattingEnabled = true;
            this.cbb_RequestType.Location = new System.Drawing.Point(117, 92);
            this.cbb_RequestType.Name = "cbb_RequestType";
            this.cbb_RequestType.Size = new System.Drawing.Size(121, 20);
            this.cbb_RequestType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "reponseType:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 516);
            this.Controls.Add(this.cbb_RequestType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_request);
            this.Controls.Add(this.cbb_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_method);
            this.Controls.Add(this.tb_Paramers);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_Paramers;
        private System.Windows.Forms.ComboBox cbb_method;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_Type;
        private System.Windows.Forms.TextBox txt_request;
        private System.Windows.Forms.ComboBox cbb_RequestType;
        private System.Windows.Forms.Label label6;
    }
}

