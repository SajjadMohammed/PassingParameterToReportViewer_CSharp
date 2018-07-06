
using Microsoft.Reporting.WinForms;

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ReportViewer
{
    public partial class Form1 : Form
    {

        private OleDbConnection olecon;
        private OleDbDataAdapter oleadp;
        private DataTable mytable;
        private DataSet myset;
        private string constr = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Application.StartupPath + "/student.mdb;";
        private int pos = 0;

        ReportParameter[] rep_param;
        ReportDataSource rep_source;

        public Form1()
        {
            InitializeComponent();
        }

        private bool Connection()
        {
            olecon = new OleDbConnection(constr);
            oleadp = new OleDbDataAdapter("select * from std", olecon);

            myset = new DataSet("Student");
            mytable = new DataTable();

            try
            {

                olecon.Open();
                oleadp.Fill(myset, "Student");
                mytable = myset.Tables["Student"];

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                olecon.Close();
            }
        }

        private void Filling(int p)
        {
            id_txt.Text = mytable.Rows[p]["std_ID"].ToString();
            name_txt.Text = mytable.Rows[p]["std_Name"] as string;
            age_txt.Text = mytable.Rows[p]["std_Age"] as string;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Connection())
            {
                MessageBox.Show("Connection Succeed");
            }
            else
            {
                MessageBox.Show("Connection Fail");
            }

            this.reportViewer1.RefreshReport();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            Filling(pos);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {

            if (pos < mytable.Rows.Count - 1)
            {
                pos++;
                Filling(pos);
            }
        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                Filling(pos);
            }
        }

        private void To_btn_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.MyReport.rdlc";
            rep_source = new ReportDataSource("mytable", mytable);
            reportViewer1.LocalReport.DataSources.Add(rep_source);
            rep_param = new ReportParameter[mytable.Columns.Count];
            rep_param[0] = new ReportParameter("id", id_txt.Text);
            rep_param[1] = new ReportParameter("name", name_txt.Text);
            rep_param[2] = new ReportParameter("age", age_txt.Text);
            reportViewer1.LocalReport.SetParameters(rep_param);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();


        }
    }
}