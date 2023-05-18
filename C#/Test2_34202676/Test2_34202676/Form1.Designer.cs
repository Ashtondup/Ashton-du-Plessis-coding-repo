
namespace Test2_34202676
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotHours = new System.Windows.Forms.TextBox();
            this.txtRatePHour = new System.Windows.Forms.TextBox();
            this.btnCreateOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lstViewRecords = new System.Windows.Forms.ListBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empolyee name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate per hour";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtTotHours
            // 
            this.txtTotHours.Location = new System.Drawing.Point(143, 41);
            this.txtTotHours.Name = "txtTotHours";
            this.txtTotHours.Size = new System.Drawing.Size(100, 20);
            this.txtTotHours.TabIndex = 4;
            // 
            // txtRatePHour
            // 
            this.txtRatePHour.Location = new System.Drawing.Point(143, 71);
            this.txtRatePHour.Name = "txtRatePHour";
            this.txtRatePHour.Size = new System.Drawing.Size(100, 20);
            this.txtRatePHour.TabIndex = 5;
            // 
            // btnCreateOpen
            // 
            this.btnCreateOpen.Location = new System.Drawing.Point(16, 100);
            this.btnCreateOpen.Name = "btnCreateOpen";
            this.btnCreateOpen.Size = new System.Drawing.Size(227, 23);
            this.btnCreateOpen.TabIndex = 6;
            this.btnCreateOpen.Text = "Create/Open";
            this.btnCreateOpen.UseVisualStyleBackColor = true;
            this.btnCreateOpen.Click += new System.EventHandler(this.btnCreateOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(16, 158);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(227, 23);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View all";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lstViewRecords
            // 
            this.lstViewRecords.FormattingEnabled = true;
            this.lstViewRecords.Location = new System.Drawing.Point(16, 199);
            this.lstViewRecords.Name = "lstViewRecords";
            this.lstViewRecords.Size = new System.Drawing.Size(227, 147);
            this.lstViewRecords.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 372);
            this.Controls.Add(this.lstViewRecords);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreateOpen);
            this.Controls.Add(this.txtRatePHour);
            this.Controls.Add(this.txtTotHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotHours;
        private System.Windows.Forms.TextBox txtRatePHour;
        private System.Windows.Forms.Button btnCreateOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lstViewRecords;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

