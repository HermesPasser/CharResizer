namespace CharResizer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextSizeMultiplier = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.CharTemplateCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MultiplierLabel = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortugueseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextSizeMultiplier
            // 
            this.TextSizeMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextSizeMultiplier.Location = new System.Drawing.Point(85, 9);
            this.TextSizeMultiplier.Name = "TextSizeMultiplier";
            this.TextSizeMultiplier.Size = new System.Drawing.Size(77, 20);
            this.TextSizeMultiplier.TabIndex = 0;
            this.TextSizeMultiplier.Text = "1";
            this.TextSizeMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextSizeMultiplier.TextChanged += new System.EventHandler(this.TextSizeMultiplier_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 134);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonGenerate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CharTemplateCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 120);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonGenerate.Location = new System.Drawing.Point(89, 89);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(100, 23);
            this.ButtonGenerate.TabIndex = 6;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // CharTemplateCheck
            // 
            this.CharTemplateCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CharTemplateCheck.AutoSize = true;
            this.CharTemplateCheck.Location = new System.Drawing.Point(118, 60);
            this.CharTemplateCheck.Name = "CharTemplateCheck";
            this.CharTemplateCheck.Size = new System.Drawing.Size(43, 17);
            this.CharTemplateCheck.TabIndex = 7;
            this.CharTemplateCheck.Text = "text";
            this.CharTemplateCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharTemplateCheck.UseVisualStyleBackColor = true;
            this.CharTemplateCheck.CheckedChanged += new System.EventHandler(this.CharTemplateCheck_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.40293F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.82784F));
            this.tableLayoutPanel2.Controls.Add(this.TextSizeMultiplier, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MultiplierLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelInfo, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 39);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // MultiplierLabel
            // 
            this.MultiplierLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MultiplierLabel.AutoSize = true;
            this.MultiplierLabel.Location = new System.Drawing.Point(3, 13);
            this.MultiplierLabel.Name = "MultiplierLabel";
            this.MultiplierLabel.Size = new System.Drawing.Size(48, 13);
            this.MultiplierLabel.TabIndex = 3;
            this.MultiplierLabel.Text = "Multiplier";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(168, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(80, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "32px (348x256)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.LangMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // LangMenuItem
            // 
            this.LangMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishMenuItem,
            this.PortugueseMenuItem});
            this.LangMenuItem.Name = "LangMenuItem";
            this.LangMenuItem.Size = new System.Drawing.Size(71, 20);
            this.LangMenuItem.Text = "Language";
            // 
            // EnglishMenuItem
            // 
            this.EnglishMenuItem.Name = "EnglishMenuItem";
            this.EnglishMenuItem.Size = new System.Drawing.Size(134, 22);
            this.EnglishMenuItem.Text = "English";
            this.EnglishMenuItem.Click += new System.EventHandler(this.EnglishMenuItem_Click);
            // 
            // PortugueseMenuItem
            // 
            this.PortugueseMenuItem.Name = "PortugueseMenuItem";
            this.PortugueseMenuItem.Size = new System.Drawing.Size(134, 22);
            this.PortugueseMenuItem.Text = "Portuguese";
            this.PortugueseMenuItem.Click += new System.EventHandler(this.PortugueseMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Char Template Resizer VX";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSizeMultiplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label MultiplierLabel;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.CheckBox CharTemplateCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem LangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PortugueseMenuItem;
    }
}

