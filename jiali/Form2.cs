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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SetText(string txt)
        {
            this.textBox1.Text = txt;
        }

        internal void MainFormTxtChaned(object sender, EventArgs e)
        {
            MyEventArg arg = e as MyEventArg;
            this.SetText(arg.Text); 
        }
}
}
