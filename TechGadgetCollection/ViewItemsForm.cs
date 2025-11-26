using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechGadgetCollection
{
    public partial class ViewItemsForm : Form
    {
        private DataGridView dgvItems;
        private Button btnClose;

        public ViewItemsForm(List<TechGadget> gadgets)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            LoadGadgets(gadgets);
        }

        private void InitializeComponent()
        {
            this.dgvItems = new DataGridView();
            this.btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // dgvItems
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(20, 20);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 25;
            this.dgvItems.Size = new System.Drawing.Size(760, 350);
            this.dgvItems.TabIndex = 0;

            // Add columns
            this.dgvItems.Columns.Add("Name", "Name");
            this.dgvItems.Columns.Add("Brand", "Brand");
            this.dgvItems.Columns.Add("Price", "Price");
            this.dgvItems.Columns.Add("Category", "Category");
            this.dgvItems.Columns.Add("PurchaseDate", "Purchase Date");
            this.dgvItems.Columns.Add("WarrantyMonths", "Warranty (Months)");

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(350, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ViewItemsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvItems);
            this.Name = "ViewItemsForm";
            this.Text = "View Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
        }

        private void LoadGadgets(List<TechGadget> gadgets)
        {
            dgvItems.Rows.Clear();

            foreach (var gadget in gadgets)
            {
                dgvItems.Rows.Add(
                    gadget.Name,
                    gadget.Brand,
                    gadget.Price.ToString("C"),
                    gadget.Category,
                    gadget.PurchaseDate.ToShortDateString(),
                    gadget.WarrantyMonths
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
