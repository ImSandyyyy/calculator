namespace calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultbox = new System.Windows.Forms.RichTextBox();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultbox
            // 
            this.resultbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultbox.Location = new System.Drawing.Point(12, 23);
            this.resultbox.Name = "resultbox";
            this.resultbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultbox.Size = new System.Drawing.Size(434, 96);
            this.resultbox.TabIndex = 0;
            this.resultbox.Text = "";
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(24, 198);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 36);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zeroBtn);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(137, 198);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 36);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.onebtn);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(257, 198);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 36);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.twobtn);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(360, 198);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 36);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.threebtn);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(24, 263);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 34);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.fourbtn);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(137, 263);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 34);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.fivebtn);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(257, 263);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 34);
            this.six.TabIndex = 1;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.sixBtn_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(360, 263);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 34);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.sevenBtn_click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(24, 326);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 33);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eightBtn_click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(137, 326);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 33);
            this.nine.TabIndex = 1;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.ninebtn_click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(257, 326);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 33);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.addbtn_click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(360, 326);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 33);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minusBtn_click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(24, 387);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 33);
            this.mult.TabIndex = 1;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.multiplyBtn_click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(137, 387);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 33);
            this.divide.TabIndex = 1;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divisionBtn_click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(257, 387);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(166, 33);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equalto_click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(24, 448);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(90, 33);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.cleanBtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Made in Ohio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.resultbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultbox;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label1;
    }
}

