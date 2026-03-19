using System;
using System.Collections.Generic;    
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;       
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnSend; //엔터키와 btnSend 버튼을 연결
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTypeHere;
            txtTypeHere.Focus(); //폼이 로드될 때 txtTypeHere 텍스트박스에 포커스를 설정
            txtTypeHere.Clear();
            // 초기화: 선택 삭제 버튼 비활성화 및 채팅 수 표시
            SlctDlt.Enabled = false;
            ChatCnt.Text = $"현재 대화 : {lstChatting.Items.Count}개";

        }

        private void lblEchoBox_Click(object sender, EventArgs e)
        {

        }

        private void lstChatting_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 항목이 선택되면 선택 삭제 버튼을 활성화, 선택 해제 시 비활성화
            SlctDlt.Enabled = lstChatting.SelectedIndex >= 0;
        }
        string MyMessage;
        private void txtTypeHere_TextChanged(object sender, EventArgs e)
        {
            MyMessage = txtTypeHere.Text;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MyMessage))//MyMessage가 null이거나 공백이 아닐경우에만 실행
            {

                // 현재 시간과 함께 메시지를 리스트에 추가
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string rslt = $"[{timestamp}] {MyMessage.Trim()}";//앞, 뒤 불필요한 공백을 제거한 메시지 추가
                lstChatting.Items.Add(rslt);
                ChatCnt.Text = $"현재 대화 : {lstChatting.Items.Count}개"; // 채팅 수 업데이트
                txtTypeHere.Clear();
                txtTypeHere.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DltAll_Click(object sender, EventArgs e)
        {
            lstChatting.Items.Clear(); // 대화 목록 초기화
            ChatCnt.Text = $"현재 대화 : {lstChatting.Items.Count}개"; // 채팅 수 업데이트
            SlctDlt.Enabled = false;

        }

        private void SlctDlt_Click(object sender, EventArgs e)
        {
            int idx = lstChatting.SelectedIndex;
            if (idx >= 0)
            {
                lstChatting.Items.RemoveAt(idx);
                ChatCnt.Text = $"현재 대화 : {lstChatting.Items.Count}개";
            }
            // 선택이 없거나 삭제 후 비활성화
            SlctDlt.Enabled = lstChatting.SelectedIndex >= 0;
        }
    }
}

