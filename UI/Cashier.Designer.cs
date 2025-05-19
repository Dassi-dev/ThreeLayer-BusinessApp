namespace UI
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            label1 = new Label();
            customerID = new Label();
            customerIDTextBox = new TextBox();
            pruductsInOrder = new Label();
            productIdComboBox = new ComboBox();
            label2 = new Label();
            totalPriceTextBox = new TextBox();
            doOrderButton = new Button();
            addPruductToOrderButton = new Button();
            label3 = new Label();
            quantityNumericUpDown = new NumericUpDown();
            currentOrderStatusdataGridView = new DataGridView();
            CustomerApprovalButton = new Button();
            salesDataGridView = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentOrderStatusdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(487, 42);
            label1.Name = "label1";
            label1.Size = new Size(344, 59);
            label1.TabIndex = 0;
            label1.Text = "placing an order";
            label1.UseMnemonic = false;
            // 
            // customerID
            // 
            customerID.AutoSize = true;
            customerID.BackColor = Color.Transparent;
            customerID.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerID.ForeColor = Color.IndianRed;
            customerID.Location = new Point(40, 123);
            customerID.Name = "customerID";
            customerID.Size = new Size(171, 40);
            customerID.TabIndex = 1;
            customerID.Text = "customer ID";
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(217, 123);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(243, 39);
            customerIDTextBox.TabIndex = 2;
            // 
            // pruductsInOrder
            // 
            pruductsInOrder.AutoSize = true;
            pruductsInOrder.BackColor = Color.Transparent;
            pruductsInOrder.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pruductsInOrder.ForeColor = Color.IndianRed;
            pruductsInOrder.Location = new Point(40, 194);
            pruductsInOrder.Name = "pruductsInOrder";
            pruductsInOrder.RightToLeft = RightToLeft.Yes;
            pruductsInOrder.Size = new Size(241, 40);
            pruductsInOrder.TabIndex = 3;
            pruductsInOrder.Text = " select product ID";
            // 
            // productIdComboBox
            // 
            productIdComboBox.FormattingEnabled = true;
            productIdComboBox.Location = new Point(307, 194);
            productIdComboBox.Name = "productIdComboBox";
            productIdComboBox.Size = new Size(242, 40);
            productIdComboBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(796, 170);
            label2.Name = "label2";
            label2.Size = new Size(152, 40);
            label2.TabIndex = 6;
            label2.Text = "total price:";
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Location = new Point(954, 170);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(229, 39);
            totalPriceTextBox.TabIndex = 7;
            // 
            // doOrderButton
            // 
            doOrderButton.Font = new Font("Harrington", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doOrderButton.ForeColor = Color.IndianRed;
            doOrderButton.Location = new Point(796, 224);
            doOrderButton.Name = "doOrderButton";
            doOrderButton.Size = new Size(387, 170);
            doOrderButton.TabIndex = 9;
            doOrderButton.Text = "do order";
            doOrderButton.UseVisualStyleBackColor = true;
            doOrderButton.Click += doOrderButton_Click;
            // 
            // addPruductToOrderButton
            // 
            addPruductToOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPruductToOrderButton.ForeColor = Color.IndianRed;
            addPruductToOrderButton.Location = new Point(23, 331);
            addPruductToOrderButton.Name = "addPruductToOrderButton";
            addPruductToOrderButton.Size = new Size(524, 63);
            addPruductToOrderButton.TabIndex = 10;
            addPruductToOrderButton.Text = "add pruduct to order";
            addPruductToOrderButton.UseVisualStyleBackColor = true;
            addPruductToOrderButton.Click += addPruductToOrderButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(49, 268);
            label3.Name = "label3";
            label3.Size = new Size(202, 40);
            label3.TabIndex = 11;
            label3.Text = "select quantity";
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(307, 269);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(240, 39);
            quantityNumericUpDown.TabIndex = 12;
            // 
            // currentOrderStatusdataGridView
            // 
            currentOrderStatusdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentOrderStatusdataGridView.Location = new Point(-2, 416);
            currentOrderStatusdataGridView.Name = "currentOrderStatusdataGridView";
            currentOrderStatusdataGridView.RowHeadersWidth = 82;
            currentOrderStatusdataGridView.Size = new Size(1312, 205);
            currentOrderStatusdataGridView.TabIndex = 8;
            // 
            // CustomerApprovalButton
            // 
            CustomerApprovalButton.Location = new Point(466, 123);
            CustomerApprovalButton.Name = "CustomerApprovalButton";
            CustomerApprovalButton.Size = new Size(83, 40);
            CustomerApprovalButton.TabIndex = 13;
            CustomerApprovalButton.Text = "OK";
            CustomerApprovalButton.UseVisualStyleBackColor = true;
            CustomerApprovalButton.Click += CustomerApprovalButton_Click;
            // 
            // salesDataGridView
            // 
            salesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGridView.Location = new Point(-2, 669);
            salesDataGridView.Name = "salesDataGridView";
            salesDataGridView.RowHeadersWidth = 82;
            salesDataGridView.Size = new Size(1312, 103);
            salesDataGridView.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(-2, 624);
            label4.Name = "label4";
            label4.Size = new Size(83, 40);
            label4.TabIndex = 15;
            label4.Text = "sales";
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1347, 780);
            Controls.Add(label4);
            Controls.Add(salesDataGridView);
            Controls.Add(CustomerApprovalButton);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(label3);
            Controls.Add(addPruductToOrderButton);
            Controls.Add(doOrderButton);
            Controls.Add(currentOrderStatusdataGridView);
            Controls.Add(totalPriceTextBox);
            Controls.Add(label2);
            Controls.Add(productIdComboBox);
            Controls.Add(pruductsInOrder);
            Controls.Add(customerIDTextBox);
            Controls.Add(customerID);
            Controls.Add(label1);
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentOrderStatusdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label customerID;
        private TextBox customerIDTextBox;
        private Label pruductsInOrder;
        private ComboBox productIdComboBox;
        private Label label2;
        private TextBox totalPriceTextBox;
        private Button doOrderButton;
        private Button addPruductToOrderButton;
        private Label label3;
        private NumericUpDown quantityNumericUpDown;
        private DataGridView currentOrderStatusdataGridView;
        private Button CustomerApprovalButton;
        private DataGridView salesDataGridView;
        private Label label4;
    }
}