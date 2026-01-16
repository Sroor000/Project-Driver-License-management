<?php
session_start();
require "../includes/db.php"; // عدّل المسار حسب مكان الملف

if ($_SERVER["REQUEST_METHOD"] === "POST") {

    $username = trim($_POST["username"]);
    $email    = trim($_POST["email"]);
    $password = trim($_POST["password"]);

    if (empty($username) || empty($email) || empty($password)) {
        $_SESSION['error'] = "Please fill in all fields.";
        header("Location: http://localhost/E-commerce/Users/Register.php");
        exit();
    }

    try {
        // Check if email already exists
        $emailCheck = "SELECT * FROM Users WHERE Email='$email'";
        $res = mysqli_query($conn, $emailCheck);
        if (!$res) throw new Exception("Error checking email: " . mysqli_error($conn));

        if (mysqli_num_rows($res) > 0) {
            throw new Exception("Email already exists.");
        }

        // Hash the password
        $hashedPassword = password_hash($password, PASSWORD_DEFAULT);

        // Insert new user
        $query = "INSERT INTO Users (Username, Email, Password, Access)
                  VALUES ('$username', '$email', '$hashedPassword', 0)";

        if (!mysqli_query($conn, $query)) {
            throw new Exception("Error inserting user: " . mysqli_error($conn));
        }

        $_SESSION['success'] = "Account created successfully. Please login.";
        header("Location: login_page.php");
        exit();

    } catch (Exception $e) {
        $_SESSION['error'] = $e->getMessage();
        header("Location: register_page.php");
        exit();
    }
}
?>