<%@ Page Title="" Language="C#" MasterPageFile="~/BusBookingMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BusBookingProject.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        body {
            background-image: url('https://wallpaperaccess.com/full/1583366.jpg');
            background-color: white;
             /*background: #77A1D3;  /* fallback for old browsers */
            /*background: -webkit-linear-gradient(to right, #E684AE, #79CBCA, #77A1D3);  /* Chrome 10-25, Safari 5.1-6 */
            /*background: linear-gradient(to right, #E684AE, #79CBCA, #77A1D3); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
             height: 600px;
        }
        </style>  
    
    <div class="container" style="margin-top:4%">
          <div style="margin-top:2%; width:80%">
                <div class="panel panel-default">
             <div class="">
                         <div class=" panel-title"> 
                             <style >
                                 h3 {text-align: center;}
                             </style>
                                 <h3 style="font-size:220%;">  Welcome to Team2 Travels </h3>

                         </div>
                     </div>
                    </div></div>
        <div class="row">
            <div class="col-lg-12">
                <asp:Image ID="Image1" ImageAlign="AbsMiddle" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCbyMNwhfXMOGZyBasD-u1KE-FLpm8_SXJEg&usqp=CAU" style="width:80%;height:50%" runat="server"/>
            </div>
            <div class="col-lg-12" style="margin-top:2%">
                <div class="panel panel-default">
                    <div class="panel-heading">
                         <div class=" panel-title">
                                 
                        <!-- <h3> Introduction to Online Bus Booking </h3>-->
                         </div>
                     </div>
                    <div class="panel-body">
                        <p style="font-size:medium">
                            Online Bus Booking is the world's largest online bus ticket booking service trusted by over 25 million happy customers globally. 
                            This offers bus ticket booking through its website for all major routes.
                        </p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
