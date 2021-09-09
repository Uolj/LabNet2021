
namespace tp1
{
    partial class DetalleForm
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
            this.detalleTxt = new System.Windows.Forms.RichTextBox();
            this.volverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detalleTxt
            // 
            this.detalleTxt.Location = new System.Drawing.Point(12, 12);
            this.detalleTxt.Name = "detalleTxt";
            this.detalleTxt.Size = new System.Drawing.Size(441, 368);
            this.detalleTxt.TabIndex = 0;
            this.detalleTxt.Text = "";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(295, 398);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(158, 52);
            this.volverBtn.TabIndex = 1;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // DetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 473);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.detalleTxt);
            this.Name = "DetalleForm";
            this.Text = "DetalleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox detalleTxt;
        private System.Windows.Forms.Button volverBtn;
    }
}