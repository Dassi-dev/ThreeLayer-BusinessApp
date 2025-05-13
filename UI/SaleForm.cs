using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DalList;

namespace UI
{
    public partial class SaleForm : Form
    {
        IBl bl;

        public SaleForm()
        {
            InitializeComponent();
            bl = Factory.Get();
            dataGridView1.Visible = false;
            FillProductComboBox();
            FillSaleIDComboBox();
            AddPanel.Visible = false;
            AddSaleBtn.Visible = false;
            updateTitleLable.Visible = false;
            saleIdComboBox.Visible = false;
            updateSalebtn.Visible = false;
            deleteTitleLable.Visible = false;
            saleIdComboBox.Visible = false;
            deletebtn.Visible = false;
           





        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            AddPanel.Visible = true;
            AddSaleBtn.Visible = true;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            deleteTitleLable.Visible=false;
            updateTitleLable.Visible=false; 
            saleIdComboBox.Visible=false;
            updateTitleLable.Visible = false;
            updateSalebtn.Visible=false;
            deletebtn.Visible=false;
            AddPanel.Visible = false;
            dataGridView1.Visible = true;//שלא יייצר עמודות אוטומטי        
            dataGridView1.DataSource = bl.ISale.ReadAll();


        }




        private void FillProductComboBox()
        {
            var products = bl.IProduct.ReadAll().ToList();
            productIdComboBox.DataSource = products;
            productIdComboBox.DisplayMember = "ID";     // מה שמוצג למשתמש
            productIdComboBox.ValueMember = "ID";       // מה שהקומבו מחזיק בפועל
        }

       

        private void AddSaleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            bl.ISale.Create(new BO.Sale(1, (int)productIdComboBox.SelectedValue, (int)requriredQuntitynumericUpDown1.Value, double.Parse(totalPriceTextBox.Text), requiredClubCheckBox.Checked, startDateTimePicker1.Value, endDateTimePicker1.Value));
            AddPanel.Visible = false;
            AddSaleBtn.Visible = false;
            MessageBox.Show(
          "The Sale was added successfully.",
         "",
          MessageBoxButtons.OK
         );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddSaleBtn.Visible=false;
            dataGridView1.Visible = false;
            AddPanel.Visible = true;
            updateTitleLable.Visible = true;
            saleIdComboBox.Visible = true;
            updateSalebtn.Visible = true;


        }


        private void FillSaleIDComboBox()
        {
            var sales = bl.ISale.ReadAll().ToList();
            saleIdComboBox.DataSource = sales;
            saleIdComboBox.DisplayMember = "ID";     // מה שמוצג למשתמש
            saleIdComboBox.ValueMember = "ID";       // מה שהקומבו מחזיק בפועל
        }

        private void updateSalebtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            updateTitleLable.Visible = false;
            saleIdComboBox.Visible = false;
            updateSalebtn.Visible = false;
            bl.ISale.Update(new BO.Sale((int)saleIdComboBox.SelectedValue, (int)productIdComboBox.SelectedValue, (int)requriredQuntitynumericUpDown1.Value, double.Parse(totalPriceTextBox.Text), requiredClubCheckBox.Checked, startDateTimePicker1.Value, endDateTimePicker1.Value));
            MessageBox.Show(
  "The Sale was update successfully.",
 "",
  MessageBoxButtons.OK
 );
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            AddSaleBtn.Visible = false;
            updateTitleLable.Visible = false;
            saleIdComboBox.Visible = false;
            updateSalebtn.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            deleteTitleLable.Visible = true;
            saleIdComboBox.Visible = true;
            updateSalebtn.Visible=false;
            deletebtn.Visible = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            bl.ISale.Delete((int)saleIdComboBox.SelectedValue);
            deleteTitleLable.Visible = false;
            saleIdComboBox.Visible = false;
            deletebtn.Visible = false;
            MessageBox.Show(
"The Sale was delete successfully.",
"",
MessageBoxButtons.OK
);
            
        }
    }
}
