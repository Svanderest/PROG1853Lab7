using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace ItemInfoStructure
{
    public partial class FrmItemInfo : Form
    {
        List<Item> myList = new List<Item>();
        public FrmItemInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Item myItem = new Item();
                myItem.ItemNumber = Convert.ToInt32(txtNumber.Text);
                myItem.ItemPrice = Convert.ToDouble(txtPrice.Text);
                myItem.ItemDescrption = txtDescription.Text;
                myList.Add(myItem);
                txtDescription.Clear();
                txtNumber.Clear();
                txtPrice.Clear();
                txtNumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach (Item listItem in myList)
                output += "Item number: " + listItem.ItemNumber
                        + "\nItem price: " + listItem.ItemPrice.ToString("C2")
                        + "\nItem description: " + listItem.ItemDescrption
                        + "\n\n";
            MessageBox.Show(output, Item.storeName);
        }
    }

    public struct Item
    {
        public const string storeName = "My store";
        private int number;
        private double price;
        private string description;
        public int ItemNumber
        {
            get { return number; }
            set { number = value; }
        }
        public double ItemPrice
        {
            get { return price; }
            set { price = value; }
        }
        public string ItemDescrption
        {
            get { return description; }
            set { description = value; }
        }
    }
}
