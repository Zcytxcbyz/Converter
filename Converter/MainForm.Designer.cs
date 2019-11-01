namespace Converter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_num = new System.Windows.Forms.ComboBox();
            this.comboBox_result = new System.Windows.Forms.ComboBox();
            this.label_num = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_num
            // 
            this.comboBox_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Items.AddRange(new object[] {
            "2进制",
            "8进制",
            "10进制",
            "16进制"});
            this.comboBox_num.Location = new System.Drawing.Point(177, 6);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(71, 20);
            this.comboBox_num.TabIndex = 0;
            // 
            // comboBox_result
            // 
            this.comboBox_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_result.FormattingEnabled = true;
            this.comboBox_result.Items.AddRange(new object[] {
            "2进制",
            "8进制",
            "10进制",
            "16进制"});
            this.comboBox_result.Location = new System.Drawing.Point(177, 33);
            this.comboBox_result.Name = "comboBox_result";
            this.comboBox_result.Size = new System.Drawing.Size(71, 20);
            this.comboBox_result.TabIndex = 1;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(12, 9);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(53, 12);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "转换数字";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(12, 36);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(53, 12);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "转换结果";
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(71, 6);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(100, 21);
            this.textBox_num.TabIndex = 4;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(71, 33);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 21);
            this.textBox_result.TabIndex = 5;
            // 
            // button_Main
            // 
            this.button_Main.Location = new System.Drawing.Point(96, 60);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(75, 23);
            this.button_Main.TabIndex = 6;
            this.button_Main.Text = "转换";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 94);
            this.Controls.Add(this.button_Main);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.comboBox_result);
            this.Controls.Add(this.comboBox_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "进制转换";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_num;
        private System.Windows.Forms.ComboBox comboBox_result;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_Main;
    }
}

