using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainPellet
{
    public partial class ScriptEditor : UserControl
    {
        public string scriptPath;
        private string priorText;
        private int priorLineCount;
        private bool scriptOverwriteAvailable = false;
        public ScriptEditor()
        {
            InitializeComponent();
        }
        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            ReadScript();
        }
        private void ReadScript()
        {
            scriptOverwriteAvailable = false;
            ScriptRTB.Clear();
            if (!File.Exists(scriptPath))
            {
                MessageBox.Show("Error: No Script File Found!");
                return;
            }
            StreamReader read = new StreamReader(scriptPath);
            ScriptRTB.Text = read.ReadToEnd();
            priorText = ScriptRTB.Text;
            read.Close();
            read.Dispose();

            CommentFilterText(TempRTB, ScriptRTB, true, 0);
            scriptOverwriteAvailable = true;

        }
        private void UpdateRTBText(object sender, EventArgs e)
        {
            if (scriptOverwriteAvailable)
            {
                scriptOverwriteAvailable = false;

                int curSemiCount = ScriptRTB.Text.Length - ScriptRTB.Text.Replace(";", "").Length;
                int prevSemiCount = priorText.Length - priorText.Replace(";", "").Length;
                int curLineCount =  (ScriptRTB.Rtf.Replace("\\par", "#####").Length) - ScriptRTB.Rtf.Length;
                if (curLineCount != priorLineCount) ScriptRTB.SelectionColor = ScriptRTB.ForeColor;

                if (curSemiCount != prevSemiCount || curLineCount != priorLineCount) CommentFilterText(TempRTB, ScriptRTB, false, (curLineCount - priorLineCount));
                priorText = ScriptRTB.Text;
                priorLineCount = curLineCount;

                if (Properties.Settings.Default.ScriptAutoSave) saveScript_Click(sender, e);
                scriptOverwriteAvailable = true;
            }
        }
        public void CommentFilterText(RichTextBox box, RichTextBox finalBox, bool initial, int lineDifference)
        {
            int start = finalBox.SelectionStart;
            int length = finalBox.SelectionLength;
            int lineCheckStart = finalBox.GetLineFromCharIndex(start) - 1;
            int lineCheckLength = 3;
            if (initial)
            {
                start = 0;
                length = finalBox.Text.Length;
                lineCheckLength = finalBox.Lines.Length;
            }

            if (lineDifference > 0)
            {
                lineCheckStart -= lineDifference;
                lineCheckLength += lineDifference;
            }

            if (lineCheckStart < 0) lineCheckStart = 0;
            if (lineCheckLength > finalBox.Lines.Length) lineCheckLength = finalBox.Lines.Length;

            string[] lines = finalBox.Lines;
            int lineCharStart = 0;
            for (int i = 0; i < lineCheckStart; i++)
            {
                lineCharStart += lines[i].Length + 1;
            }

            box.Clear();
            box.Rtf = finalBox.Rtf;
            int curChar = lineCharStart;
            saveScript.Focus();

            for (int i = lineCheckStart; i < lineCheckStart + lineCheckLength; i++)
            {
                if (i >= lines.Length || i < 0) continue;
                if (lines[i].Contains(";"))
                {
                    string[] lineHalves = lines[i].Split(";", 2);

                    box.Select(curChar, lineHalves[0].Length);
                    box.SelectionColor = box.ForeColor;
                    box.Select(curChar + lineHalves[0].Length, lineHalves[1].Length + 1);
                    box.SelectionColor = Color.FromArgb(90, 180, 75);
                }
                else
                {
                    box.Select(curChar, lines[i].Length);
                    box.SelectionColor = box.ForeColor;
                }
                curChar += lines[i].Length + 1;
            }

            finalBox.Rtf = box.Rtf;
            if (initial) length = 0;
            finalBox.Select(start, length);
            finalBox.Focus();
        }

        private void saveScript_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(scriptPath);
            try
            {
                string[] line = ScriptRTB.Lines;
                for (int i = 0; i < line.Length; i++)
                {
                    write.WriteLine(line[i]);
                }
            }
            catch
            {
                MessageBox.Show("Failed to save script to: " + Environment.NewLine + scriptPath);
            }
            write.Close();
            write.Dispose();
        }
    }
}
