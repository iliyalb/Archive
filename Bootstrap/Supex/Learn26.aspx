<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Learn26.aspx.cs" Inherits="Learn01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enhancing responsive form layouts</title>
    <link href="_/css/bootstrap.css" rel="stylesheet" />
    <%-- One of the approaches in the new version of bootstrap is "Mobile First"
            that means making sure that everything look great at mobiles.    
    --%>
    <%-- I wanna a horizontal form side by side and in mobile size such as fieldset --%>
</head>
<body id="Home">
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
                    <%-- Registeration Form --%>
                    <article class="registrationform">
                        <h2>Registration form</h2>
                        <p>We're not currently taking registrations for the Roux Academy Conference, but if you want to be placed into our mailing list for more information, please complete the form below.</p>

                        <%-- To have a horizontal form use form-horizontal class --%>
                        <form class="registration form-horizontal" action="#">

                            <fieldset id="personalinfo">
                                <legend>Personal Info</legend>

                                <section class="row">
                                    <label class="col col-lg-4 control-label" for="myname">Name</label>
                                    <div class="controls">
                                        <input class="col col-lg-8" type="text" name="myname" id="myname" autofocus="autofocus" placeholder="Last, First" required="required">
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->

                                <section class="row">
                                    <label class="col col-lg-4 control-label" for="companyname">Company Name</label>
                                    <div class="controls">
                                        <input class="col col-lg-8" type="text" name="companybname" id="companyname" />
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->

                                <section class="row">
                                    <label class="col col-lg-4 control-label" for="myemail">Email</label>
                                    <div class="controls">
                                        <input class="col col-lg-8" type="email" name="myemail" id="myemail" required="required" autocomplete="off" />
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->

                            </fieldset>
                            <!-- personal info -->

                            <fieldset id="otherinfo">
                                <legend>Other Info</legend>

                                <section class="row">
                                    <label class="col col-lg-4 control-label">Request Type</label>
                                    <div class="controls col col-lg-8">
                                        <label class="radio">
                                            <input type="radio" name="requesttype" value="question" />
                                            Question
					
                                        </label>
                                        <label class="radio">
                                            <input type="radio" name="requesttype" value="comment" />
                                            Comment
					
                                        </label>
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->


                                <section class="row">
                                    <label class="col col-lg-4 control-label">Subscribe</label>
                                    <div class="controls col col-lg-8">
                                        <label class="checkbox">
                                            <input type="checkbox" id="subscribe" name="subscribe" checked value="yes" />
                                            Would you like to subscribe to our e-mail list?
				
                                        </label>
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->

                                <section class="row">
                                    <label class="col col-lg-4 control-label" for="reference">How did you hear about the Roux Academy Conference?</label>
                                    <div class="controls col col-lg-8">
                                        <select name="reference" id="reference">
                                            <option>Choose...</option>
                                            <option value="friend">A friend</option>
                                            <option value="facebook">Facebook</option>
                                            <option value="twitter">Twitter</option>
                                        </select>
                                    </div>
                                    <!-- controls -->
                                </section>
                                <!-- row -->

                            </fieldset>
                            <button class="btn" type="submit">Submit</button>
                        </form>
                    </article>
                    <%-- /Registeration Form --%>
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
