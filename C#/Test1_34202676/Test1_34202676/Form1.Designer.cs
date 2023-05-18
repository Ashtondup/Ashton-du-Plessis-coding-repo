
namespace Test1_34202676
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
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDegreesF = new System.Windows.Forms.Label();
            this.lblDegreesC = new System.Windows.Forms.Label();
            this.txtFtemp = new System.Windows.Forms.TextBox();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFtoC
            // 
            this.btnFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFtoC.Location = new System.Drawing.Point(147, 130);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(150, 52);
            this.btnFtoC.TabIndex = 0;
            this.btnFtoC.Text = "Convert Fahrenheit  to Celsius ";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(189, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(114, 63);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(227, 18);
            this.lblFahrenheit.TabIndex = 2;
            this.lblFahrenheit.Text = "Enter the Fahrenheit temperature:";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblDegreesC);
            this.gbResult.Controls.Add(this.lblDegreesF);
            this.gbResult.Controls.Add(this.label3);
            this.gbResult.Controls.Add(this.label2);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(108, 188);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(234, 100);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Degrees Fahrenheit ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Degrees Celcius";
            // 
            // lblDegreesF
            // 
            this.lblDegreesF.AutoSize = true;
            this.lblDegreesF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreesF.Location = new System.Drawing.Point(170, 26);
            this.lblDegreesF.Name = "lblDegreesF";
            this.lblDegreesF.Size = new System.Drawing.Size(0, 18);
            this.lblDegreesF.TabIndex = 4;
            // 
            // lblDegreesC
            // 
            this.lblDegreesC.AutoSize = true;
            this.lblDegreesC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreesC.Location = new System.Drawing.Point(170, 64);
            this.lblDegreesC.Name = "lblDegreesC";
            this.lblDegreesC.Size = new System.Drawing.Size(0, 18);
            this.lblDegreesC.TabIndex = 4;
            // 
            // txtFtemp
            // 
            this.txtFtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFtemp.Location = new System.Drawing.Point(164, 100);
            this.txtFtemp.Name = "txtFtemp";
            this.txtFtemp.Size = new System.Drawing.Size(100, 24);
            this.txtFtemp.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 379);
            this.Controls.Add(this.txtFtemp);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFtoC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblDegreesC;
        private System.Windows.Forms.Label lblDegreesF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFtemp;
    }
}

