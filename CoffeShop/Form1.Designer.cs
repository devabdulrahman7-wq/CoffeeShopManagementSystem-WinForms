namespace CoffeShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shoplbl = new System.Windows.Forms.Label();
            this.radiobtncoffee = new System.Windows.Forms.RadioButton();
            this.radiobtndessert = new System.Windows.Forms.RadioButton();
            this.SelectItemslbl = new System.Windows.Forms.Label();
            this.pricesslbl = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.Combobox = new System.Windows.Forms.ComboBox();
            this.additemsbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteitemsbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountlbl = new System.Windows.Forms.Label();
            this.repayamountlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.repayamounttxt = new System.Windows.Forms.TextBox();
            this.payamounttxt = new System.Windows.Forms.TextBox();
            this.totalamounttxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.loadbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.shoplbl);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 93);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // shoplbl
            // 
            this.shoplbl.AutoSize = true;
            this.shoplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoplbl.Location = new System.Drawing.Point(271, 17);
            this.shoplbl.Name = "shoplbl";
            this.shoplbl.Size = new System.Drawing.Size(220, 31);
            this.shoplbl.TabIndex = 0;
            this.shoplbl.Text = "COFFEE SHOP";
            // 
            // radiobtncoffee
            // 
            this.radiobtncoffee.AutoSize = true;
            this.radiobtncoffee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtncoffee.Location = new System.Drawing.Point(27, 158);
            this.radiobtncoffee.Name = "radiobtncoffee";
            this.radiobtncoffee.Size = new System.Drawing.Size(68, 20);
            this.radiobtncoffee.TabIndex = 1;
            this.radiobtncoffee.TabStop = true;
            this.radiobtncoffee.Text = "COFFEE";
            this.radiobtncoffee.UseVisualStyleBackColor = true;
            this.radiobtncoffee.CheckedChanged += new System.EventHandler(this.radiobtncoffee_CheckedChanged);
            // 
            // radiobtndessert
            // 
            this.radiobtndessert.AutoSize = true;
            this.radiobtndessert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtndessert.Location = new System.Drawing.Point(141, 158);
            this.radiobtndessert.Name = "radiobtndessert";
            this.radiobtndessert.Size = new System.Drawing.Size(80, 20);
            this.radiobtndessert.TabIndex = 2;
            this.radiobtndessert.TabStop = true;
            this.radiobtndessert.Text = "DESSERT";
            this.radiobtndessert.UseVisualStyleBackColor = true;
            this.radiobtndessert.CheckedChanged += new System.EventHandler(this.radiobtndessert_CheckedChanged);
            // 
            // SelectItemslbl
            // 
            this.SelectItemslbl.AutoSize = true;
            this.SelectItemslbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectItemslbl.Location = new System.Drawing.Point(24, 207);
            this.SelectItemslbl.Name = "SelectItemslbl";
            this.SelectItemslbl.Size = new System.Drawing.Size(98, 17);
            this.SelectItemslbl.TabIndex = 3;
            this.SelectItemslbl.Text = "Select Items";
            // 
            // pricesslbl
            // 
            this.pricesslbl.AutoSize = true;
            this.pricesslbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesslbl.Location = new System.Drawing.Point(24, 250);
            this.pricesslbl.Name = "pricesslbl";
            this.pricesslbl.Size = new System.Drawing.Size(55, 17);
            this.pricesslbl.TabIndex = 4;
            this.pricesslbl.Text = "Prices";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(24, 285);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(69, 17);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "Quantity";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(24, 320);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(44, 17);
            this.totallbl.TabIndex = 6;
            this.totallbl.Text = "Total";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(128, 247);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(121, 20);
            this.pricetxt.TabIndex = 7;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(128, 317);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(121, 20);
            this.totaltxt.TabIndex = 8;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(128, 282);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(121, 20);
            this.quantitytxt.TabIndex = 9;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            // 
            // Combobox
            // 
            this.Combobox.FormattingEnabled = true;
            this.Combobox.Location = new System.Drawing.Point(128, 203);
            this.Combobox.Name = "Combobox";
            this.Combobox.Size = new System.Drawing.Size(121, 21);
            this.Combobox.TabIndex = 10;
            this.Combobox.SelectedIndexChanged += new System.EventHandler(this.Combobox_SelectedIndexChanged);
            // 
            // additemsbtn
            // 
            this.additemsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.additemsbtn.FlatAppearance.BorderSize = 0;
            this.additemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additemsbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemsbtn.ForeColor = System.Drawing.Color.White;
            this.additemsbtn.Location = new System.Drawing.Point(80, 390);
            this.additemsbtn.Name = "additemsbtn";
            this.additemsbtn.Size = new System.Drawing.Size(101, 31);
            this.additemsbtn.TabIndex = 11;
            this.additemsbtn.Text = "Add Items";
            this.additemsbtn.UseVisualStyleBackColor = false;
            this.additemsbtn.Click += new System.EventHandler(this.additemsbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // deleteitemsbtn
            // 
            this.deleteitemsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteitemsbtn.FlatAppearance.BorderSize = 0;
            this.deleteitemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteitemsbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteitemsbtn.ForeColor = System.Drawing.Color.White;
            this.deleteitemsbtn.Location = new System.Drawing.Point(80, 430);
            this.deleteitemsbtn.Name = "deleteitemsbtn";
            this.deleteitemsbtn.Size = new System.Drawing.Size(101, 31);
            this.deleteitemsbtn.TabIndex = 13;
            this.deleteitemsbtn.Text = "Delete Items";
            this.deleteitemsbtn.UseVisualStyleBackColor = false;
            this.deleteitemsbtn.Click += new System.EventHandler(this.deleteitemsbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(267, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 225);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Items Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prices";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // totalamountlbl
            // 
            this.totalamountlbl.AutoSize = true;
            this.totalamountlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountlbl.Location = new System.Drawing.Point(555, 383);
            this.totalamountlbl.Name = "totalamountlbl";
            this.totalamountlbl.Size = new System.Drawing.Size(92, 14);
            this.totalamountlbl.TabIndex = 15;
            this.totalamountlbl.Text = "Total Amount";
            // 
            // repayamountlbl
            // 
            this.repayamountlbl.AutoSize = true;
            this.repayamountlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repayamountlbl.Location = new System.Drawing.Point(554, 450);
            this.repayamountlbl.Name = "repayamountlbl";
            this.repayamountlbl.Size = new System.Drawing.Size(99, 14);
            this.repayamountlbl.TabIndex = 16;
            this.repayamountlbl.Text = "RePay Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pay Amount";
            // 
            // repayamounttxt
            // 
            this.repayamounttxt.Location = new System.Drawing.Point(683, 444);
            this.repayamounttxt.Name = "repayamounttxt";
            this.repayamounttxt.Size = new System.Drawing.Size(121, 20);
            this.repayamounttxt.TabIndex = 18;
            // 
            // payamounttxt
            // 
            this.payamounttxt.Location = new System.Drawing.Point(683, 410);
            this.payamounttxt.Name = "payamounttxt";
            this.payamounttxt.Size = new System.Drawing.Size(121, 20);
            this.payamounttxt.TabIndex = 19;
            this.payamounttxt.TextChanged += new System.EventHandler(this.payamounttxt_TextChanged);
            // 
            // totalamounttxt
            // 
            this.totalamounttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalamounttxt.Location = new System.Drawing.Point(683, 377);
            this.totalamounttxt.Name = "totalamounttxt";
            this.totalamounttxt.Size = new System.Drawing.Size(121, 20);
            this.totalamounttxt.TabIndex = 20;
            this.totalamounttxt.Text = "0";
            this.totalamounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalamounttxt.TextChanged += new System.EventHandler(this.totalamounttxt_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(387, 389);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(66, 31);
            this.savebtn.TabIndex = 21;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(312, 390);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(69, 30);
            this.clearbtn.TabIndex = 22;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(692, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // loadbtn
            // 
            this.loadbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadbtn.FlatAppearance.BorderSize = 0;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.ForeColor = System.Drawing.Color.White;
            this.loadbtn.Location = new System.Drawing.Point(348, 430);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(86, 31);
            this.loadbtn.TabIndex = 24;
            this.loadbtn.Text = "Load Data";
            this.loadbtn.UseVisualStyleBackColor = false;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 484);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.totalamounttxt);
            this.Controls.Add(this.payamounttxt);
            this.Controls.Add(this.repayamounttxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.repayamountlbl);
            this.Controls.Add(this.totalamountlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteitemsbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.additemsbtn);
            this.Controls.Add(this.Combobox);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.pricesslbl);
            this.Controls.Add(this.SelectItemslbl);
            this.Controls.Add(this.radiobtndessert);
            this.Controls.Add(this.radiobtncoffee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shoplbl;
        private System.Windows.Forms.RadioButton radiobtncoffee;
        private System.Windows.Forms.RadioButton radiobtndessert;
        private System.Windows.Forms.Label SelectItemslbl;
        private System.Windows.Forms.Label pricesslbl;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.ComboBox Combobox;
        private System.Windows.Forms.Button additemsbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteitemsbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalamountlbl;
        private System.Windows.Forms.Label repayamountlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox repayamounttxt;
        private System.Windows.Forms.TextBox payamounttxt;
        private System.Windows.Forms.TextBox totalamounttxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

