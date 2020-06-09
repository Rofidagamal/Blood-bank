namespace boodbank2
{
    partial class FBloodBag_ins
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
            this.don_amount = new System.Windows.Forms.TextBox();
            this.assn = new System.Windows.Forms.TextBox();
            this.bb_name = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.bcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.don_type = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A_plus = new System.Windows.Forms.RadioButton();
            this.AB_plus = new System.Windows.Forms.RadioButton();
            this.AB_negative = new System.Windows.Forms.RadioButton();
            this.A_negative = new System.Windows.Forms.RadioButton();
            this.B_negative = new System.Windows.Forms.RadioButton();
            this.B_plus = new System.Windows.Forms.RadioButton();
            this.O_neg = new System.Windows.Forms.RadioButton();
            this.O_plus = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // don_amount
            // 
            this.don_amount.Location = new System.Drawing.Point(152, 335);
            this.don_amount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.don_amount.Name = "don_amount";
            this.don_amount.Size = new System.Drawing.Size(255, 22);
            this.don_amount.TabIndex = 69;
            this.don_amount.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // assn
            // 
            this.assn.Location = new System.Drawing.Point(152, 273);
            this.assn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assn.Name = "assn";
            this.assn.Size = new System.Drawing.Size(255, 22);
            this.assn.TabIndex = 67;
            this.assn.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // bb_name
            // 
            this.bb_name.Location = new System.Drawing.Point(152, 243);
            this.bb_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bb_name.Name = "bb_name";
            this.bb_name.Size = new System.Drawing.Size(255, 22);
            this.bb_name.TabIndex = 66;
            this.bb_name.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(154, 61);
            this.cost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(255, 22);
            this.cost.TabIndex = 63;
            this.cost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bcode
            // 
            this.bcode.Location = new System.Drawing.Point(154, 32);
            this.bcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcode.Name = "bcode";
            this.bcode.Size = new System.Drawing.Size(255, 22);
            this.bcode.TabIndex = 62;
            this.bcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 75);
            this.button1.TabIndex = 61;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "donation_amount";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "donation_type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "donor ssn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "blood bank name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "cost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "blood bag code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(427, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 41);
            this.button2.TabIndex = 70;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // don_type
            // 
            this.don_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.don_type.FormattingEnabled = true;
            this.don_type.Items.AddRange(new object[] {
            "Blood",
            "Plasma",
            "Power red"});
            this.don_type.Location = new System.Drawing.Point(152, 306);
            this.don_type.Name = "don_type";
            this.don_type.Size = new System.Drawing.Size(255, 24);
            this.don_type.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.A_plus);
            this.groupBox1.Controls.Add(this.AB_plus);
            this.groupBox1.Controls.Add(this.AB_negative);
            this.groupBox1.Controls.Add(this.A_negative);
            this.groupBox1.Controls.Add(this.B_negative);
            this.groupBox1.Controls.Add(this.B_plus);
            this.groupBox1.Controls.Add(this.O_neg);
            this.groupBox1.Controls.Add(this.O_plus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(152, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 134);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            // 
            // A_plus
            // 
            this.A_plus.AutoSize = true;
            this.A_plus.Location = new System.Drawing.Point(34, 50);
            this.A_plus.Name = "A_plus";
            this.A_plus.Size = new System.Drawing.Size(53, 24);
            this.A_plus.TabIndex = 86;
            this.A_plus.TabStop = true;
            this.A_plus.Text = "A+";
            this.A_plus.UseVisualStyleBackColor = true;
            this.A_plus.CheckedChanged += new System.EventHandler(this.A_plus_CheckedChanged);
            // 
            // AB_plus
            // 
            this.AB_plus.AutoSize = true;
            this.AB_plus.Location = new System.Drawing.Point(34, 23);
            this.AB_plus.Name = "AB_plus";
            this.AB_plus.Size = new System.Drawing.Size(66, 24);
            this.AB_plus.TabIndex = 84;
            this.AB_plus.TabStop = true;
            this.AB_plus.Text = "AB+";
            this.AB_plus.UseVisualStyleBackColor = true;
            this.AB_plus.CheckedChanged += new System.EventHandler(this.AB_plus_CheckedChanged);
            // 
            // AB_negative
            // 
            this.AB_negative.AutoSize = true;
            this.AB_negative.Location = new System.Drawing.Point(114, 23);
            this.AB_negative.Name = "AB_negative";
            this.AB_negative.Size = new System.Drawing.Size(62, 24);
            this.AB_negative.TabIndex = 85;
            this.AB_negative.TabStop = true;
            this.AB_negative.Text = "AB-";
            this.AB_negative.UseVisualStyleBackColor = true;
            this.AB_negative.CheckedChanged += new System.EventHandler(this.AB_negative_CheckedChanged);
            // 
            // A_negative
            // 
            this.A_negative.AutoSize = true;
            this.A_negative.Location = new System.Drawing.Point(114, 50);
            this.A_negative.Name = "A_negative";
            this.A_negative.Size = new System.Drawing.Size(49, 24);
            this.A_negative.TabIndex = 87;
            this.A_negative.TabStop = true;
            this.A_negative.Text = "A-";
            this.A_negative.UseVisualStyleBackColor = true;
            this.A_negative.CheckedChanged += new System.EventHandler(this.A_negative_CheckedChanged);
            // 
            // B_negative
            // 
            this.B_negative.AutoSize = true;
            this.B_negative.Location = new System.Drawing.Point(114, 77);
            this.B_negative.Name = "B_negative";
            this.B_negative.Size = new System.Drawing.Size(50, 24);
            this.B_negative.TabIndex = 88;
            this.B_negative.TabStop = true;
            this.B_negative.Text = "B-";
            this.B_negative.UseVisualStyleBackColor = true;
            this.B_negative.CheckedChanged += new System.EventHandler(this.B_negative_CheckedChanged);
            // 
            // B_plus
            // 
            this.B_plus.AutoSize = true;
            this.B_plus.Location = new System.Drawing.Point(34, 77);
            this.B_plus.Name = "B_plus";
            this.B_plus.Size = new System.Drawing.Size(54, 24);
            this.B_plus.TabIndex = 89;
            this.B_plus.TabStop = true;
            this.B_plus.Text = "B+";
            this.B_plus.UseVisualStyleBackColor = true;
            this.B_plus.CheckedChanged += new System.EventHandler(this.B_plus_CheckedChanged);
            // 
            // O_neg
            // 
            this.O_neg.AutoSize = true;
            this.O_neg.Location = new System.Drawing.Point(114, 104);
            this.O_neg.Name = "O_neg";
            this.O_neg.Size = new System.Drawing.Size(51, 24);
            this.O_neg.TabIndex = 90;
            this.O_neg.TabStop = true;
            this.O_neg.Text = "O-";
            this.O_neg.UseVisualStyleBackColor = true;
            this.O_neg.CheckedChanged += new System.EventHandler(this.O_neg_CheckedChanged);
            // 
            // O_plus
            // 
            this.O_plus.AutoSize = true;
            this.O_plus.Location = new System.Drawing.Point(34, 104);
            this.O_plus.Name = "O_plus";
            this.O_plus.Size = new System.Drawing.Size(55, 24);
            this.O_plus.TabIndex = 91;
            this.O_plus.TabStop = true;
            this.O_plus.Text = "O+";
            this.O_plus.UseVisualStyleBackColor = true;
            this.O_plus.CheckedChanged += new System.EventHandler(this.O_plus_CheckedChanged);
            // 
            // FBloodBag_ins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(460, 558);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.don_type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.don_amount);
            this.Controls.Add(this.assn);
            this.Controls.Add(this.bb_name);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.bcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FBloodBag_ins";
            this.Load += new System.EventHandler(this.FBloodBag_ins_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox don_amount;
        private System.Windows.Forms.TextBox assn;
        private System.Windows.Forms.TextBox bb_name;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox bcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox don_type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton A_plus;
        private System.Windows.Forms.RadioButton AB_plus;
        private System.Windows.Forms.RadioButton AB_negative;
        private System.Windows.Forms.RadioButton A_negative;
        private System.Windows.Forms.RadioButton B_negative;
        private System.Windows.Forms.RadioButton B_plus;
        private System.Windows.Forms.RadioButton O_neg;
        private System.Windows.Forms.RadioButton O_plus;
    }
}