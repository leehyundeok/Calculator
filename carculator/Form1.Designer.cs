namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Numbtn1 = new System.Windows.Forms.Button();
            this.Numbtn2 = new System.Windows.Forms.Button();
            this.NumText = new System.Windows.Forms.Label();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.MultipleBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.SetText = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numbtn1
            // 
            this.Numbtn1.Location = new System.Drawing.Point(35, 117);
            this.Numbtn1.Name = "Numbtn1";
            this.Numbtn1.Size = new System.Drawing.Size(68, 56);
            this.Numbtn1.TabIndex = 0;
            this.Numbtn1.Text = "7";
            this.Numbtn1.UseVisualStyleBackColor = true;
            this.Numbtn1.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // Numbtn2
            // 
            this.Numbtn2.Location = new System.Drawing.Point(109, 117);
            this.Numbtn2.Name = "Numbtn2";
            this.Numbtn2.Size = new System.Drawing.Size(68, 56);
            this.Numbtn2.TabIndex = 1;
            this.Numbtn2.Text = "8";
            this.Numbtn2.UseVisualStyleBackColor = true;
            this.Numbtn2.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // NumText
            // 
            this.NumText.BackColor = System.Drawing.Color.White;
            this.NumText.Location = new System.Drawing.Point(22, 59);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(303, 32);
            this.NumText.TabIndex = 2;
            this.NumText.Text = "0";
            this.NumText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(266, 241);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(59, 56);
            this.PlusBtn.TabIndex = 3;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 56);
            this.button3.TabIndex = 6;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 56);
            this.button4.TabIndex = 7;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 56);
            this.button5.TabIndex = 8;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(110, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 56);
            this.button6.TabIndex = 9;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(184, 241);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 56);
            this.button7.TabIndex = 10;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numbtn1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(110, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 56);
            this.button8.TabIndex = 11;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(184, 303);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(68, 56);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "c";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Location = new System.Drawing.Point(267, 180);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(59, 56);
            this.DivideBtn.TabIndex = 13;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MultipleBtn
            // 
            this.MultipleBtn.Location = new System.Drawing.Point(267, 118);
            this.MultipleBtn.Name = "MultipleBtn";
            this.MultipleBtn.Size = new System.Drawing.Size(59, 56);
            this.MultipleBtn.TabIndex = 14;
            this.MultipleBtn.Text = "*";
            this.MultipleBtn.UseVisualStyleBackColor = true;
            this.MultipleBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(267, 304);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(59, 56);
            this.MinusBtn.TabIndex = 15;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // SetText
            // 
            this.SetText.BackColor = System.Drawing.Color.White;
            this.SetText.Location = new System.Drawing.Point(22, 9);
            this.SetText.Name = "SetText";
            this.SetText.Size = new System.Drawing.Size(300, 39);
            this.SetText.TabIndex = 16;
            this.SetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(36, 303);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 56);
            this.button9.TabIndex = 17;
            this.button9.Text = "=";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.SetText);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MultipleBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.Numbtn2);
            this.Controls.Add(this.Numbtn1);
            this.Name = "Form1";
            this.Text = "a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Numbtn1;
        private System.Windows.Forms.Button Numbtn2;
        private System.Windows.Forms.Label NumText;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button MultipleBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Label SetText;
        private System.Windows.Forms.Button button9;
    }
}

