<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn24-target.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activate schedule tabls</title>
    <%--Go to the javascript--%>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
</head>
<body id="Home">
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
                <div id="myCarousel" class="carousel slide">
                    <ol class="carousel-indicators">
                        <li data-target="#myCarousel" data-slide-to="0"></li>
                        <li data-target="#myCarousel" data-slide-to="1"></li>
                        <li data-target="#myCarousel" data-slide-to="2" class="active"></li>
                    </ol>


                    <section class="carousel-inner">
                        <div class="item">
                            <img src="Images/supexlogo.jpg" alt="Supex logo 1" width="100%" />
                        </div>
                        <div class="item">
                            <img src="Images/supexlogo2.jpg" alt="Supex logo 2" width="100%" />
                        </div>
                        <div class="active item">
                            <img src="Images/supexlogo3.jpg" alt="Supex logo 3" width="100%" />
                        </div>
                    </section>
                    <a href="#myCarousel" class="left carousel-control" data-slide="prev"><span class="glyphicon glyphicon-chevron-left"></span></a>
                    <a href="#myCarousel" class="right carousel-control" data-slide="next"><span class="glyphicon glyphicon-chevron-right"></span></a>
                </div>
            </div>
            <div class="content row">
                <section class="main col col-lg-8">
                    <article class="schedule">
                        <h1>Schedule</h1>
                        <p>This is the schedule timetable for supex institute.</p>
                        <div class="tabbable tabs">
                            <ul class="nav nav-tabs">
                                <li class="active"><a href="#monday" data-toggle="tab">Monday</a></li>
                                <li><a href="#tuesday" data-toggle="tab">Tuesday</a></li>
                                <li><a href="#wednesday" data-toggle="tab">Wednesday</a></li>
                            </ul>
                        </div>
                        <section class="tab-content">
                            <div class="tab-pane active" id="monday">
                                <p>Monday text goes here...</p>
                            </div>

                            <div class="tab-pane" id="tuesday">
                                <p>Tuesday text goes here...</p>
                            </div>

                            <div class="tab-pane" id="wednesday">
                                <p>Wednesday text goes here...</p>
                            </div>
                        </section>
                    </article>
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
            //BEGIN

            //(1) get location
            var hash = window.location.hash;
            //(2) use location to show tab in your anchor href
            //show is a bootstrap function to showup the relations
            hash && $('ul.nav a[href="' + hash + '"]').tab('show');

            //END




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
