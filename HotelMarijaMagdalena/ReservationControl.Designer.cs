namespace HotelMarijaMagdalena
{
    partial class ReservationControl
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
            this.tabPageReservations = new System.Windows.Forms.TabPage();
            this.labelReservations = new System.Windows.Forms.Label();
            this.dataGridViewAllReservations = new System.Windows.Forms.DataGridView();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.labelReservation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllReservations)).BeginInit();
            this.tabPageAddReservation.SuspendLayout();
            this.tabControlReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageReservations
            // 
            this.tabPageReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageReservations.Controls.Add(this.dataGridViewAllReservations);
            this.tabPageReservations.Controls.Add(this.labelReservations);
            this.tabPageReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageReservations.Location = new System.Drawing.Point(4, 37);
            this.tabPageReservations.Name = "tabPageReservations";
            this.tabPageReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservations.Size = new System.Drawing.Size(1443, 952);
            this.tabPageReservations.TabIndex = 1;
            this.tabPageReservations.Text = "Reservations";
            // 
            // labelReservations
            // 
            this.labelReservations.AutoSize = true;
            this.labelReservations.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservations.Location = new System.Drawing.Point(83, 77);
            this.labelReservations.Name = "labelReservations";
            this.labelReservations.Size = new System.Drawing.Size(245, 41);
            this.labelReservations.TabIndex = 1;
            this.labelReservations.Text = "All reservations:";
            // 
            // dataGridViewAllReservations
            // 
            this.dataGridViewAllReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllReservations.Location = new System.Drawing.Point(90, 171);
            this.dataGridViewAllReservations.Name = "dataGridViewAllReservations";
            this.dataGridViewAllReservations.RowHeadersWidth = 51;
            this.dataGridViewAllReservations.RowTemplate.Height = 24;
            this.dataGridViewAllReservations.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewAllReservations.TabIndex = 2;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageAddReservation.Controls.Add(this.textBoxName);
            this.tabPageAddReservation.Controls.Add(this.buttonUpdate);
            this.tabPageAddReservation.Controls.Add(this.buttonSave);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerCheckOut);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerCheckIn);
            this.tabPageAddReservation.Controls.Add(this.labelCheckOutDate);
            this.tabPageAddReservation.Controls.Add(this.labelCheckInDate);
            this.tabPageAddReservation.Controls.Add(this.labelRoomNumber);
            this.tabPageAddReservation.Controls.Add(this.labelName);
            this.tabPageAddReservation.Controls.Add(this.labelReservation);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1443, 952);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add reservation";
            // 
            // labelReservation
            // 
            this.labelReservation.AutoSize = true;
            this.labelReservation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservation.Location = new System.Drawing.Point(83, 77);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(192, 41);
            this.labelReservation.TabIndex = 0;
            this.labelReservation.Text = "Reservation:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(85, 187);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 28);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(85, 348);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 4;
            this.labelRoomNumber.Text = "Room number:";
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
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(754, 244);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(229, 34);
            this.dateTimePickerCheckIn.TabIndex = 7;
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
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(90, 502);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveOrUpdate_Click);
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
            this.buttonUpdate.Click += new System.EventHandler(this.buttonSaveOrUpdate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(90, 244);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(425, 34);
            this.textBoxName.TabIndex = 13;
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(90, 400);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 14;
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageReservations);
            this.tabControlReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlReservation.Location = new System.Drawing.Point(0, 0);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1451, 993);
            this.tabControlReservation.TabIndex = 2;
            this.tabControlReservation.SelectedIndexChanged += new System.EventHandler(this.tabControlReservation_SelectedIndexChanged);
            this.tabControlReservation.VisibleChanged += new System.EventHandler(this.tabControlReservation_VisibleChanged);
            // 
            // ReservationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControlReservation);
            this.Name = "ReservationControl";
            this.Size = new System.Drawing.Size(1451, 993);
            this.tabPageReservations.ResumeLayout(false);
            this.tabPageReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllReservations)).EndInit();
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabControlReservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageReservations;
        private System.Windows.Forms.DataGridView dataGridViewAllReservations;
        private System.Windows.Forms.Label labelReservations;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReservation;
        private System.Windows.Forms.TabControl tabControlReservation;
    }
}
