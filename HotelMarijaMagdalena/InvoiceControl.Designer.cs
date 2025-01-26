namespace HotelMarijaMagdalena
{
    partial class InvoiceControl
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
            this.tabControlPayment = new System.Windows.Forms.TabControl();
            this.tabPageBill = new System.Windows.Forms.TabPage();
            this.labelPrintInvoice = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.tabPagePayments = new System.Windows.Forms.TabPage();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.labelPayments = new System.Windows.Forms.Label();
            this.tabControlPayment.SuspendLayout();
            this.tabPageBill.SuspendLayout();
            this.tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPayment
            // 
            this.tabControlPayment.Controls.Add(this.tabPageBill);
            this.tabControlPayment.Controls.Add(this.tabPagePayments);
            this.tabControlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlPayment.Location = new System.Drawing.Point(0, 0);
            this.tabControlPayment.Name = "tabControlPayment";
            this.tabControlPayment.SelectedIndex = 0;
            this.tabControlPayment.Size = new System.Drawing.Size(1451, 993);
            this.tabControlPayment.TabIndex = 1;
            this.tabControlPayment.SelectedIndexChanged += new System.EventHandler(this.tabControlPayment_SelectedIndexChanged);
            this.tabControlPayment.VisibleChanged += new System.EventHandler(this.tabControlPayment_VisibleChanged);
            // 
            // tabPageBill
            // 
            this.tabPageBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageBill.Controls.Add(this.labelPrintInvoice);
            this.tabPageBill.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageBill.Controls.Add(this.buttonPreview);
            this.tabPageBill.Controls.Add(this.labelRoomNumber);
            this.tabPageBill.Location = new System.Drawing.Point(4, 37);
            this.tabPageBill.Name = "tabPageBill";
            this.tabPageBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBill.Size = new System.Drawing.Size(1443, 952);
            this.tabPageBill.TabIndex = 0;
            this.tabPageBill.Text = "Invoice";
            // 
            // labelPrintInvoice
            // 
            this.labelPrintInvoice.AutoSize = true;
            this.labelPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrintInvoice.Location = new System.Drawing.Point(83, 77);
            this.labelPrintInvoice.Name = "labelPrintInvoice";
            this.labelPrintInvoice.Size = new System.Drawing.Size(308, 41);
            this.labelPrintInvoice.TabIndex = 23;
            this.labelPrintInvoice.Text = "Print the invoice for:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(90, 244);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 22;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreview.Location = new System.Drawing.Point(90, 334);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(116, 44);
            this.buttonPreview.TabIndex = 21;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(85, 187);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 20;
            this.labelRoomNumber.Text = "Room number:";
            // 
            // tabPagePayments
            // 
            this.tabPagePayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPagePayments.Controls.Add(this.dataGridViewPayments);
            this.tabPagePayments.Controls.Add(this.labelPayments);
            this.tabPagePayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPagePayments.Location = new System.Drawing.Point(4, 37);
            this.tabPagePayments.Name = "tabPagePayments";
            this.tabPagePayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayments.Size = new System.Drawing.Size(1443, 952);
            this.tabPagePayments.TabIndex = 1;
            this.tabPagePayments.Text = "Payments";
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(90, 171);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewPayments.TabIndex = 2;
            // 
            // labelPayments
            // 
            this.labelPayments.AutoSize = true;
            this.labelPayments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPayments.Location = new System.Drawing.Point(83, 77);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(210, 41);
            this.labelPayments.TabIndex = 1;
            this.labelPayments.Text = "All payments:";
            // 
            // InvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControlPayment);
            this.Name = "InvoiceControl";
            this.Size = new System.Drawing.Size(1451, 993);
            this.tabControlPayment.ResumeLayout(false);
            this.tabPageBill.ResumeLayout(false);
            this.tabPageBill.PerformLayout();
            this.tabPagePayments.ResumeLayout(false);
            this.tabPagePayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPayment;
        private System.Windows.Forms.TabPage tabPageBill;
        private System.Windows.Forms.TabPage tabPagePayments;
        private System.Windows.Forms.Label labelPayments;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Label labelPrintInvoice;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label labelRoomNumber;
    }
}
