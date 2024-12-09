﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            메모장 newMemo = new 메모장();
            newMemo.Show();
        }

        private void 시간날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            if(textBox.Text.Length == 0)
            {
                실행취소ToolStripMenuItem.Enabled = false;
                잘라내기ToolStripMenuItem.Enabled = false;
                삭제ToolStripMenuItem.Enabled = false;
                bing으로검색ToolStripMenuItem.Enabled = false;
                찾기ToolStripMenuItem.Enabled = false;
                다음찾기ToolStripMenuItem.Enabled = false;
                이전찾기ToolStripMenuItem.Enabled = false;
                바꾸기ToolStripMenuItem.Enabled = false;
            }

            else
            {
                실행취소ToolStripMenuItem.Enabled = true;
                잘라내기ToolStripMenuItem.Enabled = true;
                삭제ToolStripMenuItem.Enabled = true;
                bing으로검색ToolStripMenuItem.Enabled = true;
                찾기ToolStripMenuItem.Enabled = true;
                다음찾기ToolStripMenuItem.Enabled = true;
                이전찾기ToolStripMenuItem.Enabled = true;
                바꾸기ToolStripMenuItem.Enabled = true;
            }
        }

        private void 페이지설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 표시및유니코드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 메모장_Load(object sender, EventArgs e)
        {
            this.모두선택ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            UpdateLineCol();
        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox.CanUndo)
            {
                textBox.Undo();
            }

        }


        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "") {
                textBox.Cut(); 
            }
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Copy();
            }
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        private void 실행취소ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox.CanUndo)
            {
                textBox.Undo();
            }
        }

        private void 잘라내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "")
            {
                textBox.Cut();
            }
        }

        private void 복사ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Copy();
            }
        }

        private void 붙여넣기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void 삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        private void 모두선택ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();      
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (상태표시줄ToolStripMenuItem.Checked == false)
            {
                상태표시줄ToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
            else
            {
                상태표시줄ToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
        }

        private void UpdateLineCol()
        {
            int li = textBox.GetLineFromCharIndex(textBox.SelectionStart) + 1; // 0부터 반환하므로 위치는 +1 해야함.
            int col = textBox.SelectionStart - textBox.GetFirstCharIndexOfCurrentLine() + 1; // 현재 위치에서 가장 처음 위치를 뺀 후 1을 더해야함.현재의 위치만 알게되면 맨 앞에 탭을 넣은 경우에도 열을 인정하게 됨)

            toolStripStatusLabel1.Text = $"줄 {li}, 열 {col}";
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLineCol();
        }
    }
}
