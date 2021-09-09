
namespace tp1
{
    partial class MainForm
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
            this.taxiGroup = new System.Windows.Forms.GroupBox();
            this.marcaBox = new System.Windows.Forms.ComboBox();
            this.pasajerosTaxiTxt = new System.Windows.Forms.TextBox();
            this.nombreTaxiTxt = new System.Windows.Forms.TextBox();
            this.marcaLbl = new System.Windows.Forms.Label();
            this.pasajerosTaxiLbl = new System.Windows.Forms.Label();
            this.nombreTaxiLbl = new System.Windows.Forms.Label();
            this.taxiBtn = new System.Windows.Forms.Button();
            this.omnibusBtn = new System.Windows.Forms.Button();
            this.omnibusGroup = new System.Windows.Forms.GroupBox();
            this.ramalBox = new System.Windows.Forms.ComboBox();
            this.pasajerosOmnibusTxt = new System.Windows.Forms.TextBox();
            this.nombreOmnibusTxt = new System.Windows.Forms.TextBox();
            this.ramalLbl = new System.Windows.Forms.Label();
            this.nombreOmnibusLbl = new System.Windows.Forms.Label();
            this.pasajerosOmnibusLbl = new System.Windows.Forms.Label();
            this.transportesTxt = new System.Windows.Forms.RichTextBox();
            this.comenzarBtn = new System.Windows.Forms.Button();
            this.taxiGroup.SuspendLayout();
            this.omnibusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // taxiGroup
            // 
            this.taxiGroup.Controls.Add(this.marcaBox);
            this.taxiGroup.Controls.Add(this.pasajerosTaxiTxt);
            this.taxiGroup.Controls.Add(this.nombreTaxiTxt);
            this.taxiGroup.Controls.Add(this.marcaLbl);
            this.taxiGroup.Controls.Add(this.pasajerosTaxiLbl);
            this.taxiGroup.Controls.Add(this.nombreTaxiLbl);
            this.taxiGroup.Controls.Add(this.taxiBtn);
            this.taxiGroup.Location = new System.Drawing.Point(28, 102);
            this.taxiGroup.Name = "taxiGroup";
            this.taxiGroup.Size = new System.Drawing.Size(214, 286);
            this.taxiGroup.TabIndex = 2;
            this.taxiGroup.TabStop = false;
            // 
            // marcaBox
            // 
            this.marcaBox.FormattingEnabled = true;
            this.marcaBox.Location = new System.Drawing.Point(31, 173);
            this.marcaBox.Name = "marcaBox";
            this.marcaBox.Size = new System.Drawing.Size(151, 24);
            this.marcaBox.TabIndex = 2;
            // 
            // pasajerosTaxiTxt
            // 
            this.pasajerosTaxiTxt.Location = new System.Drawing.Point(31, 112);
            this.pasajerosTaxiTxt.Name = "pasajerosTaxiTxt";
            this.pasajerosTaxiTxt.Size = new System.Drawing.Size(151, 22);
            this.pasajerosTaxiTxt.TabIndex = 1;
            // 
            // nombreTaxiTxt
            // 
            this.nombreTaxiTxt.Location = new System.Drawing.Point(31, 49);
            this.nombreTaxiTxt.Name = "nombreTaxiTxt";
            this.nombreTaxiTxt.Size = new System.Drawing.Size(151, 22);
            this.nombreTaxiTxt.TabIndex = 0;
            // 
            // marcaLbl
            // 
            this.marcaLbl.AutoSize = true;
            this.marcaLbl.Location = new System.Drawing.Point(28, 153);
            this.marcaLbl.Name = "marcaLbl";
            this.marcaLbl.Size = new System.Drawing.Size(47, 17);
            this.marcaLbl.TabIndex = 4;
            this.marcaLbl.Text = "Marca";
            // 
            // pasajerosTaxiLbl
            // 
            this.pasajerosTaxiLbl.AutoSize = true;
            this.pasajerosTaxiLbl.Location = new System.Drawing.Point(28, 92);
            this.pasajerosTaxiLbl.Name = "pasajerosTaxiLbl";
            this.pasajerosTaxiLbl.Size = new System.Drawing.Size(150, 17);
            this.pasajerosTaxiLbl.TabIndex = 1;
            this.pasajerosTaxiLbl.Text = "Cantidad de pasajeros";
            // 
            // nombreTaxiLbl
            // 
            this.nombreTaxiLbl.AutoSize = true;
            this.nombreTaxiLbl.Location = new System.Drawing.Point(28, 29);
            this.nombreTaxiLbl.Name = "nombreTaxiLbl";
            this.nombreTaxiLbl.Size = new System.Drawing.Size(125, 17);
            this.nombreTaxiLbl.TabIndex = 1;
            this.nombreTaxiLbl.Text = "Nombre del chofer";
            // 
            // taxiBtn
            // 
            this.taxiBtn.Location = new System.Drawing.Point(31, 210);
            this.taxiBtn.Name = "taxiBtn";
            this.taxiBtn.Size = new System.Drawing.Size(151, 41);
            this.taxiBtn.TabIndex = 3;
            this.taxiBtn.Text = "Crear Taxi";
            this.taxiBtn.UseVisualStyleBackColor = true;
            this.taxiBtn.Click += new System.EventHandler(this.taxiBtn_Click);
            // 
            // omnibusBtn
            // 
            this.omnibusBtn.Location = new System.Drawing.Point(33, 210);
            this.omnibusBtn.Name = "omnibusBtn";
            this.omnibusBtn.Size = new System.Drawing.Size(151, 41);
            this.omnibusBtn.TabIndex = 7;
            this.omnibusBtn.Text = "Crear Omnibus";
            this.omnibusBtn.UseVisualStyleBackColor = true;
            this.omnibusBtn.Click += new System.EventHandler(this.omnibusBtn_Click);
            // 
            // omnibusGroup
            // 
            this.omnibusGroup.Controls.Add(this.ramalBox);
            this.omnibusGroup.Controls.Add(this.pasajerosOmnibusTxt);
            this.omnibusGroup.Controls.Add(this.nombreOmnibusTxt);
            this.omnibusGroup.Controls.Add(this.ramalLbl);
            this.omnibusGroup.Controls.Add(this.nombreOmnibusLbl);
            this.omnibusGroup.Controls.Add(this.pasajerosOmnibusLbl);
            this.omnibusGroup.Controls.Add(this.omnibusBtn);
            this.omnibusGroup.Location = new System.Drawing.Point(573, 102);
            this.omnibusGroup.Name = "omnibusGroup";
            this.omnibusGroup.Size = new System.Drawing.Size(214, 286);
            this.omnibusGroup.TabIndex = 3;
            this.omnibusGroup.TabStop = false;
            // 
            // ramalBox
            // 
            this.ramalBox.FormattingEnabled = true;
            this.ramalBox.Location = new System.Drawing.Point(33, 173);
            this.ramalBox.Name = "ramalBox";
            this.ramalBox.Size = new System.Drawing.Size(151, 24);
            this.ramalBox.TabIndex = 6;
            // 
            // pasajerosOmnibusTxt
            // 
            this.pasajerosOmnibusTxt.Location = new System.Drawing.Point(33, 112);
            this.pasajerosOmnibusTxt.Name = "pasajerosOmnibusTxt";
            this.pasajerosOmnibusTxt.Size = new System.Drawing.Size(147, 22);
            this.pasajerosOmnibusTxt.TabIndex = 5;
            // 
            // nombreOmnibusTxt
            // 
            this.nombreOmnibusTxt.Location = new System.Drawing.Point(33, 49);
            this.nombreOmnibusTxt.Name = "nombreOmnibusTxt";
            this.nombreOmnibusTxt.Size = new System.Drawing.Size(147, 22);
            this.nombreOmnibusTxt.TabIndex = 4;
            // 
            // ramalLbl
            // 
            this.ramalLbl.AutoSize = true;
            this.ramalLbl.Location = new System.Drawing.Point(33, 153);
            this.ramalLbl.Name = "ramalLbl";
            this.ramalLbl.Size = new System.Drawing.Size(48, 17);
            this.ramalLbl.TabIndex = 3;
            this.ramalLbl.Text = "Ramal";
            // 
            // nombreOmnibusLbl
            // 
            this.nombreOmnibusLbl.AutoSize = true;
            this.nombreOmnibusLbl.Location = new System.Drawing.Point(30, 29);
            this.nombreOmnibusLbl.Name = "nombreOmnibusLbl";
            this.nombreOmnibusLbl.Size = new System.Drawing.Size(127, 17);
            this.nombreOmnibusLbl.TabIndex = 2;
            this.nombreOmnibusLbl.Text = "Nombre del Chofer";
            // 
            // pasajerosOmnibusLbl
            // 
            this.pasajerosOmnibusLbl.AutoSize = true;
            this.pasajerosOmnibusLbl.Location = new System.Drawing.Point(33, 92);
            this.pasajerosOmnibusLbl.Name = "pasajerosOmnibusLbl";
            this.pasajerosOmnibusLbl.Size = new System.Drawing.Size(150, 17);
            this.pasajerosOmnibusLbl.TabIndex = 2;
            this.pasajerosOmnibusLbl.Text = "Cantidad de pasajeros";
            // 
            // transportesTxt
            // 
            this.transportesTxt.Enabled = false;
            this.transportesTxt.Location = new System.Drawing.Point(276, 111);
            this.transportesTxt.Name = "transportesTxt";
            this.transportesTxt.Size = new System.Drawing.Size(263, 170);
            this.transportesTxt.TabIndex = 4;
            this.transportesTxt.Text = "";
            // 
            // comenzarBtn
            // 
            this.comenzarBtn.Location = new System.Drawing.Point(337, 329);
            this.comenzarBtn.Name = "comenzarBtn";
            this.comenzarBtn.Size = new System.Drawing.Size(141, 59);
            this.comenzarBtn.TabIndex = 5;
            this.comenzarBtn.Text = "COMENZAR RECORRIDOS";
            this.comenzarBtn.UseVisualStyleBackColor = true;
            this.comenzarBtn.Click += new System.EventHandler(this.comenzarBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.comenzarBtn);
            this.Controls.Add(this.transportesTxt);
            this.Controls.Add(this.omnibusGroup);
            this.Controls.Add(this.taxiGroup);
            this.Name = "MainForm";
            this.Text = "Carrera de TP\'s";
            this.taxiGroup.ResumeLayout(false);
            this.taxiGroup.PerformLayout();
            this.omnibusGroup.ResumeLayout(false);
            this.omnibusGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox taxiGroup;
        private System.Windows.Forms.TextBox nombreTaxiTxt; 
        private System.Windows.Forms.TextBox pasajerosTaxiTxt;
        private System.Windows.Forms.ComboBox marcaBox;
        private System.Windows.Forms.Button taxiBtn;
        private System.Windows.Forms.GroupBox omnibusGroup;
        private System.Windows.Forms.TextBox nombreOmnibusTxt;
        private System.Windows.Forms.TextBox pasajerosOmnibusTxt;
        private System.Windows.Forms.ComboBox ramalBox;
        private System.Windows.Forms.Button omnibusBtn;
        private System.Windows.Forms.Label pasajerosTaxiLbl;
        private System.Windows.Forms.Label marcaLbl;
        private System.Windows.Forms.Label nombreTaxiLbl;
        private System.Windows.Forms.Label ramalLbl;
        private System.Windows.Forms.Label nombreOmnibusLbl;
        private System.Windows.Forms.Label pasajerosOmnibusLbl;
        private System.Windows.Forms.RichTextBox transportesTxt;
        private System.Windows.Forms.Button comenzarBtn;
    }
}

