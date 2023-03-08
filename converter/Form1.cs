using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.PowerPoint;

namespace converter
{
    public partial class converter : Form
    {
        public converter()
        {
            InitializeComponent();
        }

        private void converter_Load(object sender, EventArgs e)
        {
            tbxfrom.Enabled = true;
            tbxto.Enabled = false;
        }

        private void Drag_Enter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        BackgroundWorker bw;

        private void Drag_Drop(object sender, DragEventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => TaskAsync(1, e);
            bw.RunWorkerAsync();
        }

        private async void TaskAsync(int times, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
            {
                //MessageBox.Show(s[i]);
                DirectoryInfo d = new DirectoryInfo(s[i]);
                FileInfo[] files = d.GetFiles($"*{tbxfrom.Text}");
                foreach (FileInfo fi in files)
                {
                    //string file = Convert.ToString(fi.FullName);
                    string destfile = fi.FullName + tbxto.Text;
                    //MessageBox.Show($"File: {fi.FullName}\nDest: {destfile}");
                    if (tbxfrom.Text == ".docx")
                    {
                        docx2pdf(fi.FullName, destfile, WdSaveFormat.wdFormatPDF);
                    }
                    else if (tbxfrom.Text == ".xlsx")
                    {
                        excel2pdf(fi.FullName, destfile);
                    }
                    else if (tbxfrom.Text == ".pptx")
                    {
                        ppt2pdf(fi.FullName, destfile);
                    }

                    //Console.ReadKey();
                }
            }
            notifyIcon1.Icon = SystemIcons.Shield;
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipText = "Convertion complete...";
            notifyIcon1.ShowBalloonTip(10000);
        }

        public static void docx2pdf(string input, string output, WdSaveFormat format)
        {
            // Create an instance of Word.exe
            Microsoft.Office.Interop.Word._Application oWord = new Word.Application
            {

                // Make this instance of word invisible (Can still see it in the taskmgr).
                Visible = false
            };

            // Interop requires objects.
            object oMissing = System.Reflection.Missing.Value;
            object isVisible = true;
            object readOnly = true;     // Does not cause any word dialog to show up
            //object readOnly = false;  // Causes a word object dialog to show at the end of the conversion
            object oInput = input;
            object oOutput = output;
            object oFormat = format;

            // Load a document into our instance of word.exe
            _Document oDoc = oWord.Documents.Open(
                ref oInput, ref oMissing, ref readOnly, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref isVisible, ref oMissing, ref oMissing, ref oMissing, ref oMissing
                );

            // Make this document the active document.
            oDoc.Activate();

            // Save this document using Word
            oDoc.SaveAs(ref oOutput, ref oFormat, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing
                );

            // Always close Word.exe.
            oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
        }

        public static void excel2pdf(string input, string output)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(input);
            excelWorkbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, output);
            excelWorkbook.Close();
            excelApp.Quit();
        }

        public static void ppt2pdf(string input, string output)
        {
            Microsoft.Office.Interop.PowerPoint.Application pptApp = new Microsoft.Office.Interop.PowerPoint.Application();
            Microsoft.Office.Interop.PowerPoint.Presentation pptPresentation = pptApp.Presentations.Open(input);
            pptPresentation.ExportAsFixedFormat(output, PpFixedFormatType.ppFixedFormatTypePDF);
            pptPresentation.Close();
            pptApp.Quit();
        }
    }
}
