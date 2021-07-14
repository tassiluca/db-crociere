
namespace DbCrociere
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuControl = new System.Windows.Forms.TabControl();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.shipPageSplit = new System.Windows.Forms.SplitContainer();
            this.shipListSplit = new System.Windows.Forms.SplitContainer();
            this.shipListBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeShipButton = new System.Windows.Forms.Button();
            this.addShipButton = new System.Windows.Forms.Button();
            this.menuControl.SuspendLayout();
            this.shipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipPageSplit)).BeginInit();
            this.shipPageSplit.Panel1.SuspendLayout();
            this.shipPageSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipListSplit)).BeginInit();
            this.shipListSplit.Panel1.SuspendLayout();
            this.shipListSplit.Panel2.SuspendLayout();
            this.shipListSplit.SuspendLayout();
            this.shipListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuControl.Controls.Add(this.shipPage);
            this.menuControl.Location = new System.Drawing.Point(12, 12);
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(994, 595);
            this.menuControl.TabIndex = 0;
            // 
            // shipPage
            // 
            this.shipPage.Controls.Add(this.shipPageSplit);
            this.shipPage.Location = new System.Drawing.Point(4, 24);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(986, 567);
            this.shipPage.TabIndex = 1;
            this.shipPage.Text = "Navi";
            this.shipPage.UseVisualStyleBackColor = true;
            // 
            // shipPageSplit
            // 
            this.shipPageSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipPageSplit.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.shipPageSplit.Location = new System.Drawing.Point(3, 3);
            this.shipPageSplit.Name = "shipPageSplit";
            // 
            // shipPageSplit.Panel1
            // 
            this.shipPageSplit.Panel1.Controls.Add(this.shipListSplit);
            this.shipPageSplit.Size = new System.Drawing.Size(980, 561);
            this.shipPageSplit.SplitterDistance = 201;
            this.shipPageSplit.TabIndex = 0;
            // 
            // shipListSplit
            // 
            this.shipListSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListSplit.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.shipListSplit.Location = new System.Drawing.Point(3, 3);
            this.shipListSplit.Name = "shipListSplit";
            this.shipListSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // shipListSplit.Panel1
            // 
            this.shipListSplit.Panel1.Controls.Add(this.shipListBox);
            // 
            // shipListSplit.Panel2
            // 
            this.shipListSplit.Panel2.Controls.Add(this.removeShipButton);
            this.shipListSplit.Panel2.Controls.Add(this.addShipButton);
            this.shipListSplit.Size = new System.Drawing.Size(195, 555);
            this.shipListSplit.SplitterDistance = 484;
            this.shipListSplit.TabIndex = 0;
            // 
            // shipListBox
            // 
            this.shipListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBox.Controls.Add(this.dataGridView1);
            this.shipListBox.Location = new System.Drawing.Point(0, 3);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(195, 478);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.TabStop = false;
            this.shipListBox.Text = "Elenco Navi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(183, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // removeShipButton
            // 
            this.removeShipButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeShipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeShipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.removeShipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removeShipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeShipButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeShipButton.Location = new System.Drawing.Point(114, 3);
            this.removeShipButton.MinimumSize = new System.Drawing.Size(60, 20);
            this.removeShipButton.Name = "removeShipButton";
            this.removeShipButton.Size = new System.Drawing.Size(81, 60);
            this.removeShipButton.TabIndex = 1;
            this.removeShipButton.Text = "RIMUOVI";
            this.removeShipButton.UseVisualStyleBackColor = false;
            // 
            // addShipButton
            // 
            this.addShipButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addShipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addShipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.addShipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addShipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addShipButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addShipButton.Location = new System.Drawing.Point(0, 3);
            this.addShipButton.Name = "addShipButton";
            this.addShipButton.Size = new System.Drawing.Size(83, 60);
            this.addShipButton.TabIndex = 0;
            this.addShipButton.Text = "AGGIUNGI";
            this.addShipButton.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 619);
            this.Controls.Add(this.menuControl);
            this.Name = "Main";
            this.Text = "DbCrociere";
            this.menuControl.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.shipPageSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipPageSplit)).EndInit();
            this.shipPageSplit.ResumeLayout(false);
            this.shipListSplit.Panel1.ResumeLayout(false);
            this.shipListSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipListSplit)).EndInit();
            this.shipListSplit.ResumeLayout(false);
            this.shipListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuControl;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.SplitContainer shipPageSplit;
        private System.Windows.Forms.SplitContainer shipListSplit;
        private System.Windows.Forms.Button removeShipButton;
        private System.Windows.Forms.Button addShipButton;
        private System.Windows.Forms.GroupBox shipListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

