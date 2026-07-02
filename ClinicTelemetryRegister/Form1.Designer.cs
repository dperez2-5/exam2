namespace ClinicTelemetryRegister
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
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wardnumber = new System.Windows.Forms.NumericUpDown();
            this.batterylife = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.devicetype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.special = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wardnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batterylife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(90, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(156, 20);
            this.id.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(90, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 20);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device Name";
            // 
            // wardnumber
            // 
            this.wardnumber.Location = new System.Drawing.Point(90, 104);
            this.wardnumber.Name = "wardnumber";
            this.wardnumber.Size = new System.Drawing.Size(125, 20);
            this.wardnumber.TabIndex = 4;
            // 
            // batterylife
            // 
            this.batterylife.Location = new System.Drawing.Point(90, 130);
            this.batterylife.Name = "batterylife";
            this.batterylife.Size = new System.Drawing.Size(125, 20);
            this.batterylife.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Battery Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ward Number";
            // 
            // devicetype
            // 
            this.devicetype.FormattingEnabled = true;
            this.devicetype.Items.AddRange(new object[] {
            "Cardiac Monitor",
            "Oxygen Regulator"});
            this.devicetype.Location = new System.Drawing.Point(90, 156);
            this.devicetype.Name = "devicetype";
            this.devicetype.Size = new System.Drawing.Size(125, 21);
            this.devicetype.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Device Type";
            // 
            // special
            // 
            this.special.Location = new System.Drawing.Point(102, 183);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(144, 20);
            this.special.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Special Attribute";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register Devices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(147, 310);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(99, 23);
            this.view.TabIndex = 13;
            this.view.Text = "View Devices";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete Device";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvDevices
            // 
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Location = new System.Drawing.Point(252, 52);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.RowHeadersVisible = false;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.Size = new System.Drawing.Size(505, 310);
            this.dgvDevices.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Medical Devices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.special);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.devicetype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.batterylife);
            this.Controls.Add(this.wardnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wardnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batterylife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown wardnumber;
        private System.Windows.Forms.NumericUpDown batterylife;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox devicetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox special;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Label label7;
    }
}

