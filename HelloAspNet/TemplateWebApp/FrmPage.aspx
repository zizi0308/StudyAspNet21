﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPage.aspx.cs" Inherits="TemplateWebApp.FrmPage" %>

<%@ Register Src="~/Navigator.ascx" TagPrefix="nav" TagName="Navigator" %>
<%@ Register Src="~/Copyright.ascx" TagPrefix="cpy" TagName="Copyright" %>
<%@ Register Src="~/Category.ascx" TagPrefix="cat" TagName="Category" %>
<%@ Register Src="~/Catalog.ascx" TagPrefix="ct1" TagName="Catalog" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>웹사이트 뼈대</title>
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <style>
        div {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="background-color: aquamarine;">
                    <nav:Navigator runat="server" ID="UcNavMain" />
                    네비게이터
                </div>
            </div>
            <div class="row" style="height: 200px;">
                <div class="col-md-4" style="background-color: antiquewhite;">
                    <cat:Category runat="server" />
                    카테고리
                </div>
                <div class="col-md-8" style="background-color: burlywood;">
                    <ct1:Catalog runat="server" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="background-color: cadetblue;">
                    <cpy:Copyright runat="server" ID="UcCopyright" />
                    카피라이트
                </div>
            </div>
        </div>
    </form>
</body>
</html>
