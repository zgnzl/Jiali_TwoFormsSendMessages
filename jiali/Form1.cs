using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jiali
{
    public partial class Form1 : Form
    {
            public event EventHandler SendMsgEvent; 

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMsgEvent(this, new MyEventArg() { Text = this.textBox1.Text });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SendMsgEvent += form2.MainFormTxtChaned;
        }
    }
}
