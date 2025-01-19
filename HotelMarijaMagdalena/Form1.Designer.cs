namespace HotelMarijaMagdalena
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.buttonShowPayments = new System.Windows.Forms.Button();
            this.buttonShowBooking = new System.Windows.Forms.Button();
            this.buttonShowGuests = new System.Windows.Forms.Button();
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.buttonShowRooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Location = new System.Drawing.Point(59, 41);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(109, 46);
            this.buttonShowUsers.TabIndex = 1;
            this.buttonShowUsers.Text = "Show Users";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // buttonShowPayments
            // 
            this.buttonShowPayments.Location = new System.Drawing.Point(646, 41);
            this.buttonShowPayments.Name = "buttonShowPayments";
            this.buttonShowPayments.Size = new System.Drawing.Size(109, 46);
            this.buttonShowPayments.TabIndex = 2;
            this.buttonShowPayments.Text = "Show Payments";
            this.buttonShowPayments.UseVisualStyleBackColor = true;
            this.buttonShowPayments.Click += new System.EventHandler(this.buttonShowPayments_Click);
            // 
            // buttonShowBooking
            // 
            this.buttonShowBooking.Location = new System.Drawing.Point(404, 41);
            this.buttonShowBooking.Name = "buttonShowBooking";
            this.buttonShowBooking.Size = new System.Drawing.Size(109, 46);
            this.buttonShowBooking.TabIndex = 3;
            this.buttonShowBooking.Text = "Show Booking";
            this.buttonShowBooking.UseVisualStyleBackColor = true;
            this.buttonShowBooking.Click += new System.EventHandler(this.buttonShowBooking_Click);
            // 
            // buttonShowGuests
            // 
            this.buttonShowGuests.Location = new System.Drawing.Point(289, 41);
            this.buttonShowGuests.Name = "buttonShowGuests";
            this.buttonShowGuests.Size = new System.Drawing.Size(109, 46);
            this.buttonShowGuests.TabIndex = 4;
            this.buttonShowGuests.Text = "Show Guests";
            this.buttonShowGuests.UseVisualStyleBackColor = true;
            this.buttonShowGuests.Click += new System.EventHandler(this.buttonShowGuests_Click);
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.Location = new System.Drawing.Point(519, 41);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(121, 46);
            this.buttonShowEmployees.TabIndex = 5;
            this.buttonShowEmployees.Text = "Show Employees";
            this.buttonShowEmployees.UseVisualStyleBackColor = true;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // buttonShowRooms
            // 
            this.buttonShowRooms.Location = new System.Drawing.Point(174, 41);
            this.buttonShowRooms.Name = "buttonShowRooms";
            this.buttonShowRooms.Size = new System.Drawing.Size(109, 46);
            this.buttonShowRooms.TabIndex = 6;
            this.buttonShowRooms.Text = "Show Rooms";
            this.buttonShowRooms.UseVisualStyleBackColor = true;
            this.buttonShowRooms.Click += new System.EventHandler(this.buttonShowRooms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowRooms);
            this.Controls.Add(this.buttonShowEmployees);
            this.Controls.Add(this.buttonShowGuests);
            this.Controls.Add(this.buttonShowBooking);
            this.Controls.Add(this.buttonShowPayments);
            this.Controls.Add(this.buttonShowUsers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.Button buttonShowPayments;
        private System.Windows.Forms.Button buttonShowBooking;
        private System.Windows.Forms.Button buttonShowGuests;
        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.Button buttonShowRooms;
    }
}

