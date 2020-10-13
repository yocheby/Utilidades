using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateFormat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //string dateFormatFrom = "30/12/2020 05:00:00 p.m.";

            //txtFormatTo.Text = string.Empty;
            //if (!string.IsNullOrEmpty(txtFormatFrom.Text))
            //    txtFormatTo.Text = ConvertFormat(txtFormatFrom.Text);


            txtFormatToBulk.Text = string.Empty;
            if (!string.IsNullOrEmpty(txtFormatFromBulk.Text))
            {
                string[] dates = txtFormatFromBulk.Text.Split('\n');
                StringBuilder datesTo = new StringBuilder();

                foreach (var item in dates.ToList())
                {
                    if (!string.IsNullOrEmpty(item.Trim()))
                        txtFormatToBulk.AppendText(ConvertFormat(item.Replace('\r', ' ')) + Environment.NewLine);
                }

                //txtFormatToBulk.AppendText = datesTo.ToString();
            }

            //Console.ReadLine();
        }

        private string ConvertFormat(string dateFormatFrom)
        {
            DateTime currectDate = DateTime.Now;

            if (isPm(ref dateFormatFrom))
            {
                //dateFormatFrom = dateFormatFrom.Replace(pm, "");
                currectDate = DateTime.Parse(dateFormatFrom);
                //Console.WriteLine(currectDate.ToString("M/d/yyyy hh:mm:ss") + " pm");
                return currectDate.ToString("M/d/yyyy hh:mm:ss") + " pm";
            }
            else if (isAm(ref dateFormatFrom))
            {
                //dateFormatFrom = dateFormatFrom.Replace(am, "");
                currectDate = DateTime.Parse(dateFormatFrom);
                //Console.WriteLine(currectDate.ToString("M/d/yyyy hh:mm:ss") + " am");
                return currectDate.ToString("M/d/yyyy hh:mm:ss") + " am";
            }

            return string.Empty;
        }

        private bool isPm(ref string dateFormatFrom)
        {
            dateFormatFrom = dateFormatFrom.ToUpper();
            if (dateFormatFrom.ToUpper().Contains("P.M."))
            {
                dateFormatFrom = dateFormatFrom.Replace("P.M.", "");
                return true;
            }
            
            if (dateFormatFrom.ToUpper().Contains("P.M"))
            {
                dateFormatFrom = dateFormatFrom.Replace("P.M", "");
                return true;
            }

            if (dateFormatFrom.ToUpper().Contains("P."))
            {
                dateFormatFrom = dateFormatFrom.Replace("P.", "");
                return true;
            }

            if (dateFormatFrom.ToUpper().Contains("P"))
            {
                dateFormatFrom = dateFormatFrom.Replace("P", "");
                return true;
            }

            return false;
        }

        private bool isAm(ref string dateFormatFrom)
        {
            dateFormatFrom = dateFormatFrom.ToUpper();
            if (dateFormatFrom.ToUpper().Contains("A.M."))
            {
                dateFormatFrom = dateFormatFrom.Replace("A.M.", "");
                return true;
            }

            if (dateFormatFrom.ToUpper().Contains("A.M"))
            {
                dateFormatFrom = dateFormatFrom.Replace("A.M", "");
                return true;
            }

            if (dateFormatFrom.ToUpper().Contains("A."))
            {
                dateFormatFrom = dateFormatFrom.Replace("A.", "");
                return true;
            }

            if (dateFormatFrom.ToUpper().Contains("A"))
            {
                dateFormatFrom = dateFormatFrom.Replace("A", "");
                return true;
            }

            return false;
        }
    }
}
