namespace HotelMarijaMagdalena
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.BillButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.ReservationsButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.RoomsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxHotel = new System.Windows.Forms.PictureBox();
            this.roomControl = new HotelMarijaMagdalena.RoomControl();
            this.serviceControl = new HotelMarijaMagdalena.ServiceControl();
            this.billControl = new HotelMarijaMagdalena.BillControl();
            this.employeeControl = new HotelMarijaMagdalena.EmployeeControl();
            this.reservationControl = new HotelMarijaMagdalena.ReservationControl();
            this.checkInControl = new HotelMarijaMagdalena.CheckInControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.ServicesButton);
            this.panel1.Controls.Add(this.BillButton);
            this.panel1.Controls.Add(this.EmployeeButton);
            this.panel1.Controls.Add(this.ReservationsButton);
            this.panel1.Controls.Add(this.CheckInButton);
            this.panel1.Controls.Add(this.RoomsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 543);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSlide.Location = new System.Drawing.Point(0, 171);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(18, 55);
            this.panelSlide.TabIndex = 4;
            // 
            // ServicesButton
            // 
            this.ServicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServicesButton.FlatAppearance.BorderSize = 0;
            this.ServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServicesButton.ForeColor = System.Drawing.Color.White;
            this.ServicesButton.Location = new System.Drawing.Point(0, 446);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(169, 55);
            this.ServicesButton.TabIndex = 4;
            this.ServicesButton.Text = "Services";
            this.ServicesButton.UseVisualStyleBackColor = false;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // BillButton
            // 
            this.BillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BillButton.FlatAppearance.BorderSize = 0;
            this.BillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BillButton.ForeColor = System.Drawing.Color.White;
            this.BillButton.Location = new System.Drawing.Point(0, 391);
            this.BillButton.Name = "BillButton";
            this.BillButton.Size = new System.Drawing.Size(169, 55);
            this.BillButton.TabIndex = 5;
            this.BillButton.Text = "Bill";
            this.BillButton.UseVisualStyleBackColor = false;
            this.BillButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Location = new System.Drawing.Point(0, 336);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(169, 55);
            this.EmployeeButton.TabIndex = 7;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // ReservationsButton
            // 
            this.ReservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReservationsButton.FlatAppearance.BorderSize = 0;
            this.ReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReservationsButton.ForeColor = System.Drawing.Color.White;
            this.ReservationsButton.Location = new System.Drawing.Point(0, 281);
            this.ReservationsButton.Name = "ReservationsButton";
            this.ReservationsButton.Size = new System.Drawing.Size(169, 55);
            this.ReservationsButton.TabIndex = 6;
            this.ReservationsButton.Text = "Reservation";
            this.ReservationsButton.UseVisualStyleBackColor = false;
            this.ReservationsButton.Click += new System.EventHandler(this.ReservationsButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckInButton.FlatAppearance.BorderSize = 0;
            this.CheckInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckInButton.ForeColor = System.Drawing.Color.White;
            this.CheckInButton.Location = new System.Drawing.Point(0, 225);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(169, 55);
            this.CheckInButton.TabIndex = 5;
            this.CheckInButton.Text = "Check in";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // RoomsButton
            // 
            this.RoomsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomsButton.FlatAppearance.BorderSize = 0;
            this.RoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoomsButton.ForeColor = System.Drawing.Color.White;
            this.RoomsButton.Location = new System.Drawing.Point(0, 171);
            this.RoomsButton.Name = "RoomsButton";
            this.RoomsButton.Size = new System.Drawing.Size(169, 55);
            this.RoomsButton.TabIndex = 4;
            this.RoomsButton.Text = "Rooms";
            this.RoomsButton.UseVisualStyleBackColor = false;
            this.RoomsButton.Click += new System.EventHandler(this.RoomsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelLogOut);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.labelUser);
            this.panel2.Controls.Add(this.labelHotelName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 172);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(808, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 60);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelLogOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.labelLogOut.Location = new System.Drawing.Point(973, 0);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(87, 31);
            this.labelLogOut.TabIndex = 3;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.ForeColor = System.Drawing.Color.Transparent;
            this.labelUsername.Location = new System.Drawing.Point(72, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(24, 31);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "?";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUser.ForeColor = System.Drawing.Color.Transparent;
            this.labelUser.Location = new System.Drawing.Point(3, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(63, 31);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User:";
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelName.ForeColor = System.Drawing.Color.Transparent;
            this.labelHotelName.Location = new System.Drawing.Point(125, 68);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(636, 71);
            this.labelHotelName.TabIndex = 0;
            this.labelHotelName.Text = "Hotel Marija Magdalena";
            this.labelHotelName.Click += new System.EventHandler(this.labelHotelName_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.roomControl);
            this.panel3.Controls.Add(this.serviceControl);
            this.panel3.Controls.Add(this.billControl);
            this.panel3.Controls.Add(this.employeeControl);
            this.panel3.Controls.Add(this.reservationControl);
            this.panel3.Controls.Add(this.checkInControl);
            this.panel3.Controls.Add(this.pictureBoxHotel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(169, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 371);
            this.panel3.TabIndex = 2;
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHotel.ErrorImage = null;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.InitialImage")));
            this.pictureBoxHotel.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(1060, 371);
            this.pictureBoxHotel.TabIndex = 0;
            this.pictureBoxHotel.TabStop = false;
            // 
            // roomControl
            // 
            this.roomControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomControl.Location = new System.Drawing.Point(0, 0);
            this.roomControl.Name = "roomControl";
            this.roomControl.Size = new System.Drawing.Size(1060, 371);
            this.roomControl.TabIndex = 5;
            this.roomControl.Visible = false;
            // 
            // serviceControl
            // 
            this.serviceControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.serviceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceControl.Location = new System.Drawing.Point(0, 0);
            this.serviceControl.Name = "serviceControl";
            this.serviceControl.Size = new System.Drawing.Size(1060, 371);
            this.serviceControl.TabIndex = 5;
            this.serviceControl.Visible = false;
            // 
            // billControl
            // 
            this.billControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.billControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billControl.Location = new System.Drawing.Point(0, 0);
            this.billControl.Name = "billControl";
            this.billControl.Size = new System.Drawing.Size(1060, 371);
            this.billControl.TabIndex = 5;
            this.billControl.Visible = false;
            // 
            // employeeControl
            // 
            this.employeeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employeeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeControl.Location = new System.Drawing.Point(0, 0);
            this.employeeControl.Name = "employeeControl";
            this.employeeControl.Size = new System.Drawing.Size(1060, 371);
            this.employeeControl.TabIndex = 5;
            this.employeeControl.Visible = false;
            // 
            // reservationControl
            // 
            this.reservationControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reservationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationControl.Location = new System.Drawing.Point(0, 0);
            this.reservationControl.Name = "reservationControl";
            this.reservationControl.Size = new System.Drawing.Size(1060, 371);
            this.reservationControl.TabIndex = 5;
            this.reservationControl.Visible = false;
            // 
            // checkInControl
            // 
            this.checkInControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkInControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkInControl.Location = new System.Drawing.Point(0, 0);
            this.checkInControl.Name = "checkInControl";
            this.checkInControl.Size = new System.Drawing.Size(1060, 371);
            this.checkInControl.TabIndex = 5;
            this.checkInControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 543);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Button RoomsButton;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button BillButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button ReservationsButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ServicesButton;
        private RoomControl roomsControl;
        private ReservationControl reservationControl;
        private CheckInControl checkInControl;
        private ServiceControl serviceControl;
        private BillControl billControl;
        private EmployeeControl employeeControl;
        private RoomControl roomControl;
    }
}