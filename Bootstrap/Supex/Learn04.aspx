<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn04.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using banner</title>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="frmMain" runat="server">
        <section class="container">
            <%--header--%>
            <div class="content row">
                <%--Column Large 12 of 12--%>
                <div class="col-lg-12">
                    <header class="clearfix">
                        <section id="banner">
                            <a href="default.aspx"><img src="Images/finalbaner.jpg" alt="Baner of the supex.ir" width="100%" /></a>
                        </section>
                    </header>
                </div>
            </div>
            <%--header--%>
            <div class="content row">
                <section class="main col col-lg-8">
                    My name is Mehrdad Naderi and I am 24 years old. 
                    My name is Mehrdad Naderi and I am 24 years old. 
                    My name is Mehrdad Naderi and I am 24 years old. 
                    My name is Mehrdad Naderi and I am 24 years old.
                    My name is Mehrdad Naderi and I am 24 years old.
                    My name is Mehrdad Naderi and I am 24 years old.
                    My name is Mehrdad Naderi and I am 24 years old.
                    My name is Mehrdad Naderi and I am 24 years old.
                    My name is Mehrdad Naderi and I am 24 years old.
                </section>
                <section class="sidebar col col-lg-4">
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu. 
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu. 
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu. 
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu. 
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu. 
                    Sidebar is for menu. Sidebar is for menu. Sidebar is for menu.
                </section>
            </div>
        </section>

    </form>
    <script src="_/js/bootstrap.js"></script>
</body>
</html>
