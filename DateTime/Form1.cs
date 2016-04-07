using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = System.DateTime.Now.ToString();
            dataGridView1.Columns["time"].DefaultCellStyle.Format = "HH:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(Database8DataSet.Tables[0]);

            //string startdate = "2015/9/15";
            //string enddate = "2015/9/15";
            string iTime = dateTimePicker1.Value.ToString("yyyy/MM/dd").Trim();
            textBox2.Text = iTime;

            dv.RowFilter = "datetime = '" + iTime + "'";

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            
            //DataView md = new DataView(Database8DataSet.Tables[0], "time = 2015/9/15下午03:50:31", "time Desc", DataViewRowState.CurrentRows);
            //dataGridView1.DataSource = md;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database8DataSet.station' table. You can move, or remove it, as needed.
            this.StationTableAdapter.Fill(this.Database8DataSet.station);
        }
    }
}
