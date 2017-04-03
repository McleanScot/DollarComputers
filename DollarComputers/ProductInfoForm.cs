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
    public partial class ProductInfoForm : Form
    {
        public SelectForm PreviousForm { get; set; }
        public ProductInfoForm()
        {
            InitializeComponent();
            ProductIdTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition;
            CostTextBox.Text = Program.product.cost.ToString();
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            OsTextBox.Text = Program.product.OS;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            LcdSizeTextBox.Text = Program.product.screensize;
            HddTextBox.Text = Program.product.HDD_size;
            CpuBrandTextBox.Text = Program.product.CPU_brand;
            CpuNumberTextBox.Text = Program.product.CPU_number;
            GpuTypeTextBox.Text = Program.product.GPU_Type;
            CpuTypeTextBox.Text = Program.product.CPU_type;
            CpuSpeedTextBox.Text = Program.product.CPU_speed;
            WebCamTextBox.Text = Program.product.webcam;

            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();


            orderForm.Show();
            this.Hide();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();


            selectForm.Show();
            this.Hide();
        }
    }
}
