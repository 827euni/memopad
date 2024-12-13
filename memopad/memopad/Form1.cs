using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace memopad
{
    public partial class 메모장 : Form
    {
        string currentURL;
        string msg;
        Stream st;
        Font printFont;
        int zoomLevel = 10;
        int index = 0;
        bool isModified;
        Form2 findForm;
        private PageSettings pageSettings = new PageSettings();
        private PrinterSettings printerSettings = new PrinterSettings();

        public 메모장()
        {
            InitializeComponent();
            textBox.MouseWheel += new MouseEventHandler(textBox_MouseWheel);
            상태표시줄ToolStripMenuItem.Checked = true;
            자동줄바꿈ToolStripMenuItem.Checked = true;
        }

        private void textBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control) // 컨트롤 누른 채로 마우스 휠 이동
            {
                if (e.Delta > 0) // 한 번 휠이 돌 때마다 +120~-120까지 이동
                {
                    zoomIn();
                }
                else
                {
                    zoomOut();
                }
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter streamWriter = new StreamWriter(st))
                    {
                        streamWriter.Write(textBox.Text);
                    }
                }
            }
            currentURL = saveFileDialog1.FileName;
            isModified = false;
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
                isModified = false;
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(currentURL))
                {
                    streamWriter.Write(textBox.Text);
                    isModified = false;
                }
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
            textBox.Text = textBox.Text.Insert(textBox.SelectionStart, DateTime.Now.ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            UpdateWord();
            isModified = true;

            if (textBox.Text.Length == 0)
            {
                실행취소ToolStripMenuItem.Enabled = false;
                잘라내기ToolStripMenuItem.Enabled = false;
                삭제ToolStripMenuItem.Enabled = false;
                bing으로검색ToolStripMenuItem.Enabled = false;
                찾기ToolStripMenuItem.Enabled = false;
                다음찾기ToolStripMenuItem.Enabled = false;
                이전찾기ToolStripMenuItem.Enabled = false;
                바꾸기ToolStripMenuItem.Enabled = false;
                잘라내기ToolStripMenuItem1.Enabled = false;
                복사ToolStripMenuItem1.Enabled = false;
                삭제ToolStripMenuItem1.Enabled = false;
                bing으로서치ToolStripMenuItem.Enabled = false;


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
                잘라내기ToolStripMenuItem1.Enabled = true;
                복사ToolStripMenuItem1.Enabled = true;
                삭제ToolStripMenuItem1.Enabled = true;
                bing으로서치ToolStripMenuItem.Enabled = true;

            }


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
            if (textBox.SelectedText != "")
            {
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
            int col = textBox.SelectionStart - textBox.GetFirstCharIndexOfCurrentLine() + 1; // 현재 위치에서 가장 처음 위치를 뺀 후 1을 더해야함.
                                                                                             // 현재의 위치만 알게되면 맨 앞에 탭을 넣은 경우에도 열을 인정하게 됨

            toolStripStatusLabel1.Text = $"줄 {li}, 열 {col}";
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLineCol();
        }

        private void UpdateWord()
        {
            int size = textBox.Text.Length;
            toolStripStatusLabel2.Text = $"{size}자";
        }

        private void zoomIn()
        {
            if (zoomLevel < 60)
            {
                zoomLevel++;
                textBox.ZoomFactor = zoomLevel * 0.1f; // 소수점 단위로 보는 것이 조금 더 명확함.
                updateZoom();
            }
        }

        private void zoomOut()
        {
            if (zoomLevel > 1)
            {
                zoomLevel--;
                textBox.ZoomFactor = zoomLevel * 0.1f;
                updateZoom();
            }
        }

        private void updateZoom()
        {
            toolStripStatusLabel3.Text = $"{Convert.ToString(zoomLevel * 10)}%";
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomIn();
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomOut();
        }

        private void 기본확대축소복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomLevel = 10;
            textBox.ZoomFactor = 1;
            updateZoom();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (자동줄바꿈ToolStripMenuItem.Checked == false)
            {
                자동줄바꿈ToolStripMenuItem.Checked = true;
                textBox.WordWrap = true;
            }
            else
            {
                자동줄바꿈ToolStripMenuItem.Checked = false;
                textBox.WordWrap = false;
            }
        }

        private void bing으로검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = textBox.SelectedText;

            if (textBox.SelectedText != null)
            {
                string url = "https://www.bing.com/search?q=" + Uri.EscapeDataString(search);
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); // 기본 인터넷 프로그램으로 검색을 돌림.
            }

            else
            {
                bing으로검색ToolStripMenuItem.Enabled = false;
            }
        }

        private void bing으로서치ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = textBox.SelectedText;

            if (textBox.SelectedText != null)
            {
                string url = "https://www.bing.com/search?q=" + Uri.EscapeDataString(search);
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

            else
            {
                bing으로서치ToolStripMenuItem.Enabled = false;
            }
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm = new Form2();
            findForm.Show(this);
            findForm.setFind();
        }

        private void 바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm = new Form2();
            findForm.Show(this);
            findForm.setChange();

        }

        private void 이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 moveLine = new Form3(this);
            moveLine.Show(this);
        }

        public void lineCursor(int lineN)
        {
            if (lineN > 0 && lineN <= textBox.Lines.Length)
            {
                int position = textBox.GetFirstCharIndexFromLine(lineN - 1); // 사람이 생각하는 줄 수 는 1부터 시작하는데 컴퓨터는 0부터 시작한다고 생각하기 때문
                if (position >= 0)
                {
                    textBox.SelectionStart = position;
                }
            }
            else
            {
                MessageBox.Show("줄 번호가 전체 줄 수를 넘습니다.", "메모장 - 줄로 이동");
            }

        }

        public void searchNowWord(string searchWord)
        {
            bool isBigSmall = findForm.getIsBigSmall();
            RichTextBoxFinds options = isBigSmall ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;

            int selectIndex = textBox.Find(searchWord, options);

            if (selectIndex != -1)
            {
                textBox.SelectionStart = selectIndex;
                textBox.SelectionLength = searchWord.Length;
                textBox.Focus();
            }


            index = selectIndex + searchWord.Length;
        }

        public void searchNextWord(string searchWord)
        {
            try
            {
                bool isBigSmall = findForm.getIsBigSmall();
                RichTextBoxFinds options = isBigSmall ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
                int selectIndex = textBox.Find(searchWord, index + 1, textBox.Text.Length, options); // 인덱스와 동일한 것을 굳이 계산 할 필요 없음

                if (selectIndex != -1)
                {
                    textBox.SelectionStart = selectIndex;
                    textBox.SelectionLength = searchWord.Length;
                    textBox.Focus();
                }



                index = selectIndex + searchWord.Length;
            }

            catch
            {
                searchNowWord(searchWord);
            }
        }

        public void searchPreviewWord(String searchWord)
        {
            bool isBigSmall = findForm.getIsBigSmall();
            RichTextBoxFinds options = isBigSmall ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None; // 대소문자 구분 여부 설정

            int selectIndex = textBox.Find(searchWord, 0, index - 1, options | RichTextBoxFinds.Reverse); // 대소문자를 구분하면서 역방향으로 검색함. 
                                                                                                          // 비트 연산자이기 때문에 AND가 아니라 OR로 합할 수 있음 

            if (selectIndex != -1)
            {
                textBox.SelectionStart = selectIndex;
                textBox.SelectionLength = searchWord.Length;
                textBox.Focus();
                index = selectIndex;
            }

            else
            {
                searchNowWord(searchWord);
            }
        }

        public void changeWord(String searchWord, String changeWord) 
        {
            bool isBigSmall = findForm.getIsBigSmall();
            RichTextBoxFinds options = isBigSmall ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None; // 대소문자 구분 여부 설정

            if (textBox.Find(searchWord, options) != -1)
            {
                textBox.SelectedText = changeWord;
            }
            else
            {
                MessageBox.Show($"'{searchWord}'을(를) 찾을 수 없습니다", "메모장");
            }
        }

        public void changeAllWords(String searchWord, String changeWord)
        {
            bool isBigSmall = findForm.getIsBigSmall();
            RichTextBoxFinds options = isBigSmall ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None; // 대소문자 구분 여부 설정

            while (textBox.Find(searchWord, options) != -1)
            {
                int selectIndex = textBox.Find(searchWord);
                textBox.SelectionStart = selectIndex;
                textBox.SelectionLength = searchWord.Length;
                textBox.SelectedText = changeWord;
            }
        }

        private void 다음찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm = new Form2();
            string searchWord = textBox.SelectedText;
            searchNextWord(searchWord);
        }

        private void 이전찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm = new Form2();
            string searchWord = textBox.SelectedText;
            searchPreviewWord(searchWord);
        }


        private void 페이지설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = pageSettings;
            pageSetupDialog.PrinterSettings = printerSettings;
            pageSetupDialog.AllowPrinter = true;
            pageSetupDialog.AllowOrientation= true;
            pageSetupDialog.ShowDialog();
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings = printerSettings;
            printDocument.DefaultPageSettings = pageSettings;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printDialog.Document = printDocument;
                printDialog.Document.Print();

            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show("저장하시겠습니까?", "종료", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    저장ToolStripMenuItem_Click(sender, e);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }

}

