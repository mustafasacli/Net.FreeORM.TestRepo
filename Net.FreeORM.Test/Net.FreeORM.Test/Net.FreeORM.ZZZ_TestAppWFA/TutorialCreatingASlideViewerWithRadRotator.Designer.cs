namespace Net.FreeORM.ZZZ_TestAppWFA
{
    partial class TutorialCreatingASlideViewerWithRadRotator
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
            this.radRotator1 = new Telerik.WinControls.UI.RadRotator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRotator1
            // 
            this.radRotator1.Location = new System.Drawing.Point(12, 12);
            this.radRotator1.Name = "radRotator1";
            this.radRotator1.Size = new System.Drawing.Size(742, 458);
            this.radRotator1.TabIndex = 0;
            this.radRotator1.Text = "radRotator1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(335, 479);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "radLabel1";
            // 
            // TutorialCreatingASlideViewerWithRadRotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 509);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radRotator1);
            this.Name = "TutorialCreatingASlideViewerWithRadRotator";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TutorialCreatingASlideViewerWithRadRotator";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TutorialCreatingASlideViewerWithRadRotator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRotator radRotator1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
