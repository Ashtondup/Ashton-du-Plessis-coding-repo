
namespace Prac10._2_Creative_project_34202676
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
            this.gbRolls = new System.Windows.Forms.GroupBox();
            this.rbnMage = new System.Windows.Forms.RadioButton();
            this.rbnThief = new System.Windows.Forms.RadioButton();
            this.rbnWarrior = new System.Windows.Forms.RadioButton();
            this.rbnRoge = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.btnCalculateLevel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRolls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRolls
            // 
            this.gbRolls.Controls.Add(this.rbnMage);
            this.gbRolls.Controls.Add(this.rbnThief);
            this.gbRolls.Controls.Add(this.rbnWarrior);
            this.gbRolls.Controls.Add(this.rbnRoge);
            this.gbRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRolls.Location = new System.Drawing.Point(31, 12);
            this.gbRolls.Name = "gbRolls";
            this.gbRolls.Size = new System.Drawing.Size(200, 100);
            this.gbRolls.TabIndex = 13;
            this.gbRolls.TabStop = false;
            this.gbRolls.Text = "Pick you roll:";
            // 
            // rbnMage
            // 
            this.rbnMage.AutoSize = true;
            this.rbnMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMage.Location = new System.Drawing.Point(6, 20);
            this.rbnMage.Name = "rbnMage";
            this.rbnMage.Size = new System.Drawing.Size(61, 21);
            this.rbnMage.TabIndex = 8;
            this.rbnMage.TabStop = true;
            this.rbnMage.Text = "Mage";
            this.rbnMage.UseVisualStyleBackColor = true;
            // 
            // rbnThief
            // 
            this.rbnThief.AutoSize = true;
            this.rbnThief.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnThief.Location = new System.Drawing.Point(86, 58);
            this.rbnThief.Name = "rbnThief";
            this.rbnThief.Size = new System.Drawing.Size(58, 21);
            this.rbnThief.TabIndex = 11;
            this.rbnThief.TabStop = true;
            this.rbnThief.Text = "Thief";
            this.rbnThief.UseVisualStyleBackColor = true;
            // 
            // rbnWarrior
            // 
            this.rbnWarrior.AutoSize = true;
            this.rbnWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnWarrior.Location = new System.Drawing.Point(86, 20);
            this.rbnWarrior.Name = "rbnWarrior";
            this.rbnWarrior.Size = new System.Drawing.Size(73, 21);
            this.rbnWarrior.TabIndex = 9;
            this.rbnWarrior.TabStop = true;
            this.rbnWarrior.Text = "Warrior";
            this.rbnWarrior.UseVisualStyleBackColor = true;
            // 
            // rbnRoge
            // 
            this.rbnRoge.AutoSize = true;
            this.rbnRoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnRoge.Location = new System.Drawing.Point(6, 58);
            this.rbnRoge.Name = "rbnRoge";
            this.rbnRoge.Size = new System.Drawing.Size(60, 21);
            this.rbnRoge.TabIndex = 10;
            this.rbnRoge.TabStop = true;
            this.rbnRoge.Text = "Roge";
            this.rbnRoge.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter player points:";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(146, 134);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 23);
            this.txtPoints.TabIndex = 15;
            // 
            // btnCalculateLevel
            // 
            this.btnCalculateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateLevel.Location = new System.Drawing.Point(12, 190);
            this.btnCalculateLevel.Name = "btnCalculateLevel";
            this.btnCalculateLevel.Size = new System.Drawing.Size(110, 42);
            this.btnCalculateLevel.TabIndex = 16;
            this.btnCalculateLevel.Text = "Calculate player level";
            this.btnCalculateLevel.UseVisualStyleBackColor = true;
            this.btnCalculateLevel.Click += new System.EventHandler(this.btnCalculateLevel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(136, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 42);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 269);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculateLevel);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbRolls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRolls.ResumeLayout(false);
            this.gbRolls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRolls;
        private System.Windows.Forms.RadioButton rbnMage;
        private System.Windows.Forms.RadioButton rbnThief;
        private System.Windows.Forms.RadioButton rbnWarrior;
        private System.Windows.Forms.RadioButton rbnRoge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button btnCalculateLevel;
        private System.Windows.Forms.Button btnClose;
    }
}

