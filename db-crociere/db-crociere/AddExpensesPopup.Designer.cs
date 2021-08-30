
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BadgeIdInfo = new System.Windows.Forms.Label();
            this.DateExpenseInfo = new System.Windows.Forms.Label();
            this.DateExpensePicker = new System.Windows.Forms.DateTimePicker();
            this.AmountExpenseInfo = new System.Windows.Forms.Label();
            this.AmountExpenseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.Infos = new System.Windows.Forms.Label();
            this.InfosTextBox = new System.Windows.Forms.RichTextBox();
            this.BadgeIdTextBox = new System.Windows.Forms.TextBox();
            this.InsertShipInfoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.InsertShipInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertShipInfoBox.Location = new System.Drawing.Point(359, 12);
            this.InsertShipInfoBox.Name = "InsertShipInfoBox";
            this.InsertShipInfoBox.Size = new System.Drawing.Size(317, 204);
            this.InsertShipInfoBox.TabIndex = 1;
            this.InsertShipInfoBox.TabStop = false;
            this.InsertShipInfoBox.Text = "Inserisci nuovo tariffario";
            // 
            // ClearShipInfoBtn
            // 
            this.ClearShipInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearShipInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearShipInfoBtn.Location = new System.Drawing.Point(9, 167);
            this.ClearShipInfoBtn.Name = "ClearShipInfoBtn";
            this.ClearShipInfoBtn.Size = new System.Drawing.Size(75, 31);
            this.ClearShipInfoBtn.TabIndex = 2;
            this.ClearShipInfoBtn.Text = "Pulisci";
            this.ClearShipInfoBtn.UseVisualStyleBackColor = false;
            // 
            // AddShipInfoBtn
            // 
            this.AddShipInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddShipInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddShipInfoBtn.Location = new System.Drawing.Point(236, 167);
            this.AddShipInfoBtn.Name = "AddShipInfoBtn";
            this.AddShipInfoBtn.Size = new System.Drawing.Size(75, 31);
            this.AddShipInfoBtn.TabIndex = 1;
            this.AddShipInfoBtn.Text = "Aggiungi";
            this.AddShipInfoBtn.UseVisualStyleBackColor = false;
            this.AddShipInfoBtn.Click += new System.EventHandler(this.AddShipInfoBtn_Click);
            // 
            // ShipNameInfo
            // 
            this.ShipNameInfo.AutoSize = true;
            this.ShipNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipNameInfo.Location = new System.Drawing.Point(6, 20);
            this.ShipNameInfo.Margin = new System.Windows.Forms.Padding(3);
            this.ShipNameInfo.Name = "ShipNameInfo";
            this.ShipNameInfo.Size = new System.Drawing.Size(81, 16);
            this.ShipNameInfo.TabIndex = 18;
            this.ShipNameInfo.Text = "Nome Nave";
            // 
            // ShipNameComboBox
            // 
            this.ShipNameComboBox.FormattingEnabled = true;
            this.ShipNameComboBox.Location = new System.Drawing.Point(90, 19);
            this.ShipNameComboBox.Name = "ShipNameComboBox";
            this.ShipNameComboBox.Size = new System.Drawing.Size(221, 24);
            this.ShipNameComboBox.TabIndex = 25;
            this.ShipNameComboBox.Click += new System.EventHandler(this.ShipNameComboBox_Click);
            // 
            // TypeInfo
            // 
            this.TypeInfo.AutoSize = true;
            this.TypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeInfo.Location = new System.Drawing.Point(6, 49);
            this.TypeInfo.Margin = new System.Windows.Forms.Padding(3);
            this.TypeInfo.Name = "TypeInfo";
            this.TypeInfo.Size = new System.Drawing.Size(66, 16);
            this.TypeInfo.TabIndex = 19;
            this.TypeInfo.Text = "Tipologia";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(90, 46);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(221, 24);
            this.TypeComboBox.TabIndex = 26;
            this.TypeComboBox.Click += new System.EventHandler(this.TypeComboBox_Click);
            // 
            // StartDateInfo
            // 
            this.StartDateInfo.AutoSize = true;
            this.StartDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateInfo.Location = new System.Drawing.Point(6, 76);
            this.StartDateInfo.Margin = new System.Windows.Forms.Padding(3);
            this.StartDateInfo.Name = "StartDateInfo";
            this.StartDateInfo.Size = new System.Drawing.Size(70, 16);
            this.StartDateInfo.TabIndex = 20;
            this.StartDateInfo.Text = "Data Inizio";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(90, 76);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(221, 22);
            this.StartDatePicker.TabIndex = 27;
            // 
            // EndDateInfo
            // 
            this.EndDateInfo.AutoSize = true;
            this.EndDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateInfo.Location = new System.Drawing.Point(6, 103);
            this.EndDateInfo.Margin = new System.Windows.Forms.Padding(3);
            this.EndDateInfo.Name = "EndDateInfo";
            this.EndDateInfo.Size = new System.Drawing.Size(66, 16);
            this.EndDateInfo.TabIndex = 21;
            this.EndDateInfo.Text = "Data Fine";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(90, 103);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(221, 22);
            this.EndDatePicker.TabIndex = 28;
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(6, 132);
            this.HeightInfo.Margin = new System.Windows.Forms.Padding(3);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(49, 16);
            this.HeightInfo.TabIndex = 22;
            this.HeightInfo.Text = "Prezzo";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(90, 129);
            this.PriceTextBox.MaxLength = 4;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(61, 22);
            this.PriceTextBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BadgeIdTextBox);
            this.groupBox1.Controls.Add(this.InfosTextBox);
            this.groupBox1.Controls.Add(this.Infos);
            this.groupBox1.Controls.Add(this.BadgeIdInfo);
            this.groupBox1.Controls.Add(this.DateExpenseInfo);
            this.groupBox1.Controls.Add(this.DateExpensePicker);
            this.groupBox1.Controls.Add(this.AmountExpenseInfo);
            this.groupBox1.Controls.Add(this.AmountExpenseTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddExpenseBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci nuova spesa extra";
            // 
            // BadgeIdInfo
            // 
            this.BadgeIdInfo.AutoSize = true;
            this.BadgeIdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BadgeIdInfo.Location = new System.Drawing.Point(6, 20);
            this.BadgeIdInfo.Margin = new System.Windows.Forms.Padding(3);
            this.BadgeIdInfo.Name = "BadgeIdInfo";
            this.BadgeIdInfo.Size = new System.Drawing.Size(95, 16);
            this.BadgeIdInfo.TabIndex = 18;
            this.BadgeIdInfo.Text = "Codice Badge";
            // 
            // DateExpenseInfo
            // 
            this.DateExpenseInfo.AutoSize = true;
            this.DateExpenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateExpenseInfo.Location = new System.Drawing.Point(6, 46);
            this.DateExpenseInfo.Margin = new System.Windows.Forms.Padding(3);
            this.DateExpenseInfo.Name = "DateExpenseInfo";
            this.DateExpenseInfo.Size = new System.Drawing.Size(37, 16);
            this.DateExpenseInfo.TabIndex = 20;
            this.DateExpenseInfo.Text = "Data";
            // 
            // DateExpensePicker
            // 
            this.DateExpensePicker.Location = new System.Drawing.Point(107, 44);
            this.DateExpensePicker.Name = "DateExpensePicker";
            this.DateExpensePicker.Size = new System.Drawing.Size(216, 22);
            this.DateExpensePicker.TabIndex = 27;
            // 
            // AmountExpenseInfo
            // 
            this.AmountExpenseInfo.AutoSize = true;
            this.AmountExpenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountExpenseInfo.Location = new System.Drawing.Point(6, 77);
            this.AmountExpenseInfo.Margin = new System.Windows.Forms.Padding(3);
            this.AmountExpenseInfo.Name = "AmountExpenseInfo";
            this.AmountExpenseInfo.Size = new System.Drawing.Size(53, 16);
            this.AmountExpenseInfo.TabIndex = 22;
            this.AmountExpenseInfo.Text = "Importo";
            // 
            // AmountExpenseTextBox
            // 
            this.AmountExpenseTextBox.Location = new System.Drawing.Point(107, 74);
            this.AmountExpenseTextBox.MaxLength = 3;
            this.AmountExpenseTextBox.Name = "AmountExpenseTextBox";
            this.AmountExpenseTextBox.Size = new System.Drawing.Size(61, 22);
            this.AmountExpenseTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pulisci";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddExpenseBtn
            // 
            this.AddExpenseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddExpenseBtn.FlatAppearance.BorderSize = 0;
            this.AddExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddExpenseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddExpenseBtn.Location = new System.Drawing.Point(248, 167);
            this.AddExpenseBtn.Name = "AddExpenseBtn";
            this.AddExpenseBtn.Size = new System.Drawing.Size(75, 31);
            this.AddExpenseBtn.TabIndex = 1;
            this.AddExpenseBtn.Text = "Aggiungi";
            this.AddExpenseBtn.UseVisualStyleBackColor = false;
            this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // Infos
            // 
            this.Infos.AutoSize = true;
            this.Infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infos.Location = new System.Drawing.Point(6, 103);
            this.Infos.Margin = new System.Windows.Forms.Padding(3);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(79, 16);
            this.Infos.TabIndex = 28;
            this.Infos.Text = "Descrizione";
            // 
            // InfosTextBox
            // 
            this.InfosTextBox.Location = new System.Drawing.Point(107, 102);
            this.InfosTextBox.MaxLength = 100;
            this.InfosTextBox.Name = "InfosTextBox";
            this.InfosTextBox.Size = new System.Drawing.Size(216, 32);
            this.InfosTextBox.TabIndex = 30;
            this.InfosTextBox.Text = "";
            // 
            // BadgeIdTextBox
            // 
            this.BadgeIdTextBox.Location = new System.Drawing.Point(107, 18);
            this.BadgeIdTextBox.MaxLength = 10;
            this.BadgeIdTextBox.Name = "BadgeIdTextBox";
            this.BadgeIdTextBox.Size = new System.Drawing.Size(216, 22);
            this.BadgeIdTextBox.TabIndex = 31;
            // 
            // AddExpensesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsertShipInfoBox);
            this.Name = "AddExpensesPopup";
            this.Text = "Form1";
            this.InsertShipInfoBox.ResumeLayout(false);
            this.InsertShipInfoBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox InfosTextBox;
        private System.Windows.Forms.Label Infos;
        private System.Windows.Forms.Label BadgeIdInfo;
        private System.Windows.Forms.Label DateExpenseInfo;
        private System.Windows.Forms.DateTimePicker DateExpensePicker;
        private System.Windows.Forms.Label AmountExpenseInfo;
        private System.Windows.Forms.TextBox AmountExpenseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddExpenseBtn;
        private System.Windows.Forms.TextBox BadgeIdTextBox;
    }
}