using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAssignment_3
{
    public partial class Home : Form
    {
        const int size = 3;

        string[] customername = new string[size];
        int[] contactno = new int[size];
        string[] address = new string[size];
        string[] item = new string[size];
        int[] orderquantity = new int[size];
        string[] maintotal = new string[size];

        int index = 0;

        double itemPrice;
        
        public Home()
        {
            InitializeComponent();

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ordercombobox;
            ordercombobox = orderComboBox.Text;


            if (ordercombobox.ToString() == "Black")
            {
                itemPrice = 120;
            }
            if (ordercombobox.ToString() == "Cold")
            {
                itemPrice = 100;
            }
            if (ordercombobox.ToString() == "Hot")
            {
                itemPrice = 90;
            }
            if (ordercombobox.ToString() == "Reguler")
            {
                itemPrice = 80;
            }

        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (index < size)
            {
                customername[index] = customerNameTextBox.Text;
                contactno[index] = Convert.ToInt32(contactNoTextBox.Text);
                address[index] = addressTextBox.Text;
                item[index] = orderComboBox.Text;
                orderquantity[index] = Convert.ToInt32(quantityTextBox.Text);


                double unitprice = Convert.ToDouble(itemPrice);
                double quantity = Convert.ToDouble(quantityTextBox.Text);
                double grandtotal = unitprice * quantity;

                maintotal[index] = grandtotal.ToString();

                showRichTextBox.Text = ("Customer Name : " + customername[index] + "\r"
                             + "Contact No : " + contactno[index] + "\r"
                             + "Address : " + address[index] + "\r"
                             + "Item Name : " + item[index] + "\r"
                             + "Per Pcs Rate : " + itemPrice + "\r"
                             + "Quantity : " + orderquantity[index] + "\r"
                             + "Total Taka : " + maintotal[index]);
                index++;
            }
            else
            {
                string finalshow = "";
                for (int index = 0; index < size; index++)
                {
                    finalshow += "Customer Name : " + customername[index] + "\r"
                             + "Contact No : " + contactno[index] + "\r"
                             + "Address : " + address[index] + "\r"
                             + "Item Name : " + item[index] + "\r"
                             + "Per Pcs Rate : " + itemPrice + "\r"
                             + "Quantity : " + orderquantity[index] + "\r"
                             + "Total Taka : " + maintotal[index] + "\n";
                   
                }

                showRichTextBox.Text = finalshow;
                //MessageBox.Show(finalshow);
            }
        }
    }
}