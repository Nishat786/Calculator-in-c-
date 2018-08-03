namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.onebyx = new System.Windows.Forms.Button();
            this.xsquare = new System.Windows.Forms.Button();
            this.squareroot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // onebyx
            // 
            this.onebyx.Location = new System.Drawing.Point(110, 79);
            this.onebyx.Name = "onebyx";
            this.onebyx.Size = new System.Drawing.Size(39, 27);
            this.onebyx.TabIndex = 59;
            this.onebyx.Text = "1/X";
            this.onebyx.UseVisualStyleBackColor = true;
            this.onebyx.Click += new System.EventHandler(this.onebyx_Click);
            // 
            // xsquare
            // 
            this.xsquare.Location = new System.Drawing.Point(62, 79);
            this.xsquare.Name = "xsquare";
            this.xsquare.Size = new System.Drawing.Size(40, 27);
            this.xsquare.TabIndex = 58;
            this.xsquare.Text = "X^2";
            this.xsquare.UseVisualStyleBackColor = true;
            this.xsquare.Click += new System.EventHandler(this.xsquare_Click);
            // 
            // squareroot
            // 
            this.squareroot.Location = new System.Drawing.Point(14, 79);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(36, 24);
            this.squareroot.TabIndex = 57;
            this.squareroot.Text = "_/";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.squareroot_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.equals.Location = new System.Drawing.Point(178, 227);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(54, 30);
            this.equals.TabIndex = 56;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.add.Location = new System.Drawing.Point(178, 189);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(54, 32);
            this.add.TabIndex = 55;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.subtract.Location = new System.Drawing.Point(178, 153);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(54, 30);
            this.subtract.TabIndex = 54;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.multiply.Location = new System.Drawing.Point(178, 116);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(54, 31);
            this.multiply.TabIndex = 53;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.divide.Location = new System.Drawing.Point(178, 79);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(54, 31);
            this.divide.TabIndex = 52;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.clear.Location = new System.Drawing.Point(178, 42);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(54, 31);
            this.clear.TabIndex = 51;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(108, 226);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(41, 31);
            this.dot.TabIndex = 50;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // plusminus
            // 
            this.plusminus.Location = new System.Drawing.Point(14, 226);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(41, 31);
            this.plusminus.TabIndex = 49;
            this.plusminus.Text = "+/-";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(61, 226);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(41, 31);
            this.zero.TabIndex = 48;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(108, 189);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(41, 31);
            this.three.TabIndex = 47;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(63, 189);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(41, 31);
            this.two.TabIndex = 46;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(14, 189);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(41, 31);
            this.one.TabIndex = 45;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(108, 152);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 31);
            this.six.TabIndex = 44;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(61, 152);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(41, 31);
            this.five.TabIndex = 43;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(14, 152);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(41, 31);
            this.four.TabIndex = 42;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(108, 115);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(41, 31);
            this.nine.TabIndex = 41;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(61, 115);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(41, 31);
            this.eight.TabIndex = 40;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 115);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(41, 31);
            this.seven.TabIndex = 39;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 42);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(135, 20);
            this.output.TabIndex = 38;
            this.output.Text = "0.";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardToolStripMenuItem.Text = "Standard ";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scientificToolStripMenuItem.Text = "Scientific ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help ";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me!";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 274);
            this.Controls.Add(this.onebyx);
            this.Controls.Add(this.xsquare);
            this.Controls.Add(this.squareroot);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.output);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Scientific Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onebyx;
        private System.Windows.Forms.Button xsquare;
        private System.Windows.Forms.Button squareroot;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
    }
}