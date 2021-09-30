
namespace PracticaEFUI
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
            this.shippersTxt = new System.Windows.Forms.RichTextBox();
            this.CategoriesTxt = new System.Windows.Forms.RichTextBox();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.companyNameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.addShipperBtn = new System.Windows.Forms.Button();
            this.categoryNameTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.selectShipperIdTxt = new System.Windows.Forms.TextBox();
            this.selectShipperIdLbl = new System.Windows.Forms.Label();
            this.selectCategoryIdLbl = new System.Windows.Forms.Label();
            this.deleteShipperBtn = new System.Windows.Forms.Button();
            this.selectCategoryIdTxt = new System.Windows.Forms.TextBox();
            this.deleteCategoryBtn = new System.Windows.Forms.Button();
            this.updateShipperBtn = new System.Windows.Forms.Button();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.shipperOrLbl = new System.Windows.Forms.Label();
            this.categoryOrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shippersTxt
            // 
            this.shippersTxt.Location = new System.Drawing.Point(39, 296);
            this.shippersTxt.Name = "shippersTxt";
            this.shippersTxt.ReadOnly = true;
            this.shippersTxt.Size = new System.Drawing.Size(324, 199);
            this.shippersTxt.TabIndex = 0;
            this.shippersTxt.Text = "";
            // 
            // CategoriesTxt
            // 
            this.CategoriesTxt.Location = new System.Drawing.Point(431, 296);
            this.CategoriesTxt.Name = "CategoriesTxt";
            this.CategoriesTxt.ReadOnly = true;
            this.CategoriesTxt.Size = new System.Drawing.Size(445, 199);
            this.CategoriesTxt.TabIndex = 1;
            this.CategoriesTxt.Text = "";
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Location = new System.Drawing.Point(263, 82);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(100, 22);
            this.companyNameTxt.TabIndex = 3;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(263, 126);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(100, 22);
            this.phoneTxt.TabIndex = 4;
            // 
            // companyNameLbl
            // 
            this.companyNameLbl.AutoSize = true;
            this.companyNameLbl.Location = new System.Drawing.Point(139, 87);
            this.companyNameLbl.Name = "companyNameLbl";
            this.companyNameLbl.Size = new System.Drawing.Size(106, 17);
            this.companyNameLbl.TabIndex = 6;
            this.companyNameLbl.Text = "Company name";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(196, 129);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(49, 17);
            this.phoneLbl.TabIndex = 7;
            this.phoneLbl.Text = "Phone";
            // 
            // addShipperBtn
            // 
            this.addShipperBtn.Location = new System.Drawing.Point(263, 174);
            this.addShipperBtn.Name = "addShipperBtn";
            this.addShipperBtn.Size = new System.Drawing.Size(100, 28);
            this.addShipperBtn.TabIndex = 8;
            this.addShipperBtn.Text = "Add shipper";
            this.addShipperBtn.UseVisualStyleBackColor = true;
            this.addShipperBtn.Click += new System.EventHandler(this.AddShipperBtn_click);
            // 
            // categoryNameTxt
            // 
            this.categoryNameTxt.Location = new System.Drawing.Point(776, 83);
            this.categoryNameTxt.Name = "categoryNameTxt";
            this.categoryNameTxt.Size = new System.Drawing.Size(100, 22);
            this.categoryNameTxt.TabIndex = 10;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(539, 131);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(337, 22);
            this.descriptionTxt.TabIndex = 11;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(758, 174);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(118, 28);
            this.addCategoryBtn.TabIndex = 12;
            this.addCategoryBtn.Text = "Add category";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.Location = new System.Drawing.Point(664, 85);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(104, 17);
            this.categoryNameLbl.TabIndex = 14;
            this.categoryNameLbl.Text = "Category name";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(452, 129);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.descriptionLbl.TabIndex = 15;
            this.descriptionLbl.Text = "Description";
            // 
            // selectShipperIdTxt
            // 
            this.selectShipperIdTxt.Location = new System.Drawing.Point(63, 178);
            this.selectShipperIdTxt.Name = "selectShipperIdTxt";
            this.selectShipperIdTxt.Size = new System.Drawing.Size(43, 22);
            this.selectShipperIdTxt.TabIndex = 16;
            // 
            // selectShipperIdLbl
            // 
            this.selectShipperIdLbl.AutoSize = true;
            this.selectShipperIdLbl.Location = new System.Drawing.Point(36, 182);
            this.selectShipperIdLbl.Name = "selectShipperIdLbl";
            this.selectShipperIdLbl.Size = new System.Drawing.Size(21, 17);
            this.selectShipperIdLbl.TabIndex = 18;
            this.selectShipperIdLbl.Text = "ID";
            // 
            // selectCategoryIdLbl
            // 
            this.selectCategoryIdLbl.AutoSize = true;
            this.selectCategoryIdLbl.Location = new System.Drawing.Point(428, 180);
            this.selectCategoryIdLbl.Name = "selectCategoryIdLbl";
            this.selectCategoryIdLbl.Size = new System.Drawing.Size(21, 17);
            this.selectCategoryIdLbl.TabIndex = 19;
            this.selectCategoryIdLbl.Text = "ID";
            // 
            // deleteShipperBtn
            // 
            this.deleteShipperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteShipperBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteShipperBtn.Location = new System.Drawing.Point(112, 206);
            this.deleteShipperBtn.Name = "deleteShipperBtn";
            this.deleteShipperBtn.Size = new System.Drawing.Size(100, 26);
            this.deleteShipperBtn.TabIndex = 20;
            this.deleteShipperBtn.Text = "DELETE";
            this.deleteShipperBtn.UseVisualStyleBackColor = true;
            this.deleteShipperBtn.Click += new System.EventHandler(this.DeleteShipperBtn_Click);
            // 
            // selectCategoryIdTxt
            // 
            this.selectCategoryIdTxt.Location = new System.Drawing.Point(455, 177);
            this.selectCategoryIdTxt.Name = "selectCategoryIdTxt";
            this.selectCategoryIdTxt.Size = new System.Drawing.Size(43, 22);
            this.selectCategoryIdTxt.TabIndex = 21;
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteCategoryBtn.Location = new System.Drawing.Point(504, 206);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(100, 26);
            this.deleteCategoryBtn.TabIndex = 22;
            this.deleteCategoryBtn.Text = "DELETE";
            this.deleteCategoryBtn.UseVisualStyleBackColor = true;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.DeleteCategoryBtn_Click);
            // 
            // updateShipperBtn
            // 
            this.updateShipperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateShipperBtn.ForeColor = System.Drawing.Color.Blue;
            this.updateShipperBtn.Location = new System.Drawing.Point(112, 174);
            this.updateShipperBtn.Name = "updateShipperBtn";
            this.updateShipperBtn.Size = new System.Drawing.Size(100, 28);
            this.updateShipperBtn.TabIndex = 23;
            this.updateShipperBtn.Text = "UPDATE";
            this.updateShipperBtn.UseVisualStyleBackColor = true;
            this.updateShipperBtn.Click += new System.EventHandler(this.UpdateShipperBtn_Click);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryBtn.ForeColor = System.Drawing.Color.Blue;
            this.updateCategoryBtn.Location = new System.Drawing.Point(504, 174);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(100, 28);
            this.updateCategoryBtn.TabIndex = 24;
            this.updateCategoryBtn.Text = "UPDATE";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.UpdateCategoryBtn_Click);
            // 
            // shipperOrLbl
            // 
            this.shipperOrLbl.AutoSize = true;
            this.shipperOrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipperOrLbl.Location = new System.Drawing.Point(225, 180);
            this.shipperOrLbl.Name = "shipperOrLbl";
            this.shipperOrLbl.Size = new System.Drawing.Size(31, 17);
            this.shipperOrLbl.TabIndex = 25;
            this.shipperOrLbl.Text = "OR";
            // 
            // categoryOrLbl
            // 
            this.categoryOrLbl.AutoSize = true;
            this.categoryOrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryOrLbl.Location = new System.Drawing.Point(664, 182);
            this.categoryOrLbl.Name = "categoryOrLbl";
            this.categoryOrLbl.Size = new System.Drawing.Size(31, 17);
            this.categoryOrLbl.TabIndex = 26;
            this.categoryOrLbl.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Specify the record ID ONLY if you want to delete or update it";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryOrLbl);
            this.Controls.Add(this.shipperOrLbl);
            this.Controls.Add(this.updateCategoryBtn);
            this.Controls.Add(this.updateShipperBtn);
            this.Controls.Add(this.deleteCategoryBtn);
            this.Controls.Add(this.selectCategoryIdTxt);
            this.Controls.Add(this.deleteShipperBtn);
            this.Controls.Add(this.selectCategoryIdLbl);
            this.Controls.Add(this.selectShipperIdLbl);
            this.Controls.Add(this.selectShipperIdTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.categoryNameLbl);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.categoryNameTxt);
            this.Controls.Add(this.addShipperBtn);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.companyNameLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.companyNameTxt);
            this.Controls.Add(this.CategoriesTxt);
            this.Controls.Add(this.shippersTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(934, 569);
            this.MinimumSize = new System.Drawing.Size(934, 569);
            this.Name = "MainForm";
            this.Text = "TP4-EF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox shippersTxt;
        private System.Windows.Forms.RichTextBox CategoriesTxt;
        private System.Windows.Forms.TextBox companyNameTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label companyNameLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Button addShipperBtn;
        private System.Windows.Forms.TextBox categoryNameTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox selectShipperIdTxt;
        private System.Windows.Forms.Label selectShipperIdLbl;
        private System.Windows.Forms.Label selectCategoryIdLbl;
        private System.Windows.Forms.Button deleteShipperBtn;
        private System.Windows.Forms.TextBox selectCategoryIdTxt;
        private System.Windows.Forms.Button deleteCategoryBtn;
        private System.Windows.Forms.Button updateShipperBtn;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.Label shipperOrLbl;
        private System.Windows.Forms.Label categoryOrLbl;
        private System.Windows.Forms.Label label1;
    }
}

