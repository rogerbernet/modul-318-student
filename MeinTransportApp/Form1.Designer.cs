
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
            this.lbxPredictionStart = new System.Windows.Forms.ListBox();
            this.lbxPredictionEnd = new System.Windows.Forms.ListBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.btnTafel = new System.Windows.Forms.Button();
            this.lbxPredictionTafel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.gbxAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End:";
            // 
            // tbxStart
            // 
            this.tbxStart.BackColor = System.Drawing.Color.Pink;
            this.tbxStart.Location = new System.Drawing.Point(60, 19);
            this.tbxStart.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(151, 20);
            this.tbxStart.TabIndex = 1;
            this.tbxStart.TextChanged += new System.EventHandler(this.predictionstart);
            // 
            // tbxEnd
            // 
            this.tbxEnd.BackColor = System.Drawing.Color.Pink;
            this.tbxEnd.Location = new System.Drawing.Point(266, 21);
            this.tbxEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(151, 20);
            this.tbxEnd.TabIndex = 3;
            this.tbxEnd.TextChanged += new System.EventHandler(this.predictionend);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnSearch.Location = new System.Drawing.Point(447, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.ClickSearch);
            // 
            // dgvConnections
            // 
            this.dgvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvConnections.Location = new System.Drawing.Point(8, 323);
            this.dgvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersVisible = false;
            this.dgvConnections.RowHeadersWidth = 82;
            this.dgvConnections.RowTemplate.Height = 33;
            this.dgvConnections.Size = new System.Drawing.Size(504, 241);
            this.dgvConnections.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.MinimumWidth = 70;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "From";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "To";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Platform";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ArrivalTime";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // lbxPredictionStart
            // 
            this.lbxPredictionStart.FormattingEnabled = true;
            this.lbxPredictionStart.Location = new System.Drawing.Point(60, 44);
            this.lbxPredictionStart.Name = "lbxPredictionStart";
            this.lbxPredictionStart.Size = new System.Drawing.Size(151, 95);
            this.lbxPredictionStart.TabIndex = 2;
            this.lbxPredictionStart.DoubleClick += new System.EventHandler(this.selectPredictionStart);
            // 
            // lbxPredictionEnd
            // 
            this.lbxPredictionEnd.FormattingEnabled = true;
            this.lbxPredictionEnd.Location = new System.Drawing.Point(266, 46);
            this.lbxPredictionEnd.Name = "lbxPredictionEnd";
            this.lbxPredictionEnd.Size = new System.Drawing.Size(151, 95);
            this.lbxPredictionEnd.TabIndex = 4;
            this.lbxPredictionEnd.DoubleClick += new System.EventHandler(this.selectPredictionEnd);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Controls.Add(this.dtpTime);
            this.gbxSearch.Controls.Add(this.dtpDate);
            this.gbxSearch.Controls.Add(this.lbxPredictionEnd);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.lbxPredictionStart);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Controls.Add(this.tbxEnd);
            this.gbxSearch.Controls.Add(this.tbxStart);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Location = new System.Drawing.Point(8, 95);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(504, 211);
            this.gbxSearch.TabIndex = 10;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datum:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(266, 156);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(151, 20);
            this.dtpTime.TabIndex = 7;
            this.dtpTime.Value = new System.DateTime(2021, 4, 15, 20, 58, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(60, 156);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Station,
            this.Column6});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(595, 323);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.RowHeadersVisible = false;
            this.dgvAbfahrtstafel.RowHeadersWidth = 82;
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(504, 241);
            this.dgvAbfahrtstafel.TabIndex = 16;
            // 
            // Zeit
            // 
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.MinimumWidth = 10;
            this.Zeit.Name = "Zeit";
            this.Zeit.Width = 200;
            // 
            // Station
            // 
            this.Station.HeaderText = "Richtung";
            this.Station.MinimumWidth = 10;
            this.Station.Name = "Station";
            this.Station.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Number";
            this.Column6.Name = "Column6";
            // 
            // gbxAbfahrtstafel
            // 
            this.gbxAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAbfahrtstafel.Controls.Add(this.btnTafel);
            this.gbxAbfahrtstafel.Controls.Add(this.lbxPredictionTafel);
            this.gbxAbfahrtstafel.Controls.Add(this.label3);
            this.gbxAbfahrtstafel.Controls.Add(this.tbxStation);
            this.gbxAbfahrtstafel.Location = new System.Drawing.Point(595, 95);
            this.gbxAbfahrtstafel.Name = "gbxAbfahrtstafel";
            this.gbxAbfahrtstafel.Size = new System.Drawing.Size(504, 211);
            this.gbxAbfahrtstafel.TabIndex = 15;
            this.gbxAbfahrtstafel.TabStop = false;
            this.gbxAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // btnTafel
            // 
            this.btnTafel.BackColor = System.Drawing.Color.Crimson;
            this.btnTafel.Location = new System.Drawing.Point(447, 5);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(57, 37);
            this.btnTafel.TabIndex = 11;
            this.btnTafel.Text = "Tafel";
            this.btnTafel.UseVisualStyleBackColor = false;
            this.btnTafel.Click += new System.EventHandler(this.ClickTafel);
            // 
            // lbxPredictionTafel
            // 
            this.lbxPredictionTafel.FormattingEnabled = true;
            this.lbxPredictionTafel.Location = new System.Drawing.Point(86, 38);
            this.lbxPredictionTafel.Name = "lbxPredictionTafel";
            this.lbxPredictionTafel.Size = new System.Drawing.Size(190, 95);
            this.lbxPredictionTafel.TabIndex = 10;
            this.lbxPredictionTafel.DoubleClick += new System.EventHandler(this.GetTafelPrediction);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Station:";
            // 
            // tbxStation
            // 
            this.tbxStation.BackColor = System.Drawing.Color.Pink;
            this.tbxStation.Location = new System.Drawing.Point(86, 16);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(190, 20);
            this.tbxStation.TabIndex = 9;
            this.tbxStation.TextChanged += new System.EventHandler(this.changetafel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 77);
            this.label6.TabIndex = 17;
            this.label6.Text = "ÖV Connect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(12, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "SteamVac AG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1133, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.gbxAbfahrtstafel);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgvConnections);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ÖV Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.gbxAbfahrtstafel.ResumeLayout(false);
            this.gbxAbfahrtstafel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.ListBox lbxPredictionStart;
        private System.Windows.Forms.ListBox lbxPredictionEnd;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.GroupBox gbxAbfahrtstafel;
        private System.Windows.Forms.ListBox lbxPredictionTafel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStation;
        private System.Windows.Forms.Button btnTafel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
    }
}

