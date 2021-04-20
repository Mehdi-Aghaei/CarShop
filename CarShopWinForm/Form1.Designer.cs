
using System;

namespace CarShopWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.BtnCreateCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CartList = new System.Windows.Forms.ListBox();
            this.BtnAddInv = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.BtnCreateCar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CreateCar";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(183, 240);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(195, 55);
            this.txt_price.TabIndex = 7;
            // 
            // BtnCreateCar
            // 
            this.BtnCreateCar.Location = new System.Drawing.Point(91, 375);
            this.BtnCreateCar.Name = "BtnCreateCar";
            this.BtnCreateCar.Size = new System.Drawing.Size(225, 69);
            this.BtnCreateCar.TabIndex = 2;
            this.BtnCreateCar.Text = "Create";
            this.BtnCreateCar.UseVisualStyleBackColor = true;
            this.BtnCreateCar.Click += new System.EventHandler(this.BtnCreateCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price :";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(183, 154);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(195, 55);
            this.txtModel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model :";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(183, 54);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(195, 55);
            this.txtMake.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarList);
            this.groupBox2.Location = new System.Drawing.Point(585, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 538);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory";
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.ItemHeight = 48;
            this.CarList.Location = new System.Drawing.Point(6, 58);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(784, 484);
            this.CarList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CartList);
            this.groupBox3.Location = new System.Drawing.Point(1403, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 547);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 48;
            this.CartList.Location = new System.Drawing.Point(6, 54);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(515, 484);
            this.CartList.TabIndex = 1;
            // 
            // BtnAddInv
            // 
            this.BtnAddInv.Location = new System.Drawing.Point(707, 604);
            this.BtnAddInv.Name = "BtnAddInv";
            this.BtnAddInv.Size = new System.Drawing.Size(455, 69);
            this.BtnAddInv.TabIndex = 3;
            this.BtnAddInv.Text = "Add to Cart >>";
            this.BtnAddInv.UseVisualStyleBackColor = true;
            this.BtnAddInv.Click += new System.EventHandler(this.BtnAddInv_Click);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.Location = new System.Drawing.Point(1583, 604);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(225, 69);
            this.BtnCheckout.TabIndex = 4;
            this.BtnCheckout.Text = "Checkout";
            this.BtnCheckout.UseVisualStyleBackColor = true;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1583, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(1704, 734);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(104, 48);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "$0.00";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 914);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCheckout);
            this.Controls.Add(this.BtnAddInv);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CarStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCreateCar;
        private System.Windows.Forms.Button BtnAddInv;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox txt_price;
    }
}

