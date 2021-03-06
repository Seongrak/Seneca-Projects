namespace CsharpProject
{
    partial class insert_form
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
            this.table_groupbox = new System.Windows.Forms.GroupBox();
            this.Course_bnt = new System.Windows.Forms.RadioButton();
            this.School_bnt = new System.Windows.Forms.RadioButton();
            this.name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.cid_textbox = new System.Windows.Forms.TextBox();
            this.Clear_bnt = new System.Windows.Forms.Button();
            this.Save_bnt = new System.Windows.Forms.Button();
            this.cancel_bnt = new System.Windows.Forms.Button();
            this.table_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_groupbox
            // 
            this.table_groupbox.Controls.Add(this.Course_bnt);
            this.table_groupbox.Controls.Add(this.School_bnt);
            this.table_groupbox.Location = new System.Drawing.Point(37, 30);
            this.table_groupbox.Name = "table_groupbox";
            this.table_groupbox.Size = new System.Drawing.Size(623, 116);
            this.table_groupbox.TabIndex = 0;
            this.table_groupbox.TabStop = false;
            this.table_groupbox.Text = "Table";
            // 
            // Course_bnt
            // 
            this.Course_bnt.AutoSize = true;
            this.Course_bnt.Location = new System.Drawing.Point(306, 39);
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
            this.School_bnt.Location = new System.Drawing.Point(26, 39);
            this.School_bnt.Name = "School_bnt";
            this.School_bnt.Size = new System.Drawing.Size(89, 22);
            this.School_bnt.TabIndex = 0;
            this.School_bnt.TabStop = true;
            this.School_bnt.Text = "School";
            this.School_bnt.UseVisualStyleBackColor = true;
            this.School_bnt.CheckedChanged += new System.EventHandler(this.School_bnt_CheckedChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(43, 174);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(117, 18);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "School Name";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(43, 225);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(138, 18);
            this.Address_label.TabIndex = 3;
            this.Address_label.Text = "School Address";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(43, 285);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(122, 18);
            this.phone_label.TabIndex = 4;
            this.phone_label.Text = "School Phone";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(43, 351);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(87, 18);
            this.ID_label.TabIndex = 5;
            this.ID_label.Text = "Course ID";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(248, 164);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(162, 28);
            this.name_textbox.TabIndex = 6;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(248, 222);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(162, 28);
            this.address_textbox.TabIndex = 7;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(248, 275);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(162, 28);
            this.phone_textbox.TabIndex = 8;
            // 
            // cid_textbox
            // 
            this.cid_textbox.Location = new System.Drawing.Point(248, 341);
            this.cid_textbox.Name = "cid_textbox";
            this.cid_textbox.Size = new System.Drawing.Size(162, 28);
            this.cid_textbox.TabIndex = 9;
            // 
            // Clear_bnt
            // 
            this.Clear_bnt.Location = new System.Drawing.Point(529, 164);
            this.Clear_bnt.Name = "Clear_bnt";
            this.Clear_bnt.Size = new System.Drawing.Size(113, 54);
            this.Clear_bnt.TabIndex = 10;
            this.Clear_bnt.Text = "Clear";
            this.Clear_bnt.UseVisualStyleBackColor = true;
            this.Clear_bnt.Click += new System.EventHandler(this.Clear_bnt_Click);
            // 
            // Save_bnt
            // 
            this.Save_bnt.Location = new System.Drawing.Point(529, 248);
            this.Save_bnt.Name = "Save_bnt";
            this.Save_bnt.Size = new System.Drawing.Size(113, 55);
            this.Save_bnt.TabIndex = 11;
            this.Save_bnt.Text = "Save";
            this.Save_bnt.UseVisualStyleBackColor = true;
            this.Save_bnt.Click += new System.EventHandler(this.Save_bnt_Click);
            // 
            // cancel_bnt
            // 
            this.cancel_bnt.Location = new System.Drawing.Point(529, 341);
            this.cancel_bnt.Name = "cancel_bnt";
            this.cancel_bnt.Size = new System.Drawing.Size(113, 61);
            this.cancel_bnt.TabIndex = 12;
            this.cancel_bnt.Text = "Cancel";
            this.cancel_bnt.UseVisualStyleBackColor = true;
            this.cancel_bnt.Click += new System.EventHandler(this.cancel_bnt_Click);
            // 
            // insert_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 463);
            this.Controls.Add(this.cancel_bnt);
            this.Controls.Add(this.Save_bnt);
            this.Controls.Add(this.Clear_bnt);
            this.Controls.Add(this.cid_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.table_groupbox);
            this.Name = "insert_form";
            this.Text = "Insert";
            this.table_groupbox.ResumeLayout(false);
            this.table_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox table_groupbox;
        private System.Windows.Forms.RadioButton Course_bnt;
        private System.Windows.Forms.RadioButton School_bnt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox cid_textbox;
        private System.Windows.Forms.Button Clear_bnt;
        private System.Windows.Forms.Button Save_bnt;
        private System.Windows.Forms.Button cancel_bnt;
    }
}