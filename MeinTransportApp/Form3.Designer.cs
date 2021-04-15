
namespace MeinTransportApp
{
    partial class Form3
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
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.gbxAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Station,
            this.Platfrom});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(12, 324);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(685, 190);
            this.dgvAbfahrtstafel.TabIndex = 14;
            this.dgvAbfahrtstafel.Visible = false;
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
            this.gbxAbfahrtstafel.Controls.Add(this.listBox3);
            this.gbxAbfahrtstafel.Controls.Add(this.label3);
            this.gbxAbfahrtstafel.Controls.Add(this.textBox1);
            this.gbxAbfahrtstafel.Location = new System.Drawing.Point(12, 12);
            this.gbxAbfahrtstafel.Name = "gbxAbfahrtstafel";
            this.gbxAbfahrtstafel.Size = new System.Drawing.Size(220, 287);
            this.gbxAbfahrtstafel.TabIndex = 13;
            this.gbxAbfahrtstafel.TabStop = false;
            this.gbxAbfahrtstafel.Text = "Abfahrtstafel";
            this.gbxAbfahrtstafel.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(96, 45);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 526);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.gbxAbfahrtstafel);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.gbxAbfahrtstafel.ResumeLayout(false);
            this.gbxAbfahrtstafel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platfrom;
        private System.Windows.Forms.GroupBox gbxAbfahrtstafel;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}