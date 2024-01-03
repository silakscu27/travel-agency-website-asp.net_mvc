<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>Tourist - Travel Agency HTML Template</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="keywords" content="">
    <meta name="description" content="">

    <!-- CSS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/owl.carousel@2.3.4/dist/assets/owl.carousel.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/owl.carousel@2.3.4/dist/assets/owl.theme.default.min.css">

    <!-- JS -->
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/owl.carousel@2.3.4/dist/owl.carousel.min.js"></script>

    <!-- Favicon 
    <link rel="icon" href="~/img/favicon.ico"> -->

    <!-- Google Web Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Heebo:wght@400;500;600&family=Nunito:wght@600;700;800&display=swap" rel="stylesheet">

    <!-- Icon Font Stylesheet -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css">

    <!-- Libraries Stylesheet -->
    <link rel="stylesheet" href="~/lib/animate/animate.min.css">
    <link rel="stylesheet" href="~/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css">

    <!-- Customized Bootstrap Stylesheet -->
    <link rel="stylesheet" href="~/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/css/style.css">

    <!-- Additional Stylesheets -->
    <link rel="stylesheet" href="~/lib/animate/animate.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.carousel.min.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.carousel.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.theme.default.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.theme.default.min.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.theme.green.css">
    <link rel="stylesheet" href="~/lib/owlcarousel/assets/owl.theme.green.min.css">
    <link rel="stylesheet" href="~/lib/tempusdominus/css/tempusdominus-bootstrap-4.css">

    <!-- JavaScript Libraries -->
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="~/lib/wow/wow.min.js"></script>
    <script src="~/lib/easing/easing.min.js"></script>
    <script src="~/lib/waypoints/waypoints.min.js"></script>
    <script src="~/lib/owlcarousel/owl.carousel.min.js"></script>
    <script src="~/lib/tempusdominus/js/moment.min.js"></script>
    <script src="~/lib/tempusdominus/js/moment-timezone.min.js"></script>
    <script src="~/lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js"></script>

    <!-- Your Main JavaScript File -->
    <script src="~/js/main.js"></script>

</head>

<body>
    @Html.Partial("_SpinnerPartial") 
    @Html.Partial("_TopbarPartial")
    @Html.Partial("_NavbarPartial")

    <div>
        @RenderBody()
    </div>

    @Html.Partial("_FooterPartial")

    <!-- Back to Top -->
    <a href="#" class="btn btn-lg btn-primary btn-lg-square back-to-top"><i class="bi bi-arrow-up"></i></a>

</body>
</html>