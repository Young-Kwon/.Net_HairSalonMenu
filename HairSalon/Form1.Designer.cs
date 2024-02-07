/* Name: Young Sang Kwon
 * Student Number: 000847777
 * Date: 2022 Oct 29th
 * Programming in .NET - COMP-10204-01 (Professor: Peter Basl)
 * Purpose: Makes use of altermate GUI interface that determines pricing for a hair salon
 * 
 * Statement of Authorship:
 * I, Young Sang Kwon, 000847777 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

namespace Lab3B
{
    partial class Lab3B
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
            this.components = new System.ComponentModel.Container();
            this.groupHairdressor = new System.Windows.Forms.GroupBox();
            this.hairdressorBox = new System.Windows.Forms.ComboBox();
            this.groupService = new System.Windows.Forms.GroupBox();
            this.serviceBox = new System.Windows.Forms.ListBox();
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.itemBox = new System.Windows.Forms.ListBox();
            this.groupPrice = new System.Windows.Forms.GroupBox();
            this.priceBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.calButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.groupHairdressor.SuspendLayout();
            this.groupService.SuspendLayout();
            this.groupItem.SuspendLayout();
            this.groupPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHairdressor
            // 
            this.groupHairdressor.Controls.Add(this.hairdressorBox);
            this.groupHairdressor.Location = new System.Drawing.Point(36, 39);
            this.groupHairdressor.Name = "groupHairdressor";
            this.groupHairdressor.Size = new System.Drawing.Size(299, 349);
            this.groupHairdressor.TabIndex = 0;
            this.groupHairdressor.TabStop = false;
            this.groupHairdressor.Text = "Select a Hairdressor:";
            // 
            // hairdressorBox
            // 
            this.hairdressorBox.FormattingEnabled = true;
            this.hairdressorBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.hairdressorBox.Location = new System.Drawing.Point(23, 41);
            this.hairdressorBox.Name = "hairdressorBox";
            this.hairdressorBox.Size = new System.Drawing.Size(257, 26);
            this.hairdressorBox.TabIndex = 0;
            this.hairdressorBox.SelectedIndexChanged += new System.EventHandler(this.hairdressorBox_SelectedIndexChanged);
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.serviceBox);
            this.groupService.Location = new System.Drawing.Point(352, 40);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(321, 348);
            this.groupService.TabIndex = 1;
            this.groupService.TabStop = false;
            this.groupService.Text = "Select a Service:";
            // 
            // serviceBox
            // 
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.ItemHeight = 18;
            this.serviceBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.serviceBox.Location = new System.Drawing.Point(16, 40);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(288, 274);
            this.serviceBox.TabIndex = 0;
            this.serviceBox.SelectedIndexChanged += new System.EventHandler(this.serviceBox_SelectedIndexChanged);
            // 
            // groupItem
            // 
            this.groupItem.Controls.Add(this.itemBox);
            this.groupItem.Location = new System.Drawing.Point(688, 40);
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size(317, 347);
            this.groupItem.TabIndex = 2;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Changed Items:";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.ItemHeight = 18;
            this.itemBox.Location = new System.Drawing.Point(15, 40);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(283, 274);
            this.itemBox.TabIndex = 0;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.itemBox_SelectedIndexChanged);
            // 
            // groupPrice
            // 
            this.groupPrice.Controls.Add(this.priceBox);
            this.groupPrice.Location = new System.Drawing.Point(1026, 40);
            this.groupPrice.Name = "groupPrice";
            this.groupPrice.Size = new System.Drawing.Size(224, 346);
            this.groupPrice.TabIndex = 3;
            this.groupPrice.TabStop = false;
            this.groupPrice.Text = "Price:";
            // 
            // priceBox
            // 
            this.priceBox.FormatString = "C2";
            this.priceBox.FormattingEnabled = true;
            this.priceBox.ItemHeight = 18;
            this.priceBox.Location = new System.Drawing.Point(18, 40);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(190, 274);
            this.priceBox.TabIndex = 0;
            this.priceBox.SelectedIndexChanged += new System.EventHandler(this.priceBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(309, 477);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(205, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Service";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(553, 476);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(207, 44);
            this.calButton.TabIndex = 5;
            this.calButton.Text = "Calculate Total Pirce";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(800, 476);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(205, 45);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1044, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(206, 44);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(957, 420);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(93, 18);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Total Price";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Enabled = false;
            this.totalPriceBox.Location = new System.Drawing.Point(1079, 417);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(170, 28);
            this.totalPriceBox.TabIndex = 9;
            // 
            // Lab3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupPrice);
            this.Controls.Add(this.groupItem);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.groupHairdressor);
            this.Name = "Lab3B";
            this.Text = "Lab3B";
            this.groupHairdressor.ResumeLayout(false);
            this.groupService.ResumeLayout(false);
            this.groupItem.ResumeLayout(false);
            this.groupPrice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupHairdressor;
        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.GroupBox groupItem;
        private System.Windows.Forms.GroupBox groupPrice;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox hairdressorBox;
        private System.Windows.Forms.ListBox serviceBox;
        private System.Windows.Forms.ListBox itemBox;
        private System.Windows.Forms.ListBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPriceBox;
    }
}

