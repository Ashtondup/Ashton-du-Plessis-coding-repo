
namespace Prac3._1_Circaes_34202676
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
            this.btnAreaofcircal = new System.Windows.Forms.Button();
            this.btnAreaofcylinder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRadius = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAreacircal = new System.Windows.Forms.TextBox();
            this.txtAreacyinder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAreaofcircal
            // 
            this.btnAreaofcircal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaofcircal.Location = new System.Drawing.Point(40, 136);
            this.btnAreaofcircal.Name = "btnAreaofcircal";
            this.btnAreaofcircal.Size = new System.Drawing.Size(81, 87);
            this.btnAreaofcircal.TabIndex = 0;
            this.btnAreaofcircal.Text = "Calculate area of circal";
            this.btnAreaofcircal.UseVisualStyleBackColor = true;
            this.btnAreaofcircal.Click += new System.EventHandler(this.btnAreaofcircal_Click);
            // 
            // btnAreaofcylinder
            // 
            this.btnAreaofcylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaofcylinder.Location = new System.Drawing.Point(163, 136);
            this.btnAreaofcylinder.Name = "btnAreaofcylinder";
            this.btnAreaofcylinder.Size = new System.Drawing.Size(84, 87);
            this.btnAreaofcylinder.TabIndex = 1;
            this.btnAreaofcylinder.Text = "Calculate area of cylinder";
            this.btnAreaofcylinder.UseVisualStyleBackColor = true;
            this.btnAreaofcylinder.Click += new System.EventHandler(this.btnAreaofcylinder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(402, 309);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreacyinder);
            this.groupBox1.Controls.Add(this.txtAreacircal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.txtRadius);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRadius);
            this.panel1.Location = new System.Drawing.Point(31, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 100);
            this.panel1.TabIndex = 5;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(4, 16);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(111, 18);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Enter the radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Area of circal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area of cylinder";
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.Location = new System.Drawing.Point(132, 13);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 24);
            this.txtRadius.TabIndex = 7;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(132, 51);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 24);
            this.txtHeight.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prac3._1_Circaes_34202676.Properties.Resources.Circular_cylinder2;
            this.pictureBox1.Location = new System.Drawing.Point(299, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtAreacircal
            // 
            this.txtAreacircal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreacircal.Location = new System.Drawing.Point(132, 35);
            this.txtAreacircal.Name = "txtAreacircal";
            this.txtAreacircal.Size = new System.Drawing.Size(100, 24);
            this.txtAreacircal.TabIndex = 9;
            // 
            // txtAreacyinder
            // 
            this.txtAreacyinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreacyinder.Location = new System.Drawing.Point(132, 77);
            this.txtAreacyinder.Name = "txtAreacyinder";
            this.txtAreacyinder.Size = new System.Drawing.Size(100, 24);
            this.txtAreacyinder.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAreaofcylinder);
            this.Controls.Add(this.btnAreaofcircal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAreaofcircal;
        private System.Windows.Forms.Button btnAreaofcylinder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAreacyinder;
        private System.Windows.Forms.TextBox txtAreacircal;
    }
}

