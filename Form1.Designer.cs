namespace MLProfileSeek
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
            this.learnButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.learnTextBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.stopLearnButton = new System.Windows.Forms.Button();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDictionaryDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.simulationTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(16, 38);
            this.learnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(79, 28);
            this.learnButton.TabIndex = 0;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(103, 47);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(69, 17);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "Progress:";
            // 
            // learnTextBackgroundWorker
            // 
            this.learnTextBackgroundWorker.WorkerReportsProgress = true;
            this.learnTextBackgroundWorker.WorkerSupportsCancellation = true;
            this.learnTextBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.learnTextBackgroundWorker_DoWork);
            this.learnTextBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.learnTextBackgroundWorker_ProgressChanged);
            this.learnTextBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.learnTextBackgroundWorker_RunWorkerCompleted);
            // 
            // stopLearnButton
            // 
            this.stopLearnButton.Enabled = false;
            this.stopLearnButton.Location = new System.Drawing.Point(16, 74);
            this.stopLearnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopLearnButton.Name = "stopLearnButton";
            this.stopLearnButton.Size = new System.Drawing.Size(79, 28);
            this.stopLearnButton.TabIndex = 2;
            this.stopLearnButton.Text = "Stop";
            this.stopLearnButton.UseVisualStyleBackColor = true;
            this.stopLearnButton.Click += new System.EventHandler(this.stopLearnButton_Click);
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.Filter = "Text files|*.txt";
            this.openTextFileDialog.Multiselect = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(707, 28);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDictionaryToolStripMenuItem,
            this.saveTextToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDictionaryToolStripMenuItem
            // 
            this.saveDictionaryToolStripMenuItem.Name = "saveDictionaryToolStripMenuItem";
            this.saveDictionaryToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveDictionaryToolStripMenuItem.Text = "Save Dictionary";
            this.saveDictionaryToolStripMenuItem.Click += new System.EventHandler(this.saveDictionaryToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // saveDictionaryDialog
            // 
            this.saveDictionaryDialog.DefaultExt = "dict";
            this.saveDictionaryDialog.Filter = "Dictionaries|*.dict";
            // 
            // saveTextDialog
            // 
            this.saveTextDialog.DefaultExt = "txt";
            this.saveTextDialog.Filter = "Text files|*.txt";
            // 
            // simulationTextBox
            // 
            this.simulationTextBox.Location = new System.Drawing.Point(107, 66);
            this.simulationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simulationTextBox.MaxLength = 1048575;
            this.simulationTextBox.Multiline = true;
            this.simulationTextBox.Name = "simulationTextBox";
            this.simulationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.simulationTextBox.Size = new System.Drawing.Size(481, 314);
            this.simulationTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 396);
            this.Controls.Add(this.simulationTextBox);
            this.Controls.Add(this.stopLearnButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MLProfileSeek.";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Button learnButton;
                private System.Windows.Forms.Label progressLabel;
                private System.ComponentModel.BackgroundWorker learnTextBackgroundWorker;
                private System.Windows.Forms.Button stopLearnButton;
                private System.Windows.Forms.OpenFileDialog openTextFileDialog;
                private System.Windows.Forms.MenuStrip mainMenuStrip;
                private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem saveDictionaryToolStripMenuItem;
                private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
                private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
                private System.Windows.Forms.SaveFileDialog saveDictionaryDialog;
                private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
                private System.Windows.Forms.SaveFileDialog saveTextDialog;
                private System.Windows.Forms.TextBox simulationTextBox;
        }
}

