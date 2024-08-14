<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MastrPage/AdminMastrpage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApp_News.Pages.Admin.NewsTypeView.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


       <link href="../../../Content/bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet" />         
    <script src="../../../Content/JS/jquery-1.11.3.min.js"></script>
    <script src="../../../Content/bootstrap-3.3.7-dist/js/bootstrap.min.js"></script>        
    <link href="../../../Content/JDataTable/media/css/dataTables.bootstrap.min.css" rel="stylesheet" />
    <script src="../../../Content/JDataTable/media/js/jquery.dataTables.min.js"></script>
    <script src="../../../Content/JDataTable/media/js/dataTables.bootstrap.min.js"></script>
  
    
      <script>
        $(document).ready(function () {
            $('#MyGridView').DataTable();
        });

          function OpenPage(ID) {
              window.open("Actions.aspx?ID=" + ID, "mypage", "width=600,height=500,left=400");
          }
      </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <a onclick="OpenPage(-1)" class="btn btn-danger">
        جدید
    </a>
    <br />
    <br />

     <table id="MyGridView" class="table table-striped table-bordered" >
        <thead>
            <tr>
                <th>ردیف</th>
                <th>نوع خبر</th>                  
                <th>ویرایش</th>
            </tr>
        </thead>
      
        <tbody id="BodyTable" runat="server">
           
             
        </tbody>
    </table>



</asp:Content>
