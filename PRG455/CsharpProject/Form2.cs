using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.OleDb;
namespace CsharpProject
{
    
    public partial class insert_form : Form
    {
        
        public insert_form()
        {
            InitializeComponent();
        }
        public string TXT
        {
            get;
            set;
        }
        public string radiobnt="School";
        private void School_bnt_CheckedChanged(object sender, EventArgs e)
        {
            name_label.Text = "School Name";
            Address_label.Text = "School Address";
            phone_label.Text = "School Phone";
            ID_label.Text = "Course ID";
            
        }

        private void Course_bnt_CheckedChanged(object sender, EventArgs e)
        {
            name_label.Text = "Course Name";
            Address_label.Text = "Course code";
            phone_label.Text = "Course fee";
            ID_label.Text = "Course location";
            radiobnt = "Course";
        }

        private void Clear_bnt_Click(object sender, EventArgs e)
        {
            name_textbox.Text = "";
            address_textbox.Text = "";
            phone_textbox.Text = "";
            cid_textbox.Text = "";

        }

        private void Save_bnt_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text != "" && address_textbox.Text != "" && phone_textbox.Text != "" && cid_textbox.Text != "")
                {
                if (School_bnt.Checked)
                {
                    TXT = "INSERT INTO " + radiobnt + "([school name],[school address],[school phone],[course id]) VALUES('" + name_textbox.Text + "','" + address_textbox.Text + "','" + phone_textbox.Text + "','" + cid_textbox.Text + "')";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if(Course_bnt.Checked)
                {
                    radiobnt = "Course";
                    TXT = "INSERT INTO " + radiobnt + "([course name],[course code],[course fee],[course location]) VALUES('" + name_textbox.Text + "','" + address_textbox.Text + "','" + phone_textbox.Text + "','" + cid_textbox.Text + "')";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                }
                else
                    MessageBox.Show("Fill up every test boxes!!");

        }

        private void cancel_bnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
