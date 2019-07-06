namespace DSM_Cheongjukje_POS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.macro1 = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.macro2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 598);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // macro1
            // 
            this.macro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macro1.Location = new System.Drawing.Point(103, 349);
            this.macro1.Name = "macro1";
            this.macro1.Size = new System.Drawing.Size(284, 119);
            this.macro1.TabIndex = 1;
            this.macro1.UseVisualStyleBackColor = true;
            this.macro1.Click += new System.EventHandler(this.Macro1_Click);
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(103, 474);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(284, 36);
            this.edit1.TabIndex = 2;
            this.edit1.Text = "수정";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.Edit1_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(103, 647);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(211, 36);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "초기화";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(393, 474);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(284, 36);
            this.edit2.TabIndex = 5;
            this.edit2.Text = "수정";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.Edit2_Click);
            // 
            // macro2
            // 
            this.macro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macro2.Location = new System.Drawing.Point(393, 349);
            this.macro2.Name = "macro2";
            this.macro2.Size = new System.Drawing.Size(284, 119);
            this.macro2.TabIndex = 4;
            this.macro2.UseVisualStyleBackColor = true;
            this.macro2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.macro2);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.macro1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DSM청죽제포스기2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button macro1;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button macro2;
    }
}

