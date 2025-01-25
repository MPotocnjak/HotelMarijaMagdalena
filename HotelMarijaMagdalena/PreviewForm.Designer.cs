using System.Windows.Forms;

namespace HotelMarijaMagdalena
{
    partial class PreviewForm
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
            this.previewControl = new HotelMarijaMagdalena.PreviewControl();
            this.SuspendLayout();
            // 
            // previewControl
            // 
            this.previewControl.AutoScroll = true;
            this.previewControl.Location = new System.Drawing.Point(0, 0);
            this.previewControl.Name = "previewControl";
            this.previewControl.Size = new System.Drawing.Size(988, 1008);
            this.previewControl.TabIndex = 0;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1007, 1002);
            this.Controls.Add(this.previewControl);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PreviewForm";
            this.Text = "Bill";
            this.ResumeLayout(false);

        }

        #endregion

        private PreviewControl previewControl;
    }
}