
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
            this.NavigationExecutionGridView = new System.Windows.Forms.DataGridView();
            this.NavigationDropDownMenu = new System.Windows.Forms.ComboBox();
            this.InfoPathBox = new System.Windows.Forms.GroupBox();
            this.LegGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.PathCodeLabel = new System.Windows.Forms.Label();
            this.InfoPathCode = new System.Windows.Forms.Label();
            this.DurationInfo = new System.Windows.Forms.Label();
            this.InfoShipBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoNameLabel = new System.Windows.Forms.Label();
            this.InfoCode = new System.Windows.Forms.Label();
            this.InfoWidth = new System.Windows.Forms.Label();
            this.InfoLength = new System.Windows.Forms.Label();
            this.InfoWeight = new System.Windows.Forms.Label();
            this.InfoHeight = new System.Windows.Forms.Label();
            this.InfoCabins = new System.Windows.Forms.Label();
            this.ShipNameLabel = new System.Windows.Forms.Label();
            this.ShipCodeLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CabinsNumLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.NavigationExecutionGridView)).BeginInit();
            this.InfoPathBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.InfoShipBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.menuContainer.Size = new System.Drawing.Size(1046, 647);
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
            this.bookingTab.Size = new System.Drawing.Size(1038, 621);
            this.bookingTab.TabIndex = 0;
            this.bookingTab.Text = "Prenotazioni";
            this.bookingTab.UseVisualStyleBackColor = true;
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
            this.shipPage.Size = new System.Drawing.Size(1038, 621);
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
            this.splitContainer1.Panel2.Controls.Add(this.InfoPathBox);
            this.splitContainer1.Panel2.Controls.Add(this.InfoShipBox);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 615);
            this.splitContainer1.SplitterDistance = 235;
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
            this.shipListContainer.Size = new System.Drawing.Size(235, 615);
            this.shipListContainer.SplitterDistance = 557;
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
            this.shipListBoxContainer.Size = new System.Drawing.Size(229, 551);
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
            this.shipListBox.Size = new System.Drawing.Size(217, 508);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.Click += new System.EventHandler(this.shipListBox_Click);
            this.shipListBox.SelectedIndexChanged += new System.EventHandler(this.shipListBox_SelectedIndexChanged);
            // 
            // DeleteShipBtn
            // 
            this.DeleteShipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteShipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteShipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteShipBtn.Location = new System.Drawing.Point(138, 4);
            this.DeleteShipBtn.MinimumSize = new System.Drawing.Size(35, 28);
            this.DeleteShipBtn.Name = "DeleteShipBtn";
            this.DeleteShipBtn.Size = new System.Drawing.Size(94, 47);
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
            this.AddShipBtn.Size = new System.Drawing.Size(103, 47);
            this.AddShipBtn.TabIndex = 0;
            this.AddShipBtn.Text = "AGGIUNGI";
            this.AddShipBtn.UseVisualStyleBackColor = false;
            this.AddShipBtn.Click += new System.EventHandler(this.AddShipBtnClick);
            // 
            // NavigationBox
            // 
            this.NavigationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigationBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NavigationBox.Controls.Add(this.NavigationExecutionGridView);
            this.NavigationBox.Controls.Add(this.NavigationDropDownMenu);
            this.NavigationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationBox.Location = new System.Drawing.Point(3, 259);
            this.NavigationBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.NavigationBox.Name = "NavigationBox";
            this.NavigationBox.Size = new System.Drawing.Size(787, 353);
            this.NavigationBox.TabIndex = 1;
            this.NavigationBox.TabStop = false;
            this.NavigationBox.Text = "Navigazioni";
            // 
            // NavigationExecutionGridView
            // 
            this.NavigationExecutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NavigationExecutionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationExecutionGridView.Location = new System.Drawing.Point(3, 42);
            this.NavigationExecutionGridView.Name = "NavigationExecutionGridView";
            this.NavigationExecutionGridView.Size = new System.Drawing.Size(781, 308);
            this.NavigationExecutionGridView.TabIndex = 3;
            // 
            // NavigationDropDownMenu
            // 
            this.NavigationDropDownMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationDropDownMenu.FormattingEnabled = true;
            this.NavigationDropDownMenu.Location = new System.Drawing.Point(3, 18);
            this.NavigationDropDownMenu.Name = "NavigationDropDownMenu";
            this.NavigationDropDownMenu.Size = new System.Drawing.Size(781, 24);
            this.NavigationDropDownMenu.TabIndex = 2;
            this.NavigationDropDownMenu.Text = "Scegli Navigazione";
            // 
            // InfoPathBox
            // 
            this.InfoPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPathBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoPathBox.Controls.Add(this.LegGridView);
            this.InfoPathBox.Controls.Add(this.tableLayoutPanel2);
            this.InfoPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPathBox.Location = new System.Drawing.Point(309, 3);
            this.InfoPathBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.InfoPathBox.Name = "InfoPathBox";
            this.InfoPathBox.Size = new System.Drawing.Size(481, 256);
            this.InfoPathBox.TabIndex = 1;
            this.InfoPathBox.TabStop = false;
            this.InfoPathBox.Text = "Percorso";
            // 
            // LegGridView
            // 
            this.LegGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.LegGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LegGridView.Location = new System.Drawing.Point(6, 85);
            this.LegGridView.Name = "LegGridView";
            this.LegGridView.Size = new System.Drawing.Size(469, 165);
            this.LegGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.58823F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.41177F));
            this.tableLayoutPanel2.Controls.Add(this.DurationLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.PathCodeLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.InfoPathCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DurationInfo, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.Black;
            this.DurationLabel.Location = new System.Drawing.Point(202, 30);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(87, 30);
            this.DurationLabel.TabIndex = 9;
            this.DurationLabel.Text = "UNDEFINED";
            this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathCodeLabel
            // 
            this.PathCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PathCodeLabel.AutoSize = true;
            this.PathCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathCodeLabel.ForeColor = System.Drawing.Color.Black;
            this.PathCodeLabel.Location = new System.Drawing.Point(202, 0);
            this.PathCodeLabel.Name = "PathCodeLabel";
            this.PathCodeLabel.Size = new System.Drawing.Size(87, 30);
            this.PathCodeLabel.TabIndex = 8;
            this.PathCodeLabel.Text = "UNDEFINED";
            this.PathCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPathCode
            // 
            this.InfoPathCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoPathCode.AutoSize = true;
            this.InfoPathCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPathCode.ForeColor = System.Drawing.Color.Black;
            this.InfoPathCode.Location = new System.Drawing.Point(3, 0);
            this.InfoPathCode.Name = "InfoPathCode";
            this.InfoPathCode.Size = new System.Drawing.Size(124, 30);
            this.InfoPathCode.TabIndex = 0;
            this.InfoPathCode.Text = "Codice Percorso";
            this.InfoPathCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationInfo
            // 
            this.DurationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DurationInfo.AutoSize = true;
            this.DurationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationInfo.ForeColor = System.Drawing.Color.Black;
            this.DurationInfo.Location = new System.Drawing.Point(3, 30);
            this.DurationInfo.Name = "DurationInfo";
            this.DurationInfo.Size = new System.Drawing.Size(99, 30);
            this.DurationInfo.TabIndex = 1;
            this.DurationInfo.Text = "Giorni Durata";
            this.DurationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoShipBox
            // 
            this.InfoShipBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoShipBox.Controls.Add(this.tableLayoutPanel1);
            this.InfoShipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoShipBox.Location = new System.Drawing.Point(3, 3);
            this.InfoShipBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.InfoShipBox.Name = "InfoShipBox";
            this.InfoShipBox.Size = new System.Drawing.Size(300, 256);
            this.InfoShipBox.TabIndex = 0;
            this.InfoShipBox.TabStop = false;
            this.InfoShipBox.Text = "Info Nave";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.24138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.75862F));
            this.tableLayoutPanel1.Controls.Add(this.InfoNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InfoCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InfoWidth, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InfoLength, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.InfoWeight, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.InfoHeight, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.InfoCabins, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ShipNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShipCodeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WidthLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LengthLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.CabinsNumLabel, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InfoNameLabel
            // 
            this.InfoNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNameLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoNameLabel.Location = new System.Drawing.Point(3, 0);
            this.InfoNameLabel.Name = "InfoNameLabel";
            this.InfoNameLabel.Size = new System.Drawing.Size(49, 38);
            this.InfoNameLabel.TabIndex = 0;
            this.InfoNameLabel.Text = "Nome";
            this.InfoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoCode
            // 
            this.InfoCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoCode.AutoSize = true;
            this.InfoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCode.ForeColor = System.Drawing.Color.Black;
            this.InfoCode.Location = new System.Drawing.Point(3, 38);
            this.InfoCode.Name = "InfoCode";
            this.InfoCode.Size = new System.Drawing.Size(98, 38);
            this.InfoCode.TabIndex = 1;
            this.InfoCode.Text = "Codice Nave";
            this.InfoCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoWidth
            // 
            this.InfoWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoWidth.AutoSize = true;
            this.InfoWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoWidth.ForeColor = System.Drawing.Color.Black;
            this.InfoWidth.Location = new System.Drawing.Point(3, 76);
            this.InfoWidth.Name = "InfoWidth";
            this.InfoWidth.Size = new System.Drawing.Size(79, 38);
            this.InfoWidth.TabIndex = 2;
            this.InfoWidth.Text = "Larghezza";
            this.InfoWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoLength
            // 
            this.InfoLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLength.AutoSize = true;
            this.InfoLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLength.ForeColor = System.Drawing.Color.Black;
            this.InfoLength.Location = new System.Drawing.Point(3, 114);
            this.InfoLength.Name = "InfoLength";
            this.InfoLength.Size = new System.Drawing.Size(81, 38);
            this.InfoLength.TabIndex = 3;
            this.InfoLength.Text = "Lunghezza";
            this.InfoLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoWeight
            // 
            this.InfoWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoWeight.AutoSize = true;
            this.InfoWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoWeight.ForeColor = System.Drawing.Color.Black;
            this.InfoWeight.Location = new System.Drawing.Point(3, 152);
            this.InfoWeight.Name = "InfoWeight";
            this.InfoWeight.Size = new System.Drawing.Size(44, 38);
            this.InfoWeight.TabIndex = 4;
            this.InfoWeight.Text = "Peso";
            this.InfoWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoHeight
            // 
            this.InfoHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoHeight.AutoSize = true;
            this.InfoHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoHeight.ForeColor = System.Drawing.Color.Black;
            this.InfoHeight.Location = new System.Drawing.Point(3, 190);
            this.InfoHeight.Name = "InfoHeight";
            this.InfoHeight.Size = new System.Drawing.Size(58, 38);
            this.InfoHeight.TabIndex = 5;
            this.InfoHeight.Text = "Altezza";
            this.InfoHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoCabins
            // 
            this.InfoCabins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoCabins.AutoSize = true;
            this.InfoCabins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCabins.ForeColor = System.Drawing.Color.Black;
            this.InfoCabins.Location = new System.Drawing.Point(3, 228);
            this.InfoCabins.Name = "InfoCabins";
            this.InfoCabins.Size = new System.Drawing.Size(115, 45);
            this.InfoCabins.TabIndex = 6;
            this.InfoCabins.Text = "Numero Cabine";
            this.InfoCabins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShipNameLabel
            // 
            this.ShipNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShipNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ShipNameLabel.Location = new System.Drawing.Point(139, 0);
            this.ShipNameLabel.Name = "ShipNameLabel";
            this.ShipNameLabel.Size = new System.Drawing.Size(148, 38);
            this.ShipNameLabel.TabIndex = 7;
            this.ShipNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShipCodeLabel
            // 
            this.ShipCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipCodeLabel.ForeColor = System.Drawing.Color.Black;
            this.ShipCodeLabel.Location = new System.Drawing.Point(139, 38);
            this.ShipCodeLabel.Name = "ShipCodeLabel";
            this.ShipCodeLabel.Size = new System.Drawing.Size(148, 38);
            this.ShipCodeLabel.TabIndex = 8;
            this.ShipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.ForeColor = System.Drawing.Color.Black;
            this.WidthLabel.Location = new System.Drawing.Point(139, 76);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(148, 38);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthLabel
            // 
            this.LengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.ForeColor = System.Drawing.Color.Black;
            this.LengthLabel.Location = new System.Drawing.Point(139, 114);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(148, 38);
            this.LengthLabel.TabIndex = 10;
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.Color.Black;
            this.WeightLabel.Location = new System.Drawing.Point(139, 152);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(148, 38);
            this.WeightLabel.TabIndex = 11;
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.Black;
            this.HeightLabel.Location = new System.Drawing.Point(139, 190);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(148, 38);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CabinsNumLabel
            // 
            this.CabinsNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CabinsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinsNumLabel.ForeColor = System.Drawing.Color.Black;
            this.CabinsNumLabel.Location = new System.Drawing.Point(139, 228);
            this.CabinsNumLabel.Name = "CabinsNumLabel";
            this.CabinsNumLabel.Size = new System.Drawing.Size(148, 45);
            this.CabinsNumLabel.TabIndex = 13;
            this.CabinsNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1038, 621);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 671);
            this.Controls.Add(this.menuContainer);
            this.Name = "App";
            this.Text = "App";
            this.TopMost = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.NavigationExecutionGridView)).EndInit();
            this.InfoPathBox.ResumeLayout(false);
            this.InfoPathBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.InfoShipBox.ResumeLayout(false);
            this.InfoShipBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox prenotBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox shipSelectorPrenot;
        private System.Windows.Forms.ComboBox navSelectorPren;
        private System.Windows.Forms.ComboBox paymentSelectPren;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox InfoShipBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InfoCode;
        private System.Windows.Forms.Label InfoWidth;
        private System.Windows.Forms.Label InfoLength;
        private System.Windows.Forms.Label InfoWeight;
        private System.Windows.Forms.Label InfoHeight;
        private System.Windows.Forms.Label InfoCabins;
        private System.Windows.Forms.GroupBox InfoPathBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label PathCodeLabel;
        private System.Windows.Forms.Label InfoPathCode;
        private System.Windows.Forms.Label DurationInfo;
        private System.Windows.Forms.DataGridView LegGridView;
        private System.Windows.Forms.GroupBox NavigationBox;
        private System.Windows.Forms.DataGridView NavigationExecutionGridView;
        private System.Windows.Forms.ComboBox NavigationDropDownMenu;
        private System.Windows.Forms.Label InfoNameLabel;
        private System.Windows.Forms.Label ShipNameLabel;
        private System.Windows.Forms.Label ShipCodeLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label CabinsNumLabel;
    }
}