namespace CsharpProject
{
    partial class delete_form
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
            this.sid_textbox = new System.Windows.Forms.TextBox();
            this.Refresh_bnt = new System.Windows.Forms.Button();
            this.SID_label = new System.Windows.Forms.Label();
            this.cancel_bnt = new System.Windows.Forms.Button();
            this.delete_bnt = new System.Windows.Forms.Button();
            this.Clear_bnt = new System.Windows.Forms.Button();
            this.cid_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.CID_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.table_groupbox = new System.Windows.Forms.GroupBox();
            this.Course_bnt = new System.Windows.Forms.RadioButton();
            this.School_bnt = new System.Windows.Forms.RadioButton();
            this.table_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sid_textbox
            // 
            this.sid_textbox.Location = new System.Drawing.Point(231, 144);
            this.sid_textbox.Name = "sid_textbox";
            this.sid_textbox.Size = new System.Drawing.Size(162, 28);
            this.sid_textbox.TabIndex = 42;
            // 
            // Refresh_bnt
            // 
            this.Refresh_bnt.Location = new System.Drawing.Point(428, 140);
            this.Refresh_bnt.Name = "Refresh_bnt";
            this.Refresh_bnt.Size = new System.Drawing.Size(94, 32);
            this.Refresh_bnt.TabIndex = 41;
            this.Refresh_bnt.Text = "Refresh";
            this.Refresh_bnt.UseVisualStyleBackColor = true;
            this.Refresh_bnt.Click += new System.EventHandler(this.Refresh_bnt_Click);
            // 
            // SID_label
            // 
            this.SID_label.AutoSize = true;
            this.SID_label.Location = new System.Drawing.Point(9, 144);
            this.SID_label.Name = "SID_label";
            this.SID_label.Size = new System.Drawing.Size(84, 18);
            this.SID_label.TabIndex = 40;
            this.SID_label.Text = "School ID";
            // 
            // cancel_bnt
            // 
            this.cancel_bnt.Location = new System.Drawing.Point(428, 325);
            this.cancel_bnt.Name = "cancel_bnt";
            this.cancel_bnt.Size = new System.Drawing.Size(94, 33);
            this.cancel_bnt.TabIndex = 39;
            this.cancel_bnt.Text = "Cancel";
            this.cancel_bnt.UseVisualStyleBackColor = true;
            this.cancel_bnt.Click += new System.EventHandler(this.cancel_bnt_Click);
            // 
            // delete_bnt
            // 
            this.delete_bnt.Location = new System.Drawing.Point(428, 279);
            this.delete_bnt.Name = "delete_bnt";
            this.delete_bnt.Size = new System.Drawing.Size(94, 33);
            this.delete_bnt.TabIndex = 38;
            this.delete_bnt.Text = "Delete";
            this.delete_bnt.UseVisualStyleBackColor = true;
            this.delete_bnt.Click += new System.EventHandler(this.delete_bnt_Click);
            // 
            // Clear_bnt
            // 
            this.Clear_bnt.Location = new System.Drawing.Point(428, 191);
            this.Clear_bnt.Name = "Clear_bnt";
            this.Clear_bnt.Size = new System.Drawing.Size(94, 32);
            this.Clear_bnt.TabIndex = 37;
            this.Clear_bnt.Text = "Clear";
            this.Clear_bnt.UseVisualStyleBackColor = true;
            this.Clear_bnt.Click += new System.EventHandler(this.Clear_bnt_Click);
            // 
            // cid_textbox
            // 
            this.cid_textbox.Location = new System.Drawing.Point(231, 325);
            this.cid_textbox.Name = "cid_textbox";
            this.cid_textbox.Size = new System.Drawing.Size(162, 28);
            this.cid_textbox.TabIndex = 36;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(231, 279);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(162, 28);
            this.phone_textbox.TabIndex = 35;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(231, 233);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(162, 28);
            this.address_textbox.TabIndex = 34;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(231, 191);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(162, 28);
            this.name_textbox.TabIndex = 33;
            // 
            // CID_label
            // 
            this.CID_label.AutoSize = true;
            this.CID_label.Location = new System.Drawing.Point(9, 325);
            this.CID_label.Name = "CID_label";
            this.CID_label.Size = new System.Drawing.Size(87, 18);
            this.CID_label.TabIndex = 32;
            this.CID_label.Text = "Course ID";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(9, 279);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(122, 18);
            this.phone_label.TabIndex = 31;
            this.phone_label.Text = "School Phone";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(9, 233);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(138, 18);
            this.Address_label.TabIndex = 30;
            this.Address_label.Text = "School Address";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(9, 191);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(117, 18);
            this.name_label.TabIndex = 29;
            this.name_label.Text = "School Name";
            // 
            // table_groupbox
            // 
            this.table_groupbox.Controls.Add(this.Course_bnt);
            this.table_groupbox.Controls.Add(this.School_bnt);
            this.table_groupbox.Location = new System.Drawing.Point(12, 21);
            this.table_groupbox.Name = "table_groupbox";
            this.table_groupbox.Size = new System.Drawing.Size(510, 98);
            this.table_groupbox.TabIndex = 28;
            this.table_groupbox.TabStop = false;
            this.table_groupbox.Text = "Table";
            // 
            // Course_bnt
            // 
            this.Course_bnt.AutoSize = true;
            this.Course_bnt.Location = new System.Drawing.Point(334, 39);
            this.Course_bnt.Name = "Course_bnt";
            this.Course_bnt.Size = new System.Drawing.Size(92, 22);
            this.Course_bnt.TabIndex = 1;
            this.Course_bnt.Text = "Course";
            this.Course_bnt.UseVisualStyleBackColor = true;
            this.Course_bnt.CheckedChanged += new System.EventHandler(this.Course_bnt_CheckedChanged);
            // 
            // School_bnt
            // 
            this.School_bnt.AutoSize = true;
            this.School_bnt.Checked = true;
            this.School_bnt.Location = new System.Drawing.Point(92, 39);
            this.School_bnt.Name = "School_bnt";
            this.School_bnt.Size = new System.Drawing.Size(89, 22);
            this.School_bnt.TabIndex = 0;
            this.School_bnt.TabStop = true;
            this.School_bnt.Text = "School";
            this.School_bnt.UseVisualStyleBackColor = true;
            this.School_bnt.CheckedChanged += new System.EventHandler(this.School_bnt_CheckedChanged);
            // 
            // delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 416);
            this.Controls.Add(this.sid_textbox);
            this.Controls.Add(this.Refresh_bnt);
            this.Controls.Add(this.SID_label);
            this.Controls.Add(this.cancel_bnt);
            this.Controls.Add(this.delete_bnt);
            this.Controls.Add(this.Clear_bnt);
            this.Controls.Add(this.cid_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.CID_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.table_groupbox);
            this.Name = "delete_form";
            this.Text = "Delete";
            this.table_groupbox.ResumeLayout(false);
            this.table_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sid_textbox;
        private System.Windows.Forms.Button Refresh_bnt;
        private System.Windows.Forms.Label SID_label;
        private System.Windows.Forms.Button cancel_bnt;
        private System.Windows.Forms.Button delete_bnt;
        private System.Windows.Forms.Button Clear_bnt;
        private System.Windows.Forms.TextBox cid_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label CID_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.GroupBox table_groupbox;
        private System.Windows.Forms.RadioButton Course_bnt;
        private System.Windows.Forms.RadioButton School_bnt;
    }
}