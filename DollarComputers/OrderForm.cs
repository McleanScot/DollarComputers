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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            ConditionTextBox.Text = Program.product.condition;
            ManufactuerTextBox.Text = Program.product.manufacturer;
            PlatformTextBox.Text = Program.product.platform;
            ModelTextBox.Text = Program.product.model;
            PriceTextBox.Text = Program.product.cost.ToString();
            LcdSizeTextBox.Text = Program.product.screensize;
            MemoryTextBox.Text = Program.product.RAM_size;
            CpuBrandTextBox.Text = Program.product.CPU_brand;
            CpuTypeTextBox.Text = Program.product.CPU_type;
            CpuNumberTextBox.Text = Program.product.CPU_number;
            CpuSpeedTextBox.Text = Program.product.CPU_speed;
            HddTextBox.Text = Program.product.HDD_size;
            GpuTypeTextBox.Text = Program.product.GPU_Type;
            WebCamTextBox.Text = Program.product.webcam;
            OsTextBox.Text = Program.product.OS;

            decimal cost = Convert.ToDecimal(PriceTextBox.Text);

            decimal salesTax = cost * 0.13m;

            decimal total = cost + salesTax;

            SalesTaxTextBox.Text = salesTax.ToString("C2");

            TotalTextBox.Text = total.ToString("C2");

            if (ManufactuerTextBox.Text.Trim() == "Asus")
            {
                OrderPictureBox.Image = Properties.Resources.asus_logo;
            }
            else if (ManufactuerTextBox.Text.Trim() == "Acer")
            {
                OrderPictureBox.Image = Properties.Resources.acer;
            }
            else if (ManufactuerTextBox.Text.Trim() == "Apple")
            {
                OrderPictureBox.Image = Properties.Resources.apple;
            }
            else if (ManufactuerTextBox.Text.Trim() == "Toshiba")
            {
                OrderPictureBox.Image = Properties.Resources.toshiba;
            }
            else if (ManufactuerTextBox.Text.Trim() == "iBUYPOWER")
            {
                OrderPictureBox.Image = Properties.Resources.ibp;
            }
            else if (ManufactuerTextBox.Text.Trim() == "Lenovo")
            {
                OrderPictureBox.Image = Properties.Resources.lenovo;
            }
            else if (ManufactuerTextBox.Text.Trim() == "HP")
            {
                OrderPictureBox.Image = Properties.Resources.hp;
            }
            else if (ManufactuerTextBox.Text.Trim() == "CybertronPC")
            {
                OrderPictureBox.Image = Properties.Resources.cybetron;
            }
            else if (ManufactuerTextBox.Text.Trim() == "Gateway")
            {
                OrderPictureBox.Image = Properties.Resources.gateway;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thanks for buying a computer ty!");
            Application.Exit();
        }
    }
}
