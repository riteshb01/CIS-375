using System;
using System.Windows.Forms;

namespace TechGadgetCollection
{
    public partial class AddItemForm : Form
    {
        public TechGadget NewGadget { get; private set; }

        private TextBox txtItemName;
        private TextBox txtBrand;
        private TextBox txtPrice;
        private TextBox txtWarrantyMonths;
        private ComboBox cmbCategory;
        private DateTimePicker dtpPurchaseDate;
        private Button btnSave;
        private Button btnCancel;
        private Label lblItemName;
        private Label lblBrand;
        private Label lblPrice;
        private Label lblWarrantyMonths;
        private Label lblCategory;
        private Label lblPurchaseDate;

        public AddItemForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void InitializeComponent()
        {
            this.lblItemName = new Label();
            this.lblBrand = new Label();
            this.lblPrice = new Label();
            this.lblWarrantyMonths = new Label();
            this.lblCategory = new Label();
            this.lblPurchaseDate = new Label();
            this.txtItemName = new TextBox();
            this.txtBrand = new TextBox();
            this.txtPrice = new TextBox();
            this.txtWarrantyMonths = new TextBox();
            this.cmbCategory = new ComboBox();
            this.dtpPurchaseDate = new DateTimePicker();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblItemName
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(20, 20);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(70, 15);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";

            // txtItemName
            this.txtItemName.Location = new System.Drawing.Point(150, 17);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 1;

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(20, 60);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 15);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand:";

            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(150, 57);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 23);
            this.txtBrand.TabIndex = 3;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(150, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 5;

            // lblWarrantyMonths
            this.lblWarrantyMonths.AutoSize = true;
            this.lblWarrantyMonths.Location = new System.Drawing.Point(20, 140);
            this.lblWarrantyMonths.Name = "lblWarrantyMonths";
            this.lblWarrantyMonths.Size = new System.Drawing.Size(110, 15);
            this.lblWarrantyMonths.TabIndex = 6;
            this.lblWarrantyMonths.Text = "Warranty (Months):";

            // txtWarrantyMonths
            this.txtWarrantyMonths.Location = new System.Drawing.Point(150, 137);
            this.txtWarrantyMonths.Name = "txtWarrantyMonths";
            this.txtWarrantyMonths.Size = new System.Drawing.Size(200, 23);
            this.txtWarrantyMonths.TabIndex = 7;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 180);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
                "Phone",
                "Laptop",
                "Tablet",
                "Accessory"
            });
            this.cmbCategory.Location = new System.Drawing.Point(150, 177);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.TabIndex = 9;

            // lblPurchaseDate
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(20, 220);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(85, 15);
            this.lblPurchaseDate.TabIndex = 10;
            this.lblPurchaseDate.Text = "Purchase Date:";

            // dtpPurchaseDate
            this.dtpPurchaseDate.Format = DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(150, 217);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpPurchaseDate.TabIndex = 11;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(260, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // AddItemForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtWarrantyMonths);
            this.Controls.Add(this.lblWarrantyMonths);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.Text = "Add Gadget";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Please enter a brand.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrand.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtWarrantyMonths.Text, out int warrantyMonths) || warrantyMonths < 0)
            {
                MessageBox.Show("Please enter a valid warranty period in months.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWarrantyMonths.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            // Create new TechGadget object
            NewGadget = new TechGadget(
                txtItemName.Text,
                txtBrand.Text,
                price,
                cmbCategory.SelectedItem.ToString(),
                dtpPurchaseDate.Value,
                warrantyMonths
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
