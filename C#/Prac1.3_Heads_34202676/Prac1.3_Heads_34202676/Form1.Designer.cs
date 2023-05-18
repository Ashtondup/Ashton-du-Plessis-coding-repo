
namespace Prac1._3_Heads_34202676
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
            this.pbTails = new System.Windows.Forms.PictureBox();
            this.pbHeads = new System.Windows.Forms.PictureBox();
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTails
            // 
            this.pbTails.Image = global::Prac1._3_Heads_34202676.Properties.Resources.Tails1;
            this.pbTails.Location = new System.Drawing.Point(268, 49);
            this.pbTails.Name = "pbTails";
            this.pbTails.Size = new System.Drawing.Size(150, 150);
            this.pbTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTails.TabIndex = 1;
            this.pbTails.TabStop = false;
            this.pbTails.Visible = false;
            // 
            // pbHeads
            // 
            this.pbHeads.Image = global::Prac1._3_Heads_34202676.Properties.Resources.Heads1;
            this.pbHeads.Location = new System.Drawing.Point(68, 49);
            this.pbHeads.Name = "pbHeads";
            this.pbHeads.Size = new System.Drawing.Size(150, 150);
            this.pbHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeads.TabIndex = 0;
            this.pbHeads.TabStop = false;
            this.pbHeads.Visible = false;
            // 
            // btnHeads
            // 
            this.btnHeads.Location = new System.Drawing.Point(68, 243);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(70, 46);
            this.btnHeads.TabIndex = 2;
            this.btnHeads.Text = "Show Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(209, 243);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(76, 46);
            this.btnTails.TabIndex = 3;
            this.btnTails.Text = "Show Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(343, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Controls.Add(this.pbTails);
            this.Controls.Add(this.pbHeads);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeads;
        private System.Windows.Forms.PictureBox pbTails;
        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnExit;
    }
}

