namespace GuessNumber
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.btnPoqr = new System.Windows.Forms.Button();
            this.btnHavasar = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnMec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.ForeColor = System.Drawing.Color.Blue;
            this.btnCheck.Location = new System.Drawing.Point(363, 45);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(103, 32);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTry.Location = new System.Drawing.Point(124, 266);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(124, 55);
            this.btnTry.TabIndex = 1;
            this.btnTry.Text = "Try Again";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(124, 52);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(209, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(145, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRes2.Location = new System.Drawing.Point(145, 167);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 13);
            this.lblRes2.TabIndex = 4;
            // 
            // btnPoqr
            // 
            this.btnPoqr.BackColor = System.Drawing.Color.Red;
            this.btnPoqr.Location = new System.Drawing.Point(349, 209);
            this.btnPoqr.Name = "btnPoqr";
            this.btnPoqr.Size = new System.Drawing.Size(103, 32);
            this.btnPoqr.TabIndex = 5;
            this.btnPoqr.Text = "Poqr";
            this.btnPoqr.UseVisualStyleBackColor = false;
            this.btnPoqr.Click += new System.EventHandler(this.btnPoqr_Click);
            // 
            // btnHavasar
            // 
            this.btnHavasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHavasar.Location = new System.Drawing.Point(349, 167);
            this.btnHavasar.Name = "btnHavasar";
            this.btnHavasar.Size = new System.Drawing.Size(103, 32);
            this.btnHavasar.TabIndex = 6;
            this.btnHavasar.Text = "Havasar";
            this.btnHavasar.UseVisualStyleBackColor = false;
            this.btnHavasar.Click += new System.EventHandler(this.btnHavasar_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(566, 138);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 25);
            this.lblEnd.TabIndex = 7;
            // 
            // btnMec
            // 
            this.btnMec.BackColor = System.Drawing.Color.Lime;
            this.btnMec.Location = new System.Drawing.Point(349, 129);
            this.btnMec.Name = "btnMec";
            this.btnMec.Size = new System.Drawing.Size(103, 32);
            this.btnMec.TabIndex = 8;
            this.btnMec.Text = "Mec";
            this.btnMec.UseVisualStyleBackColor = false;
            this.btnMec.Click += new System.EventHandler(this.btnMec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMec);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnHavasar);
            this.Controls.Add(this.btnPoqr);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Button btnPoqr;
        private System.Windows.Forms.Button btnHavasar;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnMec;
    }
}

