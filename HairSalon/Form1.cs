/* Name: Young Sang Kwon
 * Student Number: 000847777
 * Date: 2022 Nov 3
 * Programming in .NET - COMP-10204-01 (Professor: Peter Basl)
 * Purpose: Makes use of altermate GUI interface that determines pricing for a hair salon
 * 
 * Statement of Authorship:
 * I, Young Sang Kwon, 000847777 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3B
{
    /// <summary>
    /// Lab3B Class
    /// </summary>
    public partial class Lab3B : Form
    {
        string selectedHairdressor = "Jane";
        string selectedService = "";
        double totalAmount = 0;
        string[] hairdressorName = { "Jane", "Pat", "Ron", "Sue", "Laurie" };
        double[] hairdressorFee = { 30, 45, 40, 50, 55 };
        string[] serviceName = { "Cut", "Wash, blow-dry, and style", "Colour", "Highlights", "Extension", "Up-do" };
        double[] serviceFee = { 30, 20, 40, 50, 200, 60 };

        /// <summary>
        /// Constructor
        /// </summary>
        public Lab3B()
        {
            InitializeComponent();

            hairdressorBox.SelectedIndex = 0;
            addButton.Enabled = false;
            calButton.Enabled = false;
        }

        /// <summary>
        /// addButton_Click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (hairdressorBox.Enabled)
            {
                switch (selectedHairdressor)
                {
                    case "Jane":
                        itemBox.Items.Add((string)hairdressorName[0]);
                        priceBox.Items.Add("$" + hairdressorFee[0]);
                        totalAmount = hairdressorFee[0]; break;
                    case "Pat":
                        itemBox.Items.Add((string)hairdressorName[1]);
                        priceBox.Items.Add("$" + hairdressorFee[1]);
                        totalAmount = hairdressorFee[1]; break;
                    case "Ron":
                        itemBox.Items.Add((string)hairdressorName[2]);
                        priceBox.Items.Add("$" + hairdressorFee[2]);
                        totalAmount = hairdressorFee[2]; break;
                    case "Sue":
                        itemBox.Items.Add((string)hairdressorName[3]);
                        priceBox.Items.Add("$" + hairdressorFee[3]);
                        totalAmount = hairdressorFee[3]; break;
                    case "Laurie":
                        itemBox.Items.Add((string)hairdressorName[4]);
                        priceBox.Items.Add("$" + hairdressorFee[4]);
                        totalAmount = hairdressorFee[4]; break;
                    default:
                        MessageBox.Show("No hairdressor selected", "Error"); break;
                }
            }

            switch (selectedService)
            {
                case "Cut":
                    itemBox.Items.Add((string)serviceName[0]);
                    priceBox.Items.Add("$" + serviceFee[0]);
                    totalAmount += serviceFee[0]; break;
                case "Wash, blow-dry, and style":
                    itemBox.Items.Add((string)serviceName[1]);
                    priceBox.Items.Add("$" + serviceFee[1]);
                    totalAmount += serviceFee[1]; break;
                case "Colour":
                    itemBox.Items.Add((string)serviceName[2]);
                    priceBox.Items.Add("$" + serviceFee[2]);
                    totalAmount += serviceFee[2]; break;
                case "Highlights":
                    itemBox.Items.Add((string)serviceName[3]);
                    priceBox.Items.Add("$" + serviceFee[3]);
                    totalAmount += serviceFee[3]; break;
                case "Extension":
                    itemBox.Items.Add((string)serviceName[4]);
                    priceBox.Items.Add("$" + serviceFee[4]);
                    totalAmount += serviceFee[4]; break;
                case "Up-do":
                    itemBox.Items.Add((string)serviceName[5]);
                    priceBox.Items.Add("$" + serviceFee[5]);
                    totalAmount += serviceFee[5]; break;
                default: 
                    MessageBox.Show("No serivice selected", "Error"); break;
            }
            calButton.Enabled = true;
            hairdressorBox.Enabled = false;
        }

        /// <summary>
        /// hairdressorBox_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hairdressorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHairdressor = hairdressorBox.Items[hairdressorBox.SelectedIndex].ToString();
        }

        /// <summary>
        /// serviceBox_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedService = serviceBox.Items[serviceBox.SelectedIndex].ToString();
            addButton.Enabled = true;
        }

        /// <summary>
        /// itemBox_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in itemBox.Items)
            { 
                sb.Append(item.ToString());
            }
        }

        /// <summary>
        /// priceBox_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in priceBox.Items)
            {
                sb.Append(item.ToString());
            }
        }

        /// <summary>
        /// calButton_Click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calButton_Click(object sender, EventArgs e)
        {
            totalPriceBox.Text = (string)("$" + totalAmount);
        }

        /// <summary>
        /// resetButton_Click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            serviceBox.SelectedIndex = 0;
            itemBox.Items.Clear();
            priceBox.Items.Clear();
            totalPriceBox.Text = "";
            hairdressorBox.SelectedIndex = 0;
            hairdressorBox.Enabled = true;
            addButton.Enabled = false;
            calButton.Enabled = false;
        }

        /// <summary>
        /// exitButton_Click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
