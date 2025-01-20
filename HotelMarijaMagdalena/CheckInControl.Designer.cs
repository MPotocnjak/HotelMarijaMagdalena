namespace HotelMarijaMagdalena
{
    partial class CheckInControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCheckIn = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownGuests = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.dataGridViewCheckIn = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).BeginInit();
            this.tabPageStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCheckIn);
            this.tabControl1.Controls.Add(this.tabPageStatus);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1451, 993);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCheckIn
            // 
            this.tabPageCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageCheckIn.Controls.Add(this.buttonUpdate);
            this.tabPageCheckIn.Controls.Add(this.buttonSave);
            this.tabPageCheckIn.Controls.Add(this.numericUpDownGuests);
            this.tabPageCheckIn.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageCheckIn.Controls.Add(this.dateTimePickerCheckOut);
            this.tabPageCheckIn.Controls.Add(this.dateTimePickerCheckIn);
            this.tabPageCheckIn.Controls.Add(this.labelCheckOutDate);
            this.tabPageCheckIn.Controls.Add(this.labelCheckInDate);
            this.tabPageCheckIn.Controls.Add(this.labelNumberOfGuests);
            this.tabPageCheckIn.Controls.Add(this.labelRoomNumber);
            this.tabPageCheckIn.Controls.Add(this.labelCheckIn);
            this.tabPageCheckIn.Location = new System.Drawing.Point(4, 37);
            this.tabPageCheckIn.Name = "tabPageCheckIn";
            this.tabPageCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckIn.Size = new System.Drawing.Size(1443, 952);
            this.tabPageCheckIn.TabIndex = 0;
            this.tabPageCheckIn.Text = "Check-in";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.Location = new System.Drawing.Point(235, 502);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 44);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(90, 502);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownGuests
            // 
            this.numericUpDownGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownGuests.Location = new System.Drawing.Point(90, 401);
            this.numericUpDownGuests.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGuests.Name = "numericUpDownGuests";
            this.numericUpDownGuests.Size = new System.Drawing.Size(425, 34);
            this.numericUpDownGuests.TabIndex = 10;
            this.numericUpDownGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(90, 246);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 9;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(754, 398);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(229, 34);
            this.dateTimePickerCheckOut.TabIndex = 8;
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(754, 244);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(229, 34);
            this.dateTimePickerCheckIn.TabIndex = 7;
            // 
            // labelCheckOutDate
            // 
            this.labelCheckOutDate.AutoSize = true;
            this.labelCheckOutDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCheckOutDate.Location = new System.Drawing.Point(749, 348);
            this.labelCheckOutDate.Name = "labelCheckOutDate";
            this.labelCheckOutDate.Size = new System.Drawing.Size(109, 28);
            this.labelCheckOutDate.TabIndex = 6;
            this.labelCheckOutDate.Text = "Check out:";
            // 
            // labelCheckInDate
            // 
            this.labelCheckInDate.AutoSize = true;
            this.labelCheckInDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCheckInDate.Location = new System.Drawing.Point(749, 187);
            this.labelCheckInDate.Name = "labelCheckInDate";
            this.labelCheckInDate.Size = new System.Drawing.Size(95, 28);
            this.labelCheckInDate.TabIndex = 5;
            this.labelCheckInDate.Text = "Check in:";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberOfGuests.Location = new System.Drawing.Point(85, 348);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(183, 28);
            this.labelNumberOfGuests.TabIndex = 4;
            this.labelNumberOfGuests.Text = "Number of guests:";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(85, 187);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "Room number:";
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCheckIn.Location = new System.Drawing.Point(83, 77);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(145, 41);
            this.labelCheckIn.TabIndex = 0;
            this.labelCheckIn.Text = "Check in:";
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageStatus.Controls.Add(this.dataGridViewCheckIn);
            this.tabPageStatus.Controls.Add(this.labelStatus);
            this.tabPageStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageStatus.Location = new System.Drawing.Point(4, 37);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatus.Size = new System.Drawing.Size(1443, 952);
            this.tabPageStatus.TabIndex = 1;
            this.tabPageStatus.Text = "Status";
            // 
            // dataGridViewCheckIn
            // 
            this.dataGridViewCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckIn.Location = new System.Drawing.Point(90, 171);
            this.dataGridViewCheckIn.Name = "dataGridViewCheckIn";
            this.dataGridViewCheckIn.RowHeadersWidth = 51;
            this.dataGridViewCheckIn.RowTemplate.Height = 24;
            this.dataGridViewCheckIn.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewCheckIn.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(83, 77);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(113, 41);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status:";
            // 
            // CheckInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "CheckInControl";
            this.Size = new System.Drawing.Size(1451, 993);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCheckIn.ResumeLayout(false);
            this.tabPageCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).EndInit();
            this.tabPageStatus.ResumeLayout(false);
            this.tabPageStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCheckIn;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownGuests;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewCheckIn;
    }
}
