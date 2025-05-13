namespace UI
{
    partial class SaleForm
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
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnShowAll = new Button();
            dataGridView1 = new DataGridView();
            productIdLable = new Label();
            productIdComboBox = new ComboBox();
            requiredQuantityLable = new Label();
            totalPriceLable = new Label();
            totalPriceTextBox = new TextBox();
            requriedClubLable = new Label();
            requiredClubCheckBox = new CheckBox();
            startDateLable = new Label();
            endDateLable = new Label();
            startDateTimePicker1 = new DateTimePicker();
            endDateTimePicker1 = new DateTimePicker();
            AddSaleBtn = new Button();
            AddPanel = new Panel();
            requriredQuntitynumericUpDown1 = new NumericUpDown();
            updateTitleLable = new Label();
            saleIdComboBox = new ComboBox();
            updateSalebtn = new Button();
            deleteTitleLable = new Label();
            deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requriredQuntitynumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(152, 31);
            label1.Name = "label1";
            label1.Size = new Size(98, 43);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(152, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 64);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(152, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 64);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(152, 281);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(148, 64);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "ShowAll";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(413, 241);
            dataGridView1.TabIndex = 6;
            // 
            // productIdLable
            // 
            productIdLable.AutoSize = true;
            productIdLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productIdLable.ForeColor = Color.Brown;
            productIdLable.Location = new Point(12, 17);
            productIdLable.Name = "productIdLable";
            productIdLable.Size = new Size(126, 31);
            productIdLable.TabIndex = 8;
            productIdLable.Text = "product-ID";
            // 
            // productIdComboBox
            // 
            productIdComboBox.FormattingEnabled = true;
            productIdComboBox.Location = new Point(258, 17);
            productIdComboBox.Name = "productIdComboBox";
            productIdComboBox.Size = new Size(151, 28);
            productIdComboBox.TabIndex = 9;
            // 
            // requiredQuantityLable
            // 
            requiredQuantityLable.AutoSize = true;
            requiredQuantityLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requiredQuantityLable.ForeColor = Color.Brown;
            requiredQuantityLable.Location = new Point(12, 65);
            requiredQuantityLable.Name = "requiredQuantityLable";
            requiredQuantityLable.Size = new Size(195, 31);
            requiredQuantityLable.TabIndex = 10;
            requiredQuantityLable.Text = "required Quantity";
            // 
            // totalPriceLable
            // 
            totalPriceLable.AutoSize = true;
            totalPriceLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLable.ForeColor = Color.Brown;
            totalPriceLable.Location = new Point(20, 112);
            totalPriceLable.Name = "totalPriceLable";
            totalPriceLable.Size = new Size(118, 31);
            totalPriceLable.TabIndex = 12;
            totalPriceLable.Text = "total price";
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Location = new Point(284, 116);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(125, 27);
            totalPriceTextBox.TabIndex = 13;
            // 
            // requriedClubLable
            // 
            requriedClubLable.AutoSize = true;
            requriedClubLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requriedClubLable.ForeColor = Color.Brown;
            requriedClubLable.Location = new Point(12, 156);
            requriedClubLable.Name = "requriedClubLable";
            requriedClubLable.Size = new Size(151, 31);
            requriedClubLable.TabIndex = 14;
            requriedClubLable.Text = "required club";
            // 
            // requiredClubCheckBox
            // 
            requiredClubCheckBox.AutoSize = true;
            requiredClubCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requiredClubCheckBox.Location = new Point(391, 165);
            requiredClubCheckBox.Name = "requiredClubCheckBox";
            requiredClubCheckBox.Size = new Size(18, 17);
            requiredClubCheckBox.TabIndex = 15;
            requiredClubCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateLable
            // 
            startDateLable.AutoSize = true;
            startDateLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateLable.ForeColor = Color.Brown;
            startDateLable.Location = new Point(13, 204);
            startDateLable.Name = "startDateLable";
            startDateLable.Size = new Size(112, 31);
            startDateLable.TabIndex = 16;
            startDateLable.Text = "start date";
            // 
            // endDateLable
            // 
            endDateLable.AutoSize = true;
            endDateLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLable.ForeColor = Color.Brown;
            endDateLable.Location = new Point(13, 249);
            endDateLable.Name = "endDateLable";
            endDateLable.Size = new Size(105, 31);
            endDateLable.TabIndex = 17;
            endDateLable.Text = "end date";
            // 
            // startDateTimePicker1
            // 
            startDateTimePicker1.Location = new Point(159, 204);
            startDateTimePicker1.Name = "startDateTimePicker1";
            startDateTimePicker1.Size = new Size(250, 27);
            startDateTimePicker1.TabIndex = 18;
            // 
            // endDateTimePicker1
            // 
            endDateTimePicker1.Location = new Point(159, 253);
            endDateTimePicker1.Name = "endDateTimePicker1";
            endDateTimePicker1.Size = new Size(250, 27);
            endDateTimePicker1.TabIndex = 19;
            // 
            // AddSaleBtn
            // 
            AddSaleBtn.BackColor = Color.IndianRed;
            AddSaleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddSaleBtn.Location = new Point(484, 398);
            AddSaleBtn.Name = "AddSaleBtn";
            AddSaleBtn.Size = new Size(125, 48);
            AddSaleBtn.TabIndex = 20;
            AddSaleBtn.Text = "add sale";
            AddSaleBtn.UseVisualStyleBackColor = false;
            AddSaleBtn.Click += AddSaleBtn_Click;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(requriredQuntitynumericUpDown1);
            AddPanel.Controls.Add(productIdLable);
            AddPanel.Controls.Add(productIdComboBox);
            AddPanel.Controls.Add(requiredClubCheckBox);
            AddPanel.Controls.Add(endDateTimePicker1);
            AddPanel.Controls.Add(totalPriceLable);
            AddPanel.Controls.Add(requiredQuantityLable);
            AddPanel.Controls.Add(startDateTimePicker1);
            AddPanel.Controls.Add(requriedClubLable);
            AddPanel.Controls.Add(endDateLable);
            AddPanel.Controls.Add(totalPriceTextBox);
            AddPanel.Controls.Add(startDateLable);
            AddPanel.Location = new Point(319, 104);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(441, 288);
            AddPanel.TabIndex = 21;
            // 
            // requriredQuntitynumericUpDown1
            // 
            requriredQuntitynumericUpDown1.Location = new Point(259, 65);
            requriredQuntitynumericUpDown1.Name = "requriredQuntitynumericUpDown1";
            requriredQuntitynumericUpDown1.Size = new Size(150, 27);
            requriredQuntitynumericUpDown1.TabIndex = 20;
            // 
            // updateTitleLable
            // 
            updateTitleLable.AutoSize = true;
            updateTitleLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateTitleLable.ForeColor = Color.IndianRed;
            updateTitleLable.Location = new Point(319, 70);
            updateTitleLable.Name = "updateTitleLable";
            updateTitleLable.Size = new Size(273, 31);
            updateTitleLable.TabIndex = 22;
            updateTitleLable.Text = "Select a sale ID to update";
            // 
            // saleIdComboBox
            // 
            saleIdComboBox.FormattingEnabled = true;
            saleIdComboBox.Location = new Point(598, 73);
            saleIdComboBox.Name = "saleIdComboBox";
            saleIdComboBox.Size = new Size(151, 28);
            saleIdComboBox.TabIndex = 21;
            // 
            // updateSalebtn
            // 
            updateSalebtn.BackColor = Color.IndianRed;
            updateSalebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateSalebtn.Location = new Point(457, 398);
            updateSalebtn.Name = "updateSalebtn";
            updateSalebtn.Size = new Size(125, 48);
            updateSalebtn.TabIndex = 23;
            updateSalebtn.Text = "update sale";
            updateSalebtn.UseVisualStyleBackColor = false;
            updateSalebtn.Click += updateSalebtn_Click;
            // 
            // deleteTitleLable
            // 
            deleteTitleLable.AutoSize = true;
            deleteTitleLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTitleLable.ForeColor = Color.IndianRed;
            deleteTitleLable.Location = new Point(319, 67);
            deleteTitleLable.Name = "deleteTitleLable";
            deleteTitleLable.Size = new Size(264, 31);
            deleteTitleLable.TabIndex = 24;
            deleteTitleLable.Text = "Select a sale ID to delete";
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.IndianRed;
            deletebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(457, 398);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(125, 48);
            deletebtn.TabIndex = 25;
            deletebtn.Text = "delete sale";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deletebtn);
            Controls.Add(deleteTitleLable);
            Controls.Add(updateSalebtn);
            Controls.Add(saleIdComboBox);
            Controls.Add(updateTitleLable);
            Controls.Add(AddPanel);
            Controls.Add(AddSaleBtn);
            Controls.Add(dataGridView1);
            Controls.Add(btnShowAll);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "SaleForm";
            Text = "Sale";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)requriredQuntitynumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnShowAll;
        private DataGridView dataGridView1;
        private Label productIdLable;
        private ComboBox productIdComboBox;
        private Label requiredQuantityLable;
        private Label totalPriceLable;
        private TextBox totalPriceTextBox;
        private Label requriedClubLable;
        private CheckBox requiredClubCheckBox;
        private Label startDateLable;
        private Label endDateLable;
        private DateTimePicker startDateTimePicker1;
        private DateTimePicker endDateTimePicker1;
        private Button AddSaleBtn;
        private Panel AddPanel;
        private NumericUpDown requriredQuntitynumericUpDown1;
        private Label updateTitleLable;
        private ComboBox saleIdComboBox;
        private Button updateSalebtn;
        private Label deleteTitleLable;
        private Button deletebtn;
    }
}