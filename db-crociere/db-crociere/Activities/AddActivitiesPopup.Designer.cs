
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
            this.AddActivityExecutionBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.NavigationLabel = new System.Windows.Forms.Label();
            this.NavigationCodeComboBox = new System.Windows.Forms.ComboBox();
            this.NavigationTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddActivityBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ActivityNameLabel = new System.Windows.Forms.Label();
            this.ActivityNameTextBox = new System.Windows.Forms.TextBox();
            this.ActivityDescriptionLabel = new System.Windows.Forms.Label();
            this.ActivityDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddActivityExecutionBtn);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aggiungi una Programmazione";
            // 
            // AddActivityExecutionBtn
            // 
            this.AddActivityExecutionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddActivityExecutionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddActivityExecutionBtn.Location = new System.Drawing.Point(643, 19);
            this.AddActivityExecutionBtn.Name = "AddActivityExecutionBtn";
            this.AddActivityExecutionBtn.Size = new System.Drawing.Size(75, 27);
            this.AddActivityExecutionBtn.TabIndex = 1;
            this.AddActivityExecutionBtn.Text = "Aggiungi";
            this.AddActivityExecutionBtn.UseVisualStyleBackColor = false;
            this.AddActivityExecutionBtn.Click += new System.EventHandler(this.AddActivityExecutionBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartLabel);
            this.flowLayoutPanel1.Controls.Add(this.StartDatePicker);
            this.flowLayoutPanel1.Controls.Add(this.StartTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.DurationLabel);
            this.flowLayoutPanel1.Controls.Add(this.DurationTextBox);
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
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(273, 3);
            this.DurationTextBox.MaxLength = 3;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(66, 22);
            this.DurationTextBox.TabIndex = 36;
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
            this.RoomLabel.Location = new System.Drawing.Point(3, 33);
            this.RoomLabel.Margin = new System.Windows.Forms.Padding(3);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(36, 16);
            this.RoomLabel.TabIndex = 33;
            this.RoomLabel.Text = "Sala";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(45, 33);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(79, 24);
            this.RoomComboBox.TabIndex = 34;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.Location = new System.Drawing.Point(130, 33);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(47, 16);
            this.ActivityLabel.TabIndex = 37;
            this.ActivityLabel.Text = "Attività";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(183, 33);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(156, 24);
            this.ActivityComboBox.TabIndex = 38;
            this.ActivityComboBox.Click += new System.EventHandler(this.ActivityComboBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddActivityBtn);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggiungi una nuova Attività";
            // 
            // AddActivityBtn
            // 
            this.AddActivityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddActivityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddActivityBtn.Location = new System.Drawing.Point(354, 21);
            this.AddActivityBtn.Name = "AddActivityBtn";
            this.AddActivityBtn.Size = new System.Drawing.Size(75, 27);
            this.AddActivityBtn.TabIndex = 2;
            this.AddActivityBtn.Text = "Aggiungi";
            this.AddActivityBtn.UseVisualStyleBackColor = false;
            this.AddActivityBtn.Click += new System.EventHandler(this.AddActivityBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ActivityNameLabel);
            this.flowLayoutPanel2.Controls.Add(this.ActivityNameTextBox);
            this.flowLayoutPanel2.Controls.Add(this.ActivityDescriptionLabel);
            this.flowLayoutPanel2.Controls.Add(this.ActivityDescriptionTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(339, 79);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // ActivityNameLabel
            // 
            this.ActivityNameLabel.AutoSize = true;
            this.ActivityNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ActivityNameLabel.Name = "ActivityNameLabel";
            this.ActivityNameLabel.Size = new System.Drawing.Size(45, 16);
            this.ActivityNameLabel.TabIndex = 0;
            this.ActivityNameLabel.Text = "Nome";
            // 
            // ActivityNameTextBox
            // 
            this.ActivityNameTextBox.Location = new System.Drawing.Point(54, 3);
            this.ActivityNameTextBox.MaxLength = 20;
            this.ActivityNameTextBox.Name = "ActivityNameTextBox";
            this.ActivityNameTextBox.Size = new System.Drawing.Size(270, 22);
            this.ActivityNameTextBox.TabIndex = 2;
            // 
            // ActivityDescriptionLabel
            // 
            this.ActivityDescriptionLabel.AutoSize = true;
            this.ActivityDescriptionLabel.Location = new System.Drawing.Point(3, 28);
            this.ActivityDescriptionLabel.Name = "ActivityDescriptionLabel";
            this.ActivityDescriptionLabel.Size = new System.Drawing.Size(79, 16);
            this.ActivityDescriptionLabel.TabIndex = 1;
            this.ActivityDescriptionLabel.Text = "Descrizione";
            // 
            // ActivityDescriptionTextBox
            // 
            this.ActivityDescriptionTextBox.Location = new System.Drawing.Point(88, 31);
            this.ActivityDescriptionTextBox.MaxLength = 150;
            this.ActivityDescriptionTextBox.Name = "ActivityDescriptionTextBox";
            this.ActivityDescriptionTextBox.Size = new System.Drawing.Size(236, 42);
            this.ActivityDescriptionTextBox.TabIndex = 3;
            this.ActivityDescriptionTextBox.Text = "";
            // 
            // AddActivitiesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 222);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddActivitiesPopup";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label NavigationLabel;
        private System.Windows.Forms.ComboBox NavigationCodeComboBox;
        private System.Windows.Forms.TextBox NavigationTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label ActivityNameLabel;
        private System.Windows.Forms.TextBox ActivityNameTextBox;
        private System.Windows.Forms.Label ActivityDescriptionLabel;
        private System.Windows.Forms.RichTextBox ActivityDescriptionTextBox;
        private System.Windows.Forms.Button AddActivityBtn;
    }
}