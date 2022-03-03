using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecurrenceProgram
{
    public partial class Weekly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            DateTime[] datearray = new DateTime[7];
            DateTime indate = Calendar1.SelectedDate;
            string inday = TextBox1.Text;
            int day = Convert.ToInt32(inday);
           
            if (CheckBox1.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Sunday)
                {
                    weekdate = indate.AddDays(day * 7);
                       
                    int daysUntilTuesday = ((int)DayOfWeek.Sunday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label3.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Sunday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label3.Text = nextTuesday.ToString();

                }
                
            }
            if (CheckBox2.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Monday)
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Monday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label5.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Monday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label5.Text = nextTuesday.ToString();
                }
            }
            if (CheckBox3.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Tuesday)
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label6.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label6.Text = nextTuesday.ToString(); 
                    
                }
            }
            if (CheckBox4.Checked)

            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Wednesday) 
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Wednesday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label7.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);

                    int daysUntilTuesday = ((int)DayOfWeek.Wednesday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label7.Text = nextTuesday.ToString();
                }
            }
            if (CheckBox5.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Thursday)
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Thursday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label8.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Thursday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label8.Text = nextTuesday.ToString();
                }
                   
            }
            if (CheckBox6.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Friday)
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Friday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label9.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Friday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label9.Text = nextTuesday.ToString();
                }

                    
            }
            if (CheckBox7.Checked)
            {
                DateTime weekdate = indate;
                if ((int)weekdate.DayOfWeek == (int)DayOfWeek.Saturday)
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Saturday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label10.Text = nextTuesday.ToString();
                }
                else
                {
                    weekdate = indate.AddDays(day * 7);
                    int daysUntilTuesday = ((int)DayOfWeek.Saturday - (int)weekdate.DayOfWeek + 7) % 7;
                    DateTime nextTuesday = weekdate.AddDays(daysUntilTuesday);
                    Label10.Text = nextTuesday.ToString();
                }

            }
        }
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}