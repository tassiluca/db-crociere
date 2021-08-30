
namespace db_crociere
{
    partial class AddExpensesPopup
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
            this.InsertShipInfoBox = new System.Windows.Forms.GroupBox();
            this.ClearShipInfoBtn = new System.Windows.Forms.Button();
            this.AddShipInfoBtn = new System.Windows.Forms.Button();
            this.ShipNameInfo = new System.Windows.Forms.Label();
            this.ShipNameComboBox = new System.Windows.Forms.ComboBox();
            this.TypeInfo = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.StartDateInfo = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateInfo = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.HeightInfo = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InsertShipInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertShipInfoBox
            // 
            this.InsertShipInfoBox.Controls.Add(this.ShipNameInfo);
            this.InsertShipInfoBox.Controls.Add(this.ShipNameComboBox);
            this.InsertShipInfoBox.Controls.Add(this.TypeInfo);
            this.InsertShipInfoBox.Controls.Add(this.TypeComboBox);
            this.InsertShipInfoBox.Controls.Add(this.StartDateInfo);
            this.InsertShipInfoBox.Controls.Add(this.StartDatePicker);
            this.InsertShipInfoBox.Controls.Add(this.EndDateInfo);
            this.InsertShipInfoBox.Controls.Add(this.EndDatePicker);
            this.InsertShipInfoBox.Controls.Add(this.HeightInfo);
            this.InsertShipInfoBox.Controls.Add(this.PriceTextBox);
            this.InsertShipInfoBox.Controls.Add(this.ClearShipInfoBtn);
            this.InsertShipInfoBox.Controls.Add(this.AddShipInfoBtn);
            this.InsertShipInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertShipInfoBox.Location = new System.Drawing.Point(0, 0);
            this.InsertShipInfoBox.Name = "InsertShipInfoBox";
            this.InsertShipInfoBox.Size = new System.Drawing.Size(800, 72);
            this.InsertShipInfoBox.TabIndex = 1;
            this.InsertShipInfoBox.TabStop = false;
            this.InsertShipInfoBox.Text = "Inserisci nuovo tariffario";
            // 
            // ClearShipInfoBtn
            // 
            this.ClearShipInfoBtn.Location = new System.Drawing.Point(719, 45);
            this.ClearShipInfoBtn.Name = "ClearShipInfoBtn";
            this.ClearShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearShipInfoBtn.TabIndex = 2;
            this.ClearShipInfoBtn.Text = "Pulisci";
            this.ClearShipInfoBtn.UseVisualStyleBackColor = true;
            // 
            // AddShipInfoBtn
            // 
            this.AddShipInfoBtn.Location = new System.Drawing.Point(719, 16);
            this.AddShipInfoBtn.Name = "AddShipInfoBtn";
            this.AddShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.AddShipInfoBtn.TabIndex = 1;
            this.AddShipInfoBtn.Text = "Aggiungi";
            this.AddShipInfoBtn.UseVisualStyleBackColor = true;
            this.AddShipInfoBtn.Click += new System.EventHandler(this.AddShipInfoBtn_Click);
            // 
            // ShipNameInfo
            // 
            this.ShipNameInfo.AutoSize = true;
            this.ShipNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipNameInfo.Location = new System.Drawing.Point(6, 20);
            this.ShipNameInfo.Margin = new System.Windows.Forms.Padding(3);
            this.ShipNameInfo.Name = "ShipNameInfo";
            this.ShipNameInfo.Size = new System.Drawing.Size(78, 16);
            this.ShipNameInfo.TabIndex = 18;
            this.ShipNameInfo.Text = "NomeNave";
            // 
            // ShipNameComboBox
            // 
            this.ShipNameComboBox.FormattingEnabled = true;
            this.ShipNameComboBox.Location = new System.Drawing.Point(90, 19);
            this.ShipNameComboBox.Name = "ShipNameComboBox";
            this.ShipNameComboBox.Size = new System.Drawing.Size(208, 21);
            this.ShipNameComboBox.TabIndex = 25;
            this.ShipNameComboBox.Click += new System.EventHandler(this.ShipNameComboBox_Click);
            // 
            // TypeInfo
            // 
            this.TypeInfo.AutoSize = true;
            this.TypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeInfo.Location = new System.Drawing.Point(304, 20);
            this.TypeInfo.Margin = new System.Windows.Forms.Padding(3);
            this.TypeInfo.Name = "TypeInfo";
            this.TypeInfo.Size = new System.Drawing.Size(66, 16);
            this.TypeInfo.TabIndex = 19;
            this.TypeInfo.Text = "Tipologia";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(376, 19);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(169, 21);
            this.TypeComboBox.TabIndex = 26;
            this.TypeComboBox.Click += new System.EventHandler(this.TypeComboBox_Click);
            // 
            // StartDateInfo
            // 
            this.StartDateInfo.AutoSize = true;
            this.StartDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateInfo.Location = new System.Drawing.Point(6, 46);
            this.StartDateInfo.Margin = new System.Windows.Forms.Padding(3);
            this.StartDateInfo.Name = "StartDateInfo";
            this.StartDateInfo.Size = new System.Drawing.Size(70, 16);
            this.StartDateInfo.TabIndex = 20;
            this.StartDateInfo.Text = "Data Inizio";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(90, 45);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(177, 20);
            this.StartDatePicker.TabIndex = 27;
            // 
            // EndDateInfo
            // 
            this.EndDateInfo.AutoSize = true;
            this.EndDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateInfo.Location = new System.Drawing.Point(273, 46);
            this.EndDateInfo.Margin = new System.Windows.Forms.Padding(3);
            this.EndDateInfo.Name = "EndDateInfo";
            this.EndDateInfo.Size = new System.Drawing.Size(66, 16);
            this.EndDateInfo.TabIndex = 21;
            this.EndDateInfo.Text = "Data Fine";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(345, 45);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 28;
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(551, 46);
            this.HeightInfo.Margin = new System.Windows.Forms.Padding(3);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(49, 16);
            this.HeightInfo.TabIndex = 22;
            this.HeightInfo.Text = "Prezzo";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(606, 45);
            this.PriceTextBox.MaxLength = 4;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(61, 20);
            this.PriceTextBox.TabIndex = 23;
            // 
            // AddExpensesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertShipInfoBox);
            this.Name = "AddExpensesPopup";
            this.Text = "Form1";
            this.InsertShipInfoBox.ResumeLayout(false);
            this.InsertShipInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertShipInfoBox;
        private System.Windows.Forms.Button ClearShipInfoBtn;
        private System.Windows.Forms.Button AddShipInfoBtn;
        private System.Windows.Forms.Label ShipNameInfo;
        private System.Windows.Forms.ComboBox ShipNameComboBox;
        private System.Windows.Forms.Label TypeInfo;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label StartDateInfo;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label EndDateInfo;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label HeightInfo;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}