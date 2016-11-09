namespace TravelApp
{
    partial class TripPlanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbActive = new System.Windows.Forms.GroupBox();
            this.gbFood = new System.Windows.Forms.GroupBox();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.cbAct1 = new System.Windows.Forms.CheckBox();
            this.cbAct2 = new System.Windows.Forms.CheckBox();
            this.cbAct3 = new System.Windows.Forms.CheckBox();
            this.cbFood1 = new System.Windows.Forms.CheckBox();
            this.cbFood2 = new System.Windows.Forms.CheckBox();
            this.cbFood3 = new System.Windows.Forms.CheckBox();
            this.rdoHotel1 = new System.Windows.Forms.RadioButton();
            this.rdoHotel2 = new System.Windows.Forms.RadioButton();
            this.rdoHotel3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbSum = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbActive.SuspendLayout();
            this.gbFood.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Location:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.DropDown += new System.EventHandler(this.Form1_Load);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbActive
            // 
            this.gbActive.Controls.Add(this.cbAct3);
            this.gbActive.Controls.Add(this.cbAct2);
            this.gbActive.Controls.Add(this.cbAct1);
            this.gbActive.Location = new System.Drawing.Point(16, 76);
            this.gbActive.Name = "gbActive";
            this.gbActive.Size = new System.Drawing.Size(200, 100);
            this.gbActive.TabIndex = 2;
            this.gbActive.TabStop = false;
            this.gbActive.Text = "Activities";
            // 
            // gbFood
            // 
            this.gbFood.Controls.Add(this.cbFood3);
            this.gbFood.Controls.Add(this.cbFood2);
            this.gbFood.Controls.Add(this.cbFood1);
            this.gbFood.Location = new System.Drawing.Point(13, 183);
            this.gbFood.Name = "gbFood";
            this.gbFood.Size = new System.Drawing.Size(200, 100);
            this.gbFood.TabIndex = 3;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Food";
            // 
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.rdoHotel3);
            this.gbHotel.Controls.Add(this.rdoHotel2);
            this.gbHotel.Controls.Add(this.rdoHotel1);
            this.gbHotel.Location = new System.Drawing.Point(13, 290);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(200, 100);
            this.gbHotel.TabIndex = 4;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // cbAct1
            // 
            this.cbAct1.AutoSize = true;
            this.cbAct1.Location = new System.Drawing.Point(7, 20);
            this.cbAct1.Name = "cbAct1";
            this.cbAct1.Size = new System.Drawing.Size(47, 17);
            this.cbAct1.TabIndex = 0;
            this.cbAct1.Text = "act1";
            this.cbAct1.UseVisualStyleBackColor = true;
            // 
            // cbAct2
            // 
            this.cbAct2.AutoSize = true;
            this.cbAct2.Location = new System.Drawing.Point(7, 44);
            this.cbAct2.Name = "cbAct2";
            this.cbAct2.Size = new System.Drawing.Size(47, 17);
            this.cbAct2.TabIndex = 1;
            this.cbAct2.Text = "act2";
            this.cbAct2.UseVisualStyleBackColor = true;
            // 
            // cbAct3
            // 
            this.cbAct3.AutoSize = true;
            this.cbAct3.Location = new System.Drawing.Point(7, 68);
            this.cbAct3.Name = "cbAct3";
            this.cbAct3.Size = new System.Drawing.Size(47, 17);
            this.cbAct3.TabIndex = 2;
            this.cbAct3.Text = "act3";
            this.cbAct3.UseVisualStyleBackColor = true;
            // 
            // cbFood1
            // 
            this.cbFood1.AutoSize = true;
            this.cbFood1.Location = new System.Drawing.Point(7, 20);
            this.cbFood1.Name = "cbFood1";
            this.cbFood1.Size = new System.Drawing.Size(53, 17);
            this.cbFood1.TabIndex = 0;
            this.cbFood1.Text = "food1";
            this.cbFood1.UseVisualStyleBackColor = true;
            // 
            // cbFood2
            // 
            this.cbFood2.AutoSize = true;
            this.cbFood2.Location = new System.Drawing.Point(7, 44);
            this.cbFood2.Name = "cbFood2";
            this.cbFood2.Size = new System.Drawing.Size(53, 17);
            this.cbFood2.TabIndex = 1;
            this.cbFood2.Text = "food2";
            this.cbFood2.UseVisualStyleBackColor = true;
            // 
            // cbFood3
            // 
            this.cbFood3.AutoSize = true;
            this.cbFood3.Location = new System.Drawing.Point(7, 68);
            this.cbFood3.Name = "cbFood3";
            this.cbFood3.Size = new System.Drawing.Size(53, 17);
            this.cbFood3.TabIndex = 2;
            this.cbFood3.Text = "food3";
            this.cbFood3.UseVisualStyleBackColor = true;
            // 
            // rdoHotel1
            // 
            this.rdoHotel1.AutoSize = true;
            this.rdoHotel1.Location = new System.Drawing.Point(7, 20);
            this.rdoHotel1.Name = "rdoHotel1";
            this.rdoHotel1.Size = new System.Drawing.Size(54, 17);
            this.rdoHotel1.TabIndex = 0;
            this.rdoHotel1.TabStop = true;
            this.rdoHotel1.Text = "hotel1";
            this.rdoHotel1.UseVisualStyleBackColor = true;
            // 
            // rdoHotel2
            // 
            this.rdoHotel2.AutoSize = true;
            this.rdoHotel2.Location = new System.Drawing.Point(7, 44);
            this.rdoHotel2.Name = "rdoHotel2";
            this.rdoHotel2.Size = new System.Drawing.Size(54, 17);
            this.rdoHotel2.TabIndex = 1;
            this.rdoHotel2.TabStop = true;
            this.rdoHotel2.Text = "hotel2";
            this.rdoHotel2.UseVisualStyleBackColor = true;
            // 
            // rdoHotel3
            // 
            this.rdoHotel3.AutoSize = true;
            this.rdoHotel3.Location = new System.Drawing.Point(7, 68);
            this.rdoHotel3.Name = "rdoHotel3";
            this.rdoHotel3.Size = new System.Drawing.Size(54, 17);
            this.rdoHotel3.TabIndex = 2;
            this.rdoHotel3.TabStop = true;
            this.rdoHotel3.Text = "hotel3";
            this.rdoHotel3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tax (7.75%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estimate Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(344, 310);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(344, 337);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(344, 363);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // lbSum
            // 
            this.lbSum.FormattingEnabled = true;
            this.lbSum.Location = new System.Drawing.Point(344, 76);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(287, 212);
            this.lbSum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Travel Summary:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(521, 310);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(521, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(521, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TripPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 430);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.gbFood);
            this.Controls.Add(this.gbActive);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "TripPlanner";
            this.Text = "Trip Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbActive.ResumeLayout(false);
            this.gbActive.PerformLayout();
            this.gbFood.ResumeLayout(false);
            this.gbFood.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbActive;
        private System.Windows.Forms.CheckBox cbAct3;
        private System.Windows.Forms.CheckBox cbAct2;
        private System.Windows.Forms.CheckBox cbAct1;
        private System.Windows.Forms.GroupBox gbFood;
        private System.Windows.Forms.CheckBox cbFood3;
        private System.Windows.Forms.CheckBox cbFood2;
        private System.Windows.Forms.CheckBox cbFood1;
        private System.Windows.Forms.GroupBox gbHotel;
        private System.Windows.Forms.RadioButton rdoHotel3;
        private System.Windows.Forms.RadioButton rdoHotel2;
        private System.Windows.Forms.RadioButton rdoHotel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lbSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

