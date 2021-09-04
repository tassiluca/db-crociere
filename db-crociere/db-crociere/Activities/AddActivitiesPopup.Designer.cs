
namespace db_crociere.Activities
{
    partial class AddActivitiesPopup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StartLabel = new System.Windows.Forms.Label();
            this.NavigationLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NavigationCodeComboBox = new System.Windows.Forms.ComboBox();
            this.NavigationTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.AddActivityExecutionBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddActivityExecutionBtn);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aggiungi una Programmazione";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartLabel);
            this.flowLayoutPanel1.Controls.Add(this.StartDatePicker);
            this.flowLayoutPanel1.Controls.Add(this.StartTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.DurationLabel);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.NavigationLabel);
            this.flowLayoutPanel1.Controls.Add(this.NavigationCodeComboBox);
            this.flowLayoutPanel1.Controls.Add(this.NavigationTextBox);
            this.flowLayoutPanel1.Controls.Add(this.RoomLabel);
            this.flowLayoutPanel1.Controls.Add(this.RoomComboBox);
            this.flowLayoutPanel1.Controls.Add(this.ActivityLabel);
            this.flowLayoutPanel1.Controls.Add(this.ActivityComboBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 58);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(3, 3);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(3);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(38, 16);
            this.StartLabel.TabIndex = 26;
            this.StartLabel.Text = "Inizio";
            // 
            // NavigationLabel
            // 
            this.NavigationLabel.AutoSize = true;
            this.NavigationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationLabel.Location = new System.Drawing.Point(345, 3);
            this.NavigationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NavigationLabel.Name = "NavigationLabel";
            this.NavigationLabel.Size = new System.Drawing.Size(84, 16);
            this.NavigationLabel.TabIndex = 27;
            this.NavigationLabel.Text = "Navigazione";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "dd-MM-yyyy";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(47, 3);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(103, 22);
            this.StartDatePicker.TabIndex = 28;
            this.StartDatePicker.Value = new System.DateTime(2021, 8, 27, 0, 0, 0, 0);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "HH:mm";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(156, 3);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(57, 22);
            this.StartTimePicker.TabIndex = 30;
            // 
            // NavigationCodeComboBox
            // 
            this.NavigationCodeComboBox.FormattingEnabled = true;
            this.NavigationCodeComboBox.Location = new System.Drawing.Point(435, 3);
            this.NavigationCodeComboBox.Name = "NavigationCodeComboBox";
            this.NavigationCodeComboBox.Size = new System.Drawing.Size(79, 24);
            this.NavigationCodeComboBox.TabIndex = 31;
            this.NavigationCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.NavigationCodeComboBox_SelectedIndexChanged);
            this.NavigationCodeComboBox.Click += new System.EventHandler(this.NavigationCodeComboBox_Click);
            // 
            // NavigationTextBox
            // 
            this.NavigationTextBox.Location = new System.Drawing.Point(520, 3);
            this.NavigationTextBox.Name = "NavigationTextBox";
            this.NavigationTextBox.ReadOnly = true;
            this.NavigationTextBox.Size = new System.Drawing.Size(100, 22);
            this.NavigationTextBox.TabIndex = 32;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLabel.Location = new System.Drawing.Point(3, 31);
            this.RoomLabel.Margin = new System.Windows.Forms.Padding(3);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(36, 16);
            this.RoomLabel.TabIndex = 33;
            this.RoomLabel.Text = "Sala";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(45, 31);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(79, 24);
            this.RoomComboBox.TabIndex = 34;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(219, 3);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(48, 16);
            this.DurationLabel.TabIndex = 35;
            this.DurationLabel.Text = "Durata";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 3);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 22);
            this.textBox1.TabIndex = 36;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.Location = new System.Drawing.Point(130, 31);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(47, 16);
            this.ActivityLabel.TabIndex = 37;
            this.ActivityLabel.Text = "Attività";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(183, 31);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(79, 24);
            this.ActivityComboBox.TabIndex = 38;
            // 
            // AddActivityExecutionBtn
            // 
            this.AddActivityExecutionBtn.Location = new System.Drawing.Point(643, 24);
            this.AddActivityExecutionBtn.Name = "AddActivityExecutionBtn";
            this.AddActivityExecutionBtn.Size = new System.Drawing.Size(75, 27);
            this.AddActivityExecutionBtn.TabIndex = 1;
            this.AddActivityExecutionBtn.Text = "Aggiungi";
            this.AddActivityExecutionBtn.UseVisualStyleBackColor = true;
            //this.AddActivityExecutionBtn.Click += new System.EventHandler(this.AddActivityExecutionBtn_Click);
            // 
            // AddActivitiesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddActivitiesPopup";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddActivityExecutionBtn;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NavigationLabel;
        private System.Windows.Forms.ComboBox NavigationCodeComboBox;
        private System.Windows.Forms.TextBox NavigationTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
    }
}