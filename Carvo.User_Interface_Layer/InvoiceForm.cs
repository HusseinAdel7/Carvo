using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;
using Microsoft.Extensions.DependencyInjection;


namespace Carvo.User_Interface_Layer
{
    public partial class InvoiceForm : Form
    {
        private IServiceProvider serviceProvider;
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
        public Invoice Invoice_ { get; set; }
        public decimal PaidPrice { get; set; }
        public List<DataDispalyedInGrid> ProductsList;
        public InvoiceForm(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
            InitializeComponent();
            this.Load += async (s, e) => await LoadInvoiceFormAsync();

        }

        private async Task LoadInvoiceFormAsync()
        {
            this.Controls.Remove(ProductsServicesGrid);
            this.Controls.Remove(PartsAndServicesHeaderPanel);

            InvoiceDate.Text = Invoice_.InvoiceDate.ToString();
            InvoiceID.Text = $"رقم الفاتورة : {Invoice_.Id}";
            InvoiceType.Text = Invoice_.InvoiceType.ToString();
            EmployeeName.Text = LoggedUser.loggedUserName;
            CustomerName.Text = Customer.Name;
            CustomerPhone.Text = Customer.PhoneNumber.ToString();

            if (Invoice_.InvoiceType == Data_Access_Layer.Enums.InvoiceType.Repair)
            {
                VehicleModel.Text = Vehicle.Model.ToString();
                VehiclePlate.Text = Vehicle.PlateNumber.ToString();
                VehicleVIN.Text = Vehicle.Id.ToString();

                SubTotal.Text = Invoice_.RepairAmount.ToString();
                PaidAmount.Text = PaidPrice.ToString();
                RemainingAmount.Text = (Invoice_.RepairAmount - PaidPrice).ToString();
            }
            else
            {

                //var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

                ProductsServicesGrid.AllowUserToAddRows = false;
                ProductsServicesGrid.DataSource = ProductsList;

                ProductsServicesGrid.Columns["InvoiceId"].Visible = false;
                ProductsServicesGrid.Columns["ProdId"].Visible = false;
                ProductsServicesGrid.Columns[2].HeaderText = "المنتج";
                ProductsServicesGrid.Columns["CustomerName"].Visible = false;
                ProductsServicesGrid.Columns[4].HeaderText = "الكمية";
                ProductsServicesGrid.Columns[5].HeaderText = "السعر";

                SubTotal.Text = Invoice_.SaleAmount.ToString();
                PaidAmount.Text = PaidPrice.ToString();
                RemainingAmount.Text = (Invoice_.SaleAmount - PaidPrice).ToString();
            }




        }

        private void ProductsServicesGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = ProductsServicesGrid.ColumnHeadersHeight;

            foreach (DataGridViewRow row in ProductsServicesGrid.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            ProductsServicesGrid.Height = totalHeight + 2; // 2px padding
        }
       
        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void PrevFormBtn_Click(object sender, EventArgs e)
        {
            EmployeeDashboardForm employeeDashboard = serviceProvider.GetRequiredService<EmployeeDashboardForm>();
            employeeDashboard.Show();
            this.Close();
        }

        private void PrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.Title = "Save Invoice as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportToPDF(filePath);
                    MessageBox.Show("Invoice exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportToPDF(string path)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            var invoiceNumber = Invoice_.Id; // From your form
            var invoiceType = Invoice_.InvoiceType == Data_Access_Layer.Enums.InvoiceType.Repair ? "صيانة" : "مشتريات"; // From your form
            var invoiceDate = Invoice_.InvoiceDate;

            var empName = LoggedUser.loggedUserName;

            var customerName = Customer.Name; // From your form
            var customerPhone = Customer.PhoneNumber; // From your form

            decimal totalPrice = 0;
            decimal paidPrice = 0;
            decimal remainingPrice = 0;

            SubTotal.Text = Invoice_.SaleAmount.ToString();
            PaidAmount.Text = PaidPrice.ToString();
            RemainingAmount.Text = (Invoice_.SaleAmount - PaidPrice).ToString();

            string vehicleName = null;
            string vehicleModel = null;
            string vehiclePlate = null;

            if (Invoice_.InvoiceType == Data_Access_Layer.Enums.InvoiceType.Repair)
            {
                vehicleName = Vehicle.Name;
                vehicleModel = Vehicle.Model;
                vehiclePlate = Vehicle.PlateNumber;
                totalPrice = Invoice_.RepairAmount;
                paidPrice = PaidPrice;
                remainingPrice = (Invoice_.RepairAmount - PaidPrice);
            }
            else
            {
                totalPrice = Invoice_.SaleAmount;
                paidPrice = PaidPrice;
                remainingPrice = (Invoice_.SaleAmount - PaidPrice);
            }

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(14));

