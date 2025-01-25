namespace HotelMarijaMagdalena
{
    partial class BillControl
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
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelPrintInvoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(90, 226);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 18;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreview.Location = new System.Drawing.Point(90, 316);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(116, 44);
            this.buttonPreview.TabIndex = 16;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(85, 169);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 15;
            this.labelRoomNumber.Text = "Room number:";
            // 
            // labelPrintInvoice
            // 
            this.labelPrintInvoice.AutoSize = true;
            this.labelPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrintInvoice.Location = new System.Drawing.Point(83, 77);
            this.labelPrintInvoice.Name = "labelPrintInvoice";
            this.labelPrintInvoice.Size = new System.Drawing.Size(308, 41);
            this.labelPrintInvoice.TabIndex = 19;
            this.labelPrintInvoice.Text = "Print the invoice for:";
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.labelPrintInvoice);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.labelRoomNumber);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(1443, 952);
            this.Load += new System.EventHandler(this.BillControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelPrintInvoice;
    }
}
