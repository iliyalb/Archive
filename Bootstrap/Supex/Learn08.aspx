<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn08.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Creating a dropdown(1)</title>
    <%--Problem is that you should click on link to dropdown--%>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="frmMain" runat="server">
        <section class="container">
            <div class="content row">
                <div class="col-lg-12">
                    <header class="clearfix">
                        <section id="branding">
                            <a href="default.aspx">
                                <img src="Images/finalbaner.jpg" alt="Baner of the supex.ir" width="100%" /></a>
                        </section>
                        <section class="navbar">
                            <ul class="nav navbar-nav">
                                <li><a href="default.aspx">Home</a></li>
                                <li class="dropdown">
                                    <%--To use dropdown for every button,use class=dropdown-toggle and data-toggle=dropdown--%>
                                    <a href="#" class="dropdown-toggle" id="dropdownMenu" data-toggle="dropdown">Schedule
                                    <%--User caret to have a down arrow--%>
                                    <span class="caret"></span></a>
                                    <%--To have dropdown use ul with class=dropdown-menu, role is important for menu differences in devices
                                        aria-labelledby and tabindex are a part of the dropdown list
                                    --%>
                                    <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu">
                                        <li><a tabindex="-1" href="#">All Schedules 1</a></li>
                                        <%--Using divider for items divides between items--%>
                                        <li class="divider"></li>
                                        <li><a tabindex="-1" href="#">All Schedules 2</a></li>
                                        <li><a tabindex="-1" href="#">All Schedules 3</a></li>
                                        <li><a tabindex="-1" href="#">All Schedules 4</a></li>
                                        <li><a tabindex="-1" href="#">All Schedules 5</a></li>
                                        <li><a tabindex="-1" href="#">All Schedules 6</a></li>
                                    </ul>
                                </li>
                                <li><a href="default.aspx">Register</a></li>
                                <li><a href="default.aspx">About</a></li>
                                <li><a href="default.aspx">Contact</a></li>
                            </ul>
                        </section>
                    </header>
                </div>
            </div>
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
    <script src="js/bootstrap.js"></script>
</body>
</html>