                    page.Content().Column(column =>
                    {
                        column.Spacing(4);
                        // Invoice Date (Top Left Alone)
                        column.Item().AlignLeft().Text($"{invoiceDate:dd/MM/yyyy HH:mm}");

                        column.Spacing(11);       

                        // Header Title
                        column.Item().Text("شركة الأستاذ للسيارات")
                            .FontSize(24)
                            .SemiBold()
                            .AlignCenter();

                        column.Item().Text($"فاتورة {invoiceType}")
                            .FontSize(20)
                            .SemiBold()
                            .AlignCenter();

                        

                        // Invoice Metadata (Number and Type) with spacing
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text($"رقم الفاتورة:     {invoiceNumber}").AlignRight();
                        });

                        // Conditional: Repair Invoice Details
                        if (Invoice_.InvoiceType == Data_Access_Layer.Enums.InvoiceType.Repair)
                        {
                            column.Item().Text("معلومات عن السيارة:")
                                .AlignRight()
                                .Bold();

                            column.Item().Row(row =>
                            {
                                
                                
                                row.RelativeItem().Text($"    رقم اللوحة:   {vehiclePlate}").AlignRight();
                                row.RelativeItem().Text($"    الموديل:  {vehicleModel}").AlignRight();
                                row.RelativeItem().Text($"    اسم السيارة:  {vehicleName}").AlignRight();
                            });
                        }
                        else // Sales Invoice with Product List
                        {
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });

                                // Table Header
                                table.Cell().Element(CellStyle).Text("السعر").AlignCenter();
                                table.Cell().Element(CellStyle).Text("الكمية").AlignCenter();
                                table.Cell().Element(CellStyle).Text("المنتج").AlignCenter();
                                
                                

                                // Product Rows
                                foreach (var product in ProductsList)
                                {
                                    table.Cell().Element(CellStyle).Text(product.TotalPrice.ToString()).AlignCenter();
                                    table.Cell().Element(CellStyle).Text(product.Quantity.ToString()).AlignCenter();
                                    table.Cell().Element(CellStyle).Text(product.ProdName).AlignCenter();            
                                }
                            });
                        }

                        // Customer Info (Name right, Phone left) with spacing
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text($"     رقم الهاتف: {customerPhone}").AlignRight();
                            row.RelativeItem().Text($"     اسم العميل: {customerName}").AlignRight();
                        });

                        // Price Summary (in one line) with spacing
                        column.Item().Row(row =>
                        { 
                            row.RelativeItem().Text($"المبلغ المتبقي: {remainingPrice}").AlignLeft();
                            row.RelativeItem().Text($"المبلغ المدفوع: {paidPrice}").AlignCenter();
                            row.RelativeItem().Text($"المبلغ الكلي: {totalPrice}").AlignRight();
                        });

                        // Employee Name
                        column.Item().Text($"الموظف: {empName}")
                            .AlignRight();

                        column.Spacing(10);

                        // Employee Name
                        column.Item().Text("للتواصل معنا").Bold()
                            .AlignRight();

                        column.Item().Text("الهاتف :   01001353216")
                            .AlignRight();

                        column.Item().Text("Email:   hatem.mostafa.hm.2000@gmail.com")
                            .AlignLeft();

                        // Footer
                        column.Item().Text("شكراً لتعاملكم معنا!")
                            .FontSize(16)
                            .AlignCenter();
                    });
                });
            })
.GeneratePdf(path);
        }
        private IContainer CellStyle(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Medium)
                .Padding(5);
        }



    }
}
