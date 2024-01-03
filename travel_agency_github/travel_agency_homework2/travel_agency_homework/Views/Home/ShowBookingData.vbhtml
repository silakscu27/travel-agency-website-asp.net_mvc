<!DOCTYPE html>
<html lang="en">
<body>
    <h2>Booking Data</h2>
    <p>Name: @Request.QueryString("name")</p>
    <p>Email: @Request.QueryString("email")</p>
    <p>Date & Time: @Request.QueryString("datetime")</p>
    <p>Destination: @Request.QueryString("destination")</p>
    <p>Special Request: @Request.QueryString("specialRequest")</p>
</body>
</html>
