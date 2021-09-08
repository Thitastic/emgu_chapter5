
namespace DemoFaceDetect
{
    partial class frmChap5
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuChap5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolColorDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRandomMaxtrix = new System.Windows.Forms.ToolStripMenuItem();
            this.toolGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.toolTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCrop = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBox.Location = new System.Drawing.Point(0, 24);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(303, 387);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // menuChap5
            // 
            this.menuChap5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolRandomMaxtrix,
            this.toolGrayscale});
            this.menuChap5.Name = "menuChap5";
            this.menuChap5.Size = new System.Drawing.Size(37, 20);
            this.menuChap5.Text = "File";
            // 
            // toolNew
            // 
            this.toolNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFromFile,
            this.toolColorDrawing});
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(180, 22);
            this.toolNew.Text = "New";
            // 
            // toolFromFile
            // 
            this.toolFromFile.Name = "toolFromFile";
            this.toolFromFile.Size = new System.Drawing.Size(150, 22);
            this.toolFromFile.Text = "From File";
            this.toolFromFile.Click += new System.EventHandler(this.toolFromFile_Click);
            // 
            // toolColorDrawing
            // 
            this.toolColorDrawing.Name = "toolColorDrawing";
            this.toolColorDrawing.Size = new System.Drawing.Size(150, 22);
            this.toolColorDrawing.Text = "Color Drawing";
            this.toolColorDrawing.Click += new System.EventHandler(this.toolColorDrawing_Click);
            // 
            // toolRandomMaxtrix
            // 
            this.toolRandomMaxtrix.Name = "toolRandomMaxtrix";
            this.toolRandomMaxtrix.Size = new System.Drawing.Size(180, 22);
            this.toolRandomMaxtrix.Text = "Random Matrix";
            this.toolRandomMaxtrix.Click += new System.EventHandler(this.toolRandomMaxtrix_Click);
            // 
            // toolGrayscale
            // 
            this.toolGrayscale.Name = "toolGrayscale";
            this.toolGrayscale.Size = new System.Drawing.Size(180, 22);
            this.toolGrayscale.Text = "Grayscale";
            this.toolGrayscale.Click += new System.EventHandler(this.toolGrayscale_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChap5,
            this.toolTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picResult
            // 
            this.picResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.picResult.Location = new System.Drawing.Point(299, 24);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(285, 387);
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // toolTools
            // 
            this.toolTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCrop});
            this.toolTools.Name = "toolTools";
            this.toolTools.Size = new System.Drawing.Size(46, 20);
            this.toolTools.Text = "Tools";
            // 
            // toolCrop
            // 
            this.toolCrop.Name = "toolCrop";
            this.toolCrop.Size = new System.Drawing.Size(180, 22);
            this.toolCrop.Text = "Crop";
            this.toolCrop.Click += new System.EventHandler(this.toolCrop_Click);
            // 
            // frmChap5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChap5";
            this.Text = "Chapter_5";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStripMenuItem menuChap5;
        private System.Windows.Forms.ToolStripMenuItem toolNew;
        private System.Windows.Forms.ToolStripMenuItem toolFromFile;
        private System.Windows.Forms.ToolStripMenuItem toolColorDrawing;
        private System.Windows.Forms.ToolStripMenuItem toolRandomMaxtrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolGrayscale;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.ToolStripMenuItem toolTools;
        private System.Windows.Forms.ToolStripMenuItem toolCrop;
    }
}