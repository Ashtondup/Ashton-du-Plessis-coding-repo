
namespace Prac1._3_Creative_project_34202676
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.btnCalculateLevel = new System.Windows.Forms.Button();
            this.rbtnMage = new System.Windows.Forms.RadioButton();
            this.rbtnWarrior = new System.Windows.Forms.RadioButton();
            this.rbtnRoge = new System.Windows.Forms.RadioButton();
            this.rbtnThief = new System.Windows.Forms.RadioButton();
            this.gbRolls = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRolls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter player points:";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(158, 124);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 23);
            this.txtPoints.TabIndex = 3;
            // 
            // btnCalculateLevel
            // 
            this.btnCalculateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateLevel.Location = new System.Drawing.Point(12, 167);
            this.btnCalculateLevel.Name = "btnCalculateLevel";
            this.btnCalculateLevel.Size = new System.Drawing.Size(110, 42);
            this.btnCalculateLevel.TabIndex = 4;
            this.btnCalculateLevel.Text = "Calculate player level";
            this.btnCalculateLevel.UseVisualStyleBackColor = true;
            this.btnCalculateLevel.Click += new System.EventHandler(this.btnCalculateLevel_Click);
            // 
            // rbtnMage
            // 
            this.rbtnMage.AutoSize = true;
            this.rbtnMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMage.Location = new System.Drawing.Point(6, 20);
            this.rbtnMage.Name = "rbtnMage";
            this.rbtnMage.Size = new System.Drawing.Size(61, 21);
            this.rbtnMage.TabIndex = 8;
            this.rbtnMage.TabStop = true;
            this.rbtnMage.Text = "Mage";
            this.rbtnMage.UseVisualStyleBackColor = true;
            // 
            // rbtnWarrior
            // 
            this.rbtnWarrior.AutoSize = true;
            this.rbtnWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWarrior.Location = new System.Drawing.Point(86, 20);
            this.rbtnWarrior.Name = "rbtnWarrior";
            this.rbtnWarrior.Size = new System.Drawing.Size(73, 21);
            this.rbtnWarrior.TabIndex = 9;
            this.rbtnWarrior.TabStop = true;
            this.rbtnWarrior.Text = "Warrior";
            this.rbtnWarrior.UseVisualStyleBackColor = true;
            // 
            // rbtnRoge
            // 
            this.rbtnRoge.AutoSize = true;
            this.rbtnRoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRoge.Location = new System.Drawing.Point(6, 58);
            this.rbtnRoge.Name = "rbtnRoge";
            this.rbtnRoge.Size = new System.Drawing.Size(60, 21);
            this.rbtnRoge.TabIndex = 10;
            this.rbtnRoge.TabStop = true;
            this.rbtnRoge.Text = "Roge";
            this.rbtnRoge.UseVisualStyleBackColor = true;
            // 
            // rbtnThief
            // 
            this.rbtnThief.AutoSize = true;
            this.rbtnThief.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThief.Location = new System.Drawing.Point(86, 58);
            this.rbtnThief.Name = "rbtnThief";
            this.rbtnThief.Size = new System.Drawing.Size(58, 21);
            this.rbtnThief.TabIndex = 11;
            this.rbtnThief.TabStop = true;
            this.rbtnThief.Text = "Thief";
            this.rbtnThief.UseVisualStyleBackColor = true;
            // 
            // gbRolls
            // 
            this.gbRolls.Controls.Add(this.rbtnMage);
            this.gbRolls.Controls.Add(this.rbtnThief);
            this.gbRolls.Controls.Add(this.rbtnWarrior);
            this.gbRolls.Controls.Add(this.rbtnRoge);
            this.gbRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRolls.Location = new System.Drawing.Point(45, 18);
            this.gbRolls.Name = "gbRolls";
            this.gbRolls.Size = new System.Drawing.Size(200, 100);
            this.gbRolls.TabIndex = 12;
            this.gbRolls.TabStop = false;
            this.gbRolls.Text = "Pick you roll:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(148, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 42);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 271);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRolls);
            this.Controls.Add(this.btnCalculateLevel);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRolls.ResumeLayout(false);
            this.gbRolls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button btnCalculateLevel;
        private System.Windows.Forms.RadioButton rbtnMage;
        private System.Windows.Forms.RadioButton rbtnWarrior;
        private System.Windows.Forms.RadioButton rbtnRoge;
        private System.Windows.Forms.RadioButton rbtnThief;
        private System.Windows.Forms.GroupBox gbRolls;
        private System.Windows.Forms.Button btnClose;
    }
}

