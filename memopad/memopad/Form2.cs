using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memopad
{
    public partial class Form2 : Form
    {
        메모장 memopad;
        bool isVisible = false;

        public Form2()
        {
            InitializeComponent();
            setFind();

        }

        public String getSearchBox()
        {
            return searchBox.Text;
        }

        public String getChangeBox()
        {
            return changeBox.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (isVisible)
            {
                setFind();
            }
            else
            {
                setChange();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var mainForm = (메모장)this.Owner;
            string textSearch = searchBox.Text;

            mainForm.searchNowWord(textSearch);

        }

        private void button6_Click(object sender, EventArgs e) // 버튼을 누르면 메뉴 바로 아래에 나오게 하는 기능 구현
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem()
            {
                Text = "대/소문자 구분"
            };
            //menuItem.Click

            ToolStripMenuItem menuItem2 = new ToolStripMenuItem()
            {
                Text = "줄 바꿈"
            };

            contextMenuStrip.Items.Add(menuItem);
            contextMenuStrip.Items.Add(menuItem2);

            Point point = button6.PointToScreen(Point.Empty);
            point.Y += button6.Height;
            contextMenuStrip.Show(point);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setChange()
        {
            changeBox.Visible = true;
            button2.Visible = true;
            button1.Visible = true;

            this.Size = new Size(780, 150);
            isVisible = true;
        }

        public void setFind()
        {
            changeBox.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

            this.Size = new Size(780, 100);
            isVisible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mainForm = (메모장)this.Owner;
            string textSearch = searchBox.Text;

            mainForm.searchNextWord(textSearch);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var mainForm = (메모장)this.Owner;
            string textSearch = searchBox.Text;

            mainForm.searchPreviewWord(textSearch);
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                button3.Focus();
            }
        }

        private void changeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainForm = (메모장)this.Owner;
            string searchWord = searchBox.Text;
            string changeWord = changeBox.Text;

            mainForm.searchNowWord(searchWord);
            mainForm.changeWord(searchWord,changeWord);
            mainForm.searchNextWord(searchWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = (메모장)this.Owner;
            string searchWord = searchBox.Text;
            string changeWord = changeBox.Text;

            mainForm.changeAllWords(searchWord,changeWord);
        }
    }
}
