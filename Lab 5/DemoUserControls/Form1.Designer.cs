namespace DemoUserControls
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
            this.userControl11 = new DemoUserControls.UserControl1();
            this.State = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 23);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(251, 40);
            this.userControl11.TabIndex = 0;
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(131, 70);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(75, 23);
            this.State.TabIndex = 1;
            this.State.Text = "button1";
            this.State.UseVisualStyleBackColor = true;
            this.State.Click += new System.EventHandler(this.State_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 112);
            this.Controls.Add(this.State);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button State;
    }
}

