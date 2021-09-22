using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System.Data.Entity;

namespace PracticaEFUI
{
    public delegate void ReloadInfoDelegate();
    public partial class MainForm : Form
    {
        public ShippersLogic shippersLogic = new ShippersLogic();
        public CategoriesLogic categoriesLogic = new CategoriesLogic();
        event ReloadInfoDelegate ReloadInfo;
        public MainForm()
        {
            InitializeComponent();
            ReloadInfo += MainForm_ReloadInfo;
            ReloadInfo.Invoke();
        }

        private void MainForm_ReloadInfo()
        {
            this.CategoriesTxt.Text = categoriesLogic.ShowInfo();
            this.shippersTxt.Text = shippersLogic.ShowInfo();
        }

        private void AddShipperBtn_click(object sender, EventArgs e)
        {
            try
            {
                string companyName = companyNameTxt.Text;
                string phone = phoneTxt.Text;

                Shippers newShipper = new Shippers(companyName, phone);
                shippersLogic.DataCheck<Shippers>(newShipper);

                shippersLogic.Add<Shippers>(newShipper);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please fill in all required fields correctly");
            }
            catch (CharacterLimitExceededException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = categoryNameTxt.Text;
                string description = descriptionTxt.Text;

                Categories newCategory = new Categories(categoryName, description);
                categoriesLogic.DataCheck<Categories>(newCategory);

                categoriesLogic.Add<Categories>(newCategory);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please fill in all required fields correctly");
            }
            catch (CharacterLimitExceededException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectCategoryIdTxt.Text);
                categoriesLogic.Delete(id);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please enter a valid id");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "this id doesnt exist");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
        }

        private void DeleteShipperBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectShipperIdTxt.Text);
                shippersLogic.Delete(id);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please enter a valid id");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "this id doesnt exist");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
        }

        private void UpdateShipperBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectShipperIdTxt.Text);
                string companyName = companyNameTxt.Text;
                string phone = phoneTxt.Text;

                Shippers updatedItem = new Shippers(id, companyName, phone);
                shippersLogic.DataCheck<Shippers>(updatedItem);

                shippersLogic.Update<Shippers>(updatedItem);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please fill in all required fields correctly");
            }
            catch (CharacterLimitExceededException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "this id doesnt exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectCategoryIdTxt.Text);
                string categoryName = categoryNameTxt.Text;
                string description = descriptionTxt.Text;

                Categories updatedItem = new Categories(id, categoryName, description);
                categoriesLogic.DataCheck<Categories>(updatedItem);

                categoriesLogic.Update<Categories>(updatedItem);
                ReloadInfo.Invoke();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "please fill in all required fields correctly");
            }
            catch (CharacterLimitExceededException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "what are you trying to do? 0_0");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "this id doesnt exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

