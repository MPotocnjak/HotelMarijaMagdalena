namespace HotelMarijaMagdalena
{
    partial class EmployeeControl
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
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.tabPageAddEmployee = new System.Windows.Forms.TabPage();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.tabControlEmployee.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabPageAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Controls.Add(this.tabPageEmployees);
            this.tabControlEmployee.Controls.Add(this.tabPageAddEmployee);
            this.tabControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmployee.Name = "tabControlEmployee";
            this.tabControlEmployee.SelectedIndex = 0;
            this.tabControlEmployee.Size = new System.Drawing.Size(1451, 993);
            this.tabControlEmployee.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabPageEmployees.Controls.Add(this.labelEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 37);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(1443, 952);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Employees";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(90, 148);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1115, 294);
            this.dataGridViewEmployees.TabIndex = 1;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmployees.Location = new System.Drawing.Point(83, 77);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(223, 41);
            this.labelEmployees.TabIndex = 0;
            this.labelEmployees.Text = "All employees:";
            // 
            // tabPageAddEmployee
            // 
            this.tabPageAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPageAddEmployee.Controls.Add(this.comboBoxStatus);
            this.tabPageAddEmployee.Controls.Add(this.textBoxPosition);
            this.tabPageAddEmployee.Controls.Add(this.textBoxPhone);
            this.tabPageAddEmployee.Controls.Add(this.textBoxLastName);
            this.tabPageAddEmployee.Controls.Add(this.labelStatus);
            this.tabPageAddEmployee.Controls.Add(this.labelShift);
            this.tabPageAddEmployee.Controls.Add(this.label1);
            this.tabPageAddEmployee.Controls.Add(this.buttonUpdate);
            this.tabPageAddEmployee.Controls.Add(this.buttonSave);
            this.tabPageAddEmployee.Controls.Add(this.comboBoxShift);
            this.tabPageAddEmployee.Controls.Add(this.textBoxFirstName);
            this.tabPageAddEmployee.Controls.Add(this.labelPhone);
            this.tabPageAddEmployee.Controls.Add(this.labelLastName);
            this.tabPageAddEmployee.Controls.Add(this.labelFirstName);
            this.tabPageAddEmployee.Controls.Add(this.labelAddEmployee);
            this.tabPageAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageAddEmployee.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddEmployee.Name = "tabPageAddEmployee";
            this.tabPageAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEmployee.Size = new System.Drawing.Size(1443, 952);
            this.tabPageAddEmployee.TabIndex = 1;
            this.tabPageAddEmployee.Text = "Add employee";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Employed",
            "On Annual/Sick Leave",
            "Unemployed"});
            this.comboBoxStatus.Location = new System.Drawing.Point(755, 439);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(425, 36);
            this.comboBoxStatus.TabIndex = 17;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(755, 200);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(425, 34);
            this.textBoxPosition.TabIndex = 16;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(90, 441);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(425, 34);
            this.textBoxPhone.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(90, 320);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(425, 34);
            this.textBoxLastName.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(750, 384);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(72, 28);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status:";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShift.Location = new System.Drawing.Point(750, 268);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(59, 28);
            this.labelShift.TabIndex = 12;
            this.labelShift.Text = "Shift:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(750, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Position:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(235, 524);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 44);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(90, 524);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 44);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Night",
            "/"});
            this.comboBoxShift.Location = new System.Drawing.Point(755, 318);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(425, 36);
            this.comboBoxShift.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(90, 200);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(425, 34);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhone.Location = new System.Drawing.Point(85, 384);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(155, 28);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone number:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(85, 268);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(110, 28);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(85, 148);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(112, 28);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First name:";
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddEmployee.Location = new System.Drawing.Point(83, 77);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(230, 41);
            this.labelAddEmployee.TabIndex = 1;
            this.labelAddEmployee.Text = "Add employee:";
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControlEmployee);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1451, 993);
            this.tabControlEmployee.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabPageAddEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.TabPage tabPageAddEmployee;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
