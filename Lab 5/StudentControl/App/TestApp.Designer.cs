namespace NewTestApp
{
    partial class TestApp
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
            this.studentInfo1 = new MyControlsLibrary.StudentInfo();
            this.btnPrintUserDetails = new System.Windows.Forms.Button();
            this.txtResponses = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.studentInfo2 = new MyControlsLibrary.StudentInfo();
            this.studentInfo3 = new MyControlsLibrary.StudentInfo();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to App-1";
            // 
            // studentInfo1
            // 
            this.studentInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfo1.Location = new System.Drawing.Point(12, 55);
            this.studentInfo1.Name = "studentInfo1";
            this.studentInfo1.Size = new System.Drawing.Size(358, 294);
            this.studentInfo1.TabIndex = 1;
            // 
            // btnPrintUserDetails
            // 
            this.btnPrintUserDetails.Location = new System.Drawing.Point(651, 100);
            this.btnPrintUserDetails.Name = "btnPrintUserDetails";
            this.btnPrintUserDetails.Size = new System.Drawing.Size(137, 74);
            this.btnPrintUserDetails.TabIndex = 2;
            this.btnPrintUserDetails.Text = "Print Student 1 Details";
            this.btnPrintUserDetails.UseVisualStyleBackColor = true;
            this.btnPrintUserDetails.Click += new System.EventHandler(this.btnPrintUserDetails_Click);
            // 
            // txtResponses
            // 
            this.txtResponses.Location = new System.Drawing.Point(376, 180);
            this.txtResponses.Multiline = true;
            this.txtResponses.Name = "txtResponses";
            this.txtResponses.Size = new System.Drawing.Size(412, 169);
            this.txtResponses.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print Student 2 Details ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentInfo2
            // 
            this.studentInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfo2.Location = new System.Drawing.Point(12, 365);
            this.studentInfo2.Name = "studentInfo2";
            this.studentInfo2.Size = new System.Drawing.Size(358, 294);
            this.studentInfo2.TabIndex = 5;
            // 
            // studentInfo3
            // 
            this.studentInfo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfo3.Location = new System.Drawing.Point(388, 365);
            this.studentInfo3.Name = "studentInfo3";
            this.studentInfo3.Size = new System.Drawing.Size(358, 294);
            this.studentInfo3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 74);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print Student 3 Details ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.studentInfo3);
            this.Controls.Add(this.studentInfo2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResponses);
            this.Controls.Add(this.btnPrintUserDetails);
            this.Controls.Add(this.studentInfo1);
            this.Controls.Add(this.label1);
            this.Name = "TestApp";
            this.Text = "Custom Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyControlsLibrary.StudentInfo studentInfo1;
        private System.Windows.Forms.Button btnPrintUserDetails;
        private System.Windows.Forms.TextBox txtResponses;
        private System.Windows.Forms.Button button1;
        private MyControlsLibrary.StudentInfo studentInfo2;
        private MyControlsLibrary.StudentInfo studentInfo3;
        private System.Windows.Forms.Button button2;
    }
}

