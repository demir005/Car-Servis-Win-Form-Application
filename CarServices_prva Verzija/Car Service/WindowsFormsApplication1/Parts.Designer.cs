namespace WindowsFormsApplication1
{
    partial class Parts
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_partID = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_car = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_warranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cb_manufacturer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PartID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // txt_partID
            // 
            this.txt_partID.Location = new System.Drawing.Point(114, 32);
            this.txt_partID.Name = "txt_partID";
            this.txt_partID.Size = new System.Drawing.Size(139, 20);
            this.txt_partID.TabIndex = 4;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(114, 145);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(139, 20);
            this.txt_model.TabIndex = 7;
            // 
            // txt_car
            // 
            this.txt_car.Location = new System.Drawing.Point(114, 108);
            this.txt_car.Name = "txt_car";
            this.txt_car.Size = new System.Drawing.Size(139, 20);
            this.txt_car.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(379, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(464, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(560, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Load Table";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // txt_warranty
            // 
            this.txt_warranty.Location = new System.Drawing.Point(114, 191);
            this.txt_warranty.Multiline = true;
            this.txt_warranty.Name = "txt_warranty";
            this.txt_warranty.Size = new System.Drawing.Size(139, 18);
            this.txt_warranty.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Warranty";
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Items.AddRange(new object[] {
            "Oil",
            "Air Pump",
            "Cylinder Head",
            "Valves",
            "Distributor",
            "Down Pipe",
            "Charge Pipe",
            "Intercooler",
            "Motor Mount"});
            this.cb_name.Location = new System.Drawing.Point(114, 69);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(139, 21);
            this.cb_name.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(114, 226);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(139, 20);
            this.txt_price.TabIndex = 28;
            // 
            // cb_manufacturer
            // 
            this.cb_manufacturer.FormattingEnabled = true;
            this.cb_manufacturer.Items.AddRange(new object[] {
            "ANDC",
            "Cordone",
            "CarSon",
            "AirTex",
            "Exide",
            "Win",
            "Stant",
            "SachHS",
            "Walker"});
            this.cb_manufacturer.Location = new System.Drawing.Point(114, 265);
            this.cb_manufacturer.Name = "cb_manufacturer";
            this.cb_manufacturer.Size = new System.Drawing.Size(139, 21);
            this.cb_manufacturer.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Manufacturer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Change";
            // 
            // txt_change
            // 
            this.txt_change.Location = new System.Drawing.Point(114, 307);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(139, 20);
            this.txt_change.TabIndex = 32;
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 332);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_manufacturer);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_warranty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_car);
            this.Controls.Add(this.txt_partID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Parts";
            this.Text = "Parts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_partID;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_car;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_warranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cb_manufacturer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_change;
    }
}