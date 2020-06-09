namespace boodbank2
{
    partial class Fbloodbank_ins
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
            this.address = new System.Windows.Forms.TextBox();
            this.bb_manager_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.bb_name = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hospital = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Info;
            this.address.Location = new System.Drawing.Point(248, 125);
            this.address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(192, 22);
            this.address.TabIndex = 26;
            // 
            // bb_manager_name
            // 
            this.bb_manager_name.BackColor = System.Drawing.SystemColors.Info;
            this.bb_manager_name.Location = new System.Drawing.Point(248, 95);
            this.bb_manager_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bb_manager_name.Name = "bb_manager_name";
            this.bb_manager_name.Size = new System.Drawing.Size(192, 22);
            this.bb_manager_name.TabIndex = 25;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.Info;
            this.phone.Location = new System.Drawing.Point(248, 66);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(192, 22);
            this.phone.TabIndex = 24;
            // 
            // bb_name
            // 
            this.bb_name.BackColor = System.Drawing.SystemColors.Info;
            this.bb_name.Location = new System.Drawing.Point(248, 36);
            this.bb_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bb_name.Name = "bb_name";
            this.bb_name.Size = new System.Drawing.Size(192, 22);
            this.bb_name.TabIndex = 23;
            this.bb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Red;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insert.Location = new System.Drawing.Point(191, 247);
            this.insert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(95, 66);
            this.insert.TabIndex = 22;
            this.insert.Text = "OK";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "blood bank name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "blood bank manager_name ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "address";
            // 
            // Hospital
            // 
            this.Hospital.BackColor = System.Drawing.SystemColors.Info;
            this.Hospital.Location = new System.Drawing.Point(249, 163);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(191, 22);
            this.Hospital.TabIndex = 75;
            this.Hospital.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Hospital";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(448, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 44);
            this.button1.TabIndex = 77;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fbloodbank_ins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(485, 364);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address);
            this.Controls.Add(this.bb_manager_name);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.bb_name);
            this.Controls.Add(this.insert);
            this.Name = "Fbloodbank_ins";
            this.Load += new System.EventHandler(this.Fbloodbank_ins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox bb_manager_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox bb_name;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Hospital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}