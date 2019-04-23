namespace ArrayOfStudentsKyleJanka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameTxt = new System.Windows.Forms.TextBox();
            this.studentGradeTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ArrayBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arrayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Grade (As a number 99 = 99%)";
            // 
            // studentNameTxt
            // 
            this.studentNameTxt.Location = new System.Drawing.Point(28, 54);
            this.studentNameTxt.Name = "studentNameTxt";
            this.studentNameTxt.Size = new System.Drawing.Size(145, 22);
            this.studentNameTxt.TabIndex = 2;
            // 
            // studentGradeTxt
            // 
            this.studentGradeTxt.Location = new System.Drawing.Point(28, 130);
            this.studentGradeTxt.Name = "studentGradeTxt";
            this.studentGradeTxt.Size = new System.Drawing.Size(145, 22);
            this.studentGradeTxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Student Grades to List (MAX 5)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArrayBtn
            // 
            this.ArrayBtn.Location = new System.Drawing.Point(40, 271);
            this.ArrayBtn.Name = "ArrayBtn";
            this.ArrayBtn.Size = new System.Drawing.Size(287, 29);
            this.ArrayBtn.TabIndex = 5;
            this.ArrayBtn.Text = "Display Grades and Calculated Average";
            this.ArrayBtn.UseVisualStyleBackColor = true;
            this.ArrayBtn.Click += new System.EventHandler(this.ArrayBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(40, 521);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(287, 33);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear All";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "...........................................................................";
            // 
            // arrayLabel
            // 
            this.arrayLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.arrayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrayLabel.Location = new System.Drawing.Point(28, 333);
            this.arrayLabel.Name = "arrayLabel";
            this.arrayLabel.Size = new System.Drawing.Size(430, 166);
            this.arrayLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 584);
            this.Controls.Add(this.arrayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ArrayBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentGradeTxt);
            this.Controls.Add(this.studentNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameTxt;
        private System.Windows.Forms.TextBox studentGradeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ArrayBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arrayLabel;
    }
}

