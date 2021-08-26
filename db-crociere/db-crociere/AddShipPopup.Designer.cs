
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CodPathInfo = new System.Windows.Forms.Label();
            this.CodPathTextBox = new System.Windows.Forms.TextBox();
            this.DurationInfo = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.ShipNameInfo = new System.Windows.Forms.Label();
            this.AddPathBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ShipNameComboPath = new System.Windows.Forms.ComboBox();
            this.InsertShipInfoBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertShipInfoBox
            // 
            this.InsertShipInfoBox.Controls.Add(this.ClearShipInfoBtn);
            this.InsertShipInfoBox.Controls.Add(this.AddShipInfoBtn);
            this.InsertShipInfoBox.Controls.Add(this.flowLayoutPanel1);
            this.InsertShipInfoBox.Location = new System.Drawing.Point(18, 217);
            this.InsertShipInfoBox.Name = "InsertShipInfoBox";
            this.InsertShipInfoBox.Size = new System.Drawing.Size(760, 100);
            this.InsertShipInfoBox.TabIndex = 0;
            this.InsertShipInfoBox.TabStop = false;
            this.InsertShipInfoBox.Text = "Inserisci nuova Nave";
            // 
            // ClearShipInfoBtn
            // 
            this.ClearShipInfoBtn.Location = new System.Drawing.Point(469, 74);
            this.ClearShipInfoBtn.Name = "ClearShipInfoBtn";
            this.ClearShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearShipInfoBtn.TabIndex = 2;
            this.ClearShipInfoBtn.Text = "Pulisci";
            this.ClearShipInfoBtn.UseVisualStyleBackColor = true;
            // 
            // AddShipInfoBtn
            // 
            this.AddShipInfoBtn.Location = new System.Drawing.Point(469, 16);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 81);
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
            this.ShipNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShipNameTextBox_Validating);
            // 
            // WidthInfo
            // 
            this.WidthInfo.AutoSize = true;
            this.WidthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInfo.Location = new System.Drawing.Point(311, 3);
            this.WidthInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.WidthInfo.Name = "WidthInfo";
            this.WidthInfo.Size = new System.Drawing.Size(70, 16);
            this.WidthInfo.TabIndex = 4;
            this.WidthInfo.Text = "Larghezza";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(387, 3);
            this.WidthTextBox.MaxLength = 3;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(38, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // LengthInfo
            // 
            this.LengthInfo.AutoSize = true;
            this.LengthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthInfo.Location = new System.Drawing.Point(3, 29);
            this.LengthInfo.Margin = new System.Windows.Forms.Padding(3);
            this.LengthInfo.Name = "LengthInfo";
            this.LengthInfo.Size = new System.Drawing.Size(72, 16);
            this.LengthInfo.TabIndex = 6;
            this.LengthInfo.Text = "Lunghezza";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(81, 29);
            this.LengthTextBox.MaxLength = 3;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(38, 20);
            this.LengthTextBox.TabIndex = 7;
            this.LengthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LengthTextBox_Validating);
            // 
            // WeightInfo
            // 
            this.WeightInfo.AutoSize = true;
            this.WeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInfo.Location = new System.Drawing.Point(147, 29);
            this.WeightInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.WeightInfo.Name = "WeightInfo";
            this.WeightInfo.Size = new System.Drawing.Size(40, 16);
            this.WeightInfo.TabIndex = 8;
            this.WeightInfo.Text = "Peso";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(193, 29);
            this.WeightTextBox.MaxLength = 6;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(63, 20);
            this.WeightTextBox.TabIndex = 9;
            this.WeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightTextBox_Validating);
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(284, 29);
            this.HeightInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(51, 16);
            this.HeightInfo.TabIndex = 10;
            this.HeightInfo.Text = "Altezza";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(341, 29);
            this.HeightTextBox.MaxLength = 3;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(38, 20);
            this.HeightTextBox.TabIndex = 11;
            this.HeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HeightInfoTextBox_Validating);
            // 
            // CabinsNumInfo
            // 
            this.CabinsNumInfo.AutoSize = true;
            this.CabinsNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinsNumInfo.Location = new System.Drawing.Point(3, 55);
            this.CabinsNumInfo.Margin = new System.Windows.Forms.Padding(3);
            this.CabinsNumInfo.Name = "CabinsNumInfo";
            this.CabinsNumInfo.Size = new System.Drawing.Size(102, 16);
            this.CabinsNumInfo.TabIndex = 12;
            this.CabinsNumInfo.Text = "Numero Cabine";
            // 
            // CabinsNumTextBox
            // 
            this.CabinsNumTextBox.Location = new System.Drawing.Point(111, 55);
            this.CabinsNumTextBox.MaxLength = 4;
            this.CabinsNumTextBox.Name = "CabinsNumTextBox";
            this.CabinsNumTextBox.Size = new System.Drawing.Size(45, 20);
            this.CabinsNumTextBox.TabIndex = 13;
            this.CabinsNumTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CabinsNumTextBox_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddPathBtn);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Percorso";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CodPathInfo);
            this.flowLayoutPanel2.Controls.Add(this.CodPathTextBox);
            this.flowLayoutPanel2.Controls.Add(this.DurationInfo);
            this.flowLayoutPanel2.Controls.Add(this.DurationTextBox);
            this.flowLayoutPanel2.Controls.Add(this.ShipNameInfo);
            this.flowLayoutPanel2.Controls.Add(this.ShipNameComboPath);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(366, 53);
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
            this.DurationInfo.Location = new System.Drawing.Point(198, 3);
            this.DurationInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.DurationInfo.Name = "DurationInfo";
            this.DurationInfo.Size = new System.Drawing.Size(86, 16);
            this.DurationInfo.TabIndex = 4;
            this.DurationInfo.Text = "Giorni Durata";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(290, 3);
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
            this.ShipNameInfo.Size = new System.Drawing.Size(45, 16);
            this.ShipNameInfo.TabIndex = 14;
            this.ShipNameInfo.Text = "Nome";
            // 
            // AddPathBtn
            // 
            this.AddPathBtn.Location = new System.Drawing.Point(372, 19);
            this.AddPathBtn.Name = "AddPathBtn";
            this.AddPathBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPathBtn.TabIndex = 3;
            this.AddPathBtn.Text = "Aggiungi";
            this.AddPathBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pulisci";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ShipNameComboPath
            // 
            this.ShipNameComboPath.FormattingEnabled = true;
            this.ShipNameComboPath.Location = new System.Drawing.Point(54, 29);
            this.ShipNameComboPath.Name = "ShipNameComboPath";
            this.ShipNameComboPath.Size = new System.Drawing.Size(278, 21);
            this.ShipNameComboPath.TabIndex = 2;
            this.ShipNameComboPath.Click += new System.EventHandler(this.ShipNameComboPath_Click);
            // 
            // AddShipPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertShipInfoBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddShipPopup";
            this.Text = "Form1";
            this.InsertShipInfoBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddPathBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label CodPathInfo;
        private System.Windows.Forms.TextBox CodPathTextBox;
        private System.Windows.Forms.Label DurationInfo;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label ShipNameInfo;
        private System.Windows.Forms.ComboBox ShipNameComboPath;
    }
}