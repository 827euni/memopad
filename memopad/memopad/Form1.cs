using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memopad
{
    public partial class 메모장 : Form
    {
        string currentURL;
        string msg;
        Stream st;
        Font printFont;


        public 메모장()
        {
            InitializeComponent();
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

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentURL = openFileDialog1.FileName;
                if ((st = openFileDialog1.OpenFile()) != null)
                {
                    using (StreamReader streamReader = new StreamReader(st))
                    {
                        string msg = streamReader.ReadToEnd();
                        textBox.Text = msg;
                    }
                }
            }
        }


        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentURL))
            {
                다른이름으로저장ToolStripMenuItem_Click(sender, e);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(currentURL))
                {
                    streamWriter.Write(textBox.Text);
                }
            }

        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {             
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                printDialog.Document = printDocument;
                printDialog.Document.Print();

            }

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            printFont = new Font("Arial", 10);
            ev.Graphics.DrawString(textBox.Text, printFont, Brushes.Black, ev.MarginBounds);

        }
    }
}
