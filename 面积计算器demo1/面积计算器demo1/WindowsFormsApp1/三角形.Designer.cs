namespace WindowsFormsApp1
{
    partial class 三角形
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
            this.button1 = new System.Windows.Forms.Button();
            this.bottom = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.unit2 = new System.Windows.Forms.ComboBox();
            this.unit1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(254, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bottom
            // 
            this.bottom.Location = new System.Drawing.Point(149, 85);
            this.bottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(76, 21);
            this.bottom.TabIndex = 1;
            this.bottom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(364, 85);
            this.height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(76, 21);
            this.height.TabIndex = 2;
            this.height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入三角形的底";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入三角形的高";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(237, 227);
            this.area.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(106, 21);
            this.area.TabIndex = 5;
            this.area.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // unit2
            // 
            this.unit2.FormattingEnabled = true;
            this.unit2.Items.AddRange(new object[] {
            "cm",
            "in"});
            this.unit2.Location = new System.Drawing.Point(445, 86);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(56, 20);
            this.unit2.TabIndex = 6;
            this.unit2.Text = "cm";
            // 
            // unit1
            // 
            this.unit1.FormattingEnabled = true;
            this.unit1.Items.AddRange(new object[] {
            "cm",
            "in"});
            this.unit1.Location = new System.Drawing.Point(230, 86);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(56, 20);
            this.unit1.TabIndex = 7;
            this.unit1.Text = "cm";
            this.unit1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "平方厘米";
            // 
            // 三角形
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "三角形";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bottom;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox area;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox unit2;
        private System.Windows.Forms.ComboBox unit1;
        private System.Windows.Forms.Label label3;
    }
}