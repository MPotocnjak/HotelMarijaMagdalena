namespace HotelMarijaMagdalena
{
    partial class ServiceControl
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
            this.labelPrintInvoice = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.tabControlService = new System.Windows.Forms.TabControl();
            this.tabPageAddService = new System.Windows.Forms.TabPage();
            this.labelServices = new System.Windows.Forms.Label();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.tabControlService.SuspendLayout();
            this.tabPageAddService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.tabPageServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrintInvoice
            // 
            this.labelPrintInvoice.AutoSize = true;
            this.labelPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrintInvoice.Location = new System.Drawing.Point(70, 60);
            this.labelPrintInvoice.Name = "labelPrintInvoice";
            this.labelPrintInvoice.Size = new System.Drawing.Size(281, 41);
            this.labelPrintInvoice.TabIndex = 23;
            this.labelPrintInvoice.Text = "Additional service:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(77, 207);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 22;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(77, 648);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(72, 150);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 20;
            this.labelRoomNumber.Text = "Room number:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(72, 523);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 28);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Price:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(77, 568);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(425, 30);
            this.numericUpDownPrice.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(508, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "€";
            // 
            // listBoxService
            // 
            this.listBoxService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.listBoxService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxService.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 31;
            this.listBoxService.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Coctail bar",
            "Room service",
            "Wellness"});
            this.listBoxService.Location = new System.Drawing.Point(77, 289);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(425, 217);
            this.listBoxService.TabIndex = 33;
            // 
            // tabControlService
            // 
            this.tabControlService.Controls.Add(this.tabPageAddService);
            this.tabControlService.Controls.Add(this.tabPageServices);
            this.tabControlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlService.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlService.Location = new System.Drawing.Point(0, 0);
            this.tabControlService.Name = "tabControlService";
            this.tabControlService.SelectedIndex = 0;
            this.tabControlService.Size = new System.Drawing.Size(1443, 952);
            this.tabControlService.TabIndex = 34;
            // 
            // tabPageAddService
            // 
            this.tabPageAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageAddService.Controls.Add(this.labelPrintInvoice);
            this.tabPageAddService.Controls.Add(this.listBoxService);
            this.tabPageAddService.Controls.Add(this.labelRoomNumber);
            this.tabPageAddService.Controls.Add(this.label6);
            this.tabPageAddService.Controls.Add(this.buttonSave);
            this.tabPageAddService.Controls.Add(this.numericUpDownPrice);
            this.tabPageAddService.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageAddService.Controls.Add(this.labelPrice);
            this.tabPageAddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageAddService.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddService.Name = "tabPageAddService";
            this.tabPageAddService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddService.Size = new System.Drawing.Size(1435, 911);
            this.tabPageAddService.TabIndex = 0;
            this.tabPageAddService.Text = "Add service";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServices.Location = new System.Drawing.Point(70, 60);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(0, 41);
            this.labelServices.TabIndex = 24;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(90, 148);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewServices.TabIndex = 25;
            // 
            // tabPageServices
            // 
            this.tabPageServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageServices.Controls.Add(this.dataGridViewServices);
            this.tabPageServices.Controls.Add(this.labelServices);
            this.tabPageServices.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageServices.Location = new System.Drawing.Point(4, 37);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(1435, 911);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControlService);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(1443, 952);
            this.Load += new System.EventHandler(this.ServiceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.tabControlService.ResumeLayout(false);
            this.tabPageAddService.ResumeLayout(false);
            this.tabPageAddService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.tabPageServices.ResumeLayout(false);
            this.tabPageServices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrintInvoice;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.TabControl tabControlService;
        private System.Windows.Forms.TabPage tabPageAddService;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label labelServices;
    }
}
