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
    public partial class update_form : Form
    {
        public update_form()
        {
            InitializeComponent();
        }
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader str = null;
        static string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Data Source = project.accdb";
        public string radiobnt = "School";
        public string sql;


        private void School_bnt_CheckedChanged(object sender, EventArgs e)
        {
            SID_label.Text = "School ID";
            name_label.Text = "School Name";
            Address_label.Text = "School Address";
            phone_label.Text = "School Phone";
            CID_label.Text = "Course ID";
        }

        private void Course_bnt_CheckedChanged(object sender, EventArgs e)
        {
            SID_label.Text = "Course ID";
            name_label.Text = "Course Name";
            Address_label.Text = "Course code";
            phone_label.Text = "Course fee";
            CID_label.Text = "Course location";
            radiobnt = "Course";
        }

        private void Refresh_bnt_Click(object sender, EventArgs e)
        {
            if (sid_textbox.Text != "")
            {
                name_textbox.Text = "";
                address_textbox.Text = "";
                phone_textbox.Text = "";
                cid_textbox.Text = "";

                conn = new OleDbConnection(constr);
                conn.Open();
                sql = "SELECT * FROM " + radiobnt + " where ID = " + sid_textbox.Text;
                comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = sql;

                str = comm.ExecuteReader();


                if (School_bnt.Checked)
                {
                    while (str.Read())
                    {

                        name_textbox.Text = str["School Name"].ToString();
                        address_textbox.Text = str["School address"].ToString();
                        phone_textbox.Text = str["School Phone"].ToString();
                        cid_textbox.Text = str["Course ID"].ToString();

                    }

                }
                else if (Course_bnt.Checked)
                {
                    while (str.Read())
                    {
                        name_textbox.Text = str["Course Name"].ToString();
                        address_textbox.Text = str["Course Code"].ToString();
                        phone_textbox.Text = str["Course fee"].ToString();
                        cid_textbox.Text = str["Course location"].ToString();
                    }
                }
                if(name_textbox.Text == "")
                {
                    MessageBox.Show("Not vaild ID in database.");
                }

                str.Close();
                conn.Close();

            }
            
            else
            {
                MessageBox.Show("Fill up the ID");
            }
            
        }

        private void cancel_bnt_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void Clear_bnt_Click(object sender, EventArgs e)
        {
            sid_textbox.Text = "";
            name_textbox.Text = "";
            address_textbox.Text = "";
            phone_textbox.Text = "";
            cid_textbox.Text = "";
        }

        private void update_bnt_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text != "" && address_textbox.Text != "" && phone_textbox.Text != "" && cid_textbox.Text != "")
            {
                
                    conn = new OleDbConnection(constr);
                    conn.Open();

                    if (School_bnt.Checked)
                    {
                        sql = "Update " + radiobnt + " Set [school name] ='" 
                        + name_textbox.Text + "', [school address] ='" + 
                        address_textbox.Text + "',[school phone] = '" + 
                        phone_textbox.Text + "',[course id] ='" + cid_textbox.Text + 
                        "' WHERE ID = " + sid_textbox.Text;

                        comm = new OleDbCommand();
                        comm.Connection = conn;
                        comm.CommandText = sql;
                    
                        int x = comm.ExecuteNonQuery();
                        if (x == 1)
                        MessageBox.Show("Succeess to Update datas in " + radiobnt);
                    conn.Close();
                        this.Close();
                    }
                    else if (Course_bnt.Checked)
                    {
                        radiobnt = "Course";

                        sql = "Update " + radiobnt + " Set [course name] ='"
                        + name_textbox.Text + "', [course code] ='" +
                        address_textbox.Text + "',[course fee] = '" +
                        phone_textbox.Text + "',[course location] ='" + cid_textbox.Text +
                        "' WHERE ID = " + sid_textbox.Text;

                        comm = new OleDbCommand();
                        comm.Connection = conn;
                        comm.CommandText = sql;

                        int x = comm.ExecuteNonQuery();
                        if (x == 1)
                        MessageBox.Show("Succeess to Update datas in " + radiobnt);

                    conn.Close();
                        this.Close();
                }
                }
                else
                {
                MessageBox.Show("There might be something missing on textboxes.");
                }
            
        }
    }
}
