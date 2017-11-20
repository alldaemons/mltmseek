using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MLProfileSeek
{
        partial class Form1 : Form
        {
                WordExtractor we = new WordExtractor();
                TextStatistics ts = new TextStatistics();

                public Form1()
                {
                        InitializeComponent();
                }

                private void learnButton_Click(object sender, EventArgs e)
                {
                        if (this.openTextFileDialog.ShowDialog() == DialogResult.OK)
                        {
                                this.we.Clear();
                                this.we.Worker = this.learnTextBackgroundWorker;
                                this.learnButton.Enabled = false;
                                this.stopLearnButton.Enabled = true;
                                //this.simulateButton.Enabled = false;
                                this.mainMenuStrip.Enabled = false;
                                this.learnTextBackgroundWorker.RunWorkerAsync(this.openTextFileDialog.FileNames);
                        }
                }

                //Learn text background worker
                private void learnTextBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
                {
                        Trace.WriteLine("learn text...");
                        String[] fileNames = (String[])e.Argument;
                        foreach (String fileName in fileNames)
                        {
                                if (this.we.Extract(fileName) < 0)
                                        MessageBox.Show(this.we.Error, "Error");
                        }
                        Trace.WriteLine("extract statistics...");
                        if (this.ts.Calculate(we) < 0)
                                MessageBox.Show(this.ts.Error, "Error");                                                                        
                }

                private void learnTextBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
                {
                        this.progressLabel.Text = e.UserState.ToString();
                }

                private void learnTextBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
                {
                        Trace.WriteLine("...finished");
                        this.learnButton.Enabled = true;
                        this.stopLearnButton.Enabled = false;
                        //this.simulateButton.Enabled = true;
                        this.mainMenuStrip.Enabled = true;
                }
                //Learn text background worker

                private void stopLearnButton_Click(object sender, EventArgs e)
                {
                        if (this.learnTextBackgroundWorker.IsBusy == true)
                        {
                                Trace.WriteLine("cancel worker");
                                this.learnTextBackgroundWorker.CancelAsync();                        
                        }
                }

                private void saveDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        if (this.we.Dictionary.Count > 0 &&
                            this.saveDictionaryDialog.ShowDialog() == DialogResult.OK)
                        {
                                if (this.we.SaveDictionary(this.saveDictionaryDialog.FileName) < 0)
                                        MessageBox.Show(we.Error, "Error");

                                String statsFileName = Path.GetFileNameWithoutExtension(this.saveDictionaryDialog.FileName);
                                statsFileName += "_stats." + this.saveDictionaryDialog.DefaultExt;                                
                                if (this.ts.SaveDictionary(statsFileName) < 0)
                                        MessageBox.Show(we.Error, "Error");

                                statsFileName = Path.GetFileNameWithoutExtension(this.saveDictionaryDialog.FileName);
                                statsFileName += "_caps." + this.saveDictionaryDialog.DefaultExt;
                                if (this.ts.SaveCapitalWords(statsFileName) < 0)
                                        MessageBox.Show(we.Error, "Error");
                        }
                }

                private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        if (this.we.Text.Count > 0 &&
                            this.saveTextDialog.ShowDialog() == DialogResult.OK)
                        {                                
                                if (this.we.SaveText(this.saveTextDialog.FileName) < 0)
                                        MessageBox.Show(we.Error, "Error");                                
                        }
                }

                private void simulateButton_Click(object sender, EventArgs e)
                {
                        try
                        {
                                this.simulationTextBox.Text = String.Empty;

                                if (this.ts.Stats.Count == 0)
                                        throw new Exception("No statistics have been learned yet");

                                //this.ts.MaxWordsPerSentence = Convert.ToInt32(maxWordsPerSentenceTextBox.Text);

                                String[] simulation = null;
                                //if (this.ts.Simulate(Convert.ToInt32(this.sentencesNumberTextBox.Text), out simulation) < 0)
                                //        throw new Exception(this.ts.Error);

                                this.simulationTextBox.Lines = simulation;
                        }
                        catch (Exception ee)
                        {
                                this.simulationTextBox.Text = ee.Message;
                        }                        
                }                                        
                

        }
}
