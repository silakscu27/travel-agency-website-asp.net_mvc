<!-- Navbar -->
<div class="container-fluid position-relative p-0">
    <nav class="navbar navbar-expand-lg navbar-light px-4 px-lg-5 py-3 py-lg-0">
        <a href="@Url.Action("Index", "Home")" class="navbar-brand p-0">
            <h1 class="text-primary m-0"><i class="fa fa-map-marker-alt me-3"></i>Tourist</h1>
          
        </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
            <span class="fa fa-bars"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarCollapse">
            <div class="navbar-nav ms-auto py-0">
                @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.class = "nav-item nav-link"})
                @Html.ActionLink("About", "About", "Home", Nothing, New With {.class = "nav-item nav-link"})
                @Html.ActionLink("Services", "Service", "Home", Nothing, New With {.class = "nav-item nav-link"})
                @Html.ActionLink("Packages", "Package", "Home", Nothing, New With {.class = "nav-item nav-link"})

                <div class="nav-item dropdown">
                    <a href="#" class="nav-link dropdown-toggle" id="pagesDropdown" role="button" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Pages</a>
                    <div class="dropdown-menu m-0" aria-labelledby="pagesDropdown">
                        @Html.ActionLink("Destination", "Destination", "Pages", Nothing, New With {.class = "dropdown-item"})
                        @Html.ActionLink("Booking", "Booking", "Pages", Nothing, New With {.class = "dropdown-item"})
                        @Html.ActionLink("Travel Guides", "Team", "Pages", Nothing, New With {.class = "dropdown-item"})
                        @Html.ActionLink("Tours", "Testimonial", "Pages", Nothing, New With {.class = "dropdown-item"})
                    </div>
                </div>

                <a class="btn btn-primary rounded-pill py-2 px-4" href="javascript:void(0);" onclick="redirectToRegister()" style="font-size: 14px; display: inline-block; margin: 25px;">Register</a>

                <script>
                    function redirectToRegister() {
                        window.location.href = '@Url.Action("Register", "Home")';
                    }
                </script>

                <!--
        </div>
        <a href="" class="btn btn-primary rounded-pill py-2 px-4">Register</a>
    </div>
            -->

</nav>

</div>
<!-- Navbar -->
