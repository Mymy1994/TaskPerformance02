namespace TaskPerformance_02
{
    partial class QueingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashier.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Location = new System.Drawing.Point(12, 12);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(123, 98);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Click to get number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(141, 40);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(192, 66);
            this.lblQueue.TabIndex = 6;
            this.lblQueue.Text = "P - 10000";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextForm
            // 
            this.btnNextForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextForm.Location = new System.Drawing.Point(249, 109);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(75, 23);
            this.btnNextForm.TabIndex = 7;
            this.btnNextForm.Text = "Next Form>>";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // QueingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(336, 141);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCashier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QueingForm";
            this.Text = "QueingForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Button btnNextForm;
    }
}

