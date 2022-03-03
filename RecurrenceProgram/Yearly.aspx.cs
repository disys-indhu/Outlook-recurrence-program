using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecurrenceProgram
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                if (DropDownList1.SelectedValue == "1")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 1;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 1;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }

                if (DropDownList1.SelectedValue == "2")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 2;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 2;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }


                if (DropDownList1.SelectedValue == "3")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 3;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 3;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "4")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 4;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 4;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "5")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 5;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 5;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "6")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 6;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 6;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "7")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 7;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 7;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "8")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 8;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 8;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "9")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 9;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 9;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "10")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 10;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 10;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "11")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;

                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 11;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 11;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
                if (DropDownList1.SelectedValue == "12")
                {
                    DateTime indate = Calendar1.SelectedDate;
                    String year = TextBox1.Text;
                    int year1 = Convert.ToInt32(year);
                    String day = TextBox2.Text;
                    int day1 = Convert.ToInt32(day);
                    if (indate.Day <= day1)
                    {
                        int N = 12;
                        int years = (int)indate.Year;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }
                    else
                    {
                        int N = 12;
                        int years = (int)indate.Year + year1;
                        DateTime outputdate1 = new DateTime(years, N, day1);
                        Label1.Text = outputdate1.ToString();
                    }

                }
            }
            if (CheckBox2.Checked)
            {
                DateTime dt = Calendar1.SelectedDate;
                String day11 = TextBox1.Text;
                int day16 = Convert.ToInt32(day11);
                String day22 = DropDownList4.SelectedValue;
                int day21 = Convert.ToInt32(day22);


                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "13")
                        {
                            int N = 1;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 28);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "14")
                        {
                            int N = 2;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 28);

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
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "15")
                        {
                            int N = 3;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "16")
                        {
                            int N = 4;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "17")
                        {
                            int N = 5;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 31);

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
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "51")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "52")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "53")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "54")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "41")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "42")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "43")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "44")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);

                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "45")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "46")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                }
                if (DropDownList2.SelectedValue == "55")
                {
                    if (DropDownList3.SelectedValue == "47")
                    {
                        if (DropDownList4.SelectedValue == "18")
                        {
                            int N = 6;
                            DateTime year = dt.AddYears(day16);
                            DateTime outcheck = new DateTime(year.Year, N, 1);
                            DateTime outp = new DateTime(year.Year, N, 30);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "19")
                            {
                                int N = 7;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "20")
                            {
                                int N = 8;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "21")
                            {
                                int N = 9;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "22")
                            {
                                int N = 10;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N =11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "23")
                            {
                                int N = 11;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 30);

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
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "51")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "52")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "53")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "54")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "41")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "42")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "43")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "44")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);

                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "45")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "46")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
                    }
                    if (DropDownList2.SelectedValue == "55")
                    {
                        if (DropDownList3.SelectedValue == "47")
                        {
                            if (DropDownList4.SelectedValue == "24")
                            {
                                int N = 12;
                                DateTime year = dt.AddYears(day16);
                                DateTime outcheck = new DateTime(year.Year, N, 1);
                                DateTime outp = new DateTime(year.Year, N, 31);

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
    }
}




            
                

    
