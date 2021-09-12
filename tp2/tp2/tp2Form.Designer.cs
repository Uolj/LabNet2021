
namespace UI
{
    partial class tp2Form
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
            this.divideByZeroTxt = new System.Windows.Forms.TextBox();
            this.dividirByZeroLbl = new System.Windows.Forms.Label();
            this.divideByZeroBtn = new System.Windows.Forms.Button();
            this.divideLbl = new System.Windows.Forms.Label();
            this.dividendTxt = new System.Windows.Forms.TextBox();
            this.divisorTxt = new System.Windows.Forms.TextBox();
            this.divideBtn = new System.Windows.Forms.Button();
            this.dividendLbl = new System.Windows.Forms.Label();
            this.divisorLbl = new System.Windows.Forms.Label();
            this.exceptionBtn = new System.Windows.Forms.Button();
            this.customExceptionBtn = new System.Windows.Forms.Button();
            this.divideSymbolLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divideByZeroTxt
            // 
            this.divideByZeroTxt.Location = new System.Drawing.Point(246, 29);
            this.divideByZeroTxt.Name = "divideByZeroTxt";
            this.divideByZeroTxt.Size = new System.Drawing.Size(100, 22);
            this.divideByZeroTxt.TabIndex = 0;
            // 
            // dividirByZeroLbl
            // 
            this.dividirByZeroLbl.AutoSize = true;
            this.dividirByZeroLbl.Location = new System.Drawing.Point(22, 28);
            this.dividirByZeroLbl.Name = "dividirByZeroLbl";
            this.dividirByZeroLbl.Size = new System.Drawing.Size(209, 17);
            this.dividirByZeroLbl.TabIndex = 1;
            this.dividirByZeroLbl.Text = "Try to divide a number by zero: ";
            // 
            // divideByZeroBtn
            // 
            this.divideByZeroBtn.Location = new System.Drawing.Point(367, 25);
            this.divideByZeroBtn.Name = "divideByZeroBtn";
            this.divideByZeroBtn.Size = new System.Drawing.Size(75, 30);
            this.divideByZeroBtn.TabIndex = 2;
            this.divideByZeroBtn.Text = "divide";
            this.divideByZeroBtn.UseVisualStyleBackColor = true;
            this.divideByZeroBtn.Click += new System.EventHandler(this.divideByZeroBtn_Click);
            // 
            // divideLbl
            // 
            this.divideLbl.AutoSize = true;
            this.divideLbl.Location = new System.Drawing.Point(22, 78);
            this.divideLbl.Name = "divideLbl";
            this.divideLbl.Size = new System.Drawing.Size(135, 17);
            this.divideLbl.TabIndex = 3;
            this.divideLbl.Text = "Divide two numbers:";
            // 
            // dividendTxt
            // 
            this.dividendTxt.Location = new System.Drawing.Point(25, 113);
            this.dividendTxt.Name = "dividendTxt";
            this.dividendTxt.Size = new System.Drawing.Size(82, 22);
            this.dividendTxt.TabIndex = 4;
            // 
            // divisorTxt
            // 
            this.divisorTxt.Location = new System.Drawing.Point(134, 112);
            this.divisorTxt.Name = "divisorTxt";
            this.divisorTxt.Size = new System.Drawing.Size(82, 22);
            this.divisorTxt.TabIndex = 5;
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(246, 108);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(75, 30);
            this.divideBtn.TabIndex = 6;
            this.divideBtn.Text = "divide";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // dividendLbl
            // 
            this.dividendLbl.AutoSize = true;
            this.dividendLbl.Location = new System.Drawing.Point(32, 138);
            this.dividendLbl.Name = "dividendLbl";
            this.dividendLbl.Size = new System.Drawing.Size(71, 17);
            this.dividendLbl.TabIndex = 7;
            this.dividendLbl.Text = "(dividend)";
            // 
            // divisorLbl
            // 
            this.divisorLbl.AutoSize = true;
            this.divisorLbl.Location = new System.Drawing.Point(147, 138);
            this.divisorLbl.Name = "divisorLbl";
            this.divisorLbl.Size = new System.Drawing.Size(59, 17);
            this.divisorLbl.TabIndex = 8;
            this.divisorLbl.Text = "(divisor)";
            // 
            // exceptionBtn
            // 
            this.exceptionBtn.Location = new System.Drawing.Point(25, 186);
            this.exceptionBtn.Name = "exceptionBtn";
            this.exceptionBtn.Size = new System.Drawing.Size(195, 45);
            this.exceptionBtn.TabIndex = 9;
            this.exceptionBtn.Text = "Throw generic exception";
            this.exceptionBtn.UseVisualStyleBackColor = true;
            this.exceptionBtn.Click += new System.EventHandler(this.exceptionBtn_Click);
            // 
            // customExceptionBtn
            // 
            this.customExceptionBtn.Location = new System.Drawing.Point(246, 186);
            this.customExceptionBtn.Name = "customExceptionBtn";
            this.customExceptionBtn.Size = new System.Drawing.Size(195, 45);
            this.customExceptionBtn.TabIndex = 10;
            this.customExceptionBtn.Text = "Throw custom exception";    
            this.customExceptionBtn.UseVisualStyleBackColor = true;
            this.customExceptionBtn.Click += new System.EventHandler(this.customExceptionBtn_Click);
            // 
            // divideSymbolLbl
            // 
            this.divideSymbolLbl.AutoSize = true;
            this.divideSymbolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideSymbolLbl.Location = new System.Drawing.Point(115, 113);
            this.divideSymbolLbl.Name = "divideSymbolLbl";
            this.divideSymbolLbl.Size = new System.Drawing.Size(13, 18);
            this.divideSymbolLbl.TabIndex = 11;
            this.divideSymbolLbl.Text = "/";
            // 
            // tp2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 257);
            this.Controls.Add(this.divideSymbolLbl);
            this.Controls.Add(this.customExceptionBtn);
            this.Controls.Add(this.exceptionBtn);
            this.Controls.Add(this.divisorLbl);
            this.Controls.Add(this.dividendLbl);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.divisorTxt);
            this.Controls.Add(this.dividendTxt);
            this.Controls.Add(this.divideLbl);
            this.Controls.Add(this.divideByZeroBtn);
            this.Controls.Add(this.dividirByZeroLbl);
            this.Controls.Add(this.divideByZeroTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 304);
            this.MinimumSize = new System.Drawing.Size(485, 304);
            this.Name = "tp2Form";
            this.ShowIcon = false;
            this.Text = "TP2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox divideByZeroTxt;
        private System.Windows.Forms.Label dividirByZeroLbl;
        private System.Windows.Forms.Button divideByZeroBtn;
        private System.Windows.Forms.Label divideLbl;
        private System.Windows.Forms.TextBox dividendTxt;
        private System.Windows.Forms.TextBox divisorTxt;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Label dividendLbl;
        private System.Windows.Forms.Label divisorLbl;
        private System.Windows.Forms.Button exceptionBtn;
        private System.Windows.Forms.Button customExceptionBtn;
        private System.Windows.Forms.Label divideSymbolLbl;
    }
}

