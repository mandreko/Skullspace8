namespace Skullspace8
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
            this.skullspaceWebBrowser = new System.Windows.Forms.WebBrowser();
            this.sequenceNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skullspaceWebBrowser
            // 
            this.skullspaceWebBrowser.Location = new System.Drawing.Point(12, 12);
            this.skullspaceWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.skullspaceWebBrowser.Name = "skullspaceWebBrowser";
            this.skullspaceWebBrowser.Size = new System.Drawing.Size(784, 509);
            this.skullspaceWebBrowser.TabIndex = 0;
            this.skullspaceWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.skullspaceWebBrowser_DocumentCompleted);
            // 
            // sequenceNumberLabel
            // 
            this.sequenceNumberLabel.AutoSize = true;
            this.sequenceNumberLabel.Location = new System.Drawing.Point(26, 536);
            this.sequenceNumberLabel.Name = "sequenceNumberLabel";
            this.sequenceNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.sequenceNumberLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 578);
            this.Controls.Add(this.sequenceNumberLabel);
            this.Controls.Add(this.skullspaceWebBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser skullspaceWebBrowser;
        private System.Windows.Forms.Label sequenceNumberLabel;
    }
}

