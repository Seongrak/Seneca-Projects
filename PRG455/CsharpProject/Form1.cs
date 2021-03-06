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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();

            runQueryToolStripMenuItem.ShortcutKeys = Keys.F5;
            insertRecordF6ToolStripMenuItem.ShortcutKeys = Keys.F6;
            updateRecodrdF7ToolStripMenuItem.ShortcutKeys = Keys.F7;
            deleteRecordF8ToolStripMenuItem.ShortcutKeys = Keys.F8;

        }

        static string sql;
        static string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Mode=ReadWrite;Data Source=project.accdb";
    
        OleDbConnection conn=null;
        OleDbCommand comm = null;
        OleDbDataAdapter da = null;
        DataTable vt = null;


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn != null)
            {
                try {
                    sql = textBox.Text.ToString();

                    comm = new OleDbCommand();
                    comm.Connection = conn;
                    comm.CommandText = sql;

                    da = new OleDbDataAdapter(comm);

                    vt = new DataTable();
                    da.Fill(vt);
                    da.Dispose();

                    dataGridView1.DataSource = vt;
                  
                    MessageBox.Show("Succeess to Run Query");
                    sql = null;
                    textBox.Text = "";
                    conn.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Type SQL statement correctly.");
                }
               
            }

            else
            {
                MessageBox.Show("You should connect to Database.");
            }

        }


        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(constr);           
                MessageBox.Show("Connect to Database.");
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to Connection");
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                conn.Close();
                MessageBox.Show("Disconect to Database.");
             
            }
            catch(Exception)
            {
                MessageBox.Show("There is no connection.");
            }
        }

        private void insertRecordF6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("Connect to Database First!");
            }
            else
            {
                insert_form ifm = new insert_form();
              
                if (ifm.ShowDialog() == DialogResult.OK)
                {
                    string sql = ifm.TXT;
                    conn.Open();
                    comm = new OleDbCommand();
                    comm.Connection = conn;                    

                    comm.CommandText = sql;
                    int x = comm.ExecuteNonQuery();
                    if (x == 1)
                        MessageBox.Show("Succeess to Insert datas!");
                    conn.Close();
                   
                }
            }
        }

        private void updateRecodrdF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("Connect to Database First!");
            }
            else
            {
                conn.Dispose();
                update_form ufm = new update_form();
                ufm.ShowDialog();
                
            }
        }

        private void deleteRecordF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("Connect to Database First!");
            }
            else
            {
                delete_form dfm = new delete_form();
                dfm.ShowDialog();
            }
        }
    }
}
