using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecurrenceProgram
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (CheckBox1.Checked)
            {

                DateTime indate = Calendar1.SelectedDate;
                String day1 = TextBox1.Text;
                int day = Convert.ToInt32(day1);
                String day2 = TextBox2.Text;
                int day3 = Convert.ToInt32(day2);
                int month = (int)indate.Month + day3;
                DateTime outputdate1 = new DateTime(indate.Year, month, day);
                Label1.Text = outputdate1.ToString();
            }



            if (CheckBox2.Checked)
            {

                DateTime dt = Calendar1.SelectedDate;
                String day11 = TextBox3.Text;
                int day16 = Convert.ToInt32(day11);
                String day22 = DropDownList2.SelectedValue;
                int day21 = Convert.ToInt32(day22);
                DateTime months = dt.AddMonths(day16);

                DateTime outcheck = new DateTime(dt.Year, months.Month, 1);

                if (DropDownList2.SelectedValue == "1")
                {
                    if (DropDownList3.SelectedValue == "12")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {

                                
                                if (outcheck.DayOfWeek == DayOfWeek.Tuesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }
                }
                    if (DropDownList2.SelectedValue == "1")
                    {
                        if (DropDownList3.SelectedValue == "11")
                        {
                            while (dt != outcheck)
                            {
                                if (outcheck.Day <= 7)
                                {


                                    if (outcheck.DayOfWeek == DayOfWeek.Monday)
                                    {
                                        DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                        Label2.Text = outputdate2.ToString();
                                        break;
                                    }

                                    outcheck = outcheck.AddDays(1);
                                }


                            }


                        }
                    }
                        if (DropDownList2.SelectedValue == "1")
                        {
                            if (DropDownList3.SelectedValue == "13")
                            {
                                while (dt != outcheck)
                                {
                                    if (outcheck.Day <= 7)
                                    {


                                        if (outcheck.DayOfWeek == DayOfWeek.Wednesday)
                                        {
                                            DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                            Label2.Text = outputdate2.ToString();
                                            break;
                                        }

                                        outcheck = outcheck.AddDays(1);
                                    }


                                }


                            }

                        }

                        if (DropDownList2.SelectedValue == "1")
                        {
                            if (DropDownList3.SelectedValue == "14")
                            {
                                while (dt != outcheck)
                                {
                                    if (outcheck.Day <= 7)
                                    {


                                        if (outcheck.DayOfWeek == DayOfWeek.Thursday)
                                        {
                                            DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                            Label2.Text = outputdate2.ToString();
                                            break;
                                        }

                                        outcheck = outcheck.AddDays(1);
                                    }


                                }


                            }

                        }
                if (DropDownList2.SelectedValue == "1")
                {
                    if (DropDownList3.SelectedValue == "15")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Friday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }
                }
                            if (DropDownList2.SelectedValue == "1")
                            {
                                if (DropDownList3.SelectedValue == "16")
                                {
                                    while (dt != outcheck)
                                    {
                                        if (outcheck.Day <= 7)
                                        {


                                            if (outcheck.DayOfWeek == DayOfWeek.Saturday)
                                            {
                                                DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                                Label2.Text = outputdate2.ToString();
                                                break;
                                            }

                                            outcheck = outcheck.AddDays(1);
                                        }


                                    }


                                }

                            }
                            if (DropDownList2.SelectedValue == "1")
                            {
                                if (DropDownList3.SelectedValue == "17")
                                {
                                    while (dt != outcheck)
                                    {
                                        if (outcheck.Day <= 7)
                                        {


                                            if (outcheck.DayOfWeek == DayOfWeek.Sunday)
                                            {
                                                DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                                Label2.Text = outputdate2.ToString();
                                                break;
                                            }

                                            outcheck = outcheck.AddDays(1);
                                        }


                                    }


                                }

                            }
                            if (DropDownList2.SelectedValue == "2")
                            {
                                if (DropDownList3.SelectedValue == "11")
                                {
                                    while (dt != outcheck)
                                    {
                                        if (outcheck.Day <= 7)
                                        {


                                            if (outcheck.DayOfWeek == DayOfWeek.Monday)
                                            {
                                                DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                                outputdate2 = outputdate2.AddDays(7);
                                                Label2.Text = outputdate2.ToString();
                                                break;
                                            }

                                            outcheck = outcheck.AddDays(1);
                                        }


                                    }


                                }

                            }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "12")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Tuesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }

                }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "13")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Wednesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }

                }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "14")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Thursday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }

                }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "15")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Friday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }

                }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "16")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {


                                if (outcheck.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }

                                outcheck = outcheck.AddDays(1);
                            }


                        }


                    }

                }
                if (DropDownList2.SelectedValue == "2")
                {
                    if (DropDownList3.SelectedValue == "17")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(7);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "11")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Monday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "12")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Tuesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "13")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Wednesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "14")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Thursday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "15")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Friday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "16")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "3")
                {
                    if (DropDownList3.SelectedValue == "17")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(14);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "11")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Monday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "12")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Tuesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "13")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Wednesday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "14")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Thursday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "15")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Friday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "16")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "4")
                {
                    if (DropDownList3.SelectedValue == "17")
                    {
                        while (dt != outcheck)
                        {
                            if (outcheck.Day <= 7)
                            {
                                if (outcheck.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    DateTime outputdate2 = new DateTime(outcheck.Year, outcheck.Month, outcheck.Day);
                                    outputdate2 = outputdate2.AddDays(21);
                                    Label2.Text = outputdate2.ToString();
                                    break;
                                }
                                outcheck = outcheck.AddDays(1);
                            }
                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "11")
                    {

                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Monday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "12")
                    {
                        
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Tuesday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "13")
                    {
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Wednesday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "14")
                    {
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Thursday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "15")
                    {
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Friday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "16")
                    {
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Saturday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
                if (DropDownList2.SelectedValue == "5")
                {
                    if (DropDownList3.SelectedValue == "17")
                    {
                        DateTime outp = new DateTime(dt.Year, months.Month, 30);
                        while (dt != outp)
                        {

                            if (outp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                DateTime outputdate2 = new DateTime(outp.Year, outp.Month, outp.Day);

                                Label2.Text = outputdate2.ToString();
                                break;
                            }
                            outp = outp.AddDays(-1);

                        }
                    }
                }
            }

            }

                    }

                }

            
       


        

   

