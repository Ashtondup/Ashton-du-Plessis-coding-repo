
namespace Prac5._1_Shisanyama_braai_menu_34202676
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPapWors = new System.Windows.Forms.RadioButton();
            this.rbFilletVeg = new System.Windows.Forms.RadioButton();
            this.rbChickenChip = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChickenChip);
            this.groupBox1.Controls.Add(this.rbPapWors);
            this.groupBox1.Controls.Add(this.rbFilletVeg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Braai Menu (Shisanyama)";
            // 
            // rbPapWors
            // 
            this.rbPapWors.AutoSize = true;
            this.rbPapWors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPapWors.Location = new System.Drawing.Point(17, 22);
            this.rbPapWors.Name = "rbPapWors";
            this.rbPapWors.Size = new System.Drawing.Size(117, 22);
            this.rbPapWors.TabIndex = 1;
            this.rbPapWors.Text = "Pap and wors";
            this.rbPapWors.UseVisualStyleBackColor = true;
            this.rbPapWors.CheckedChanged += new System.EventHandler(this.rbPapWors_CheckedChanged);
            // 
            // rbFilletVeg
            // 
            this.rbFilletVeg.AutoSize = true;
            this.rbFilletVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilletVeg.Location = new System.Drawing.Point(17, 60);
            this.rbFilletVeg.Name = "rbFilletVeg";
            this.rbFilletVeg.Size = new System.Drawing.Size(151, 22);
            this.rbFilletVeg.TabIndex = 2;
            this.rbFilletVeg.Text = "Fillet steak and veg";
            this.rbFilletVeg.UseVisualStyleBackColor = true;
            this.rbFilletVeg.CheckedChanged += new System.EventHandler(this.rbFilletVeg_CheckedChanged);
            // 
            // rbChickenChip
            // 
            this.rbChickenChip.AutoSize = true;
            this.rbChickenChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChickenChip.Location = new System.Drawing.Point(17, 98);
            this.rbChickenChip.Name = "rbChickenChip";
            this.rbChickenChip.Size = new System.Drawing.Size(147, 22);
            this.rbChickenChip.TabIndex = 3;
            this.rbChickenChip.Text = "Chicken and chips";
            this.rbChickenChip.UseVisualStyleBackColor = true;
            this.rbChickenChip.CheckedChanged += new System.EventHandler(this.rbChickenChip_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(108, 170);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 24);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(48, 211);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 43);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 295);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChickenChip;
        private System.Windows.Forms.RadioButton rbPapWors;
        private System.Windows.Forms.RadioButton rbFilletVeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnConfirm;
    }
}

