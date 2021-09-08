
namespace DemoFaceDetect
{
    partial class frmInput
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
            this.txtP1X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtP1Y = new System.Windows.Forms.TextBox();
            this.txtP2Y = new System.Windows.Forms.TextBox();
            this.txtP2X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtP1X
            // 
            this.txtP1X.Location = new System.Drawing.Point(106, 28);
            this.txtP1X.Name = "txtP1X";
            this.txtP1X.Size = new System.Drawing.Size(81, 20);
            this.txtP1X.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "P2:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(286, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtP1Y
            // 
            this.txtP1Y.Location = new System.Drawing.Point(204, 28);
            this.txtP1Y.Name = "txtP1Y";
            this.txtP1Y.Size = new System.Drawing.Size(81, 20);
            this.txtP1Y.TabIndex = 5;
            // 
            // txtP2Y
            // 
            this.txtP2Y.Location = new System.Drawing.Point(204, 75);
            this.txtP2Y.Name = "txtP2Y";
            this.txtP2Y.Size = new System.Drawing.Size(81, 20);
            this.txtP2Y.TabIndex = 6;
            // 
            // txtP2X
            // 
            this.txtP2X.Location = new System.Drawing.Point(106, 75);
            this.txtP2X.Name = "txtP2X";
            this.txtP2X.Size = new System.Drawing.Size(81, 20);
            this.txtP2X.TabIndex = 7;
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 154);
            this.ControlBox = false;
            this.Controls.Add(this.txtP2X);
            this.Controls.Add(this.txtP2Y);
            this.Controls.Add(this.txtP1Y);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP1X);
            this.MinimizeBox = false;
            this.Name = "frmInput";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "P1 & P2?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP1X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtP1Y;
        private System.Windows.Forms.TextBox txtP2Y;
        private System.Windows.Forms.TextBox txtP2X;
    }
}