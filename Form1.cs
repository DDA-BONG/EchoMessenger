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
            
        }

        private void lblEchoBox_Click(object sender, EventArgs e)
        {

        }

        private void lstChatting_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                lstChatting.Items.Add(MyMessage);
                txtTypeHere.Clear();
                txtTypeHere.Focus();
            }
        }
    }
}

