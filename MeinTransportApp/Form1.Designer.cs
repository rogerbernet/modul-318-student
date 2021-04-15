
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.lbxPredictionTafel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStation = new System.Windows.Forms.TextBox();
            this.btnTafel = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.gbxAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "End:";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(596, 44);
            this.tbxStart.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(240, 31);
            this.tbxStart.TabIndex = 2;
            this.tbxStart.TextChanged += new System.EventHandler(this.predictionstart);
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(172, 43);
            this.tbxEnd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(240, 31);
            this.tbxEnd.TabIndex = 3;
            this.tbxEnd.TextChanged += new System.EventHandler(this.predictionend);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(894, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 70);
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
            this.dgvConnections.Location = new System.Drawing.Point(26, 461);
            this.dgvConnections.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersVisible = false;
            this.dgvConnections.RowHeadersWidth = 82;
            this.dgvConnections.RowTemplate.Height = 33;
            this.dgvConnections.Size = new System.Drawing.Size(1008, 463);
            this.dgvConnections.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.MinimumWidth = 100;
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
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // lbxPredictionStart
            // 
            this.lbxPredictionStart.FormattingEnabled = true;
            this.lbxPredictionStart.ItemHeight = 25;
            this.lbxPredictionStart.Location = new System.Drawing.Point(596, 84);
            this.lbxPredictionStart.Margin = new System.Windows.Forms.Padding(6);
            this.lbxPredictionStart.Name = "lbxPredictionStart";
            this.lbxPredictionStart.Size = new System.Drawing.Size(240, 179);
            this.lbxPredictionStart.TabIndex = 8;
            this.lbxPredictionStart.DoubleClick += new System.EventHandler(this.selectPredictionStart);
            // 
            // lbxPredictionEnd
            // 
            this.lbxPredictionEnd.FormattingEnabled = true;
            this.lbxPredictionEnd.ItemHeight = 25;
            this.lbxPredictionEnd.Location = new System.Drawing.Point(171, 84);
            this.lbxPredictionEnd.Margin = new System.Windows.Forms.Padding(6);
            this.lbxPredictionEnd.Name = "lbxPredictionEnd";
            this.lbxPredictionEnd.Size = new System.Drawing.Size(240, 179);
            this.lbxPredictionEnd.TabIndex = 9;
            this.lbxPredictionEnd.DoubleClick += new System.EventHandler(this.selectPredictionEnd);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Controls.Add(this.dtpTime);
            this.gbxSearch.Controls.Add(this.dtpDate);
            this.gbxSearch.Controls.Add(this.lbxPredictionEnd);
            this.gbxSearch.Controls.Add(this.lbxPredictionStart);
            this.gbxSearch.Controls.Add(this.tbxEnd);
            this.gbxSearch.Controls.Add(this.tbxStart);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Location = new System.Drawing.Point(26, 23);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(6);
            this.gbxSearch.Size = new System.Drawing.Size(1008, 406);
            this.gbxSearch.TabIndex = 10;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(171, 300);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 31);
            this.dtpDate.TabIndex = 18;
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Station,
            this.Platfrom});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(1224, 461);
            this.dgvAbfahrtstafel.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.RowHeadersVisible = false;
            this.dgvAbfahrtstafel.RowHeadersWidth = 82;
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(1008, 463);
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
            this.Station.HeaderText = "Name";
            this.Station.MinimumWidth = 10;
            this.Station.Name = "Station";
            this.Station.Width = 200;
            // 
            // Platfrom
            // 
            this.Platfrom.HeaderText = "Platform";
            this.Platfrom.MinimumWidth = 10;
            this.Platfrom.Name = "Platfrom";
            this.Platfrom.Width = 200;
            // 
            // gbxAbfahrtstafel
            // 
            this.gbxAbfahrtstafel.Controls.Add(this.btnTafel);
            this.gbxAbfahrtstafel.Controls.Add(this.lbxPredictionTafel);
            this.gbxAbfahrtstafel.Controls.Add(this.label3);
            this.gbxAbfahrtstafel.Controls.Add(this.tbxStation);
            this.gbxAbfahrtstafel.Location = new System.Drawing.Point(1224, 33);
            this.gbxAbfahrtstafel.Margin = new System.Windows.Forms.Padding(6);
            this.gbxAbfahrtstafel.Name = "gbxAbfahrtstafel";
            this.gbxAbfahrtstafel.Padding = new System.Windows.Forms.Padding(6);
            this.gbxAbfahrtstafel.Size = new System.Drawing.Size(1008, 396);
            this.gbxAbfahrtstafel.TabIndex = 15;
            this.gbxAbfahrtstafel.TabStop = false;
            this.gbxAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // lbxPredictionTafel
            // 
            this.lbxPredictionTafel.FormattingEnabled = true;
            this.lbxPredictionTafel.ItemHeight = 25;
            this.lbxPredictionTafel.Location = new System.Drawing.Point(172, 74);
            this.lbxPredictionTafel.Margin = new System.Windows.Forms.Padding(6);
            this.lbxPredictionTafel.Name = "lbxPredictionTafel";
            this.lbxPredictionTafel.Size = new System.Drawing.Size(214, 179);
            this.lbxPredictionTafel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Station";
            // 
            // tbxStation
            // 
            this.tbxStation.Location = new System.Drawing.Point(172, 31);
            this.tbxStation.Margin = new System.Windows.Forms.Padding(6);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(214, 31);
            this.tbxStation.TabIndex = 0;
            this.tbxStation.TextChanged += new System.EventHandler(this.changetafel);
            // 
            // btnTafel
            // 
            this.btnTafel.Location = new System.Drawing.Point(438, 40);
            this.btnTafel.Margin = new System.Windows.Forms.Padding(6);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(416, 77);
            this.btnTafel.TabIndex = 17;
            this.btnTafel.Text = "Tafel";
            this.btnTafel.UseVisualStyleBackColor = true;
            this.btnTafel.Click += new System.EventHandler(this.ClickTafel);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(596, 300);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(240, 31);
            this.dtpTime.TabIndex = 19;
            this.dtpTime.Value = new System.DateTime(2021, 4, 15, 20, 58, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3462, 1916);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.gbxAbfahrtstafel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgvConnections);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
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
        private System.Windows.Forms.ListBox lbxPredictionStart;
        private System.Windows.Forms.ListBox lbxPredictionEnd;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platfrom;
        private System.Windows.Forms.GroupBox gbxAbfahrtstafel;
        private System.Windows.Forms.ListBox lbxPredictionTafel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStation;
        private System.Windows.Forms.Button btnTafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

