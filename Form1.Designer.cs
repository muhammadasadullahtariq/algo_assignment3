namespace algoAssignment3
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
            this.matchWholeWordCheBox = new System.Windows.Forms.CheckBox();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.canclebtn = new System.Windows.Forms.Button();
            this.matchCaseCheBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findWhattextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchWholeWordCheBox
            // 
            this.matchWholeWordCheBox.AutoSize = true;
            this.matchWholeWordCheBox.Location = new System.Drawing.Point(108, 113);
            this.matchWholeWordCheBox.Name = "matchWholeWordCheBox";
            this.matchWholeWordCheBox.Size = new System.Drawing.Size(135, 17);
            this.matchWholeWordCheBox.TabIndex = 0;
            this.matchWholeWordCheBox.Text = "Matc Whole Word only";
            this.matchWholeWordCheBox.UseVisualStyleBackColor = true;
            this.matchWholeWordCheBox.CheckedChanged += new System.EventHandler(this.matchWholeWordCheBox_CheckedChanged);
            // 
            // findNextBtn
            // 
            this.findNextBtn.Location = new System.Drawing.Point(498, 47);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(75, 23);
            this.findNextBtn.TabIndex = 1;
            this.findNextBtn.Text = "Find Next";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // canclebtn
            // 
            this.canclebtn.Location = new System.Drawing.Point(498, 109);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(75, 23);
            this.canclebtn.TabIndex = 2;
            this.canclebtn.Text = "Cancel";
            this.canclebtn.UseVisualStyleBackColor = true;
            this.canclebtn.Click += new System.EventHandler(this.canclebtn_Click);
            // 
            // matchCaseCheBox
            // 
            this.matchCaseCheBox.AutoSize = true;
            this.matchCaseCheBox.Location = new System.Drawing.Point(108, 153);
            this.matchCaseCheBox.Name = "matchCaseCheBox";
            this.matchCaseCheBox.Size = new System.Drawing.Size(83, 17);
            this.matchCaseCheBox.TabIndex = 3;
            this.matchCaseCheBox.Text = "Match Case";
            this.matchCaseCheBox.UseVisualStyleBackColor = true;
            this.matchCaseCheBox.CheckedChanged += new System.EventHandler(this.matchCaseCheBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find What:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // findWhattextBox
            // 
            this.findWhattextBox.Location = new System.Drawing.Point(108, 49);
            this.findWhattextBox.Name = "findWhattextBox";
            this.findWhattextBox.Size = new System.Drawing.Size(351, 20);
            this.findWhattextBox.TabIndex = 5;
            this.findWhattextBox.TextChanged += new System.EventHandler(this.findWhattextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findWhattextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchCaseCheBox);
            this.Controls.Add(this.canclebtn);
            this.Controls.Add(this.findNextBtn);
            this.Controls.Add(this.matchWholeWordCheBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox matchWholeWordCheBox;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.CheckBox matchCaseCheBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findWhattextBox;
        private System.Windows.Forms.Button button1;
    }
}

