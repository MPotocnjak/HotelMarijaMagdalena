namespace HotelMarijaMagdalena
{
    partial class ServicesControl
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
            this.tabControlServices = new System.Windows.Forms.TabControl();
            this.tabPageAddService = new System.Windows.Forms.TabPage();
            this.labelEuro = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.labelServices = new System.Windows.Forms.Label();
            this.tabControlServices.SuspendLayout();
            this.tabPageAddService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.tabPageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlServices
            // 
            this.tabControlServices.Controls.Add(this.tabPageAddService);
            this.tabControlServices.Controls.Add(this.tabPageServices);
            this.tabControlServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlServices.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlServices.Location = new System.Drawing.Point(0, 0);
            this.tabControlServices.Name = "tabControlServices";
            this.tabControlServices.SelectedIndex = 0;
            this.tabControlServices.Size = new System.Drawing.Size(1451, 993);
            this.tabControlServices.TabIndex = 1;
            this.tabControlServices.SelectedIndexChanged += new System.EventHandler(this.tabControlServices_SelectedIndexChanged);
            this.tabControlServices.VisibleChanged += new System.EventHandler(this.tabControlServices_VisibleChanged);
            // 
            // tabPageAddService
            // 
            this.tabPageAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageAddService.Controls.Add(this.labelEuro);
            this.tabPageAddService.Controls.Add(this.numericUpDownPrice);
            this.tabPageAddService.Controls.Add(this.labelPrice);
            this.tabPageAddService.Controls.Add(this.buttonSave);
            this.tabPageAddService.Controls.Add(this.listBoxService);
            this.tabPageAddService.Controls.Add(this.label3);
            this.tabPageAddService.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageAddService.Controls.Add(this.labelRoomNumber);
            this.tabPageAddService.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddService.Name = "tabPageAddService";
            this.tabPageAddService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddService.Size = new System.Drawing.Size(1443, 952);
            this.tabPageAddService.TabIndex = 0;
            this.tabPageAddService.Text = "Add service";
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEuro.Location = new System.Drawing.Point(521, 613);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(18, 20);
            this.labelEuro.TabIndex = 46;
            this.labelEuro.Text = "€";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(90, 609);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(425, 30);
            this.numericUpDownPrice.TabIndex = 45;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(85, 564);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 28);
            this.labelPrice.TabIndex = 44;
            this.labelPrice.Text = "Price:";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(90, 689);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 43;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.listBoxService.Location = new System.Drawing.Point(90, 328);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(425, 217);
            this.listBoxService.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(83, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 41);
            this.label3.TabIndex = 38;
            this.label3.Text = "Additional service:";
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
            // tabPageServices
            // 
            this.tabPageServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageServices.Controls.Add(this.dataGridViewServices);
            this.tabPageServices.Controls.Add(this.labelServices);
            this.tabPageServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageServices.Location = new System.Drawing.Point(4, 37);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(1443, 952);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(90, 171);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewServices.TabIndex = 2;
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServices.Location = new System.Drawing.Point(83, 77);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(183, 41);
            this.labelServices.TabIndex = 1;
            this.labelServices.Text = "All services:";
            // 
            // ServicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControlServices);
            this.Name = "ServicesControl";
            this.Size = new System.Drawing.Size(1451, 993);
            this.tabControlServices.ResumeLayout(false);
            this.tabPageAddService.ResumeLayout(false);
            this.tabPageAddService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.tabPageServices.ResumeLayout(false);
            this.tabPageServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlServices;
        private System.Windows.Forms.TabPage tabPageAddService;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonSave;
    }
}
