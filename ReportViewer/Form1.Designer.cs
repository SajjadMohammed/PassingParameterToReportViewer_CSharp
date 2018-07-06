namespace ReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.to_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 22);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(574, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(389, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(582, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viewing Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(96, 34);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(197, 25);
            this.id_txt.TabIndex = 5;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(96, 80);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(197, 25);
            this.name_txt.TabIndex = 6;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(96, 122);
            this.age_txt.Margin = new System.Windows.Forms.Padding(4);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(197, 25);
            this.age_txt.TabIndex = 7;
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(27, 192);
            this.show_btn.Margin = new System.Windows.Forms.Padding(4);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(100, 30);
            this.show_btn.TabIndex = 8;
            this.show_btn.Text = "Show Data";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.to_btn);
            this.groupBox2.Controls.Add(this.prev_btn);
            this.groupBox2.Controls.Add(this.next_btn);
            this.groupBox2.Controls.Add(this.show_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.age_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.name_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.id_txt);
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(352, 297);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info.";
            // 
            // to_btn
            // 
            this.to_btn.Location = new System.Drawing.Point(244, 242);
            this.to_btn.Margin = new System.Windows.Forms.Padding(4);
            this.to_btn.Name = "to_btn";
            this.to_btn.Size = new System.Drawing.Size(100, 30);
            this.to_btn.TabIndex = 10;
            this.to_btn.Text = "Report";
            this.to_btn.UseVisualStyleBackColor = true;
            this.to_btn.Click += new System.EventHandler(this.To_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(27, 242);
            this.prev_btn.Margin = new System.Windows.Forms.Padding(4);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(100, 30);
            this.prev_btn.TabIndex = 10;
            this.prev_btn.Text = "Prev";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.Prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(135, 242);
            this.next_btn.Margin = new System.Windows.Forms.Padding(4);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(100, 30);
            this.next_btn.TabIndex = 9;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealing with ReportViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button to_btn;
    }
}

