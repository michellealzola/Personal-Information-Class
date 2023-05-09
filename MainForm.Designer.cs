namespace Personal_Information_Class
{
    partial class MainForm
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
            this.tBoxInputName = new System.Windows.Forms.TextBox();
            this.tBoxInputAddress = new System.Windows.Forms.TextBox();
            this.tBoxInputAge = new System.Windows.Forms.TextBox();
            this.tBoxInputPhone = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnSeeContacts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // tBoxInputName
            // 
            this.tBoxInputName.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInputName.Location = new System.Drawing.Point(154, 146);
            this.tBoxInputName.Name = "tBoxInputName";
            this.tBoxInputName.Size = new System.Drawing.Size(410, 26);
            this.tBoxInputName.TabIndex = 4;
            // 
            // tBoxInputAddress
            // 
            this.tBoxInputAddress.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInputAddress.Location = new System.Drawing.Point(154, 184);
            this.tBoxInputAddress.Name = "tBoxInputAddress";
            this.tBoxInputAddress.Size = new System.Drawing.Size(410, 26);
            this.tBoxInputAddress.TabIndex = 5;
            // 
            // tBoxInputAge
            // 
            this.tBoxInputAge.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInputAge.Location = new System.Drawing.Point(154, 226);
            this.tBoxInputAge.Name = "tBoxInputAge";
            this.tBoxInputAge.Size = new System.Drawing.Size(410, 26);
            this.tBoxInputAge.TabIndex = 6;
            // 
            // tBoxInputPhone
            // 
            this.tBoxInputPhone.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInputPhone.Location = new System.Drawing.Point(154, 270);
            this.tBoxInputPhone.Name = "tBoxInputPhone";
            this.tBoxInputPhone.Size = new System.Drawing.Size(410, 26);
            this.tBoxInputPhone.TabIndex = 7;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(48, 319);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(226, 38);
            this.btnAddContact.TabIndex = 8;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeeContacts
            // 
            this.btnSeeContacts.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeContacts.Location = new System.Drawing.Point(280, 319);
            this.btnSeeContacts.Name = "btnSeeContacts";
            this.btnSeeContacts.Size = new System.Drawing.Size(153, 38);
            this.btnSeeContacts.TabIndex = 9;
            this.btnSeeContacts.Text = "See Contacts";
            this.btnSeeContacts.UseVisualStyleBackColor = true;
            this.btnSeeContacts.Click += new System.EventHandler(this.btnSeeContacts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(439, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personal_Information_Class.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSeeContacts);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.tBoxInputPhone);
            this.Controls.Add(this.tBoxInputAge);
            this.Controls.Add(this.tBoxInputAddress);
            this.Controls.Add(this.tBoxInputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Enter Contact Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxInputName;
        private System.Windows.Forms.TextBox tBoxInputAddress;
        private System.Windows.Forms.TextBox tBoxInputAge;
        private System.Windows.Forms.TextBox tBoxInputPhone;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSeeContacts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

