using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        public StartForm PreviousForm;

        private product _product;
        private ProductsContext _DBO = new ProductsContext();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productForm = new ProductInfoForm();
            productForm.Show();
            this.Hide();
            
            
        }

        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

            List<product> ProductList = (from _product in _DBO.products select _product).ToList();
            HardwareDataGridView.DataSource = ProductList;
        }

        private void _HardwareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            YourSelectionTextBox.Text = "Manufacturer: " + HardwareDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " Model: " + HardwareDataGridView.SelectedRows[0].Cells[3].Value.ToString() + " Cost: " + HardwareDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            var selected = (sender as DataGridView).SelectedRows[0];
            product Chosen = (product)selected.DataBoundItem;
            //Sends chosen info to the product class
            Program.product = Chosen;
        }
    }
}
