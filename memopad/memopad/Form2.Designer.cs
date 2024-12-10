namespace memopad
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.changeBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("돋움", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBox.Location = new System.Drawing.Point(149, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1218, 96);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "";
            this.searchBox.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // changeBox
            // 
            this.changeBox.Font = new System.Drawing.Font("돋움", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeBox.Location = new System.Drawing.Point(149, 159);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(1093, 96);
            this.changeBox.TabIndex = 1;
            this.changeBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1260, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "바꾸기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1581, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "모두 바꾸기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1239, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 76);
            this.button3.TabIndex = 5;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1385, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 76);
            this.button4.TabIndex = 6;
            this.button4.Text = "↓";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 76);
            this.button5.TabIndex = 7;
            this.button5.Text = "◈";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1651, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 76);
            this.button6.TabIndex = 8;
            this.button6.Text = "메뉴";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1771, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 76);
            this.button7.TabIndex = 9;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1514, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 76);
            this.button8.TabIndex = 10;
            this.button8.Text = "↑";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(4805, 150);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 287);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.RichTextBox changeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}