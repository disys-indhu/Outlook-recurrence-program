<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Yearly.aspx.cs" Inherits="RecurrenceProgram.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <WeekendDayStyle BackColor="#CCCCFF" />
    </asp:Calendar>


    <br />
    Recur every&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; year(s)<br />
    <br />
    <asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;On&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">January</asp:ListItem>
        <asp:ListItem Value="2">February</asp:ListItem>
        <asp:ListItem Value="3">March</asp:ListItem>
        <asp:ListItem Value="4">April</asp:ListItem>
        <asp:ListItem Value="5">May</asp:ListItem>
        <asp:ListItem Value="6">June</asp:ListItem>
        <asp:ListItem Value="7">July</asp:ListItem>
        <asp:ListItem Value="8">August</asp:ListItem>
        <asp:ListItem Value="9">September</asp:ListItem>
        <asp:ListItem Value="10">October</asp:ListItem>
        <asp:ListItem Value="11">November</asp:ListItem>
        <asp:ListItem Value="12">December</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:CheckBox ID="CheckBox2" runat="server" />
&nbsp; On the&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem Value="51">First</asp:ListItem>
        <asp:ListItem Value="52">Second</asp:ListItem>
        <asp:ListItem Value="53">Third</asp:ListItem>
        <asp:ListItem Value="54">Fourth</asp:ListItem>
        <asp:ListItem Value="55">Last</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem Value="41">Monday</asp:ListItem>
        <asp:ListItem Value="42">Tuesday</asp:ListItem>
        <asp:ListItem Value="43">Wednesday</asp:ListItem>
        <asp:ListItem Value="44">Thursday</asp:ListItem>
        <asp:ListItem Value="45">Friday</asp:ListItem>
        <asp:ListItem Value="46">Saturday</asp:ListItem>
        <asp:ListItem Value="47">Sunday</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;of&nbsp; &nbsp;
    <asp:DropDownList ID="DropDownList4" runat="server">
        <asp:ListItem Value="13">January</asp:ListItem>
        <asp:ListItem Value="14">February</asp:ListItem>
        <asp:ListItem Value="15">March</asp:ListItem>
        <asp:ListItem Value="16">April</asp:ListItem>
        <asp:ListItem Value="17">May</asp:ListItem>
        <asp:ListItem Value="18">June</asp:ListItem>
        <asp:ListItem Value="19">July</asp:ListItem>
        <asp:ListItem Value="20">August</asp:ListItem>
        <asp:ListItem Value="21">September</asp:ListItem>
        <asp:ListItem Value="22">October</asp:ListItem>
        <asp:ListItem Value="23">November</asp:ListItem>
        <asp:ListItem Value="24">December</asp:ListItem> 

    </asp:DropDownList>
    &nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />

     <asp:LinkButton runat="server" id="SomeLinkButton" href="https://localhost:44352/Default" CssClass="btn btn-primary btn-sm">Daily</asp:LinkButton>
     <asp:LinkButton runat="server" id="LinkButton2" href="https://localhost:44352/Weekly" CssClass="btn btn-primary btn-sm">Weekly</asp:LinkButton>  
        <asp:LinkButton runat="server" id="LinkButton1" href="https://localhost:44352/Monthly" CssClass="btn btn-primary btn-sm">Monthly</asp:LinkButton>

</asp:Content>
