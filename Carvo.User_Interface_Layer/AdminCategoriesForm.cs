using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminCategoriesForm : Form
    {
        private ICategoryService categoryService;
        private IServiceProvider serviceProvider;

        public AdminCategoriesForm(ICategoryService _categoryService, IServiceProvider _serviceProvider)
        {
            categoryService = _categoryService;
            serviceProvider = _serviceProvider;
            InitializeComponent();
            this.Load += async (s, e) => await LoadCategoriesAsync();
            this.serviceProvider = serviceProvider;
        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = CategoryGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in CategoryGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            CategoryGridView.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            string Name = CategoryNameTxt.Text;
            string Desc = CategoryDescTxt.Text;
            if (ValidateCategory(Name, Desc))
            {
                Category addedCategory = new Category { Name = Name, Description = Desc };
                await categoryService.AddCategoryAsync(addedCategory);
                await LoadCategoriesAsync();
            }
        }

        private async void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            string Name = CategoryNameTxt.Text;
            string Desc = CategoryDescTxt.Text;

            if (ValidateCategory(Name, Desc))
            {
                var selectedRow = CategoryGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                Category category = await categoryService.GetCategoryByIdAsync(id);

                category.Name = Name;
                category.Description = Desc;

                await categoryService.UpdateCategoryAsync(category);
                await LoadCategoriesAsync();
            }
        }

        private async void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = CategoryGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            await categoryService.DeleteCategoryAsync(id);
            await LoadCategoriesAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            var allCategories = await categoryService.GetAllCategoryAsync();

            var categories = allCategories.Select(c => new { ID = c.Id, Description = c.Description, Name = c.Name }).ToList();

            CategoryGridView.DataSource = null;
            CategoryGridView.DataSource = categories;

            CategoryGridView.Columns["ID"].Visible = false;
            CategoryGridView.Columns[1].HeaderText = "الوصف";
            CategoryGridView.Columns[2].HeaderText = "الاسم";
        }



        private void CategoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoryGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CategoryGridView.SelectedRows[0];
                string desc = (string)selectedRow.Cells["Description"].Value;
                string name = (string)selectedRow.Cells["Name"].Value;
                CategoryNameTxt.Text = name;
                CategoryDescTxt.Text = desc;
            }

        }



        /// <summary>
        /// Validation Function To validate Category Inputs
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="categoryDesc"></param>
        /// <returns>
        /// Displays Error Message On the Form , and return False If any input
        /// is invalid, Otherwise return True. 
        /// </returns>
        private bool ValidateCategory(string categoryName, string categoryDesc)
        {
            bool isValid = true;

            if (categoryName.Length < 3 || string.IsNullOrWhiteSpace(categoryName))
            {
                isValid = false;
                NameErrorMsg.Visible = true;
            }
            else
                NameErrorMsg.Visible = false;

            if (categoryDesc.Length < 5 || string.IsNullOrWhiteSpace(categoryDesc))
            {
                isValid = false;
                DescErrorMsg.Visible = true;
            }
            else
                DescErrorMsg.Visible = false;

            return isValid;
        }

        private void PrevImageAsBtn_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = serviceProvider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

    }
}
