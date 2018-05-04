<%@ Page Title="" Language="C#" MasterPageFile="~/theme.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="factorySystem.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .box{
            width:400px;
            height:200px;
            padding:5%;
            margin:10px;
            background-color:#206f9c;
            color:white;
        }
        .box_head{
            text-align:center;
            font-family:Tahoma;
            letter-spacing:3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4 col-sm-6 col-xs-12 box">
            <p class="box_head">Cars</p>
            <p> Content </p>
        </div>
        <div class="col-md-4 col-sm-6 col-xs-12 box">
            <p class="box_head">Cars</p>
            
        </div>
        <div class="col-md-4 col-sm-6 col-xs-12 box">
            <p class="box_head">Cars</p>
            <p> Content </p>
        </div>
    </div>
</asp:Content>
