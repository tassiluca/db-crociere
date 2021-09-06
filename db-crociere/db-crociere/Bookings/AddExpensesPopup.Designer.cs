
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
            this.InsertPricesGroupBox = new System.Windows.Forms.GroupBox();
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
            this.AddPriceBtn = new System.Windows.Forms.Button();
            this.InsertExpensesGroupBox = new System.Windows.Forms.GroupBox();
            this.BadgeIdTextBox = new System.Windows.Forms.TextBox();
            this.InfosTextBox = new System.Windows.Forms.RichTextBox();
            this.Infos = new System.Windows.Forms.Label();
            this.BadgeIdInfo = new System.Windows.Forms.Label();
            this.DateExpenseInfo = new System.Windows.Forms.Label();
            this.DateExpensePicker = new System.Windows.Forms.DateTimePicker();
            this.AmountExpenseInfo = new System.Windows.Forms.Label();
            this.AmountExpenseTextBox = new System.Windows.Forms.TextBox();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RefundTextBox = new System.Windows.Forms.TextBox();
            this.AddRefundBtn = new System.Windows.Forms.Button();
            this.FromNoticeTextBox = new System.Windows.Forms.TextBox();
            this.ToNoticeTextBox = new System.Windows.Forms.TextBox();
            this.InsertPricesGroupBox.SuspendLayout();
            this.InsertExpensesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertPricesGroupBox
            // 
            this.InsertPricesGroupBox.Controls.Add(this.ShipNameInfo);
            this.InsertPricesGroupBox.Controls.Add(this.ShipNameComboBox);
            this.InsertPricesGroupBox.Controls.Add(this.TypeInfo);
            this.InsertPricesGroupBox.Controls.Add(this.TypeComboBox);
            this.InsertPricesGroupBox.Controls.Add(this.StartDateInfo);
            this.InsertPricesGroupBox.Controls.Add(this.StartDatePicker);
            this.InsertPricesGroupBox.Controls.Add(this.EndDateInfo);
            this.InsertPricesGroupBox.Controls.Add(this.EndDatePicker);
            this.InsertPricesGroupBox.Controls.Add(this.HeightInfo);
            this.InsertPricesGroupBox.Controls.Add(this.PriceTextBox);
            this.InsertPricesGroupBox.Controls.Add(this.AddPriceBtn);
            this.InsertPricesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertPricesGroupBox.Location = new System.Drawing.Point(359, 12);
            this.InsertPricesGroupBox.Name = "InsertPricesGroupBox";
            this.InsertPricesGroupBox.Size = new System.Drawing.Size(317, 204);
            this.InsertPricesGroupBox.TabIndex = 1;
            this.InsertPricesGroupBox.TabStop = false;
            this.InsertPricesGroupBox.Text = "Inserisci nuovo tariffario";
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
            // AddPriceBtn
            // 
            this.AddPriceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPriceBtn.Location = new System.Drawing.Point(236, 167);
            this.AddPriceBtn.Name = "AddPriceBtn";
            this.AddPriceBtn.Size = new System.Drawing.Size(75, 31);
            this.AddPriceBtn.TabIndex = 1;
            this.AddPriceBtn.Text = "Aggiungi";
            this.AddPriceBtn.UseVisualStyleBackColor = false;
            this.AddPriceBtn.Click += new System.EventHandler(this.AddPriceBtn_Click);
            // 
            // InsertExpensesGroupBox
            // 
            this.InsertExpensesGroupBox.Controls.Add(this.BadgeIdTextBox);
            this.InsertExpensesGroupBox.Controls.Add(this.InfosTextBox);
            this.InsertExpensesGroupBox.Controls.Add(this.Infos);
            this.InsertExpensesGroupBox.Controls.Add(this.BadgeIdInfo);
            this.InsertExpensesGroupBox.Controls.Add(this.DateExpenseInfo);
            this.InsertExpensesGroupBox.Controls.Add(this.DateExpensePicker);
            this.InsertExpensesGroupBox.Controls.Add(this.AmountExpenseInfo);
            this.InsertExpensesGroupBox.Controls.Add(this.AmountExpenseTextBox);
            this.InsertExpensesGroupBox.Controls.Add(this.AddExpenseBtn);
            this.InsertExpensesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertExpensesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InsertExpensesGroupBox.Name = "InsertExpensesGroupBox";
            this.InsertExpensesGroupBox.Size = new System.Drawing.Size(329, 204);
            this.InsertExpensesGroupBox.TabIndex = 2;
            this.InsertExpensesGroupBox.TabStop = false;
            this.InsertExpensesGroupBox.Text = "Inserisci nuova spesa extra";
            // 
            // BadgeIdTextBox
            // 
            this.BadgeIdTextBox.Location = new System.Drawing.Point(107, 18);
            this.BadgeIdTextBox.MaxLength = 10;
            this.BadgeIdTextBox.Name = "BadgeIdTextBox";
            this.BadgeIdTextBox.Size = new System.Drawing.Size(216, 22);
            this.BadgeIdTextBox.TabIndex = 31;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToNoticeTextBox);
            this.groupBox1.Controls.Add(this.FromNoticeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RefundTextBox);
            this.groupBox1.Controls.Add(this.AddRefundBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(676, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 204);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definisci nuova tariffa per rimborsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Da";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rimborso \r\n(%)";
            // 
            // RefundTextBox
            // 
            this.RefundTextBox.Location = new System.Drawing.Point(90, 103);
            this.RefundTextBox.MaxLength = 3;
            this.RefundTextBox.Name = "RefundTextBox";
            this.RefundTextBox.Size = new System.Drawing.Size(59, 22);
            this.RefundTextBox.TabIndex = 23;
            // 
            // AddRefundBtn
            // 
            this.AddRefundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddRefundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRefundBtn.Location = new System.Drawing.Point(84, 167);
            this.AddRefundBtn.Name = "AddRefundBtn";
            this.AddRefundBtn.Size = new System.Drawing.Size(75, 31);
            this.AddRefundBtn.TabIndex = 1;
            this.AddRefundBtn.Text = "Aggiungi";
            this.AddRefundBtn.UseVisualStyleBackColor = false;
            this.AddRefundBtn.Click += new System.EventHandler(this.AddRefundBtn_Click);
            // 
            // FromNoticeTextBox
            // 
            this.FromNoticeTextBox.Location = new System.Drawing.Point(90, 37);
            this.FromNoticeTextBox.MaxLength = 3;
            this.FromNoticeTextBox.Name = "FromNoticeTextBox";
            this.FromNoticeTextBox.Size = new System.Drawing.Size(59, 22);
            this.FromNoticeTextBox.TabIndex = 29;
            // 
            // ToNoticeTextBox
            // 
            this.ToNoticeTextBox.Location = new System.Drawing.Point(90, 62);
            this.ToNoticeTextBox.MaxLength = 3;
            this.ToNoticeTextBox.Name = "ToNoticeTextBox";
            this.ToNoticeTextBox.Size = new System.Drawing.Size(59, 22);
            this.ToNoticeTextBox.TabIndex = 30;
            // 
            // AddExpensesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsertExpensesGroupBox);
            this.Controls.Add(this.InsertPricesGroupBox);
            this.Name = "AddExpensesPopup";
            this.Text = "Form1";
            this.InsertPricesGroupBox.ResumeLayout(false);
            this.InsertPricesGroupBox.PerformLayout();
            this.InsertExpensesGroupBox.ResumeLayout(false);
            this.InsertExpensesGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertPricesGroupBox;
        private System.Windows.Forms.Button AddPriceBtn;
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
        private System.Windows.Forms.GroupBox InsertExpensesGroupBox;
        private System.Windows.Forms.RichTextBox InfosTextBox;
        private System.Windows.Forms.Label Infos;
        private System.Windows.Forms.Label BadgeIdInfo;
        private System.Windows.Forms.Label DateExpenseInfo;
        private System.Windows.Forms.DateTimePicker DateExpensePicker;
        private System.Windows.Forms.Label AmountExpenseInfo;
        private System.Windows.Forms.TextBox AmountExpenseTextBox;
        private System.Windows.Forms.Button AddExpenseBtn;
        private System.Windows.Forms.TextBox BadgeIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RefundTextBox;
        private System.Windows.Forms.Button AddRefundBtn;
        private System.Windows.Forms.TextBox ToNoticeTextBox;
        private System.Windows.Forms.TextBox FromNoticeTextBox;
    }
}