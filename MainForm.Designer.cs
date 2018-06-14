namespace AccessControlDemo
{
    partial class MainForm
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
            this.showAceInformationbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aceInformationTextBox = new System.Windows.Forms.TextBox();
            this.addSelfToAclButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAceInformationbutton
            // 
            this.showAceInformationbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAceInformationbutton.Location = new System.Drawing.Point(398, 57);
            this.showAceInformationbutton.Name = "showAceInformationbutton";
            this.showAceInformationbutton.Size = new System.Drawing.Size(100, 23);
            this.showAceInformationbutton.TabIndex = 4;
            this.showAceInformationbutton.Text = "&Show ACEs";
            this.showAceInformationbutton.UseVisualStyleBackColor = true;
            this.showAceInformationbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Filename:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameTextBox.Location = new System.Drawing.Point(12, 30);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(376, 20);
            this.filenameTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(398, 28);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseFileDialog
            // 
            this.browseFileDialog.Filter = "All Files (*.*)|*.*";
            this.browseFileDialog.Title = "Browse File";
            // 
            // aceInformationTextBox
            // 
            this.aceInformationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aceInformationTextBox.Location = new System.Drawing.Point(12, 57);
            this.aceInformationTextBox.Multiline = true;
            this.aceInformationTextBox.Name = "aceInformationTextBox";
            this.aceInformationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aceInformationTextBox.Size = new System.Drawing.Size(376, 239);
            this.aceInformationTextBox.TabIndex = 3;
            // 
            // addSelfToAclButton
            // 
            this.addSelfToAclButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSelfToAclButton.Location = new System.Drawing.Point(394, 115);
            this.addSelfToAclButton.Name = "addSelfToAclButton";
            this.addSelfToAclButton.Size = new System.Drawing.Size(100, 23);
            this.addSelfToAclButton.TabIndex = 5;
            this.addSelfToAclButton.Text = "&Add Self to ACL";
            this.addSelfToAclButton.UseVisualStyleBackColor = true;
            this.addSelfToAclButton.Click += new System.EventHandler(this.addSelfToAclButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Write FullControl";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addSelfToAclButton);
            this.Controls.Add(this.aceInformationTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAceInformationbutton);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Text = "Access Control in .NET Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAceInformationbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog browseFileDialog;
        private System.Windows.Forms.TextBox aceInformationTextBox;
        private System.Windows.Forms.Button addSelfToAclButton;
        private System.Windows.Forms.Button button1;
    }
}

