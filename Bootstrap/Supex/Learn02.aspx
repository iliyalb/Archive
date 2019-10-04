<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn02.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Design the base of the layout</title>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="frmMain" runat="server">
        <section class="container">
            <div class="content row">
                <section class="main col col-lg-8">

                </section><%--Main section has 8 width from 12 columns--%>
                <section class="sidebar col col-lg-4">

                </section><%--Sidebar has 4 width from 12 columns--%>
            </div><%--content is my custom class, but row is for any row  in a layout--%>
        </section><%-- All layouts should wrap in a section which has a container class. --%>

    </form>
    <script src="_/js/bootstrap.js"></script>
</body>
</html>
