namespace DateTime
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Database8DataSet = new DateTime.Database8DataSet();
            this.StationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StationTableAdapter = new DateTime.Database8DataSetTableAdapters.stationTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vswr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reverse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pttandcor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmbyte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poweralarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vswralarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(247, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(427, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 20);
            this.comboBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "日";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.station,
            this.channel,
            this.vswr,
            this.forward,
            this.reverse,
            this.pttandcor,
            this.alarmbyte,
            this.poweralarm,
            this.vswralarm,
            this.datetime,
            this.time});
            this.dataGridView1.DataSource = this.StationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 455);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 428);
            this.textBox2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Database8DataSet
            // 
            this.Database8DataSet.DataSetName = "Database8DataSet";
            this.Database8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StationBindingSource
            // 
            this.StationBindingSource.DataMember = "station";
            this.StationBindingSource.DataSource = this.Database8DataSet;
            // 
            // StationTableAdapter
            // 
            this.StationTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // station
            // 
            this.station.DataPropertyName = "Station";
            this.station.HeaderText = "Station";
            this.station.Name = "station";
            // 
            // channel
            // 
            this.channel.DataPropertyName = "Channel";
            this.channel.HeaderText = "Channel";
            this.channel.Name = "channel";
            // 
            // vswr
            // 
            this.vswr.DataPropertyName = "VSWR";
            this.vswr.HeaderText = "VSWR";
            this.vswr.Name = "vswr";
            // 
            // forward
            // 
            this.forward.DataPropertyName = "Forward";
            this.forward.HeaderText = "Forward";
            this.forward.Name = "forward";
            // 
            // reverse
            // 
            this.reverse.DataPropertyName = "Reverse";
            this.reverse.HeaderText = "Reverse";
            this.reverse.Name = "reverse";
            // 
            // pttandcor
            // 
            this.pttandcor.DataPropertyName = "Ptt and Cor Sense Byte";
            this.pttandcor.HeaderText = "Ptt and Cor Sense Byte";
            this.pttandcor.Name = "pttandcor";
            // 
            // alarmbyte
            // 
            this.alarmbyte.DataPropertyName = "Alarm Byte";
            this.alarmbyte.HeaderText = "Alarm Byte";
            this.alarmbyte.Name = "alarmbyte";
            // 
            // poweralarm
            // 
            this.poweralarm.DataPropertyName = "Power Reading at Alarm";
            this.poweralarm.HeaderText = "Power Reading at Alarm";
            this.poweralarm.Name = "poweralarm";
            // 
            // vswralarm
            // 
            this.vswralarm.DataPropertyName = "VSWR Alarm Reading";
            this.vswralarm.HeaderText = "VSWR Alarm Reading";
            this.vswralarm.Name = "vswralarm";
            // 
            // datetime
            // 
            this.datetime.DataPropertyName = "DateTime";
            this.datetime.HeaderText = "DateTime";
            this.datetime.Name = "datetime";
            // 
            // time
            // 
            this.time.DataPropertyName = "Time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 569);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Database8DataSet Database8DataSet;
        private System.Windows.Forms.BindingSource StationBindingSource;
        private Database8DataSetTableAdapters.stationTableAdapter StationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vswr;
        private System.Windows.Forms.DataGridViewTextBoxColumn forward;
        private System.Windows.Forms.DataGridViewTextBoxColumn reverse;
        private System.Windows.Forms.DataGridViewTextBoxColumn pttandcor;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmbyte;
        private System.Windows.Forms.DataGridViewTextBoxColumn poweralarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn vswralarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}

