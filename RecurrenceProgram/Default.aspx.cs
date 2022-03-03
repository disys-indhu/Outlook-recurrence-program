using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RecurrenceProgram
{
    public partial class _Default : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime indate = Calendar1.SelectedDate;
            if (CheckBox1.Checked)
            {   
                String day1 = TextBox2.Text;
                int day = Convert.ToInt32(day1);
                DateTime outputdate = indate.AddDays(day);
                Label2.Text = outputdate.ToString();
            }
            if (CheckBox2.Checked)
            {
                DateTime indate1 = Calendar1.SelectedDate;
                if (indate1.DayOfWeek == DayOfWeek.Sunday)
                {
                    
                    indate1 = indate1.AddDays(1);
                    Label2.Text = indate1.ToString();
                }
                DateTime indate2 = Calendar1.SelectedDate;
                if (indate2.DayOfWeek == DayOfWeek.Saturday)
                {
                    indate2 = indate2.AddDays(2);
                    Label2.Text = indate2.ToString();
                }
                DateTime indate3 = Calendar1.SelectedDate;
                if (indate3.DayOfWeek == DayOfWeek.Monday)
                {
                    indate3 = indate1.AddDays(1);
                    Label2.Text = indate3.ToString();
                }
                DateTime indate4 = Calendar1.SelectedDate;
                if (indate4.DayOfWeek == DayOfWeek.Tuesday)
                {
                    indate4 = indate4.AddDays(1);
                    Label2.Text = indate4.ToString();
                }
                DateTime indate5 = Calendar1.SelectedDate;
                if (indate5.DayOfWeek == DayOfWeek.Wednesday)
                {
                    indate5 = indate5.AddDays(1);
                    Label2.Text = indate5.ToString();
                }
                DateTime indate6 = Calendar1.SelectedDate;
                if (indate6.DayOfWeek == DayOfWeek.Thursday)
                {
                    indate6 = indate6.AddDays(1);
                    Label2.Text = indate6.ToString();
                }
                DateTime indate7 = Calendar1.SelectedDate;
                if (indate7.DayOfWeek == DayOfWeek.Friday)
                {
                    indate7 = indate7.AddDays(3);
                    Label2.Text = indate7.ToString();
                }
                
            }

        }

       
    }
    }