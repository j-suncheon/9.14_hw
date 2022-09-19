namespace _9._14_hw
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5,
            this.C6,
            this.C7});
            this.dataGridView1.Location = new System.Drawing.Point(39, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(547, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // C1
            // 
            this.C1.HeaderText = "월";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.Width = 70;
            // 
            // C2
            // 
            this.C2.HeaderText = "화";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.Width = 70;
            // 
            // C3
            // 
            this.C3.HeaderText = "수";
            this.C3.MinimumWidth = 6;
            this.C3.Name = "C3";
            this.C3.Width = 70;
            // 
            // C4
            // 
            this.C4.HeaderText = "목";
            this.C4.MinimumWidth = 6;
            this.C4.Name = "C4";
            this.C4.Width = 70;
            // 
            // C5
            // 
            this.C5.HeaderText = "금";
            this.C5.MinimumWidth = 6;
            this.C5.Name = "C5";
            this.C5.Width = 70;
            // 
            // C6
            // 
            this.C6.HeaderText = "토";
            this.C6.MinimumWidth = 6;
            this.C6.Name = "C6";
            this.C6.Width = 70;
            // 
            // C7
            // 
            this.C7.HeaderText = "일";
            this.C7.MinimumWidth = 6;
            this.C7.Name = "C7";
            this.C7.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "일주일간";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "이주일간";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
        private DataGridViewTextBoxColumn C3;
        private DataGridViewTextBoxColumn C4;
        private DataGridViewTextBoxColumn C5;
        private DataGridViewTextBoxColumn C6;
        private DataGridViewTextBoxColumn C7;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}