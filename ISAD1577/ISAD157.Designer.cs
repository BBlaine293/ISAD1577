namespace ISAD1577
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriendship = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.dataGridViewEducation = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkplace = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer(GeneralAppUser)Info",
            "FriendShip",
            "Messages",
            "Education",
            "Workplace"});
            this.comboBox1.Location = new System.Drawing.Point(273, 612);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(40, 36);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(225, 268);
            this.dataGridViewCustomer.TabIndex = 1;
            // 
            // dataGridViewFriendship
            // 
            this.dataGridViewFriendship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendship.Location = new System.Drawing.Point(355, 36);
            this.dataGridViewFriendship.Name = "dataGridViewFriendship";
            this.dataGridViewFriendship.Size = new System.Drawing.Size(225, 268);
            this.dataGridViewFriendship.TabIndex = 2;
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(670, 36);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.Size = new System.Drawing.Size(225, 268);
            this.dataGridViewMessages.TabIndex = 3;
            // 
            // dataGridViewEducation
            // 
            this.dataGridViewEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEducation.Location = new System.Drawing.Point(206, 338);
            this.dataGridViewEducation.Name = "dataGridViewEducation";
            this.dataGridViewEducation.Size = new System.Drawing.Size(225, 268);
            this.dataGridViewEducation.TabIndex = 4;
            // 
            // dataGridViewWorkplace
            // 
            this.dataGridViewWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplace.Location = new System.Drawing.Point(531, 338);
            this.dataGridViewWorkplace.Name = "dataGridViewWorkplace";
            this.dataGridViewWorkplace.Size = new System.Drawing.Size(225, 268);
            this.dataGridViewWorkplace.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer(GeneralAppUser) Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Friendship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Messages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Education";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Workplace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 645);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWorkplace);
            this.Controls.Add(this.dataGridViewEducation);
            this.Controls.Add(this.dataGridViewMessages);
            this.Controls.Add(this.dataGridViewFriendship);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridView dataGridViewFriendship;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridView dataGridViewEducation;
        private System.Windows.Forms.DataGridView dataGridViewWorkplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

