﻿namespace f21sc_courswork_1.View
{
    partial class FormMain
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxUrlInput = new System.Windows.Forms.TextBox();
            this.richTextBoxHtmlDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHttpStatusCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHttpStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToHomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.makeThisSiteFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFav = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(376, 27);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search !";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxUrlInput
            // 
            this.textBoxUrlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlInput.Location = new System.Drawing.Point(232, 29);
            this.textBoxUrlInput.Name = "textBoxUrlInput";
            this.textBoxUrlInput.Size = new System.Drawing.Size(138, 20);
            this.textBoxUrlInput.TabIndex = 0;
            this.textBoxUrlInput.Text = "lingscars.com";
            this.textBoxUrlInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrlInput_KeyDown);
            // 
            // richTextBoxHtmlDisplay
            // 
            this.richTextBoxHtmlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHtmlDisplay.Location = new System.Drawing.Point(12, 56);
            this.richTextBoxHtmlDisplay.Name = "richTextBoxHtmlDisplay";
            this.richTextBoxHtmlDisplay.ReadOnly = true;
            this.richTextBoxHtmlDisplay.Size = new System.Drawing.Size(520, 435);
            this.richTextBoxHtmlDisplay.TabIndex = 2000;
            this.richTextBoxHtmlDisplay.TabStop = false;
            this.richTextBoxHtmlDisplay.Text = "";
            // 
            // buttonReload
            // 
            this.buttonReload.Enabled = false;
            this.buttonReload.Location = new System.Drawing.Point(12, 27);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(93, 27);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHttpStatusCode,
            this.toolStripStatusLabelHttpStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHttpStatusCode
            // 
            this.toolStripStatusLabelHttpStatusCode.Name = "toolStripStatusLabelHttpStatusCode";
            this.toolStripStatusLabelHttpStatusCode.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelHttpStatus
            // 
            this.toolStripStatusLabelHttpStatus.Name = "toolStripStatusLabelHttpStatus";
            this.toolStripStatusLabelHttpStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.favoritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.goToHomePageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goToHomePageToolStripMenuItem
            // 
            this.goToHomePageToolStripMenuItem.Name = "goToHomePageToolStripMenuItem";
            this.goToHomePageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToHomePageToolStripMenuItem.Text = "Go to home page";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.allHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.eraseHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // allHistoryToolStripMenuItem
            // 
            this.allHistoryToolStripMenuItem.Name = "allHistoryToolStripMenuItem";
            this.allHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allHistoryToolStripMenuItem.Text = "All history";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // eraseHistoryToolStripMenuItem
            // 
            this.eraseHistoryToolStripMenuItem.Name = "eraseHistoryToolStripMenuItem";
            this.eraseHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eraseHistoryToolStripMenuItem.Text = "Erase history";
            this.eraseHistoryToolStripMenuItem.Click += new System.EventHandler(this.eraseHistoryToolStripMenuItem_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topSitesToolStripMenuItem,
            this.seeAllFavoritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.makeThisSiteFavoriteToolStripMenuItem});
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // topSitesToolStripMenuItem
            // 
            this.topSitesToolStripMenuItem.Name = "topSitesToolStripMenuItem";
            this.topSitesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.topSitesToolStripMenuItem.Text = "Top sites";
            // 
            // seeAllFavoritesToolStripMenuItem
            // 
            this.seeAllFavoritesToolStripMenuItem.Name = "seeAllFavoritesToolStripMenuItem";
            this.seeAllFavoritesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.seeAllFavoritesToolStripMenuItem.Text = "See all favorites";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // makeThisSiteFavoriteToolStripMenuItem
            // 
            this.makeThisSiteFavoriteToolStripMenuItem.Name = "makeThisSiteFavoriteToolStripMenuItem";
            this.makeThisSiteFavoriteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.makeThisSiteFavoriteToolStripMenuItem.Text = "Make this site favorite";
            // 
            // buttonFav
            // 
            this.buttonFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFav.Location = new System.Drawing.Point(457, 27);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(75, 23);
            this.buttonFav.TabIndex = 2;
            this.buttonFav.Text = "Make fav";
            this.buttonFav.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Location = new System.Drawing.Point(174, 27);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(23, 23);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "←";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonForward
            // 
            this.buttonForward.Enabled = false;
            this.buttonForward.Location = new System.Drawing.Point(203, 27);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(23, 23);
            this.buttonForward.TabIndex = 6;
            this.buttonForward.Text = "→";
            this.buttonForward.UseVisualStyleBackColor = true;
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Enabled = false;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonFav);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.richTextBoxHtmlDisplay);
            this.Controls.Add(this.textBoxUrlInput);
            this.Controls.Add(this.buttonSearch);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(555, 555);
            this.Name = "FormMain";
            this.Text = "Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxUrlInput;
        private System.Windows.Forms.RichTextBox richTextBoxHtmlDisplay;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHttpStatusCode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHttpStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToHomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eraseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topSitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeAllFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem makeThisSiteFavoriteToolStripMenuItem;
        private System.Windows.Forms.Button buttonFav;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}

