
namespace tp1
{
    partial class RecorridosForm
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
            this.detalleBtn = new System.Windows.Forms.Button();
            this.resultadosTxt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // detalleBtn
            // 
            this.detalleBtn.Location = new System.Drawing.Point(25, 379);
            this.detalleBtn.Name = "detalleBtn";
            this.detalleBtn.Size = new System.Drawing.Size(137, 63);
            this.detalleBtn.TabIndex = 1;
            this.detalleBtn.Text = "Ver detalle";
            this.detalleBtn.UseVisualStyleBackColor = true;
            this.detalleBtn.Click += new System.EventHandler(this.DetalleBtn_Click);
            // 
            // resultadosTxt
            // 
            this.resultadosTxt.FormattingEnabled = true;
            this.resultadosTxt.ItemHeight = 16;
            this.resultadosTxt.Location = new System.Drawing.Point(36, 38);
            this.resultadosTxt.Name = "resultadosTxt";
            this.resultadosTxt.Size = new System.Drawing.Size(429, 292);
            this.resultadosTxt.TabIndex = 2;
            // 
            // RecorridosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 470);
            this.Controls.Add(this.resultadosTxt);
            this.Controls.Add(this.detalleBtn);
            this.Name = "RecorridosForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button detalleBtn;
        private System.Windows.Forms.ListBox resultadosTxt;
    }
}