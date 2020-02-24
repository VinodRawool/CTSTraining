<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="CRUDDemo.Student" %>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <h3> Students</h3>
        <br />
        
        <asp:GridView ID="GridView1" runat="server" Width="350"></asp:GridView>
        <br />
        
        <a class="btn btn-default" href="CreateStudent.aspx">Add Student</a><a class="btn btn-default" href="UpdateStudent.aspx"> Update Student</a><a class="btn btn-default" href="DeleteStudent.aspx">Delete Student</a>

        
     </div>
        <div class="jumbotron">
        <h3> Faculty</h3>
         <br />
        <asp:GridView ID="GridView2" runat="server" Width="350"></asp:GridView>
         <br />
        
        <a class="btn btn-default" href="CreateFaculty.aspx">Add Faculty</a> <a class="btn btn-default" href="CreateStudent.aspx">Update Faculty</a> <a class="btn btn-default" href="CreateStudent.aspx">Delete Faculty</a>


        
      </div>
    <div class="jumbotron">
        <h3> Course</h3>
         <br />
        <asp:GridView ID="GridView3" runat="server" Width="350"></asp:GridView>
         <br />
        
       <a class="btn btn-default" href="CreateStudent.aspx">Add Course</a> <a class="btn btn-default" href="CreateStudent.aspx">Update Course</a> <a class="btn btn-default" href="CreateStudent.aspx">Delete Course</a>
         
   </div>



</asp:Content>
