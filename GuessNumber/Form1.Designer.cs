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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.rbGreater = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttemptsCount = new System.Windows.Forms.Label();
            this.lblWinGameOverIWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.ForeColor = System.Drawing.Color.Blue;
            this.btnCheck.Location = new System.Drawing.Point(44, 305);
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
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTry.Location = new System.Drawing.Point(189, 305);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(124, 55);
            this.btnTry.TabIndex = 1;
            this.btnTry.Text = "Try Again";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(139, 61);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(209, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(166, 127);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "none";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.BackColor = System.Drawing.Color.White;
            this.lblRes2.Location = new System.Drawing.Point(166, 185);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(31, 13);
            this.lblRes2.TabIndex = 4;
            this.lblRes2.Text = "none";
            // 
            // rbGreater
            // 
            this.rbGreater.AutoSize = true;
            this.rbGreater.BackColor = System.Drawing.Color.Red;
            this.rbGreater.ForeColor = System.Drawing.Color.White;
            this.rbGreater.Location = new System.Drawing.Point(300, 132);
            this.rbGreater.Name = "rbGreater";
            this.rbGreater.Size = new System.Drawing.Size(85, 17);
            this.rbGreater.TabIndex = 9;
            this.rbGreater.TabStop = true;
            this.rbGreater.Text = "GreaterThan";
            this.rbGreater.UseVisualStyleBackColor = false;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.BackColor = System.Drawing.Color.Lime;
            this.rbEqual.Location = new System.Drawing.Point(300, 158);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(60, 17);
            this.rbEqual.TabIndex = 10;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "IsEqual";
            this.rbEqual.UseVisualStyleBackColor = false;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.BackColor = System.Drawing.Color.Blue;
            this.rbLess.ForeColor = System.Drawing.Color.White;
            this.rbLess.Location = new System.Drawing.Point(300, 181);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(72, 17);
            this.rbLess.TabIndex = 11;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "LessThan";
            this.rbLess.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "AnswerOfPlayer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "AnswerOfCode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 48);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please mention AnswerOfCode is greater, less or equal\r\n to your remembered number" +
    "\r\n<\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "AI Number:";
            // 
            // lblAttemptsCount
            // 
            this.lblAttemptsCount.AutoSize = true;
            this.lblAttemptsCount.BackColor = System.Drawing.Color.White;
            this.lblAttemptsCount.Location = new System.Drawing.Point(166, 253);
            this.lblAttemptsCount.Name = "lblAttemptsCount";
            this.lblAttemptsCount.Size = new System.Drawing.Size(31, 13);
            this.lblAttemptsCount.TabIndex = 16;
            this.lblAttemptsCount.Text = "none";
            // 
            // lblWinGameOverIWin
            // 
            this.lblWinGameOverIWin.AutoSize = true;
            this.lblWinGameOverIWin.BackColor = System.Drawing.Color.White;
            this.lblWinGameOverIWin.Location = new System.Drawing.Point(546, 271);
            this.lblWinGameOverIWin.Name = "lblWinGameOverIWin";
            this.lblWinGameOverIWin.Size = new System.Drawing.Size(31, 13);
            this.lblWinGameOverIWin.TabIndex = 17;
            this.lblWinGameOverIWin.Text = "none";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 388);
            this.Controls.Add(this.lblWinGameOverIWin);
            this.Controls.Add(this.lblAttemptsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbLess);
            this.Controls.Add(this.rbEqual);
            this.Controls.Add(this.rbGreater);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.btnCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.RadioButton rbGreater;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAttemptsCount;
        private System.Windows.Forms.Label lblWinGameOverIWin;
    }
}

