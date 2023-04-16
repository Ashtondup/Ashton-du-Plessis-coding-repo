namespace Prac6_34202676
{
    partial class Add
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTheatreNum = new System.Windows.Forms.TextBox();
            this.txtTotSeats = new System.Windows.Forms.TextBox();
            this.txtOpenSeats = new System.Windows.Forms.TextBox();
            this.txtTheatreSize = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theatre number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total seats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Open seats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Theatre size:";
            // 
            // txtTheatreNum
            // 
            this.txtTheatreNum.Location = new System.Drawing.Point(122, 10);
            this.txtTheatreNum.Name = "txtTheatreNum";
            this.txtTheatreNum.Size = new System.Drawing.Size(100, 20);
            this.txtTheatreNum.TabIndex = 4;
            // 
            // txtTotSeats
            // 
            this.txtTotSeats.Location = new System.Drawing.Point(122, 43);
            this.txtTotSeats.Name = "txtTotSeats";
            this.txtTotSeats.Size = new System.Drawing.Size(100, 20);
            this.txtTotSeats.TabIndex = 5;
            // 
            // txtOpenSeats
            // 
            this.txtOpenSeats.Location = new System.Drawing.Point(122, 78);
            this.txtOpenSeats.Name = "txtOpenSeats";
            this.txtOpenSeats.Size = new System.Drawing.Size(100, 20);
            this.txtOpenSeats.TabIndex = 6;
            // 
            // txtTheatreSize
            // 
            this.txtTheatreSize.Location = new System.Drawing.Point(122, 114);
            this.txtTheatreSize.Name = "txtTheatreSize";
            this.txtTheatreSize.Size = new System.Drawing.Size(100, 20);
            this.txtTheatreSize.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(53, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 27);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 199);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTheatreSize);
            this.Controls.Add(this.txtOpenSeats);
            this.Controls.Add(this.txtTotSeats);
            this.Controls.Add(this.txtTheatreNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTheatreNum;
        private System.Windows.Forms.TextBox txtTotSeats;
        private System.Windows.Forms.TextBox txtOpenSeats;
        private System.Windows.Forms.TextBox txtTheatreSize;
        private System.Windows.Forms.Button btnSubmit;
    }
}