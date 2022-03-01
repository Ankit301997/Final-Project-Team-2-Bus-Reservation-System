<%@ Page Title="" Language="C#" MasterPageFile="~/BusBookingMaster.Master" AutoEventWireup="true" CodeBehind="BusBookingSearchDetails.aspx.cs" Inherits="BusBookingProject.BusBookingSearchDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            /*background-image: url('https://metalengg.com/wp-content/uploads/2019/05/404-error-page-templates-1.jpg');
            background-repeat: no-repeat;*/
            background-color: thistle;
            height: 600px;
        }
        td:nth-child(odd),th:nth-child(odd),td:nth-child(even),th:nth-child(even)
        {
            background-color:#D6EEEE;
        }
        th:nth-child(odd),th:nth-child(even)
        {
            background-color:orange;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        body {
            background-color: thistle;
            height: 600px;
        }
        td:nth-child(odd),th:nth-child(odd),td:nth-child(even),th:nth-child(even)
        {
            background-color:#D6EEEE;
        }
        th:nth-child(odd),th:nth-child(even)
        {
            background-color:orange;
        }
        </style>

    <div class="container" style="margin-top:8%">
        <asp:HyperLink ID="hlinkSearch" runat="server" NavigateUrl="~/Home.aspx" style="width:10%;align-content:center" class="btn btn-info btn-block">Search Again</asp:HyperLink>
        <asp:GridView ID="gvBusDetails" EmptyDataText="No Record Found...." runat="server" AutoGenerateColumns="False" CssClass="table table-hover table-bordered" OnRowDataBound="gvBusDetails_RowDataBound">
                    <Columns>
                       <asp:TemplateField HeaderText="Bus Name">
                           <ItemTemplate>
                               <asp:Label ID="lblBusName" runat="server" Text='<%# Eval("BusName") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Departure Time">
                           <ItemTemplate>
                               <asp:Label ID="lbldeparture" runat="server" Text='<%# Eval("DepartureTime") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                         <asp:TemplateField HeaderText="Arrival Time">
                           <ItemTemplate>
                               <asp:Label ID="lblArrival" runat="server" Text='<%# Eval("ArivalTime") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Available Seats">
                           <ItemTemplate>
                               <asp:Label ID="lblAvailableSeats" runat="server" Text='<%# Eval("AvailableSeats") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fare">
                           <ItemTemplate>
                               <asp:Label ID="lblFare" runat="server" Text='<%# Eval("Fare") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:HyperLink ID="hplnkSelect" runat="server" ToolTip="Select Bus">Select Bus</asp:HyperLink>
                                <asp:HiddenField ID="hdnBusID" runat="server" Value='<%# Eval("BusId") %>' />
                                 <asp:HiddenField ID="hdnSeatRow" runat="server" Value='<%# Eval("SeatRow") %>' />
                                 <asp:HiddenField ID="hdnSeatColumn" runat="server" Value='<%# Eval("SeatColumn") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
    </div>
</asp:Content>
