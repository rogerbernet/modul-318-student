
namespace MeinTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAbfahrtstafel = new System.Windows.Forms.RadioButton();
            this.rbtnSearch = new System.Windows.Forms.RadioButton();
            this.lbxPredictionStart = new System.Windows.Forms.ListBox();
            this.lbxPredictionEnd = new System.Windows.Forms.ListBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStation = new System.Windows.Forms.TextBox();
            this.btnTafel = new System.Windows.Forms.Button();
            this.cbxTafel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.gbxAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End:";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(77, 25);
            this.tbxStart.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(122, 20);
            this.tbxStart.TabIndex = 2;
            this.tbxStart.TextChanged += new System.EventHandler(this.predictionstart);
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(77, 150);
            this.tbxEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(122, 20);
            this.tbxEnd.TabIndex = 3;
            this.tbxEnd.TextChanged += new System.EventHandler(this.predictionend);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1, 330);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(1018, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.ClickSearch);
            // 
            // dgvConnections
            // 
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvConnections.Location = new System.Drawing.Point(1, 374);
            this.dgvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersWidth = 82;
            this.dgvConnections.RowTemplate.Height = 33;
            this.dgvConnections.Size = new System.Drawing.Size(1018, 241);
            this.dgvConnections.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "From";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "To";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Platform";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ArrivalTime";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAbfahrtstafel);
            this.groupBox1.Controls.Add(this.rbtnSearch);
            this.groupBox1.Location = new System.Drawing.Point(238, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // rbtnAbfahrtstafel
            // 
            this.rbtnAbfahrtstafel.AutoSize = true;
            this.rbtnAbfahrtstafel.Location = new System.Drawing.Point(22, 44);
            this.rbtnAbfahrtstafel.Name = "rbtnAbfahrtstafel";
            this.rbtnAbfahrtstafel.Size = new System.Drawing.Size(84, 17);
            this.rbtnAbfahrtstafel.TabIndex = 1;
            this.rbtnAbfahrtstafel.TabStop = true;
            this.rbtnAbfahrtstafel.Text = "Abfahrtstafel";
            this.rbtnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.rbtnAbfahrtstafel.Click += new System.EventHandler(this.ShowAbfahrtstafel);
            // 
            // rbtnSearch
            // 
            this.rbtnSearch.AutoSize = true;
            this.rbtnSearch.Location = new System.Drawing.Point(22, 21);
            this.rbtnSearch.Name = "rbtnSearch";
            this.rbtnSearch.Size = new System.Drawing.Size(116, 17);
            this.rbtnSearch.TabIndex = 0;
            this.rbtnSearch.TabStop = true;
            this.rbtnSearch.Text = "Search Connection";
            this.rbtnSearch.UseVisualStyleBackColor = true;
            this.rbtnSearch.Click += new System.EventHandler(this.ShowSearch);
            // 
            // lbxPredictionStart
            // 
            this.lbxPredictionStart.FormattingEnabled = true;
            this.lbxPredictionStart.Location = new System.Drawing.Point(77, 46);
            this.lbxPredictionStart.Name = "lbxPredictionStart";
            this.lbxPredictionStart.Size = new System.Drawing.Size(122, 95);
            this.lbxPredictionStart.TabIndex = 8;
            this.lbxPredictionStart.DoubleClick += new System.EventHandler(this.selectPredictionStart);
            // 
            // lbxPredictionEnd
            // 
            this.lbxPredictionEnd.FormattingEnabled = true;
            this.lbxPredictionEnd.Location = new System.Drawing.Point(77, 172);
            this.lbxPredictionEnd.Name = "lbxPredictionEnd";
            this.lbxPredictionEnd.Size = new System.Drawing.Size(122, 95);
            this.lbxPredictionEnd.TabIndex = 9;
            this.lbxPredictionEnd.DoubleClick += new System.EventHandler(this.selectPredictionEnd);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lbxPredictionEnd);
            this.gbxSearch.Controls.Add(this.lbxPredictionStart);
            this.gbxSearch.Controls.Add(this.tbxEnd);
            this.gbxSearch.Controls.Add(this.tbxStart);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Location = new System.Drawing.Point(13, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(220, 299);
            this.gbxSearch.TabIndex = 10;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Station,
            this.Platfrom});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(679, 70);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(350, 241);
            this.dgvAbfahrtstafel.TabIndex = 16;
            // 
            // Zeit
            // 
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            // 
            // Station
            // 
            this.Station.HeaderText = "Name";
            this.Station.Name = "Station";
            // 
            // Platfrom
            // 
            this.Platfrom.HeaderText = "Platform";
            this.Platfrom.Name = "Platfrom";
            // 
            // gbxAbfahrtstafel
            // 
            this.gbxAbfahrtstafel.Controls.Add(this.cbxTafel);
            this.gbxAbfahrtstafel.Controls.Add(this.listBox3);
            this.gbxAbfahrtstafel.Controls.Add(this.label3);
            this.gbxAbfahrtstafel.Controls.Add(this.tbxStation);
            this.gbxAbfahrtstafel.Location = new System.Drawing.Point(453, 17);
            this.gbxAbfahrtstafel.Name = "gbxAbfahrtstafel";
            this.gbxAbfahrtstafel.Size = new System.Drawing.Size(220, 294);
            this.gbxAbfahrtstafel.TabIndex = 15;
            this.gbxAbfahrtstafel.TabStop = false;
            this.gbxAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(96, 82);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(109, 212);
            this.listBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Station";
            // 
            // tbxStation
            // 
            this.tbxStation.Location = new System.Drawing.Point(96, 53);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(109, 20);
            this.tbxStation.TabIndex = 0;
            // 
            // btnTafel
            // 
            this.btnTafel.Location = new System.Drawing.Point(679, 24);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(350, 40);
            this.btnTafel.TabIndex = 17;
            this.btnTafel.Text = "Tafel";
            this.btnTafel.UseVisualStyleBackColor = true;
            this.btnTafel.Click += new System.EventHandler(this.ClickTafel);
            // 
            // cbxTafel
            // 
            this.cbxTafel.FormattingEnabled = true;
            this.cbxTafel.Location = new System.Drawing.Point(96, 20);
            this.cbxTafel.Name = "cbxTafel";
            this.cbxTafel.Size = new System.Drawing.Size(108, 21);
            this.cbxTafel.TabIndex = 3;
            this.cbxTafel.TextChanged += new System.EventHandler(this.changetafel);
            this.cbxTafel.Click += new System.EventHandler(this.SelectTafel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 629);
            this.Controls.Add(this.btnTafel);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.gbxAbfahrtstafel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvConnections);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.gbxAbfahrtstafel.ResumeLayout(false);
            this.gbxAbfahrtstafel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAbfahrtstafel;
        private System.Windows.Forms.RadioButton rbtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ListBox lbxPredictionStart;
        private System.Windows.Forms.ListBox lbxPredictionEnd;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platfrom;
        private System.Windows.Forms.GroupBox gbxAbfahrtstafel;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStation;
        private System.Windows.Forms.Button btnTafel;
        private System.Windows.Forms.ComboBox cbxTafel;
    }
}

