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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            lstChatting.Items.Add(MyMessage);
            txtTypeHere.Clear();
        }

        
        }
    }

