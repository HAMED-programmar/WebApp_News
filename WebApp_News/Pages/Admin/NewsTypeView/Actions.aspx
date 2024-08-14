<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MastrPage/ActionMastrePage.Master" AutoEventWireup="true" CodeBehind="Actions.aspx.cs" Inherits="WebApp_News.Pages.Admin.NewsTypeView.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <script>
    function ClosePage() {
        window.close();
        window.opener.location.reload();
    }
     </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />


   <div class="panel panel-primary">  
   <div class="panel-heading">نوع خبر</div>
   <div class="panel-body">
          نوع خبر
   <br />
   <input  type="text"  class="form-control" runat="server" id="TxtTitle"/>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtTitle" ErrorMessage="لطفا نام را وراد نمایید"></asp:RequiredFieldValidator>
   <br />
       <asp:Button ID="btnNew" CssClass="btn btn-success" runat="server" Text="جدید" OnClick="btnNew_Click1" />
       <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-info" Text="ویرایش" OnClick="btnEdit_Click" />
       <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="حذف" OnClick="btnDelete_Click" />
       <a onclick="ClosePage()" class="btn btn-warning">برگشت</a>
   </div>
  </div>     

</asp:Content>
