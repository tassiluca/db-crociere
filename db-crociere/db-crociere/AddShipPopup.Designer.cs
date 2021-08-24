
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
            this.ShipCodeInfo = new System.Windows.Forms.Label();
            this.ShipCodeTextBox = new System.Windows.Forms.TextBox();
            this.WidthInfo = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthInfo = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WeightInfo = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightInfo = new System.Windows.Forms.Label();
            this.HeightInfoTextBox = new System.Windows.Forms.TextBox();
            this.CabinsNumInfo = new System.Windows.Forms.Label();
            this.CabinsNumTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.InsertShipInfoBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).BeginInit();
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
            this.InsertShipInfoBox.Size = new System.Drawing.Size(800, 100);
            this.InsertShipInfoBox.TabIndex = 0;
            this.InsertShipInfoBox.TabStop = false;
            this.InsertShipInfoBox.Text = "InformazioniNave";
            // 
            // ClearShipInfoBtn
            // 
            this.ClearShipInfoBtn.Location = new System.Drawing.Point(525, 74);
            this.ClearShipInfoBtn.Name = "ClearShipInfoBtn";
            this.ClearShipInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearShipInfoBtn.TabIndex = 2;
            this.ClearShipInfoBtn.Text = "Pulisci";
            this.ClearShipInfoBtn.UseVisualStyleBackColor = true;
            // 
            // AddShipInfoBtn
            // 
            this.AddShipInfoBtn.Location = new System.Drawing.Point(525, 16);
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
            this.flowLayoutPanel1.Controls.Add(this.ShipCodeInfo);
            this.flowLayoutPanel1.Controls.Add(this.ShipCodeTextBox);
            this.flowLayoutPanel1.Controls.Add(this.WidthInfo);
            this.flowLayoutPanel1.Controls.Add(this.WidthTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LengthInfo);
            this.flowLayoutPanel1.Controls.Add(this.LengthTextBox);
            this.flowLayoutPanel1.Controls.Add(this.WeightInfo);
            this.flowLayoutPanel1.Controls.Add(this.WeightTextBox);
            this.flowLayoutPanel1.Controls.Add(this.HeightInfo);
            this.flowLayoutPanel1.Controls.Add(this.HeightInfoTextBox);
            this.flowLayoutPanel1.Controls.Add(this.CabinsNumInfo);
            this.flowLayoutPanel1.Controls.Add(this.CabinsNumTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 81);
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
            this.ShipNameTextBox.Name = "ShipNameTextBox";
            this.ShipNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.ShipNameTextBox.TabIndex = 1;
            this.ShipNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShipNameTextBox_Validating);
            // 
            // ShipCodeInfo
            // 
            this.ShipCodeInfo.AutoSize = true;
            this.ShipCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipCodeInfo.Location = new System.Drawing.Point(246, 3);
            this.ShipCodeInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.ShipCodeInfo.Name = "ShipCodeInfo";
            this.ShipCodeInfo.Size = new System.Drawing.Size(87, 16);
            this.ShipCodeInfo.TabIndex = 2;
            this.ShipCodeInfo.Text = "Codice Nave";
            // 
            // ShipCodeTextBox
            // 
            this.ShipCodeTextBox.Location = new System.Drawing.Point(339, 3);
            this.ShipCodeTextBox.Name = "ShipCodeTextBox";
            this.ShipCodeTextBox.Size = new System.Drawing.Size(122, 20);
            this.ShipCodeTextBox.TabIndex = 3;
            this.ShipCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShipCodeTextBox_Validating);
            // 
            // WidthInfo
            // 
            this.WidthInfo.AutoSize = true;
            this.WidthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInfo.Location = new System.Drawing.Point(3, 29);
            this.WidthInfo.Margin = new System.Windows.Forms.Padding(3);
            this.WidthInfo.Name = "WidthInfo";
            this.WidthInfo.Size = new System.Drawing.Size(70, 16);
            this.WidthInfo.TabIndex = 4;
            this.WidthInfo.Text = "Larghezza";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(79, 29);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(75, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // LengthInfo
            // 
            this.LengthInfo.AutoSize = true;
            this.LengthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthInfo.Location = new System.Drawing.Point(182, 29);
            this.LengthInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.LengthInfo.Name = "LengthInfo";
            this.LengthInfo.Size = new System.Drawing.Size(72, 16);
            this.LengthInfo.TabIndex = 6;
            this.LengthInfo.Text = "Lunghezza";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(260, 29);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(73, 20);
            this.LengthTextBox.TabIndex = 7;
            this.LengthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LengthTextBox_Validating);
            // 
            // WeightInfo
            // 
            this.WeightInfo.AutoSize = true;
            this.WeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInfo.Location = new System.Drawing.Point(361, 29);
            this.WeightInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.WeightInfo.Name = "WeightInfo";
            this.WeightInfo.Size = new System.Drawing.Size(40, 16);
            this.WeightInfo.TabIndex = 8;
            this.WeightInfo.Text = "Peso";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(407, 29);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(76, 20);
            this.WeightTextBox.TabIndex = 9;
            this.WeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightTextBox_Validating);
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(3, 55);
            this.HeightInfo.Margin = new System.Windows.Forms.Padding(3);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(51, 16);
            this.HeightInfo.TabIndex = 10;
            this.HeightInfo.Text = "Altezza";
            // 
            // HeightInfoTextBox
            // 
            this.HeightInfoTextBox.Location = new System.Drawing.Point(60, 55);
            this.HeightInfoTextBox.Name = "HeightInfoTextBox";
            this.HeightInfoTextBox.Size = new System.Drawing.Size(94, 20);
            this.HeightInfoTextBox.TabIndex = 11;
            this.HeightInfoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HeightInfoTextBox_Validating);
            // 
            // CabinsNumInfo
            // 
            this.CabinsNumInfo.AutoSize = true;
            this.CabinsNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinsNumInfo.Location = new System.Drawing.Point(182, 55);
            this.CabinsNumInfo.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CabinsNumInfo.Name = "CabinsNumInfo";
            this.CabinsNumInfo.Size = new System.Drawing.Size(102, 16);
            this.CabinsNumInfo.TabIndex = 12;
            this.CabinsNumInfo.Text = "Numero Cabine";
            // 
            // CabinsNumTextBox
            // 
            this.CabinsNumTextBox.Location = new System.Drawing.Point(290, 55);
            this.CabinsNumTextBox.Name = "CabinsNumTextBox";
            this.CabinsNumTextBox.Size = new System.Drawing.Size(62, 20);
            this.CabinsNumTextBox.TabIndex = 13;
            this.CabinsNumTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CabinsNumTextBox_Validating);
            // 
            // errorProviderInfo
            // 
            this.errorProviderInfo.ContainerControl = this;
            // 
            // AddShipPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertShipInfoBox);
            this.Name = "AddShipPopup";
            this.Text = "Form1";
            this.InsertShipInfoBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertShipInfoBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameInfo;
        private System.Windows.Forms.TextBox ShipNameTextBox;
        private System.Windows.Forms.Label ShipCodeInfo;
        private System.Windows.Forms.TextBox ShipCodeTextBox;
        private System.Windows.Forms.Label WidthInfo;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label LengthInfo;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label WeightInfo;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightInfo;
        private System.Windows.Forms.TextBox HeightInfoTextBox;
        private System.Windows.Forms.Label CabinsNumInfo;
        private System.Windows.Forms.TextBox CabinsNumTextBox;
        private System.Windows.Forms.Button AddShipInfoBtn;
        private System.Windows.Forms.Button ClearShipInfoBtn;
        private System.Windows.Forms.ErrorProvider errorProviderInfo;
    }
}