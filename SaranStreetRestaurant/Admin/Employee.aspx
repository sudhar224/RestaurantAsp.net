<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="SaranStreetRestaurant.Admin.Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .panel-right {
            position: absolute;
            top: 20px;
            right: 20px;
            width: 300px; /* Adjust width as per your need */
            padding: 20px;
            background-color: lightgray;
            border-radius: 5px;
        }
        .panel-right label, .panel-right button {
            display: block;
            margin-bottom: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 63px;
            right: 7px;
            width: 776px; /* Adjust width as per your need */
            padding: 20px;
            background-color: lightgray;
            border-radius: 5px;
            height: 452px;
        }
        .auto-style3 {
            margin-top: 29px;
        }
    </style>

    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2">
       
        <table>
            
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Employee Name"></asp:Label></td>
                <td><asp:TextBox ID="txt_emp_name" runat="server" CssClass="text-box" Height="22px" Width="159px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddl_Gender" runat="server" CssClass="" Height="22px" Width="159px">
                        <asp:ListItem>Select Gender</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="DOB"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txt_DOB" runat="server" CssClass="text-box" Height="22px" Width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Mobile Number"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txt_mobile" runat="server" CssClass="text-box" Height="22px" Width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Address"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txt_address" runat="server" CssClass="text-box" Height="22px" Width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                </td>
            </tr>
        </table>
             <asp:GridView ID="GridView1" runat="server" CssClass="auto-style3" Height="236px" Width="784px">
             </asp:GridView>

     
       
    </asp:Panel>
</asp:Content>