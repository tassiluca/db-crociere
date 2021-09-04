
namespace db_crociere.Bookings
{
    partial class RefundsPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundsPopup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookingLabel = new System.Windows.Forms.Label();
            this.BookingComboBox = new System.Windows.Forms.ComboBox();
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoticeTextBox = new System.Windows.Forms.TextBox();
            this.RefundLabel = new System.Windows.Forms.Label();
            this.RefundTextBox = new System.Windows.Forms.TextBox();
            this.CancelBookingBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelBookingBtn);
            this.groupBox1.Controls.Add(this.RefundTextBox);
            this.groupBox1.Controls.Add(this.RefundLabel);
            this.groupBox1.Controls.Add(this.NoticeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BookingLabel);
            this.groupBox1.Controls.Add(this.BookingComboBox);
            this.groupBox1.Controls.Add(this.NoticeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Annulla Prenotazione";
            // 
            // BookingLabel
            // 
            this.BookingLabel.AutoSize = true;
            this.BookingLabel.Location = new System.Drawing.Point(6, 29);
            this.BookingLabel.Name = "BookingLabel";
            this.BookingLabel.Size = new System.Drawing.Size(87, 16);
            this.BookingLabel.TabIndex = 3;
            this.BookingLabel.Text = "Prenotazione";
            // 
            // BookingComboBox
            // 
            this.BookingComboBox.FormattingEnabled = true;
            this.BookingComboBox.Location = new System.Drawing.Point(99, 26);
            this.BookingComboBox.Name = "BookingComboBox";
            this.BookingComboBox.Size = new System.Drawing.Size(121, 24);
            this.BookingComboBox.TabIndex = 4;
            this.BookingComboBox.SelectedIndexChanged += new System.EventHandler(this.BookingComboBox_SelectedIndexChanged);
            this.BookingComboBox.Click += new System.EventHandler(this.BookingComboBox_Click);
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.AutoSize = true;
            this.NoticeLabel.Location = new System.Drawing.Point(6, 63);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Size = new System.Drawing.Size(69, 16);
            this.NoticeLabel.TabIndex = 5;
            this.NoticeLabel.Text = "Preavviso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // NoticeTextBox
            // 
            this.NoticeTextBox.Location = new System.Drawing.Point(99, 63);
            this.NoticeTextBox.Name = "NoticeTextBox";
            this.NoticeTextBox.ReadOnly = true;
            this.NoticeTextBox.Size = new System.Drawing.Size(121, 22);
            this.NoticeTextBox.TabIndex = 7;
            // 
            // RefundLabel
            // 
            this.RefundLabel.AutoSize = true;
            this.RefundLabel.Location = new System.Drawing.Point(6, 103);
            this.RefundLabel.Name = "RefundLabel";
            this.RefundLabel.Size = new System.Drawing.Size(126, 16);
            this.RefundLabel.TabIndex = 8;
            this.RefundLabel.Text = "Rimborso Generato";
            // 
            // RefundTextBox
            // 
            this.RefundTextBox.Location = new System.Drawing.Point(140, 99);
            this.RefundTextBox.Name = "RefundTextBox";
            this.RefundTextBox.ReadOnly = true;
            this.RefundTextBox.Size = new System.Drawing.Size(80, 22);
            this.RefundTextBox.TabIndex = 9;
            // 
            // CancelBookingBtn
            // 
            this.CancelBookingBtn.Location = new System.Drawing.Point(297, 25);
            this.CancelBookingBtn.Name = "CancelBookingBtn";
            this.CancelBookingBtn.Size = new System.Drawing.Size(98, 24);
            this.CancelBookingBtn.TabIndex = 10;
            this.CancelBookingBtn.Text = "ANNULLA";
            this.CancelBookingBtn.UseVisualStyleBackColor = true;
            this.CancelBookingBtn.Click += new System.EventHandler(this.CancelBookingBtn_Click);
            // 
            // RefundsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "RefundsPopup";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BookingLabel;
        private System.Windows.Forms.ComboBox BookingComboBox;
        private System.Windows.Forms.Label NoticeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RefundTextBox;
        private System.Windows.Forms.Label RefundLabel;
        private System.Windows.Forms.TextBox NoticeTextBox;
        private System.Windows.Forms.Button CancelBookingBtn;
    }
}