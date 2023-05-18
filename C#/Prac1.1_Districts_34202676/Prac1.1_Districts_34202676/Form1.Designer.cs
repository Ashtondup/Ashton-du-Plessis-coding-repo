
namespace Prac1._1_Districts_34202676
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
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistricts = new System.Windows.Forms.Label();
            this.btnDetermineDistrict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(15, 38);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 23);
            this.txtTown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Town:";
            // 
            // lblDistricts
            // 
            this.lblDistricts.AutoSize = true;
            this.lblDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistricts.Location = new System.Drawing.Point(174, 44);
            this.lblDistricts.Name = "lblDistricts";
            this.lblDistricts.Size = new System.Drawing.Size(20, 17);
            this.lblDistricts.TabIndex = 2;
            this.lblDistricts.Text = "...";
            // 
            // btnDetermineDistrict
            // 
            this.btnDetermineDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetermineDistrict.Location = new System.Drawing.Point(40, 76);
            this.btnDetermineDistrict.Name = "btnDetermineDistrict";
            this.btnDetermineDistrict.Size = new System.Drawing.Size(139, 38);
            this.btnDetermineDistrict.TabIndex = 3;
            this.btnDetermineDistrict.Text = "Determine District";
            this.btnDetermineDistrict.UseVisualStyleBackColor = true;
            this.btnDetermineDistrict.Click += new System.EventHandler(this.btnDetermineDistrict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 193);
            this.Controls.Add(this.btnDetermineDistrict);
            this.Controls.Add(this.lblDistricts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDistricts;
        private System.Windows.Forms.Button btnDetermineDistrict;
    }
}

