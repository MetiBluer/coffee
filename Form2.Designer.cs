namespace Coffee_ordering_System
{
    partial class Form2
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
            this.lblTot = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPnts = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblDine = new System.Windows.Forms.Label();
            this.lblDining = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(100, 35);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(41, 16);
            this.lblTot.TabIndex = 0;
            this.lblTot.Text = "Total:";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(103, 159);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(540, 211);
            this.dgvDisplay.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(173, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "*";
            // 
            // lblPnts
            // 
            this.lblPnts.AutoSize = true;
            this.lblPnts.Location = new System.Drawing.Point(100, 94);
            this.lblPnts.Name = "lblPnts";
            this.lblPnts.Size = new System.Drawing.Size(47, 16);
            this.lblPnts.TabIndex = 3;
            this.lblPnts.Text = "Points:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(173, 94);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(12, 16);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "*";
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Location = new System.Drawing.Point(400, 35);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(63, 16);
            this.lblMem.TabIndex = 5;
            this.lblMem.Text = "Member: ";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(465, 35);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(12, 16);
            this.lblMember.TabIndex = 6;
            this.lblMember.Text = "*";
            // 
            // lblDine
            // 
            this.lblDine.AutoSize = true;
            this.lblDine.Location = new System.Drawing.Point(400, 94);
            this.lblDine.Name = "lblDine";
            this.lblDine.Size = new System.Drawing.Size(48, 16);
            this.lblDine.TabIndex = 7;
            this.lblDine.Text = "Dining:";
            // 
            // lblDining
            // 
            this.lblDining.AutoSize = true;
            this.lblDining.Location = new System.Drawing.Point(465, 94);
            this.lblDining.Name = "lblDining";
            this.lblDining.Size = new System.Drawing.Size(12, 16);
            this.lblDining.TabIndex = 8;
            this.lblDining.Text = "*";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(103, 388);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(212, 22);
            this.txtPay.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(336, 388);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Purchase";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.lblDining);
            this.Controls.Add(this.lblDine);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblMem);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPnts);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.lblTot);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPnts;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblDine;
        private System.Windows.Forms.Label lblDining;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnPay;
    }
}