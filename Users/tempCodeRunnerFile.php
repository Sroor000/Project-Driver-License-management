<?php
$query = "SELECT * FROM Users WHERE Email='$email'";
    $result = mysqli_query($conn, $query);