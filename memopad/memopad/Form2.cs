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
        int lastIndex = -1;
        bool searchForward = true; // 다음 찾기의 디폴트 방향값이 아래
        bool isVisible = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        

            if (isVisible) 
            {
                changeBox.Visible = false;
                button2.Visible = false;
                button1.Visible = false;

                this.Size = new Size(780, 100);
                isVisible = false;
            }
            else
            {
                changeBox.Visible = true;
                button2.Visible = true;
                button1.Visible = true;

                this.Size = new Size(780, 150);
                isVisible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textSearch = searchBox.Text;

        }

        private void button6_Click(object sender, EventArgs e) // 버튼을 누르면 메뉴가 나오게 하는 기능 구현
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

        private void Form2_Load(object sender, EventArgs e)
        {
            changeBox.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

            this.Size = new Size(780,100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
