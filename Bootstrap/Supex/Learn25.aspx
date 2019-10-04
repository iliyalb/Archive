<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn25.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using a scrollspy component</title>
    <%-- The main part is the scrollspy, Let's go and create it --%>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
</head>
<body id="Home" data-spy="scroll" data-target=".scrollspy">
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
                                    <a href="#" class="dropdown-toggle" id="dropdownMenu" data-toggle="dropdown">Schedule
                                    <span class="caret"></span></a>
                                    <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu">
                                        <li><a tabindex="-1" href="#">All Schedules 1</a></li>
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

                        <section id="modal" class="modal fade">
                            <div class="modal-body">
                                <img id="modalimage" src="" alt="Modal Photo" />
                            </div>
                        </section>
                    </header>
                </div>
            </div>
            <div class="content row">
                <section class="main col col-lg-8">
                    <%-- Starting here --%>
                    <section class="mylist">
                        <%-- Just using row class is important --%>
                        <div id="myindex" class="row">
                            <%-- layout area 3 of the 12 columns and hide this on small devices --%>
                            <section class="scrollspy clearfix col col-lg-3 ">
                                <%-- affix, fix positions on the screen done with bootstrap --%>
                                <ul class="nav nav-list affix">
                                    <%-- href here should be match by item's id --%>
                                    <li><a href="#item1"><span class="glyphicon glyphicon-user"></span> Item 1</a></li>
                                    <li><a href="#item2"><span class="glyphicon glyphicon-user"></span> Item 2</a></li>
                                    <li><a href="#item3"><span class="glyphicon glyphicon-user"></span> Item 3</a></li>
                                    <li><a href="#item4"><span class="glyphicon glyphicon-user"></span> Item 4</a></li>
                                    <li><a href="#item5"><span class="glyphicon glyphicon-user"></span> Item 5</a></li>
                                </ul>
                            </section>

                            <%-- informations about each item --%>
                            <section class="mylistinfo col col-lg-9">
                                <%-- Item 1 --%>
                                <%-- id here should match by href in the top section --%>
                                <article id="item1" class="media">
                                    <h2>Item 1</h2>
                                    <img class="pull-left img-rounded" src="Images/smallsupexlogo.jpg" />
                                    <div class="media-body">
                                        <p>This is Item 1.</p>
                                        <p>This is Item 1.</p>
                                        <p>This is Item 1.</p>
                                        <p>This is Item 1.</p>
                                        <p>This is Item 1.</p>
                                    </div>
                                </article>
                                <%-- /Item 1 --%>

                                <%-- Item 2 --%>
                                <article id="item2" class="media">
                                    <h2>Item 2</h2>
                                    <img class="pull-left img-rounded" src="Images/smallsupexlogo2.jpg" />
                                    <div class="media-body">
                                        <p>This is Item 2.</p>
                                        <p>This is Item 2.</p>
                                        <p>This is Item 2.</p>
                                        <p>This is Item 2.</p>
                                        <p>This is Item 2.</p>
                                    </div>
                                </article>
                                <%-- /Item 2 --%>

                                <%-- Item 3 --%>
                                <article id="item3" class="media">
                                    <h2>Item 3</h2>
                                    <img class="pull-left img-rounded" src="Images/smallsupexlogo3.jpg" />
                                    <div class="media-body">
                                        <p>This is Item 3.</p>
                                        <p>This is Item 3.</p>
                                        <p>This is Item 3.</p>
                                        <p>This is Item 3.</p>
                                        <p>This is Item 3.</p>
                                    </div>
                                </article>
                                <%-- /Item 3 --%>

                                <%-- Item 4 --%>
                                <article id="item4" class="media">
                                    <h2>Item 4</h2>
                                    <img class="pull-left img-rounded" src="Images/smallsupexlogo.jpg" />
                                    <div class="media-body">
                                        <p>This is Item 4.</p>
                                        <p>This is Item 4.</p>
                                        <p>This is Item 4.</p>
                                        <p>This is Item 4.</p>
                                        <p>This is Item 4.</p>
                                    </div>
                                </article>
                                <%-- /Item 4 --%>

                                <%-- Item 5 --%>
                                <article id="Article1" class="media">
                                    <h2>Item 5</h2>
                                    <img class="pull-left img-rounded" src="Images/smallsupexlogo2.jpg" />
                                    <div class="media-body">
                                        <p>This is Item 5.</p>
                                        <p>This is Item 5.</p>
                                        <p>This is Item 5.</p>
                                        <p>This is Item 5.</p>
                                        <p>This is Item 5.</p>
                                    </div>
                                </article>
                                <%-- /Item 5 --%>
                            </section>
                        </div>
                    </section>
                    <%-- Ends here --%>
                </section>
                <section class="sidebar col col-lg-4">
                    <aside class="register">
                        <h2>Registeration info</h2>
                        <p>
                            Fill <a href="register.aspx">our registeration form</a> and we'll
                        let you know when we begin the registeration process. Then, get ready
                        for the best conference in contemporary art.
                        <a href="register.aspx" class="btn btn-danger">Register now</a>
                        </p>
                    </aside>
                    <aside class="supexphotos">
                        <h2>Supex Logos</h2>
                        <p>Do you know supex institute? Checkout some photos from that.</p>
                        <div class="modalphotos photogrid clearfix">
                            <img src="Images/smallsupexlogo.jpg" alt="Small Supex Logo 1" />
                            <img src="Images/smallsupexlogo2.jpg" alt="Small Supex Logo 2" />
                            <img src="Images/smallsupexlogo3.jpg" alt="Small Supex Logo 3" />
                        </div>
                    </aside>
                </section>
            </div>
            <section class="container">
                <footer class="row">
                    <nav class="col-lg-12">
                        <ul class="breadcrumb">
                            <li><a href="default.aspx">About the SUPEX</a></li>
                            <li><a href="default.aspx">Privacy Policy</a></li>
                            <li><a href="default.aspx">SUPEX institute website</a></li>
                        </ul>
                    </nav>
                </footer>
            </section>
        </section>

    </form>
    <script src="_/js/bootstrap.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#Home a:contains('Home')").parent().addClass('active');
            $("#Schedule a:contains('Schedule')").parent().addClass('active');
            $("#Register a:contains('Register')").parent().addClass('active');
            $("#About a:contains('About')").parent().addClass('active');
            $("#Contact a:contains('Contact')").parent().addClass('active');

            $('ul.nav li.dropdown').hover(function () {
                $('.dropdown-menu', this).fadeIn();
            }, function () {
                $('.dropdown-menu', this).fadeOut('fast');
            });

            $("[data-toggle='tooltip']").tooltip({ animation: true });

            $('.modalphotos img').on('click', function () {
                $('#modal').modal({
                    show: true,
                })

                var mysrc = this.src.substr(5, this.src.length - 1);
                $('#modalimage').attr('src', mysrc);

                $('#modalimage').on('click', function () {
                    $('#modal').modal('hide');
                })
            });
        });
    </script>
</body>
</html>
