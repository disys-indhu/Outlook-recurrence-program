<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Weekly.aspx.cs" Inherits="RecurrenceProgram.Weekly" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h3>Weekly Schedule
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
        <b>
            <h4>
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Recur  every    "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="35px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Week(s)  on "></asp:Label></b>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Sunday" value="0" />
        <br />
        &nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Monday" value="1"/>
        <br />
        &nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Tuesday" value="2" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Wednesday" value="3"/>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Thursday" value="4"/>
        <br />
        <asp:CheckBox ID="CheckBox6" runat="server" Text="Friday" value="5"/>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox7" runat="server" Text="Saturday" value="6"/>
        <br />
        
        <br />
        
        
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="submit" />
        <br />
        <br />
        <p>
        <asp:Label ID="Label3" runat="server" Text="Next meeting occurs on"></asp:Label>
            </p>
        
        <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
        <br />
        </h4>
        <asp:LinkButton runat="server" id="SomeLinkButton" href="https://localhost:44352/Default" CssClass="btn btn-primary btn-sm">Daily</asp:LinkButton>
        <asp:LinkButton runat="server" id="LinkButton1" href="https://localhost:44352/Monthly" CssClass="btn btn-primary btn-sm">Monthly</asp:LinkButton>
       <asp:LinkButton runat="server" id="LinkButton2" href="https://localhost:44352/Yearly" CssClass="btn btn-primary btn-sm">Yearly</asp:LinkButton>
        </center>
    
</asp:Content>
