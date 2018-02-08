using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using tilecon;

namespace CharResizer
{
    public partial class Form1 : Form
    {
        private int multiplierFactor = 1;

        public Form1()
        {
            InitializeComponent();
            ChangeLang(Vocab.Lang.en);
        }

        private void TextSizeMultiplier_TextChanged(object sender, EventArgs e)
        {
            TextSizeMultiplier.Text = Regex.Replace(TextSizeMultiplier.Text, @"[^0-9]", "");

            if (TextSizeMultiplier.Text == "")
                TextSizeMultiplier.Text = "1";

            multiplierFactor = Int32.Parse(TextSizeMultiplier.Text);

            if (multiplierFactor == 0)
                multiplierFactor = 1;

            int size = 32 * multiplierFactor, w, h;

            if (CharTemplateCheck.Checked)
            {
                w = Resizer.charWidth * multiplierFactor;
                h = Resizer.charHeight * multiplierFactor;
            }
            else
            {
                w = Resizer.charsetWidth * multiplierFactor;
                h = Resizer.charsetHeight * multiplierFactor;
            }

            labelInfo.Text = size + "px (" + w + "x" + h + ")";
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (SaveDialog.ShowDialog() != DialogResult.OK)
                return;

            string path = SaveDialog.FileName, template = "template";
            int w, h;

            if (CharTemplateCheck.Checked)
            {
                string filename = System.IO.Path.GetFileName(path);
                path = path.Replace(filename, "!$" + filename);
                template += "-one-char";

                w = Resizer.charWidth * multiplierFactor;
                h = Resizer.charHeight * multiplierFactor;
            }
            else
            {
                w = Resizer.charsetWidth * multiplierFactor;
                h = Resizer.charsetHeight * multiplierFactor;
            }

            Resizer.ApplyMultiplierFactor(w, h, template).Save(path);
        }

        private void ChangeLang(Vocab.Lang l)
        {
            Vocab.currentLanguage = l;

            FileMenuItem.Text = Vocab.GetText("file");
            ExitMenuItem.Text = Vocab.GetText("exit");

            LangMenuItem.Text = Vocab.GetText("language");
            EnglishMenuItem.Text = Vocab.GetText("english");
            PortugueseMenuItem.Text = Vocab.GetText("portuguese");

            HelpMenuItem.Text = Vocab.GetText("help");
            AboutMenuItem.Text = Vocab.GetText("about");

            SaveDialog.Filter = Vocab.GetText("pngFiles") + " (*.png) | *.png";

            MultiplierLabel.Text= Vocab.GetText("multiplier");
            CharTemplateCheck.Text = Vocab.GetText("useCharTemplateMsg");
            ButtonGenerate.Text = Vocab.GetText("generate");

        }

        private void CharTemplateCheck_CheckedChanged(object sender, EventArgs e)
        {
            TextSizeMultiplier_TextChanged(null, null);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void EnglishMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang(Vocab.Lang.en);
        }

        private void PortugueseMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang(Vocab.Lang.pt);
        }
    }
}
