using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        int size=3;
        string showbill;
        string[] name = new string[4];
        string[] phone = new string[4];
        string[] addresss = new string[4];
        string[] order = new string[4];
        int[] quantity = new int[4];
        int index = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(arraySize.Text);
            if (txtNameInput.Text == "")
            {
                MessageBox.Show("Please Write Your Name");
            }
            else if (txtContactInput.Text == "")
            {
                MessageBox.Show("Please Write Your Phone Number");
            }
            else if (txtAddressInput.Text == "")
            {
                MessageBox.Show("Please Write Your Address");
            }
            else if (comboBoxItem.Text == "")
            {
                MessageBox.Show("Please Select Your Item");
            }
            else if (txtQuantityInput.Text == "")
            {
                MessageBox.Show("Please Write Your Item Quantity");
            }
            else
            {
                if (index < size)
                {
                    name[index] = txtNameInput.Text;
                    phone[index] = txtContactInput.Text;
                    addresss[index] = txtAddressInput.Text;
                    order[index] = comboBoxItem.Text;
                    string itemquantity= txtQuantityInput.Text;
                    quantity[index] = Convert.ToInt32(itemquantity);
                    int totalprice;
                    if (order[index] == "Black Coffee")
                    {
                        totalprice = 120 * quantity[index];
                        showbill = Convert.ToString(totalprice);
                    }
                    else if (order[index] == "Cold Coffee")
                    {
                        totalprice = 100 * quantity[index];
                        showbill = Convert.ToString(totalprice);
                    }
                    else if (order[index] == "Hot Coffee")
                    {
                        totalprice = 90 * quantity[index];
                        showbill = Convert.ToString(totalprice);
                    }
                    else if (order[index] == "Reguler Coffee")
                    {
                        totalprice = 80 * quantity[index];
                        showbill = Convert.ToString(totalprice);
                    }
                    else
                    {
                        showbill = "0 tk.";
                    }
                    index++;
                }
                else
                {
                    MessageBox.Show("Please try again later");
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(arraySize.Text);
            string messege = "";
            for (int index = 0; index < size; index++)
            {
                messege += "Customer Name :" + name[index] + "\n Customer Contact Number :" + phone[index] + "\n Customer Address :" + addresss[index] + "\n Customer Ordered Item :" + order[index] + "\n Quantity of this item  :" + quantity[index] +"\n\n\n";
            }
            MoneyReceipt.AppendText(messege);
        }
    }
}
