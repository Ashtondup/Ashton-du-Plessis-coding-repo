
namespace Prac3._2_Creative_project_34202676
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbItem1 = new System.Windows.Forms.GroupBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.gbItem2 = new System.Windows.Forms.GroupBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.btnHightestitem = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAmountBothItemsTax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbItem1.SuspendLayout();
            this.gbItem2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prac3._2_Creative_project_34202676.Properties.Resources.Money;
            this.pictureBox1.Location = new System.Drawing.Point(414, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbItem1
            // 
            this.gbItem1.Controls.Add(this.txtPrice1);
            this.gbItem1.Controls.Add(this.txtName1);
            this.gbItem1.Controls.Add(this.lblPrice1);
            this.gbItem1.Controls.Add(this.lblName1);
            this.gbItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem1.Location = new System.Drawing.Point(14, 12);
            this.gbItem1.Name = "gbItem1";
            this.gbItem1.Size = new System.Drawing.Size(215, 113);
            this.gbItem1.TabIndex = 10;
            this.gbItem1.TabStop = false;
            this.gbItem1.Text = "Item 1";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(6, 23);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(91, 17);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Name of Item";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(6, 23);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(91, 17);
            this.lblName2.TabIndex = 11;
            this.lblName2.Text = "Name of Item";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.Location = new System.Drawing.Point(6, 66);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(86, 17);
            this.lblPrice1.TabIndex = 1;
            this.lblPrice1.Text = "Price of Item";
            this.lblPrice1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(6, 66);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(86, 17);
            this.lblPrice2.TabIndex = 12;
            this.lblPrice2.Text = "Price of Item";
            // 
            // gbItem2
            // 
            this.gbItem2.Controls.Add(this.txtPrice2);
            this.gbItem2.Controls.Add(this.txtName2);
            this.gbItem2.Controls.Add(this.lblPrice2);
            this.gbItem2.Controls.Add(this.lblName2);
            this.gbItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem2.Location = new System.Drawing.Point(235, 12);
            this.gbItem2.Name = "gbItem2";
            this.gbItem2.Size = new System.Drawing.Size(215, 113);
            this.gbItem2.TabIndex = 13;
            this.gbItem2.TabStop = false;
            this.gbItem2.Text = "Item 2";
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName1.Location = new System.Drawing.Point(103, 20);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 23);
            this.txtName1.TabIndex = 2;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice1.Location = new System.Drawing.Point(103, 63);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 23);
            this.txtPrice1.TabIndex = 14;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName2.Location = new System.Drawing.Point(103, 20);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 23);
            this.txtName2.TabIndex = 14;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice2.Location = new System.Drawing.Point(103, 63);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(100, 23);
            this.txtPrice2.TabIndex = 14;
            // 
            // btnHightestitem
            // 
            this.btnHightestitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHightestitem.Location = new System.Drawing.Point(269, 146);
            this.btnHightestitem.Name = "btnHightestitem";
            this.btnHightestitem.Size = new System.Drawing.Size(103, 70);
            this.btnHightestitem.TabIndex = 14;
            this.btnHightestitem.Text = "Shows the item that cost the most";
            this.btnHightestitem.UseVisualStyleBackColor = true;
            this.btnHightestitem.Click += new System.EventHandler(this.btnHightestitem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(11, 266);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 18);
            this.lblPrice.TabIndex = 15;
            // 
            // btnAmountBothItemsTax
            // 
            this.btnAmountBothItemsTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountBothItemsTax.Location = new System.Drawing.Point(83, 147);
            this.btnAmountBothItemsTax.Name = "btnAmountBothItemsTax";
            this.btnAmountBothItemsTax.Size = new System.Drawing.Size(103, 69);
            this.btnAmountBothItemsTax.TabIndex = 16;
            this.btnAmountBothItemsTax.Text = "Amount of both items with tax";
            this.btnAmountBothItemsTax.UseVisualStyleBackColor = true;
            this.btnAmountBothItemsTax.Click += new System.EventHandler(this.btnAmountBothItemsTax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 381);
            this.Controls.Add(this.btnAmountBothItemsTax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnHightestitem);
            this.Controls.Add(this.gbItem2);
            this.Controls.Add(this.gbItem1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbItem1.ResumeLayout(false);
            this.gbItem1.PerformLayout();
            this.gbItem2.ResumeLayout(false);
            this.gbItem2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbItem1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.GroupBox gbItem2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button btnHightestitem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAmountBothItemsTax;
    }
}

