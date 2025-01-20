﻿namespace HotelMarijaMagdalena
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
            this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrintInvoice
            // 
            this.labelPrintInvoice.AutoSize = true;
            this.labelPrintInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrintInvoice.Location = new System.Drawing.Point(154, 101);
            this.labelPrintInvoice.Name = "labelPrintInvoice";
            this.labelPrintInvoice.Size = new System.Drawing.Size(243, 37);
            this.labelPrintInvoice.TabIndex = 23;
            this.labelPrintInvoice.Text = "Additional service:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(161, 255);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(425, 36);
            this.comboBoxRoomNumber.TabIndex = 22;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(161, 698);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(156, 198);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(149, 28);
            this.labelRoomNumber.TabIndex = 20;
            this.labelRoomNumber.Text = "Room number:";
            // 
            // checkedListBoxServices
            // 
            this.checkedListBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.checkedListBoxServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxServices.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxServices.FormattingEnabled = true;
            this.checkedListBoxServices.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Coctail bar",
            "Room service",
            "Wellness"});
            this.checkedListBoxServices.Location = new System.Drawing.Point(161, 333);
            this.checkedListBoxServices.Name = "checkedListBoxServices";
            this.checkedListBoxServices.Size = new System.Drawing.Size(282, 231);
            this.checkedListBoxServices.TabIndex = 24;
            this.checkedListBoxServices.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(156, 586);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 28);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Price:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(161, 631);
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
            this.label6.Location = new System.Drawing.Point(592, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "€";
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.checkedListBoxServices);
            this.Controls.Add(this.labelPrintInvoice);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRoomNumber);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(1443, 952);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrintInvoice;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.CheckedListBox checkedListBoxServices;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label6;
    }
}
