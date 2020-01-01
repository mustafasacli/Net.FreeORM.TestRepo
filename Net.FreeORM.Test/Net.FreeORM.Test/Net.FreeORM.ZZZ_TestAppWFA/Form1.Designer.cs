namespace Net.FreeORM.ZZZ_TestAppWFA
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
            this.spnrHour = new Net.FreeORM.Windows.SpannerControl.FreeSpanner();
            this.freeSpanner2 = new Net.FreeORM.Windows.SpannerControl.FreeSpanner();
            this.lblT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spnrHour
            // 
            this.spnrHour.Location = new System.Drawing.Point(94, 98);
            this.spnrHour.MaximumSize = new System.Drawing.Size(100, 20);
            this.spnrHour.MaxValue = 23;
            this.spnrHour.MinimumSize = new System.Drawing.Size(20, 20);
            this.spnrHour.MinValue = 0;
            this.spnrHour.Name = "spnrHour";
            this.spnrHour.Size = new System.Drawing.Size(20, 20);
            this.spnrHour.TabIndex = 0;
            this.spnrHour.Text = "0";
            this.spnrHour.Value = 0;
            // 
            // freeSpanner2
            // 
            this.freeSpanner2.Location = new System.Drawing.Point(133, 98);
            this.freeSpanner2.MaximumSize = new System.Drawing.Size(100, 20);
            this.freeSpanner2.MaxValue = 59;
            this.freeSpanner2.MinimumSize = new System.Drawing.Size(20, 20);
            this.freeSpanner2.MinValue = 0;
            this.freeSpanner2.Name = "freeSpanner2";
            this.freeSpanner2.Size = new System.Drawing.Size(20, 20);
            this.freeSpanner2.TabIndex = 1;
            this.freeSpanner2.Text = "0";
            this.freeSpanner2.Value = 0;
            // 
            // lblT
            // 
            this.lblT.Location = new System.Drawing.Point(116, 100);
            this.lblT.MaximumSize = new System.Drawing.Size(15, 15);
            this.lblT.MinimumSize = new System.Drawing.Size(15, 15);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(15, 15);
            this.lblT.TabIndex = 2;
            this.lblT.Text = ":";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.freeSpanner2);
            this.Controls.Add(this.spnrHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.SpannerControl.FreeSpanner spnrHour;
        private Windows.SpannerControl.FreeSpanner freeSpanner2;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label2;


    }
}