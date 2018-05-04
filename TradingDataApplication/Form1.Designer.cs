namespace TradingDataApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBoxTradingPartner = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTradingPartners = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGpdGrowth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.txtTradeBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHdiRanking = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxTrade = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameTrade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInflationTrade = new System.Windows.Forms.TextBox();
            this.txtGpdTrade = new System.Windows.Forms.TextBox();
            this.txtTradeBalanceTrade = new System.Windows.Forms.TextBox();
            this.txtHdiTrade = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGpdTradeSum = new System.Windows.Forms.TextBox();
            this.btnAddTradePartner = new System.Windows.Forms.Button();
            this.addTradePartner = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(884, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // loadCSVToolStripMenuItem
            // 
            this.loadCSVToolStripMenuItem.Name = "loadCSVToolStripMenuItem";
            this.loadCSVToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadCSVToolStripMenuItem.Text = "Load CSV";
            this.loadCSVToolStripMenuItem.Click += new System.EventHandler(this.loadCSVToolStripMenuItem_Click);
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.DisplayMember = "ToString";
            this.listBoxCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.ItemHeight = 20;
            this.listBoxCountries.Location = new System.Drawing.Point(17, 128);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(307, 484);
            this.listBoxCountries.TabIndex = 1;
            this.listBoxCountries.SelectedIndexChanged += new System.EventHandler(this.listBoxCountries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Countries";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(249, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBoxTradingPartner
            // 
            this.checkBoxTradingPartner.AutoSize = true;
            this.checkBoxTradingPartner.Location = new System.Drawing.Point(18, 99);
            this.checkBoxTradingPartner.Name = "checkBoxTradingPartner";
            this.checkBoxTradingPartner.Size = new System.Drawing.Size(198, 21);
            this.checkBoxTradingPartner.TabIndex = 5;
            this.checkBoxTradingPartner.Text = "Search by Trading Partner";
            this.checkBoxTradingPartner.UseVisualStyleBackColor = true;
            this.checkBoxTradingPartner.CheckedChanged += new System.EventHandler(this.checkBoxTradingPartner_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Data";
            // 
            // listBoxTradingPartners
            // 
            this.listBoxTradingPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTradingPartners.FormattingEnabled = true;
            this.listBoxTradingPartners.ItemHeight = 20;
            this.listBoxTradingPartners.Location = new System.Drawing.Point(339, 464);
            this.listBoxTradingPartners.Name = "listBoxTradingPartners";
            this.listBoxTradingPartners.Size = new System.Drawing.Size(249, 144);
            this.listBoxTradingPartners.TabIndex = 1;
            this.listBoxTradingPartners.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxTradingPartners_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(338, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 3;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "GPD Growth";
            // 
            // txtGpdGrowth
            // 
            this.txtGpdGrowth.Location = new System.Drawing.Point(338, 208);
            this.txtGpdGrowth.Name = "txtGpdGrowth";
            this.txtGpdGrowth.Size = new System.Drawing.Size(250, 22);
            this.txtGpdGrowth.TabIndex = 3;
            this.txtGpdGrowth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGpdGrowth_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inflation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Trade Balance";
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(339, 270);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(250, 22);
            this.txtInflation.TabIndex = 3;
            this.txtInflation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInflation_KeyUp);
            // 
            // txtTradeBalance
            // 
            this.txtTradeBalance.Location = new System.Drawing.Point(339, 332);
            this.txtTradeBalance.Name = "txtTradeBalance";
            this.txtTradeBalance.Size = new System.Drawing.Size(250, 22);
            this.txtTradeBalance.TabIndex = 3;
            this.txtTradeBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTradeBalance_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "HDI Ranking";
            // 
            // txtHdiRanking
            // 
            this.txtHdiRanking.Location = new System.Drawing.Point(339, 394);
            this.txtHdiRanking.Name = "txtHdiRanking";
            this.txtHdiRanking.Size = new System.Drawing.Size(250, 22);
            this.txtHdiRanking.TabIndex = 3;
            this.txtHdiRanking.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHdiRanking_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Main Trade Partners";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(14, 621);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(175, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Countries: x, Height: x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(603, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Biggest Potential of Trade";
            // 
            // listBoxTrade
            // 
            this.listBoxTrade.Enabled = false;
            this.listBoxTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTrade.FormattingEnabled = true;
            this.listBoxTrade.ItemHeight = 20;
            this.listBoxTrade.Location = new System.Drawing.Point(609, 516);
            this.listBoxTrade.Name = "listBoxTrade";
            this.listBoxTrade.Size = new System.Drawing.Size(249, 124);
            this.listBoxTrade.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(604, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Inflation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(604, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "GPD Growth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Trade Balance";
            // 
            // txtNameTrade
            // 
            this.txtNameTrade.Enabled = false;
            this.txtNameTrade.Location = new System.Drawing.Point(608, 146);
            this.txtNameTrade.Name = "txtNameTrade";
            this.txtNameTrade.Size = new System.Drawing.Size(250, 22);
            this.txtNameTrade.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(605, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "HDI Ranking";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(605, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Main Trade Partners";
            // 
            // txtInflationTrade
            // 
            this.txtInflationTrade.Enabled = false;
            this.txtInflationTrade.Location = new System.Drawing.Point(609, 332);
            this.txtInflationTrade.Name = "txtInflationTrade";
            this.txtInflationTrade.Size = new System.Drawing.Size(250, 22);
            this.txtInflationTrade.TabIndex = 3;
            // 
            // txtGpdTrade
            // 
            this.txtGpdTrade.Enabled = false;
            this.txtGpdTrade.Location = new System.Drawing.Point(608, 208);
            this.txtGpdTrade.Name = "txtGpdTrade";
            this.txtGpdTrade.Size = new System.Drawing.Size(250, 22);
            this.txtGpdTrade.TabIndex = 3;
            // 
            // txtTradeBalanceTrade
            // 
            this.txtTradeBalanceTrade.Enabled = false;
            this.txtTradeBalanceTrade.Location = new System.Drawing.Point(609, 394);
            this.txtTradeBalanceTrade.Name = "txtTradeBalanceTrade";
            this.txtTradeBalanceTrade.Size = new System.Drawing.Size(250, 22);
            this.txtTradeBalanceTrade.TabIndex = 3;
            // 
            // txtHdiTrade
            // 
            this.txtHdiTrade.Enabled = false;
            this.txtHdiTrade.Location = new System.Drawing.Point(609, 454);
            this.txtHdiTrade.Name = "txtHdiTrade";
            this.txtHdiTrade.Size = new System.Drawing.Size(250, 22);
            this.txtHdiTrade.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(605, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(223, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "GPD Growth Trade Potential";
            // 
            // txtGpdTradeSum
            // 
            this.txtGpdTradeSum.Enabled = false;
            this.txtGpdTradeSum.Location = new System.Drawing.Point(609, 270);
            this.txtGpdTradeSum.Name = "txtGpdTradeSum";
            this.txtGpdTradeSum.Size = new System.Drawing.Size(250, 22);
            this.txtGpdTradeSum.TabIndex = 3;
            // 
            // btnAddTradePartner
            // 
            this.btnAddTradePartner.Location = new System.Drawing.Point(540, 615);
            this.btnAddTradePartner.Name = "btnAddTradePartner";
            this.btnAddTradePartner.Size = new System.Drawing.Size(49, 27);
            this.btnAddTradePartner.TabIndex = 6;
            this.btnAddTradePartner.Text = "Add";
            this.btnAddTradePartner.UseVisualStyleBackColor = true;
            this.btnAddTradePartner.Click += new System.EventHandler(this.btnAddTradePartner_Click);
            // 
            // addTradePartner
            // 
            this.addTradePartner.FormattingEnabled = true;
            this.addTradePartner.Location = new System.Drawing.Point(338, 617);
            this.addTradePartner.Name = "addTradePartner";
            this.addTradePartner.Size = new System.Drawing.Size(196, 24);
            this.addTradePartner.TabIndex = 7;
            this.addTradePartner.TextChanged += new System.EventHandler(this.addTradePartner_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 645);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Enter in boxes to save any modifications";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 663);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addTradePartner);
            this.Controls.Add(this.btnAddTradePartner);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.checkBoxTradingPartner);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHdiTrade);
            this.Controls.Add(this.txtHdiRanking);
            this.Controls.Add(this.txtTradeBalanceTrade);
            this.Controls.Add(this.txtTradeBalance);
            this.Controls.Add(this.txtGpdTradeSum);
            this.Controls.Add(this.txtGpdTrade);
            this.Controls.Add(this.txtGpdGrowth);
            this.Controls.Add(this.txtInflationTrade);
            this.Controls.Add(this.txtInflation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNameTrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTradingPartners);
            this.Controls.Add(this.listBoxCountries);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "Trading Data Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem loadCSVToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBoxTradingPartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTradingPartners;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGpdGrowth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.TextBox txtTradeBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHdiRanking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxTrade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNameTrade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInflationTrade;
        private System.Windows.Forms.TextBox txtGpdTrade;
        private System.Windows.Forms.TextBox txtTradeBalanceTrade;
        private System.Windows.Forms.TextBox txtHdiTrade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGpdTradeSum;
        private System.Windows.Forms.Button btnAddTradePartner;
        private System.Windows.Forms.ComboBox addTradePartner;
        private System.Windows.Forms.Label label9;
    }
}

