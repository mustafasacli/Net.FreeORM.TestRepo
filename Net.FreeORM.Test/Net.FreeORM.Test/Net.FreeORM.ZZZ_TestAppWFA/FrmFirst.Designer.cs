namespace Net.FreeORM.ZZZ_TestAppWFA
{
    partial class FrmFirst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdFree = new Net.FreeORM.Windows.GridControl.FreeGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdFree)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFree
            // 
            this.grdFree.AllowUserToAddRows = false;
            this.grdFree.AllowUserToDeleteRows = false;
            this.grdFree.AllowUserToResizeColumns = false;
            this.grdFree.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdFree.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFree.ColumnHeaderDeLimiter = '-';
            this.grdFree.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdFree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdFree.ColumnHeaderTextList = "";
            this.grdFree.ColumnInVisibilityString = "[i]";
            this.grdFree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFree.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdFree.Location = new System.Drawing.Point(0, 0);
            this.grdFree.Name = "grdFree";
            this.grdFree.ReadOnly = true;
            this.grdFree.RowHeadersVisible = false;
            this.grdFree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFree.Size = new System.Drawing.Size(559, 388);
            this.grdFree.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 388);
            this.Controls.Add(this.grdFree);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdFree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Net.FreeORM.Windows.GridControl.FreeGridView grdFree;
    }
}

