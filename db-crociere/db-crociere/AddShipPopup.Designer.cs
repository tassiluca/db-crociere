
namespace db_crociere
{
    partial class AddShipPopup
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
            this.components = new System.ComponentModel.Container();
            this.InsertShipInfoBox = new System.Windows.Forms.GroupBox();
            this.ClearShipInfoBtn = new System.Windows.Forms.Button();
            this.AddShipInfoBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameInfo = new System.Windows.Forms.Label();
            this.ShipNameTextBox = new System.Windows.Forms.TextBox();
            this.WidthInfo = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthInfo = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WeightInfo = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightInfo = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CabinsNumInfo = new System.Windows.Forms.Label();
            this.CabinsNumTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.InsertPathInfoBox = new System.Windows.Forms.GroupBox();
            this.InsertedSections = new System.Windows.Forms.ListBox();
            this.SectionsListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddPathBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CodPathInfo = new System.Windows.Forms.Label();
            this.CodPathTextBox = new System.Windows.Forms.TextBox();
            this.DurationInfo = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.ShipNameInfo = new System.Windows.Forms.Label();
            this.ShipNameComboPath = new System.Windows.Forms.ComboBox();
            this.InsertSectionPathBtn = new System.Windows.Forms.Button();
            this.DeleteSectionPathBtn = new System.Windows.Forms.Button();
            this.InsertHarborInfoBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddHarbour = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.HarborCodeInfo = new System.Windows.Forms.Label();
            this.HarborCodeTextBox = new System.Windows.Forms.TextBox();
            this.NationalityInfo = new System.Windows.Forms.Label();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.CityInfo = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.DockingPriceInfo = new System.Windows.Forms.Label();
            this.DockingPriceTextBox = new System.Windows.Forms.TextBox();
            this.InsertShipInfoBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).BeginInit();
            this.InsertPathInfoBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.InsertHarborInfoBox.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertShipInfoBox
            // 
            this.InsertShipInfoBox.Controls.Add(this.ClearShipInfoBtn);
            this.InsertShipInfoBox.Controls.Add(this.AddShipInfoBtn);
            this.InsertShipInfoBox.Controls.Add(this.flowLayoutPanel1);
            this.InsertShipInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertShipInfoBox.Location = new System.Drawing.Point(0, 0);
            this.InsertShipInfoBox.Name = "InsertShipInfoBox";
            this.InsertShipInfoBox.Size = new System.Drawing.Size(714, 81);
            this.InsertShipInfoBox.TabIndex = 0;
            this.InsertShipInfoBox.TabStop = false;
            this.InsertShipInfoBox.Text = "Inserisci nuova Nave";
            // 
            // ClearShipInfoBtn
            // 
            this.ClearShipInfoBtn.Location = new System.Drawing.Point(545, 51);
            this.ClearShipInfoBtn.Name = "ClearShipInfoBtn";
            this.ClearShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearShipInfoBtn.TabIndex = 2;
            this.ClearShipInfoBtn.Text = "Pulisci";
            this.ClearShipInfoBtn.UseVisualStyleBackColor = true;
            // 
            // AddShipInfoBtn
            // 
            this.AddShipInfoBtn.Location = new System.Drawing.Point(545, 16);
            this.AddShipInfoBtn.Name = "AddShipInfoBtn";
            this.AddShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.AddShipInfoBtn.TabIndex = 1;
            this.AddShipInfoBtn.Text = "Aggiungi";
            this.AddShipInfoBtn.UseVisualStyleBackColor = true;
            this.AddShipInfoBtn.Click += new System.EventHandler(this.AddShipInfoBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameInfo);
            this.flowLayoutPanel1.Controls.Add(this.ShipNameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.WidthInfo);
            this.flowLayoutPanel1.Controls.Add(this.WidthTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LengthInfo);
            this.flowLayoutPanel1.Controls.Add(this.LengthTextBox);
            this.flowLayoutPanel1.Controls.Add(this.WeightInfo);
            this.flowLayoutPanel1.Controls.Add(this.WeightTextBox);
            this.flowLayoutPanel1.Controls.Add(this.HeightInfo);
            this.flowLayoutPanel1.Controls.Add(this.HeightTextBox);
            this.flowLayoutPanel1.Controls.Add(this.CabinsNumInfo);
            this.flowLayoutPanel1.Controls.Add(this.CabinsNumTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 58);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NameInfo
            // 
            this.NameInfo.AutoSize = true;
            this.NameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInfo.Location = new System.Drawing.Point(3, 3);
            this.NameInfo.Margin = new System.Windows.Forms.Padding(3);
            this.NameInfo.Name = "NameInfo";
            this.NameInfo.Size = new System.Drawing.Size(45, 16);
            this.NameInfo.TabIndex = 0;
            this.NameInfo.Text = "Nome";
            // 
            // ShipNameTextBox
            // 
            this.ShipNameTextBox.Location = new System.Drawing.Point(54, 3);
            this.ShipNameTextBox.MaxLength = 30;
            this.ShipNameTextBox.Name = "ShipNameTextBox";
            this.ShipNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.ShipNameTextBox.TabIndex = 1;
            // 
            // WidthInfo
            // 
            this.WidthInfo.AutoSize = true;
            this.WidthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInfo.Location = new System.Drawing.Point(289, 3);
            this.WidthInfo.Margin = new System.Windows.Forms.Padding(3);
            this.WidthInfo.Name = "WidthInfo";
            this.WidthInfo.Size = new System.Drawing.Size(70, 16);
            this.WidthInfo.TabIndex = 4;
            this.WidthInfo.Text = "Larghezza";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(365, 3);
            this.WidthTextBox.MaxLength = 3;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(38, 20);
            this.WidthTextBox.TabIndex = 5;
            // 
            // LengthInfo
            // 
            this.LengthInfo.AutoSize = true;
            this.LengthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthInfo.Location = new System.Drawing.Point(409, 3);
            this.LengthInfo.Margin = new System.Windows.Forms.Padding(3);
            this.LengthInfo.Name = "LengthInfo";
            this.LengthInfo.Size = new System.Drawing.Size(72, 16);
            this.LengthInfo.TabIndex = 6;
            this.LengthInfo.Text = "Lunghezza";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(487, 3);
            this.LengthTextBox.MaxLength = 3;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(38, 20);
            this.LengthTextBox.TabIndex = 7;
            // 
            // WeightInfo
            // 
            this.WeightInfo.AutoSize = true;
            this.WeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInfo.Location = new System.Drawing.Point(3, 29);
            this.WeightInfo.Margin = new System.Windows.Forms.Padding(3);
            this.WeightInfo.Name = "WeightInfo";
            this.WeightInfo.Size = new System.Drawing.Size(40, 16);
            this.WeightInfo.TabIndex = 8;
            this.WeightInfo.Text = "Peso";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(49, 29);
            this.WeightTextBox.MaxLength = 6;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(63, 20);
            this.WeightTextBox.TabIndex = 9;
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(118, 29);
            this.HeightInfo.Margin = new System.Windows.Forms.Padding(3);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(51, 16);
            this.HeightInfo.TabIndex = 10;
            this.HeightInfo.Text = "Altezza";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(175, 29);
            this.HeightTextBox.MaxLength = 3;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(38, 20);
            this.HeightTextBox.TabIndex = 11;
            // 
            // CabinsNumInfo
            // 
            this.CabinsNumInfo.AutoSize = true;
            this.CabinsNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinsNumInfo.Location = new System.Drawing.Point(219, 29);
            this.CabinsNumInfo.Margin = new System.Windows.Forms.Padding(3);
            this.CabinsNumInfo.Name = "CabinsNumInfo";
            this.CabinsNumInfo.Size = new System.Drawing.Size(102, 16);
            this.CabinsNumInfo.TabIndex = 12;
            this.CabinsNumInfo.Text = "Numero Cabine";
            // 
            // CabinsNumTextBox
            // 
            this.CabinsNumTextBox.Location = new System.Drawing.Point(327, 29);
            this.CabinsNumTextBox.MaxLength = 4;
            this.CabinsNumTextBox.Name = "CabinsNumTextBox";
            this.CabinsNumTextBox.Size = new System.Drawing.Size(45, 20);
            this.CabinsNumTextBox.TabIndex = 13;
            // 
            // errorProviderInfo
            // 
            this.errorProviderInfo.ContainerControl = this;
            // 
            // InsertPathInfoBox
            // 
            this.InsertPathInfoBox.Controls.Add(this.InsertedSections);
            this.InsertPathInfoBox.Controls.Add(this.SectionsListBox);
            this.InsertPathInfoBox.Controls.Add(this.button2);
            this.InsertPathInfoBox.Controls.Add(this.AddPathBtn);
            this.InsertPathInfoBox.Controls.Add(this.flowLayoutPanel2);
            this.InsertPathInfoBox.Controls.Add(this.InsertSectionPathBtn);
            this.InsertPathInfoBox.Controls.Add(this.DeleteSectionPathBtn);
            this.InsertPathInfoBox.Location = new System.Drawing.Point(3, 80);
            this.InsertPathInfoBox.Name = "InsertPathInfoBox";
            this.InsertPathInfoBox.Size = new System.Drawing.Size(710, 152);
            this.InsertPathInfoBox.TabIndex = 1;
            this.InsertPathInfoBox.TabStop = false;
            this.InsertPathInfoBox.Text = "Inserisci Percorso";
            // 
            // InsertedSections
            // 
            this.InsertedSections.FormattingEnabled = true;
            this.InsertedSections.Location = new System.Drawing.Point(223, 19);
            this.InsertedSections.Name = "InsertedSections";
            this.InsertedSections.Size = new System.Drawing.Size(160, 121);
            this.InsertedSections.TabIndex = 16;
            // 
            // SectionsListBox
            // 
            this.SectionsListBox.FormattingEnabled = true;
            this.SectionsListBox.Location = new System.Drawing.Point(9, 19);
            this.SectionsListBox.Name = "SectionsListBox";
            this.SectionsListBox.Size = new System.Drawing.Size(170, 121);
            this.SectionsListBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pulisci";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddPathBtn
            // 
            this.AddPathBtn.Location = new System.Drawing.Point(389, 117);
            this.AddPathBtn.Name = "AddPathBtn";
            this.AddPathBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPathBtn.TabIndex = 3;
            this.AddPathBtn.Text = "Aggiungi";
            this.AddPathBtn.UseVisualStyleBackColor = true;
            this.AddPathBtn.Click += new System.EventHandler(this.AddPathBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CodPathInfo);
            this.flowLayoutPanel2.Controls.Add(this.CodPathTextBox);
            this.flowLayoutPanel2.Controls.Add(this.DurationInfo);
            this.flowLayoutPanel2.Controls.Add(this.DurationTextBox);
            this.flowLayoutPanel2.Controls.Add(this.ShipNameInfo);
            this.flowLayoutPanel2.Controls.Add(this.ShipNameComboPath);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(389, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(315, 80);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // CodPathInfo
            // 
            this.CodPathInfo.AutoSize = true;
            this.CodPathInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodPathInfo.Location = new System.Drawing.Point(3, 3);
            this.CodPathInfo.Margin = new System.Windows.Forms.Padding(3);
            this.CodPathInfo.Name = "CodPathInfo";
            this.CodPathInfo.Size = new System.Drawing.Size(109, 16);
            this.CodPathInfo.TabIndex = 0;
            this.CodPathInfo.Text = "Codice Percorso";
            // 
            // CodPathTextBox
            // 
            this.CodPathTextBox.Location = new System.Drawing.Point(118, 3);
            this.CodPathTextBox.MaxLength = 5;
            this.CodPathTextBox.Name = "CodPathTextBox";
            this.CodPathTextBox.Size = new System.Drawing.Size(52, 20);
            this.CodPathTextBox.TabIndex = 1;
            // 
            // DurationInfo
            // 
            this.DurationInfo.AutoSize = true;
            this.DurationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationInfo.Location = new System.Drawing.Point(176, 3);
            this.DurationInfo.Margin = new System.Windows.Forms.Padding(3);
            this.DurationInfo.Name = "DurationInfo";
            this.DurationInfo.Size = new System.Drawing.Size(86, 16);
            this.DurationInfo.TabIndex = 4;
            this.DurationInfo.Text = "Giorni Durata";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(268, 3);
            this.DurationTextBox.MaxLength = 2;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(42, 20);
            this.DurationTextBox.TabIndex = 5;
            // 
            // ShipNameInfo
            // 
            this.ShipNameInfo.AutoSize = true;
            this.ShipNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipNameInfo.Location = new System.Drawing.Point(3, 29);
            this.ShipNameInfo.Margin = new System.Windows.Forms.Padding(3);
            this.ShipNameInfo.Name = "ShipNameInfo";
            this.ShipNameInfo.Size = new System.Drawing.Size(81, 16);
            this.ShipNameInfo.TabIndex = 14;
            this.ShipNameInfo.Text = "Nome Nave";
            // 
            // ShipNameComboPath
            // 
            this.ShipNameComboPath.FormattingEnabled = true;
            this.ShipNameComboPath.Location = new System.Drawing.Point(3, 51);
            this.ShipNameComboPath.Name = "ShipNameComboPath";
            this.ShipNameComboPath.Size = new System.Drawing.Size(307, 21);
            this.ShipNameComboPath.TabIndex = 2;
            this.ShipNameComboPath.Click += new System.EventHandler(this.ShipNameComboPath_Click);
            // 
            // InsertSectionPathBtn
            // 
            this.InsertSectionPathBtn.Location = new System.Drawing.Point(185, 41);
            this.InsertSectionPathBtn.Name = "InsertSectionPathBtn";
            this.InsertSectionPathBtn.Size = new System.Drawing.Size(32, 23);
            this.InsertSectionPathBtn.TabIndex = 18;
            this.InsertSectionPathBtn.Text = "->";
            this.InsertSectionPathBtn.UseVisualStyleBackColor = true;
            this.InsertSectionPathBtn.Click += new System.EventHandler(this.InsertSectionPathBtn_Click);
            // 
            // DeleteSectionPathBtn
            // 
            this.DeleteSectionPathBtn.Location = new System.Drawing.Point(185, 68);
            this.DeleteSectionPathBtn.Name = "DeleteSectionPathBtn";
            this.DeleteSectionPathBtn.Size = new System.Drawing.Size(32, 23);
            this.DeleteSectionPathBtn.TabIndex = 19;
            this.DeleteSectionPathBtn.Text = "<-";
            this.DeleteSectionPathBtn.UseVisualStyleBackColor = true;
            this.DeleteSectionPathBtn.Click += new System.EventHandler(this.DeleteSectionPathBtn_Click);
            // 
            // InsertHarborInfoBox
            // 
            this.InsertHarborInfoBox.Controls.Add(this.flowLayoutPanel3);
            this.InsertHarborInfoBox.Controls.Add(this.AddHarbour);
            this.InsertHarborInfoBox.Controls.Add(this.button1);
            this.InsertHarborInfoBox.Location = new System.Drawing.Point(3, 238);
            this.InsertHarborInfoBox.Name = "InsertHarborInfoBox";
            this.InsertHarborInfoBox.Size = new System.Drawing.Size(383, 105);
            this.InsertHarborInfoBox.TabIndex = 20;
            this.InsertHarborInfoBox.TabStop = false;
            this.InsertHarborInfoBox.Text = "Inserisci Porto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pulisci";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddHarbour
            // 
            this.AddHarbour.Location = new System.Drawing.Point(301, 19);
            this.AddHarbour.Name = "AddHarbour";
            this.AddHarbour.Size = new System.Drawing.Size(75, 23);
            this.AddHarbour.TabIndex = 3;
            this.AddHarbour.Text = "Aggiungi";
            this.AddHarbour.UseVisualStyleBackColor = true;
            this.AddHarbour.Click += new System.EventHandler(this.AddHarbour_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.HarborCodeInfo);
            this.flowLayoutPanel3.Controls.Add(this.HarborCodeTextBox);
            this.flowLayoutPanel3.Controls.Add(this.NationalityInfo);
            this.flowLayoutPanel3.Controls.Add(this.NationalityTextBox);
            this.flowLayoutPanel3.Controls.Add(this.CityInfo);
            this.flowLayoutPanel3.Controls.Add(this.CityTextBox);
            this.flowLayoutPanel3.Controls.Add(this.DockingPriceInfo);
            this.flowLayoutPanel3.Controls.Add(this.DockingPriceTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(9, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(286, 80);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // HarborCodeInfo
            // 
            this.HarborCodeInfo.AutoSize = true;
            this.HarborCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HarborCodeInfo.Location = new System.Drawing.Point(3, 3);
            this.HarborCodeInfo.Margin = new System.Windows.Forms.Padding(3);
            this.HarborCodeInfo.Name = "HarborCodeInfo";
            this.HarborCodeInfo.Size = new System.Drawing.Size(86, 16);
            this.HarborCodeInfo.TabIndex = 0;
            this.HarborCodeInfo.Text = "Codice Porto";
            this.HarborCodeInfo.Click += new System.EventHandler(this.AddHarbour_Click);
            // 
            // HarborCodeTextBox
            // 
            this.HarborCodeTextBox.Location = new System.Drawing.Point(95, 3);
            this.HarborCodeTextBox.MaxLength = 4;
            this.HarborCodeTextBox.Name = "HarborCodeTextBox";
            this.HarborCodeTextBox.Size = new System.Drawing.Size(52, 20);
            this.HarborCodeTextBox.TabIndex = 1;
            // 
            // NationalityInfo
            // 
            this.NationalityInfo.AutoSize = true;
            this.NationalityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityInfo.Location = new System.Drawing.Point(153, 3);
            this.NationalityInfo.Margin = new System.Windows.Forms.Padding(3);
            this.NationalityInfo.Name = "NationalityInfo";
            this.NationalityInfo.Size = new System.Drawing.Size(75, 16);
            this.NationalityInfo.TabIndex = 4;
            this.NationalityInfo.Text = "Nazionalità";
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(234, 3);
            this.NationalityTextBox.MaxLength = 3;
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(42, 20);
            this.NationalityTextBox.TabIndex = 5;
            // 
            // CityInfo
            // 
            this.CityInfo.AutoSize = true;
            this.CityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityInfo.Location = new System.Drawing.Point(3, 29);
            this.CityInfo.Margin = new System.Windows.Forms.Padding(3);
            this.CityInfo.Name = "CityInfo";
            this.CityInfo.Size = new System.Drawing.Size(34, 16);
            this.CityInfo.TabIndex = 14;
            this.CityInfo.Text = "Città";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(43, 29);
            this.CityTextBox.MaxLength = 30;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(233, 20);
            this.CityTextBox.TabIndex = 15;
            // 
            // DockingPriceInfo
            // 
            this.DockingPriceInfo.AutoSize = true;
            this.DockingPriceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DockingPriceInfo.Location = new System.Drawing.Point(3, 55);
            this.DockingPriceInfo.Margin = new System.Windows.Forms.Padding(3);
            this.DockingPriceInfo.Name = "DockingPriceInfo";
            this.DockingPriceInfo.Size = new System.Drawing.Size(101, 16);
            this.DockingPriceInfo.TabIndex = 16;
            this.DockingPriceInfo.Text = "Prezzo Attracco";
            // 
            // DockingPriceTextBox
            // 
            this.DockingPriceTextBox.Location = new System.Drawing.Point(110, 55);
            this.DockingPriceTextBox.MaxLength = 4;
            this.DockingPriceTextBox.Name = "DockingPriceTextBox";
            this.DockingPriceTextBox.Size = new System.Drawing.Size(52, 20);
            this.DockingPriceTextBox.TabIndex = 17;
            // 
            // AddShipPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.InsertHarborInfoBox);
            this.Controls.Add(this.InsertShipInfoBox);
            this.Controls.Add(this.InsertPathInfoBox);
            this.Name = "AddShipPopup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddShipPopup_Load);
            this.InsertShipInfoBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).EndInit();
            this.InsertPathInfoBox.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.InsertHarborInfoBox.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertShipInfoBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameInfo;
        private System.Windows.Forms.TextBox ShipNameTextBox;
        private System.Windows.Forms.Label WidthInfo;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label LengthInfo;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label WeightInfo;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightInfo;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label CabinsNumInfo;
        private System.Windows.Forms.TextBox CabinsNumTextBox;
        private System.Windows.Forms.Button AddShipInfoBtn;
        private System.Windows.Forms.Button ClearShipInfoBtn;
        private System.Windows.Forms.ErrorProvider errorProviderInfo;
        private System.Windows.Forms.GroupBox InsertPathInfoBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddPathBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label CodPathInfo;
        private System.Windows.Forms.TextBox CodPathTextBox;
        private System.Windows.Forms.Label DurationInfo;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label ShipNameInfo;
        private System.Windows.Forms.ComboBox ShipNameComboPath;
        private System.Windows.Forms.Button InsertSectionPathBtn;
        private System.Windows.Forms.ListBox InsertedSections;
        private System.Windows.Forms.ListBox SectionsListBox;
        private System.Windows.Forms.Button DeleteSectionPathBtn;
        private System.Windows.Forms.GroupBox InsertHarborInfoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddHarbour;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label HarborCodeInfo;
        private System.Windows.Forms.TextBox HarborCodeTextBox;
        private System.Windows.Forms.Label NationalityInfo;
        private System.Windows.Forms.TextBox NationalityTextBox;
        private System.Windows.Forms.Label CityInfo;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label DockingPriceInfo;
        private System.Windows.Forms.TextBox DockingPriceTextBox;
    }
}