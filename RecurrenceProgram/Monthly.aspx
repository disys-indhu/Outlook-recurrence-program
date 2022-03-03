<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Monthly.aspx.cs" Inherits="RecurrenceProgram.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <centre>
        <h3>
            Monthly Schedule
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
           
        </h3>
        
        <br />
    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />&nbsp;Day <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;of every
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> months
        <br />
    
    
    
    <br />
    <asp:CheckBox ID="CheckBox2" runat="server" />The&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem text="First" Value="1"></asp:ListItem>
            <asp:ListItem text="Second" Value="2"></asp:ListItem>
            <asp:ListItem text="Third" Value="3"></asp:ListItem>
            <asp:ListItem text="Fourth" Value="4"></asp:ListItem>
            <asp:ListItem text="Last" Value="5"></asp:ListItem>
    </asp:DropDownList>
    &nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Value="11">Monday</asp:ListItem>
            <asp:ListItem Value="12">Tuesday</asp:ListItem>
            <asp:ListItem value="13">Wednesday</asp:ListItem>
            <asp:ListItem Value="14">Thursday</asp:ListItem>
            <asp:ListItem Value="15">Friday</asp:ListItem>
            <asp:ListItem Value="16">Saturday</asp:ListItem>
            <asp:ListItem Value="17">Sunday</asp:ListItem>
    </asp:DropDownList> 
        &nbsp;of every&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;months<br />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:LinkButton runat="server" id="LinkButton1" href="https://localhost:44352/Default" CssClass="btn btn-primary btn-sm">Daily</asp:LinkButton>
        <asp:LinkButton runat="server" id="SomeLinkButton" href="https://localhost:44352/Weekly" CssClass="btn btn-primary btn-sm">Weekly</asp:LinkButton>    
        <asp:LinkButton runat="server" id="LinkButton2" href="https://localhost:44352/Yearly" CssClass="btn btn-primary btn-sm">Yearly</asp:LinkButton>
    </centre>

    
</asp:Content>
