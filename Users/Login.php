<?php
session_start();
require "../includes/db.php"; // عدّل المسار حسب مكان الملف

if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $email = trim($_POST["email"]);
    $password = trim($_POST["password"]);

    if (empty($email) || empty($password)) {
        $_SESSION['error'] = "Please fill in all fields.";
        header("Location: login_page.php");
        exit();
    }

    $query = "SELECT * FROM Users WHERE Email='$email'";
    $result = mysqli_query($conn, $query);

    if (mysqli_num_rows($result) === 1) {
        $user = mysqli_fetch_assoc($result);
       
        if ( password_verify($password, $user['Password']) || $password == $user['Password']) {
            // Login successful
      $_SESSION['user_id'] = $user['UserID']; // بدل User_ID
      $_SESSION['username'] = $user['Username'];
      $_SESSION['access'] = $user['Access'];

            header("Location: http://localhost/E-commerce/Pages/home_page.php"); 
                exit();
           
        } else {
            $_SESSION['error'] = "Incorrect password.";
            header("Location: login_page.php");
            exit();
        }
    } else {
        $_SESSION['error'] = "Email not found.";
        header("Location: login_page.php");
        exit();
    }
}