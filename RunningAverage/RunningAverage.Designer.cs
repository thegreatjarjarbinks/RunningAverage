namespace RunningAverage
{
    partial class frmRunningAverage
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(13, 13);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(212, 16);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter the next number from 0 to 100";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(13, 41);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(93, 16);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Enter -1 to end";
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(16, 80);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNewNumber.TabIndex = 2;
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterNumber.Location = new System.Drawing.Point(16, 158);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(100, 22);
            this.btnEnterNumber.TabIndex = 3;
            this.btnEnterNumber.Text = "Enter Number";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(16, 200);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(153, 16);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Your running Average is:";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnEnterNumber);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average";
            this.Load += new System.EventHandler(this.frmRunningAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.Label lblAverage;
    }
}

