namespace SU2_Act1_34202676
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
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.dbView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnMoveData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDataView
            // 
            this.gbDataView.Controls.Add(this.dbView);
            this.gbDataView.Location = new System.Drawing.Point(13, 13);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Size = new System.Drawing.Size(393, 211);
            this.gbDataView.TabIndex = 0;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Database Data";
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(6, 20);
            this.dbView.Name = "dbView";
            this.dbView.Size = new System.Drawing.Size(381, 176);
            this.dbView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbData);
            this.groupBox2.Location = new System.Drawing.Point(430, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ListBox Data";
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(7, 20);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(380, 186);
            this.lbData.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 255);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(129, 255);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 37);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnMoveData
            // 
            this.btnMoveData.Location = new System.Drawing.Point(252, 255);
            this.btnMoveData.Name = "btnMoveData";
            this.btnMoveData.Size = new System.Drawing.Size(97, 37);
            this.btnMoveData.TabIndex = 4;
            this.btnMoveData.Text = "Move Data";
            this.btnMoveData.UseVisualStyleBackColor = true;
            this.btnMoveData.Click += new System.EventHandler(this.btnMoveData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(720, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMoveData);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDataView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataView;
        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnMoveData;
        private System.Windows.Forms.Button btnExit;
    }
}

