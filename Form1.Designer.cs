namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEchoMessenger = new System.Windows.Forms.Label();
            this.lstChatting = new System.Windows.Forms.ListBox();
            this.txtTypeHere = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEchoMessenger
            // 
            this.lblEchoMessenger.AutoSize = true;
            this.lblEchoMessenger.Font = new System.Drawing.Font("휴먼둥근헤드라인", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEchoMessenger.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEchoMessenger.Location = new System.Drawing.Point(12, 9);
            this.lblEchoMessenger.Name = "lblEchoMessenger";
            this.lblEchoMessenger.Size = new System.Drawing.Size(457, 45);
            this.lblEchoMessenger.TabIndex = 0;
            this.lblEchoMessenger.Text = "Echo Messenger";
            this.lblEchoMessenger.Click += new System.EventHandler(this.lblEchoBox_Click);
            // 
            // lstChatting
            // 
            this.lstChatting.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstChatting.FormattingEnabled = true;
            this.lstChatting.ItemHeight = 23;
            this.lstChatting.Location = new System.Drawing.Point(20, 70);
            this.lstChatting.Name = "lstChatting";
            this.lstChatting.Size = new System.Drawing.Size(756, 234);
            this.lstChatting.TabIndex = 1;
            this.lstChatting.SelectedIndexChanged += new System.EventHandler(this.lstChatting_SelectedIndexChanged);
            // 
            // txtTypeHere
            // 
            this.txtTypeHere.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTypeHere.Location = new System.Drawing.Point(20, 362);
            this.txtTypeHere.Name = "txtTypeHere";
            this.txtTypeHere.Size = new System.Drawing.Size(562, 30);
            this.txtTypeHere.TabIndex = 2;
            this.txtTypeHere.TextChanged += new System.EventHandler(this.txtTypeHere_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gold;
            this.btnSend.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSend.Location = new System.Drawing.Point(605, 339);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 74);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtTypeHere);
            this.Controls.Add(this.lstChatting);
            this.Controls.Add(this.lblEchoMessenger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEchoMessenger;
        private System.Windows.Forms.ListBox lstChatting;
        private System.Windows.Forms.TextBox txtTypeHere;
        private System.Windows.Forms.Button btnSend;
    }
}

