<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateStudent.aspx.cs" Inherits="CRUDDemo.CreateStudent" %>

<asp:Content ID="xcv" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h3>Insert Student Details</h3>
        <br />
        <br />
        <table width="350">
            <tr>
                <td>
                    <h4>ID</h4>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <h4>Name </h4>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
         <asp:Button  class="btn btn-default" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" /><asp:Label ID="Label1" runat="server" Text="" ForeColor="Green"></asp:Label>

    </div>

</asp:Content>
