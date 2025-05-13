namespace UI
{
    partial class management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(management));
            buttonCustomer = new Button();
            buttonSales = new Button();
            buttonProducts = new Button();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(186, 72);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(169, 70);
            buttonCustomer.TabIndex = 1;
            buttonCustomer.Text = "Customers";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonSales
            // 
            buttonSales.Location = new Point(185, 258);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(169, 70);
            buttonSales.TabIndex = 2;
            buttonSales.Text = "Sales";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(186, 166);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(169, 70);
            buttonProducts.TabIndex = 3;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonProducts);
            Controls.Add(buttonSales);
            Controls.Add(buttonCustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "management";
            Text = "management";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCustomer;
        private Button buttonSales;
        private Button buttonProducts;
    }
}