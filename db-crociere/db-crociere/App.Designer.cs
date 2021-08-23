
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
            this.bookingTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prenotBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.shipSelectorPrenot = new System.Windows.Forms.ComboBox();
            this.navSelectorPren = new System.Windows.Forms.ComboBox();
            this.paymentSelectPren = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shipListContainer = new System.Windows.Forms.SplitContainer();
            this.shipListBoxContainer = new System.Windows.Forms.GroupBox();
            this.shipListBox = new System.Windows.Forms.ListBox();
            this.DeleteShipBtn = new System.Windows.Forms.Button();
            this.AddShipBtn = new System.Windows.Forms.Button();
            this.NavigationBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NavigationListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNavigationBtn = new System.Windows.Forms.Button();
            this.RemoveNavigationBtn = new System.Windows.Forms.Button();
            this.RouteShipBox = new System.Windows.Forms.GroupBox();
            this.InfoShipBox = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuContainer.SuspendLayout();
            this.bookingTab.SuspendLayout();
            this.prenotBox.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.shipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).BeginInit();
            this.shipListContainer.Panel1.SuspendLayout();
            this.shipListContainer.Panel2.SuspendLayout();
            this.shipListContainer.SuspendLayout();
            this.shipListBoxContainer.SuspendLayout();
            this.NavigationBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuContainer.Controls.Add(this.bookingTab);
            this.menuContainer.Controls.Add(this.shipPage);
            this.menuContainer.Controls.Add(this.tabPage3);
            this.menuContainer.Location = new System.Drawing.Point(12, 12);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.SelectedIndex = 0;
            this.menuContainer.Size = new System.Drawing.Size(1003, 622);
            this.menuContainer.TabIndex = 0;
            this.menuContainer.Click += new System.EventHandler(this.onShipTabClick);
            // 
            // bookingTab
            // 
            this.bookingTab.Controls.Add(this.groupBox1);
            this.bookingTab.Controls.Add(this.prenotBox);
            this.bookingTab.Location = new System.Drawing.Point(4, 22);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingTab.Size = new System.Drawing.Size(995, 596);
            this.bookingTab.TabIndex = 0;
            this.bookingTab.Text = "Prenotazioni";
            this.bookingTab.UseVisualStyleBackColor = true;
            this.bookingTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(621, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // prenotBox
            // 
            this.prenotBox.Controls.Add(this.flowLayoutPanel4);
            this.prenotBox.Location = new System.Drawing.Point(7, 7);
            this.prenotBox.Name = "prenotBox";
            this.prenotBox.Size = new System.Drawing.Size(607, 583);
            this.prenotBox.TabIndex = 0;
            this.prenotBox.TabStop = false;
            this.prenotBox.Text = "Prenotazini Effettuate";
            this.prenotBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(595, 217);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.shipSelectorPrenot);
            this.flowLayoutPanel3.Controls.Add(this.navSelectorPren);
            this.flowLayoutPanel3.Controls.Add(this.paymentSelectPren);
            this.flowLayoutPanel3.Controls.Add(this.comboBox2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(591, 33);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // shipSelectorPrenot
            // 
            this.shipSelectorPrenot.FormattingEnabled = true;
            this.shipSelectorPrenot.Location = new System.Drawing.Point(3, 3);
            this.shipSelectorPrenot.Name = "shipSelectorPrenot";
            this.shipSelectorPrenot.Size = new System.Drawing.Size(153, 21);
            this.shipSelectorPrenot.TabIndex = 0;
            this.shipSelectorPrenot.Text = "Nave";
            // 
            // navSelectorPren
            // 
            this.navSelectorPren.FormattingEnabled = true;
            this.navSelectorPren.Location = new System.Drawing.Point(162, 3);
            this.navSelectorPren.Name = "navSelectorPren";
            this.navSelectorPren.Size = new System.Drawing.Size(121, 21);
            this.navSelectorPren.TabIndex = 1;
            this.navSelectorPren.Text = "Navigazione";
            // 
            // paymentSelectPren
            // 
            this.paymentSelectPren.FormattingEnabled = true;
            this.paymentSelectPren.Location = new System.Drawing.Point(289, 3);
            this.paymentSelectPren.Name = "paymentSelectPren";
            this.paymentSelectPren.Size = new System.Drawing.Size(121, 21);
            this.paymentSelectPren.TabIndex = 2;
            this.paymentSelectPren.Text = "Pagamento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // shipPage
            // 
            this.shipPage.AutoScroll = true;
            this.shipPage.Controls.Add(this.splitContainer1);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(995, 596);
            this.shipPage.TabIndex = 1;
            this.shipPage.Text = "Navi";
            this.shipPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.shipListContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.NavigationBox);
            this.splitContainer1.Panel2.Controls.Add(this.RouteShipBox);
            this.splitContainer1.Panel2.Controls.Add(this.InfoShipBox);
            this.splitContainer1.Size = new System.Drawing.Size(989, 590);
            this.splitContainer1.SplitterDistance = 226;
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
            // 
            // shipListContainer.Panel2
            // 
            this.shipListContainer.Panel2.AutoScroll = true;
            this.shipListContainer.Panel2.Controls.Add(this.DeleteShipBtn);
            this.shipListContainer.Panel2.Controls.Add(this.AddShipBtn);
            this.shipListContainer.Size = new System.Drawing.Size(226, 590);
            this.shipListContainer.SplitterDistance = 535;
            this.shipListContainer.TabIndex = 0;
            // 
            // shipListBoxContainer
            // 
            this.shipListBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBoxContainer.Controls.Add(this.shipListBox);
            this.shipListBoxContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipListBoxContainer.Location = new System.Drawing.Point(3, 3);
            this.shipListBoxContainer.Name = "shipListBoxContainer";
            this.shipListBoxContainer.Size = new System.Drawing.Size(220, 529);
            this.shipListBoxContainer.TabIndex = 0;
            this.shipListBoxContainer.TabStop = false;
            this.shipListBoxContainer.Text = "Navi";
            // 
            // shipListBox
            // 
            this.shipListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipListBox.FormattingEnabled = true;
            this.shipListBox.ItemHeight = 18;
            this.shipListBox.Location = new System.Drawing.Point(6, 19);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(208, 490);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.SelectedIndexChanged += new System.EventHandler(this.shipListBox_SelectedIndexChanged);
            // 
            // DeleteShipBtn
            // 
            this.DeleteShipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteShipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteShipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteShipBtn.Location = new System.Drawing.Point(129, 4);
            this.DeleteShipBtn.MinimumSize = new System.Drawing.Size(35, 28);
            this.DeleteShipBtn.Name = "DeleteShipBtn";
            this.DeleteShipBtn.Size = new System.Drawing.Size(94, 44);
            this.DeleteShipBtn.TabIndex = 1;
            this.DeleteShipBtn.Text = "RIMUOVI";
            this.DeleteShipBtn.UseVisualStyleBackColor = false;
            // 
            // AddShipBtn
            // 
            this.AddShipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddShipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddShipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShipBtn.Location = new System.Drawing.Point(3, 4);
            this.AddShipBtn.MinimumSize = new System.Drawing.Size(35, 28);
            this.AddShipBtn.Name = "AddShipBtn";
            this.AddShipBtn.Size = new System.Drawing.Size(103, 44);
            this.AddShipBtn.TabIndex = 0;
            this.AddShipBtn.Text = "AGGIUNGI";
            this.AddShipBtn.UseVisualStyleBackColor = false;
            this.AddShipBtn.Click += new System.EventHandler(this.AddShipBtn_Click);
            // 
            // NavigationBox
            // 
            this.NavigationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigationBox.Controls.Add(this.flowLayoutPanel1);
            this.NavigationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationBox.Location = new System.Drawing.Point(3, 254);
            this.NavigationBox.Name = "NavigationBox";
            this.NavigationBox.Size = new System.Drawing.Size(747, 333);
            this.NavigationBox.TabIndex = 3;
            this.NavigationBox.TabStop = false;
            this.NavigationBox.Text = "Navigazioni";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.NavigationListBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(527, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 314);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NavigationListBox
            // 
            this.NavigationListBox.FormattingEnabled = true;
            this.NavigationListBox.ItemHeight = 16;
            this.NavigationListBox.Location = new System.Drawing.Point(3, 3);
            this.NavigationListBox.Name = "NavigationListBox";
            this.NavigationListBox.Size = new System.Drawing.Size(197, 244);
            this.NavigationListBox.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AddNavigationBtn);
            this.flowLayoutPanel2.Controls.Add(this.RemoveNavigationBtn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 253);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(197, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // AddNavigationBtn
            // 
            this.AddNavigationBtn.Location = new System.Drawing.Point(3, 3);
            this.AddNavigationBtn.Name = "AddNavigationBtn";
            this.AddNavigationBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNavigationBtn.TabIndex = 0;
            this.AddNavigationBtn.Text = "Aggiungi";
            this.AddNavigationBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveNavigationBtn
            // 
            this.RemoveNavigationBtn.Location = new System.Drawing.Point(84, 3);
            this.RemoveNavigationBtn.Name = "RemoveNavigationBtn";
            this.RemoveNavigationBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveNavigationBtn.TabIndex = 1;
            this.RemoveNavigationBtn.Text = "Cancella";
            this.RemoveNavigationBtn.UseVisualStyleBackColor = true;
            // 
            // RouteShipBox
            // 
            this.RouteShipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteShipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteShipBox.Location = new System.Drawing.Point(423, 3);
            this.RouteShipBox.Name = "RouteShipBox";
            this.RouteShipBox.Size = new System.Drawing.Size(327, 245);
            this.RouteShipBox.TabIndex = 1;
            this.RouteShipBox.TabStop = false;
            this.RouteShipBox.Text = "Percorso";
            // 
            // InfoShipBox
            // 
            this.InfoShipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoShipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoShipBox.Location = new System.Drawing.Point(3, 3);
            this.InfoShipBox.Name = "InfoShipBox";
            this.InfoShipBox.Size = new System.Drawing.Size(413, 245);
            this.InfoShipBox.TabIndex = 0;
            this.InfoShipBox.TabStop = false;
            this.InfoShipBox.Text = "Info Nave";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(995, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 646);
            this.Controls.Add(this.menuContainer);
            this.Name = "App";
            this.Text = "App";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuContainer.ResumeLayout(false);
            this.bookingTab.ResumeLayout(false);
            this.prenotBox.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.shipListContainer.Panel1.ResumeLayout(false);
            this.shipListContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipListContainer)).EndInit();
            this.shipListContainer.ResumeLayout(false);
            this.shipListBoxContainer.ResumeLayout(false);
            this.NavigationBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuContainer;
        private System.Windows.Forms.TabPage bookingTab;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer shipListContainer;
        private System.Windows.Forms.GroupBox shipListBoxContainer;
        private System.Windows.Forms.ListBox shipListBox;
        private System.Windows.Forms.Button DeleteShipBtn;
        private System.Windows.Forms.Button AddShipBtn;
        private System.Windows.Forms.GroupBox NavigationBox;
        private System.Windows.Forms.GroupBox RouteShipBox;
        private System.Windows.Forms.GroupBox InfoShipBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox NavigationListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddNavigationBtn;
        private System.Windows.Forms.Button RemoveNavigationBtn;
        private System.Windows.Forms.GroupBox prenotBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox shipSelectorPrenot;
        private System.Windows.Forms.ComboBox navSelectorPren;
        private System.Windows.Forms.ComboBox paymentSelectPren;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}