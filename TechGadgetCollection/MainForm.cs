using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechGadgetCollection
{
    public partial class MainForm : Form
    {
        private List<TechGadget> gadgetCollection;

        public MainForm()
        {
            InitializeComponent();
            gadgetCollection = new List<TechGadget>();
            this.Text = "Tech Gadget Collection";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent()
        {
            this.btnAddItem = new Button();
            this.btnViewItems = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tech Gadget Collection";

            // btnAddItem
            this.btnAddItem.Location = new System.Drawing.Point(100, 100);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(200, 40);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new EventHandler(this.btnAddItem_Click);

            // btnViewItems
            this.btnViewItems.Location = new System.Drawing.Point(100, 160);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(200, 40);
            this.btnViewItems.TabIndex = 2;
            this.btnViewItems.Text = "View Items";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new EventHandler(this.btnViewItems_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Tech Gadget Collection";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Button btnAddItem;
        private Button btnViewItems;
        private Label lblTitle;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (AddItemForm addForm = new AddItemForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    gadgetCollection.Add(addForm.NewGadget);
                    MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            using (ViewItemsForm viewForm = new ViewItemsForm(gadgetCollection))
            {
                viewForm.ShowDialog();
            }
        }
    }
}
