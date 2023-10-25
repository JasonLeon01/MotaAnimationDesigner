namespace AnimationDesigner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(1, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(85, 327);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 1;
            label1.Text = "动画列表";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "无";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 14);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 3;
            label2.Text = "动画名称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 51);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 4;
            label3.Text = "动画帧";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(102, 72);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(107, 293);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(99, 372);
            button1.Name = "button1";
            button1.Size = new Size(110, 27);
            button1.TabIndex = 6;
            button1.Text = "新建帧";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 378);
            button2.Name = "button2";
            button2.Size = new Size(300, 36);
            button2.TabIndex = 7;
            button2.Text = "保存动画数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(540, 72);
            button3.Name = "button3";
            button3.Size = new Size(67, 82);
            button3.TabIndex = 9;
            button3.Text = "设置当前帧动画";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(540, 289);
            button4.Name = "button4";
            button4.Size = new Size(67, 83);
            button4.TabIndex = 10;
            button4.Text = "播放动画";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 14);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 11;
            label4.Text = "SE文件名：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 14);
            label5.Name = "label5";
            label5.Size = new Size(22, 17);
            label5.TabIndex = 12;
            label5.Text = "SE";
            // 
            // button5
            // 
            button5.Location = new Point(468, 10);
            button5.Name = "button5";
            button5.Size = new Size(30, 21);
            button5.TabIndex = 13;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 41);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 14;
            label6.Text = "SE播放于";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(363, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 23);
            textBox2.TabIndex = 15;
            textBox2.Text = "0";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 41);
            label7.Name = "label7";
            label7.Size = new Size(20, 17);
            label7.TabIndex = 16;
            label7.Text = "帧";
            // 
            // button6
            // 
            button6.Location = new Point(1, 372);
            button6.Name = "button6";
            button6.Size = new Size(85, 27);
            button6.TabIndex = 17;
            button6.Text = "新建空动画";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(99, 405);
            button7.Name = "button7";
            button7.Size = new Size(110, 27);
            button7.TabIndex = 18;
            button7.Text = "删除帧";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1, 405);
            button8.Name = "button8";
            button8.Size = new Size(85, 27);
            button8.TabIndex = 19;
            button8.Text = "删除该动画";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(620, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "动画编辑器";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Button button5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}