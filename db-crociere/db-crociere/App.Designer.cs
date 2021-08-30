
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuContainer = new System.Windows.Forms.TabControl();
            this.bookingTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editBtnFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.addPrenBtn = new System.Windows.Forms.Button();
            this.prenViewTable = new System.Windows.Forms.DataGridView();
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
            this.SectionsGridView = new System.Windows.Forms.DataGridView();
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
            this.ExpenseTrackerPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddExpensesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceListGridView = new System.Windows.Forms.DataGridView();
            this.ShipNameComboBox = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RankPathGridView = new System.Windows.Forms.DataGridView();
            this.TEST = new System.Windows.Forms.Button();
            this.AddPathBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuContainer.SuspendLayout();
            this.bookingTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editBtnFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prenViewTable)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.SectionsGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.InfoShipBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ExpenseTrackerPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankPathGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuContainer.Controls.Add(this.bookingTab);
            this.menuContainer.Controls.Add(this.shipPage);
            this.menuContainer.Controls.Add(this.ExpenseTrackerPage);
            this.menuContainer.Controls.Add(this.tabPage1);
            this.menuContainer.Controls.Add(this.tabPage2);
            this.menuContainer.Location = new System.Drawing.Point(12, 12);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.SelectedIndex = 0;
            this.menuContainer.Size = new System.Drawing.Size(1087, 650);
            this.menuContainer.TabIndex = 0;
            // 
            // bookingTab
            // 
            this.bookingTab.Controls.Add(this.groupBox1);
            this.bookingTab.Location = new System.Drawing.Point(4, 22);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingTab.Size = new System.Drawing.Size(1079, 624);
            this.bookingTab.TabIndex = 0;
            this.bookingTab.Text = "Prenotazioni";
            this.bookingTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editBtnFlow);
            this.groupBox1.Controls.Add(this.prenViewTable);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // editBtnFlow
            // 
            this.editBtnFlow.Controls.Add(this.addPrenBtn);
            this.editBtnFlow.Location = new System.Drawing.Point(7, 284);
            this.editBtnFlow.Name = "editBtnFlow";
            this.editBtnFlow.Size = new System.Drawing.Size(100, 28);
            this.editBtnFlow.TabIndex = 1;
            // 
            // addPrenBtn
            // 
            this.addPrenBtn.Location = new System.Drawing.Point(3, 3);
            this.addPrenBtn.Name = "addPrenBtn";
            this.addPrenBtn.Size = new System.Drawing.Size(75, 23);
            this.addPrenBtn.TabIndex = 0;
            this.addPrenBtn.Text = "Aggiungi";
            this.addPrenBtn.UseVisualStyleBackColor = true;
            this.addPrenBtn.Click += new System.EventHandler(this.addPrenBtn_Click);
            // 
            // prenViewTable
            // 
            this.prenViewTable.AllowUserToAddRows = false;
            this.prenViewTable.AllowUserToDeleteRows = false;
            this.prenViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prenViewTable.Location = new System.Drawing.Point(6, 19);
            this.prenViewTable.Name = "prenViewTable";
            this.prenViewTable.ReadOnly = true;
            this.prenViewTable.Size = new System.Drawing.Size(611, 258);
            this.prenViewTable.TabIndex = 0;
            // 
            // shipPage
            // 
            this.shipPage.AutoScroll = true;
            this.shipPage.Controls.Add(this.splitContainer1);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(1079, 624);
            this.shipPage.TabIndex = 1;
            this.shipPage.Text = "Navi";
            this.shipPage.UseVisualStyleBackColor = true;
            this.shipPage.Enter += new System.EventHandler(this.updateShipList);
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
            this.splitContainer1.Size = new System.Drawing.Size(1073, 618);
            this.splitContainer1.SplitterDistance = 244;
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
            this.shipListContainer.Size = new System.Drawing.Size(244, 618);
            this.shipListContainer.SplitterDistance = 559;
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
            this.shipListBoxContainer.Size = new System.Drawing.Size(238, 553);
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
            this.shipListBox.Size = new System.Drawing.Size(226, 508);
            this.shipListBox.TabIndex = 0;
            this.shipListBox.SelectedIndexChanged += new System.EventHandler(this.shipListBox_Click);
            // 
            // DeleteShipBtn
            // 
            this.DeleteShipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteShipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteShipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteShipBtn.Location = new System.Drawing.Point(147, 4);
            this.DeleteShipBtn.MinimumSize = new System.Drawing.Size(35, 28);
            this.DeleteShipBtn.Name = "DeleteShipBtn";
            this.DeleteShipBtn.Size = new System.Drawing.Size(94, 48);
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
            this.AddShipBtn.Size = new System.Drawing.Size(103, 48);
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
            this.NavigationBox.Location = new System.Drawing.Point(3, 262);
            this.NavigationBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.NavigationBox.Name = "NavigationBox";
            this.NavigationBox.Size = new System.Drawing.Size(819, 353);
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
            this.NavigationExecutionGridView.Size = new System.Drawing.Size(813, 308);
            this.NavigationExecutionGridView.TabIndex = 3;
            // 
            // NavigationDropDownMenu
            // 
            this.NavigationDropDownMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationDropDownMenu.FormattingEnabled = true;
            this.NavigationDropDownMenu.Location = new System.Drawing.Point(3, 18);
            this.NavigationDropDownMenu.Name = "NavigationDropDownMenu";
            this.NavigationDropDownMenu.Size = new System.Drawing.Size(813, 24);
            this.NavigationDropDownMenu.TabIndex = 2;
            this.NavigationDropDownMenu.Text = "Scegli Navigazione";
            this.NavigationDropDownMenu.SelectedIndexChanged += new System.EventHandler(this.NavigationDropDownMenu_SelectedIndexChanged);
            this.NavigationDropDownMenu.Click += new System.EventHandler(this.NavigationDropDownMenu_Click);
            // 
            // InfoPathBox
            // 
            this.InfoPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPathBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoPathBox.Controls.Add(this.button2);
            this.InfoPathBox.Controls.Add(this.AddPathBtn);
            this.InfoPathBox.Controls.Add(this.SectionsGridView);
            this.InfoPathBox.Controls.Add(this.tableLayoutPanel2);
            this.InfoPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPathBox.Location = new System.Drawing.Point(309, 3);
            this.InfoPathBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.InfoPathBox.Name = "InfoPathBox";
            this.InfoPathBox.Size = new System.Drawing.Size(513, 256);
            this.InfoPathBox.TabIndex = 1;
            this.InfoPathBox.TabStop = false;
            this.InfoPathBox.Text = "Percorso";
            // 
            // SectionsGridView
            // 
            this.SectionsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SectionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionsGridView.Location = new System.Drawing.Point(6, 85);
            this.SectionsGridView.Name = "SectionsGridView";
            this.SectionsGridView.Size = new System.Drawing.Size(501, 165);
            this.SectionsGridView.TabIndex = 1;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.Black;
            this.DurationLabel.Location = new System.Drawing.Point(158, 30);
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
            this.PathCodeLabel.Location = new System.Drawing.Point(158, 0);
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
            this.InfoShipBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 231);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // InfoNameLabel
            // 
            this.InfoNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoNameLabel.AutoSize = true;
            this.InfoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNameLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoNameLabel.Location = new System.Drawing.Point(3, 0);
            this.InfoNameLabel.Name = "InfoNameLabel";
            this.InfoNameLabel.Size = new System.Drawing.Size(49, 32);
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
            this.InfoCode.Location = new System.Drawing.Point(3, 32);
            this.InfoCode.Name = "InfoCode";
            this.InfoCode.Size = new System.Drawing.Size(98, 32);
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
            this.InfoWidth.Location = new System.Drawing.Point(3, 64);
            this.InfoWidth.Name = "InfoWidth";
            this.InfoWidth.Size = new System.Drawing.Size(79, 32);
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
            this.InfoLength.Location = new System.Drawing.Point(3, 96);
            this.InfoLength.Name = "InfoLength";
            this.InfoLength.Size = new System.Drawing.Size(81, 32);
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
            this.InfoWeight.Location = new System.Drawing.Point(3, 128);
            this.InfoWeight.Name = "InfoWeight";
            this.InfoWeight.Size = new System.Drawing.Size(44, 32);
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
            this.InfoHeight.Location = new System.Drawing.Point(3, 160);
            this.InfoHeight.Name = "InfoHeight";
            this.InfoHeight.Size = new System.Drawing.Size(58, 32);
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
            this.InfoCabins.Location = new System.Drawing.Point(3, 192);
            this.InfoCabins.Name = "InfoCabins";
            this.InfoCabins.Size = new System.Drawing.Size(115, 39);
            this.InfoCabins.TabIndex = 6;
            this.InfoCabins.Text = "Numero Cabine";
            this.InfoCabins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShipNameLabel
            // 
            this.ShipNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShipNameLabel.AutoSize = true;
            this.ShipNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ShipNameLabel.Location = new System.Drawing.Point(139, 0);
            this.ShipNameLabel.Name = "ShipNameLabel";
            this.ShipNameLabel.Size = new System.Drawing.Size(0, 32);
            this.ShipNameLabel.TabIndex = 7;
            this.ShipNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShipCodeLabel
            // 
            this.ShipCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShipCodeLabel.AutoSize = true;
            this.ShipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipCodeLabel.ForeColor = System.Drawing.Color.Black;
            this.ShipCodeLabel.Location = new System.Drawing.Point(139, 32);
            this.ShipCodeLabel.Name = "ShipCodeLabel";
            this.ShipCodeLabel.Size = new System.Drawing.Size(0, 32);
            this.ShipCodeLabel.TabIndex = 8;
            this.ShipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.ForeColor = System.Drawing.Color.Black;
            this.WidthLabel.Location = new System.Drawing.Point(139, 64);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(0, 32);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthLabel
            // 
            this.LengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.ForeColor = System.Drawing.Color.Black;
            this.LengthLabel.Location = new System.Drawing.Point(139, 96);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(0, 32);
            this.LengthLabel.TabIndex = 10;
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.Color.Black;
            this.WeightLabel.Location = new System.Drawing.Point(139, 128);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(0, 32);
            this.WeightLabel.TabIndex = 11;
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.Black;
            this.HeightLabel.Location = new System.Drawing.Point(139, 160);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(0, 32);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CabinsNumLabel
            // 
            this.CabinsNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CabinsNumLabel.AutoSize = true;
            this.CabinsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinsNumLabel.ForeColor = System.Drawing.Color.Black;
            this.CabinsNumLabel.Location = new System.Drawing.Point(139, 192);
            this.CabinsNumLabel.Name = "CabinsNumLabel";
            this.CabinsNumLabel.Size = new System.Drawing.Size(0, 39);
            this.CabinsNumLabel.TabIndex = 13;
            this.CabinsNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExpenseTrackerPage
            // 
            this.ExpenseTrackerPage.Controls.Add(this.TEST);
            this.ExpenseTrackerPage.Controls.Add(this.RankPathGridView);
            this.ExpenseTrackerPage.Controls.Add(this.chart1);
            this.ExpenseTrackerPage.Controls.Add(this.groupBox2);
            this.ExpenseTrackerPage.Controls.Add(this.AddExpensesBtn);
            this.ExpenseTrackerPage.Location = new System.Drawing.Point(4, 22);
            this.ExpenseTrackerPage.Name = "ExpenseTrackerPage";
            this.ExpenseTrackerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExpenseTrackerPage.Size = new System.Drawing.Size(1079, 624);
            this.ExpenseTrackerPage.TabIndex = 2;
            this.ExpenseTrackerPage.Text = "Spese";
            this.ExpenseTrackerPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 624);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Personale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 624);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Attività";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddExpensesBtn
            // 
            this.AddExpensesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpensesBtn.Location = new System.Drawing.Point(12, 325);
            this.AddExpensesBtn.Name = "AddExpensesBtn";
            this.AddExpensesBtn.Size = new System.Drawing.Size(172, 32);
            this.AddExpensesBtn.TabIndex = 2;
            this.AddExpensesBtn.Text = "Aggiungi Spese / Tariffari";
            this.AddExpensesBtn.UseVisualStyleBackColor = true;
            this.AddExpensesBtn.Click += new System.EventHandler(this.AddExpensesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShipNameComboBox);
            this.groupBox2.Controls.Add(this.PriceListGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 313);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tariffari";
            // 
            // PriceListGridView
            // 
            this.PriceListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceListGridView.Location = new System.Drawing.Point(6, 46);
            this.PriceListGridView.Name = "PriceListGridView";
            this.PriceListGridView.Size = new System.Drawing.Size(461, 259);
            this.PriceListGridView.TabIndex = 0;
            // 
            // ShipNameComboBox
            // 
            this.ShipNameComboBox.FormattingEnabled = true;
            this.ShipNameComboBox.Location = new System.Drawing.Point(6, 21);
            this.ShipNameComboBox.Name = "ShipNameComboBox";
            this.ShipNameComboBox.Size = new System.Drawing.Size(461, 24);
            this.ShipNameComboBox.TabIndex = 1;
            this.ShipNameComboBox.Text = "Nave";
            this.ShipNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ShipNameComboBox_SelectedIndexChanged);
            this.ShipNameComboBox.Click += new System.EventHandler(this.ShipNameComboBox_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(512, 303);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(539, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // RankPathGridView
            // 
            this.RankPathGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RankPathGridView.Location = new System.Drawing.Point(550, 38);
            this.RankPathGridView.Name = "RankPathGridView";
            this.RankPathGridView.Size = new System.Drawing.Size(461, 259);
            this.RankPathGridView.TabIndex = 2;
            // 
            // TEST
            // 
            this.TEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEST.Location = new System.Drawing.Point(1014, 38);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(47, 32);
            this.TEST.TabIndex = 5;
            this.TEST.Text = "test";
            this.TEST.UseVisualStyleBackColor = true;
            this.TEST.Click += new System.EventHandler(this.RankingPath);
            // 
            // AddPathBtn
            // 
            this.AddPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddPathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPathBtn.Location = new System.Drawing.Point(404, 19);
            this.AddPathBtn.MinimumSize = new System.Drawing.Size(35, 28);
            this.AddPathBtn.Name = "AddPathBtn";
            this.AddPathBtn.Size = new System.Drawing.Size(103, 30);
            this.AddPathBtn.TabIndex = 2;
            this.AddPathBtn.Text = "AGGIUNGI";
            this.AddPathBtn.UseVisualStyleBackColor = false;
            this.AddPathBtn.Click += new System.EventHandler(this.AddPathBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(404, 51);
            this.button2.MinimumSize = new System.Drawing.Size(35, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "RIMUOVI";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 674);
            this.Controls.Add(this.menuContainer);
            this.Name = "App";
            this.Text = "App";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.App_Activated);
            this.menuContainer.ResumeLayout(false);
            this.bookingTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.editBtnFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prenViewTable)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.SectionsGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.InfoShipBox.ResumeLayout(false);
            this.InfoShipBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ExpenseTrackerPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankPathGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuContainer;
        private System.Windows.Forms.TabPage bookingTab;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage ExpenseTrackerPage;
        private System.Windows.Forms.SplitContainer shipListContainer;
        private System.Windows.Forms.GroupBox shipListBoxContainer;
        private System.Windows.Forms.ListBox shipListBox;
        private System.Windows.Forms.Button DeleteShipBtn;
        private System.Windows.Forms.Button AddShipBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox InfoShipBox;
        private System.Windows.Forms.GroupBox InfoPathBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label PathCodeLabel;
        private System.Windows.Forms.Label InfoPathCode;
        private System.Windows.Forms.Label DurationInfo;
        private System.Windows.Forms.DataGridView SectionsGridView;
        private System.Windows.Forms.GroupBox NavigationBox;
        private System.Windows.Forms.DataGridView NavigationExecutionGridView;
        private System.Windows.Forms.ComboBox NavigationDropDownMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InfoNameLabel;
        private System.Windows.Forms.Label InfoCode;
        private System.Windows.Forms.Label InfoWidth;
        private System.Windows.Forms.Label InfoLength;
        private System.Windows.Forms.Label InfoWeight;
        private System.Windows.Forms.Label InfoHeight;
        private System.Windows.Forms.Label InfoCabins;
        private System.Windows.Forms.Label ShipNameLabel;
        private System.Windows.Forms.Label ShipCodeLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label CabinsNumLabel;
        private System.Windows.Forms.DataGridView prenViewTable;
        private System.Windows.Forms.FlowLayoutPanel editBtnFlow;
        private System.Windows.Forms.Button addPrenBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddExpensesBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PriceListGridView;
        private System.Windows.Forms.ComboBox ShipNameComboBox;
        private System.Windows.Forms.DataGridView RankPathGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button TEST;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddPathBtn;
    }
}