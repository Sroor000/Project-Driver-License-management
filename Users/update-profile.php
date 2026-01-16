<?php
session_start();
require "../includes/db.php";

if (!isset($_SESSION['user_id'])) {
    header("Location: ../Users/login_page.php");
    exit();
}

if (isset($_POST['update-profile'])) {

    $user_id = $_SESSION['user_id'];
    $username = $_POST['username'];
    $email = $_POST['email'];

    // لو في صورة جديدة
    if (!empty($_FILES['image']['name'])) {

        $image_name = time() . "_" . $_FILES['image']['name'];
        $tmp = $_FILES['image']['tmp_name'];
        $path = "../uploads/" . $image_name;

        move_uploaded_file($tmp, $path);

        $sql = "UPDATE Users 
                SET Username = ?, Email = ?, ImagePath = ?
                WHERE UserID = ?";
        $stmt = mysqli_prepare($conn, $sql);
        mysqli_stmt_bind_param($stmt, "sssi",
            $username,
            $email,
            $path,
            $user_id
        );

    } else {

        $sql = "UPDATE Users 
                SET Username = ?, Email = ?
                WHERE UserID = ?";
        $stmt = mysqli_prepare($conn, $sql);
        mysqli_stmt_bind_param($stmt, "ssi",
            $username,
            $email,
            $user_id
        );
    }

    mysqli_stmt_execute($stmt);

    // تحديث السيشن عشان الناف بار
    $_SESSION['username'] = $username;

    header("Location: ../Pages/Profile.php?success=1");
    exit();
}
