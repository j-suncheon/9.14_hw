namespace _9._14_hw
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Sh = new System.Windows.Forms.Label();
            this.label_In = new System.Windows.Forms.Label();
            this.label_Do = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label_Sh
            // 
            this.label_Sh.AutoSize = true;
            this.label_Sh.Location = new System.Drawing.Point(242, 143);
            this.label_Sh.Name = "label_Sh";
            this.label_Sh.Size = new System.Drawing.Size(17, 20);
            this.label_Sh.TabIndex = 5;
            this.label_Sh.Text = "0";
            // 
            // label_In
            // 
            this.label_In.AutoSize = true;
            this.label_In.Location = new System.Drawing.Point(242, 188);
            this.label_In.Name = "label_In";
            this.label_In.Size = new System.Drawing.Size(17, 20);
            this.label_In.TabIndex = 6;
            this.label_In.Text = "0";
            // 
            // label_Do
            // 
            this.label_Do.AutoSize = true;
            this.label_Do.Location = new System.Drawing.Point(242, 234);
            this.label_Do.Name = "label_Do";
            this.label_Do.Size = new System.Drawing.Size(17, 20);
            this.label_Do.TabIndex = 7;
            this.label_Do.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Short 변환";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Int 변환";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Double 변환";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_Do);
            this.Controls.Add(this.label_In);
            this.Controls.Add(this.label_Sh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_Sh;
        private Label label_In;
        private Label label_Do;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}