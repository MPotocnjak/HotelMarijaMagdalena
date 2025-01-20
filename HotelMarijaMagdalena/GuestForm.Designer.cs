namespace HotelMarijaMagdalena
{
    partial class GuestForm
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
            this.guestControl = new HotelMarijaMagdalena.GuestControl();
            this.SuspendLayout();
            // 
            // guestControl
            // 
            this.guestControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.guestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestControl.Location = new System.Drawing.Point(0, 0);
            this.guestControl.Name = "guestControl";
            this.guestControl.Size = new System.Drawing.Size(998, 717);
            this.guestControl.TabIndex = 0;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(998, 717);
            this.Controls.Add(this.guestControl);
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GuestControl guestControl;
    }
}