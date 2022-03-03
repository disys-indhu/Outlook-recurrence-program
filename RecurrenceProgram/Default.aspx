<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RecurrenceProgram._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <div class="jumbotron">
        <center>
      <h3>  Daily Schedule
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" Height="200px" Width="220px" BackColor="White" BorderColor="#3366CC" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" BorderWidth="1px" >
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" Font-Bold="True" BorderWidth="1px" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
        </h3>
            <h4>
            <asp:CheckBox ID="CheckBox1" runat="server" text="Every"/>
            <asp:TextBox ID="TextBox2" runat="server" Width="75px"></asp:TextBox><b>day(s)</b>
        <br />
            
        
             
    
                <asp:CheckBox ID="CheckBox2" runat="server" text="Every weekdays"/>
                 
        </h4>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Next meeting occurs on"></asp:Label>
            
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            
        </p>
    </div>

        


    <div class="row">
    </div>
        <asp:LinkButton runat="server" id="SomeLinkButton" href="https://localhost:44352/Weekly" CssClass="btn btn-primary btn-sm">Weekly</asp:LinkButton>
        <asp:LinkButton runat="server" id="LinkButton1" href="https://localhost:44352/Monthly" CssClass="btn btn-primary btn-sm">Monthly</asp:LinkButton>
        <asp:LinkButton runat="server" id="LinkButton2" href="https://localhost:44352/Yearly" CssClass="btn btn-primary btn-sm">Yearly</asp:LinkButton>
    </center>
    
</asp:Content>


