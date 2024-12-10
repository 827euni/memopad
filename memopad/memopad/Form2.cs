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
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textSearch = search.Text;

        }
    }
}
