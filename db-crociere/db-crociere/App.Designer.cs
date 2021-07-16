
namespace db_crociere
{
    partial class App
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
            this.menuContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shipListContainer = new System.Windows.Forms.SplitContainer();
            this.shipListBoxContainer = new System.Windows.Forms.GroupBox();
            this.shipListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuContainer.SuspendLayout();
            this.shipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).BeginInit();
            this.shipListContainer.Panel1.SuspendLayout();
            this.shipListContainer.SuspendLayout();
            this.shipListBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.tabPage1);
            this.menuContainer.Controls.Add(this.shipPage);
            this.menuContainer.Controls.Add(this.tabPage3);
            this.menuContainer.Location = new System.Drawing.Point(12, 12);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.SelectedIndex = 0;
            this.menuContainer.Size = new System.Drawing.Size(996, 608);
            this.menuContainer.TabIndex = 0;
            this.menuContainer.Click += new System.EventHandler(this.onShipTabClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shipPage
            // 
            this.shipPage.Controls.Add(this.splitContainer1);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(988, 582);
            this.shipPage.TabIndex = 1;
            this.shipPage.Text = "Navi";
            this.shipPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.shipListContainer);
            this.splitContainer1.Size = new System.Drawing.Size(982, 576);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            // 
            // shipListContainer
            // 
            this.shipListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipListContainer.Location = new System.Drawing.Point(0, 0);
            this.shipListContainer.Name = "shipListContainer";
            this.shipListContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // shipListContainer.Panel1
            // 
            this.shipListContainer.Panel1.Controls.Add(this.shipListBoxContainer);
            this.shipListContainer.Size = new System.Drawing.Size(225, 576);
            this.shipListContainer.SplitterDistance = 465;
            this.shipListContainer.TabIndex = 0;
            // 
            // shipListBoxContainer
            // 
            this.shipListBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBoxContainer.Controls.Add(this.shipListBox);
            this.shipListBoxContainer.Location = new System.Drawing.Point(3, 3);
            this.shipListBoxContainer.Name = "shipListBoxContainer";
            this.shipListBoxContainer.Size = new System.Drawing.Size(219, 459);
            this.shipListBoxContainer.TabIndex = 0;
            this.shipListBoxContainer.TabStop = false;
            this.shipListBoxContainer.Text = "Navi";
            // 
            // shipListBox
            // 
            this.shipListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBox.FormattingEnabled = true;
            this.shipListBox.Location = new System.Drawing.Point(6, 19);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(207, 433);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.Click += new System.EventHandler(this.test);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(988, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.menuContainer);
            this.Name = "App";
            this.Text = "App";
            this.menuContainer.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.shipListContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).EndInit();
            this.shipListContainer.ResumeLayout(false);
            this.shipListBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer shipListContainer;
        private System.Windows.Forms.GroupBox shipListBoxContainer;
        private System.Windows.Forms.ListBox shipListBox;
    }
}