using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNbuoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void weToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void weToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }


        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true; 
            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDialog.Color;
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(dlg.FileName);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null) 
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                
                if (richTextBox1.SelectionFont.Bold)
                {
                    newStyle &= ~FontStyle.Bold; 
                }
                else
                {
                    newStyle |= FontStyle.Bold; 
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Italic)
                {
                    newStyle &= ~FontStyle.Italic; 
                }
                else
                {
                    newStyle |= FontStyle.Italic; 
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Underline)
                {
                    newStyle &= ~FontStyle.Underline; 
                }
                else
                {
                    newStyle |= FontStyle.Underline; 
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void luuNoiDungVanBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(dlg.FileName);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(dlg.FileName);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem != null)
            {
                string fontName = toolStripComboBox1.SelectedItem.ToString();
                float fontSize = richTextBox1.Font.Size; 
                FontStyle fontStyle = richTextBox1.Font.Style;
                richTextBox1.Font = new Font(fontName, fontSize, fontStyle);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem != null)
            {
                float fontSize = float.Parse(toolStripComboBox2.SelectedItem.ToString());
                string fontName = richTextBox1.Font.FontFamily.Name; 
                FontStyle fontStyle = richTextBox1.Font.Style; 
                richTextBox1.Font = new Font(fontName, fontSize, fontStyle);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
