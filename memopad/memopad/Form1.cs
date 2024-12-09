using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memopad
{
    public partial class 메모장 : Form
    {
        string msg;
        Stream st;

        public 메모장()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog1.OpenFile()) != null) {
                    using (StreamWriter streamWriter = new StreamWriter(st)) {
                        streamWriter.Write(textBox.Text);
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
