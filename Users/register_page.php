<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Register</title>

    <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>
        body {
            background: linear-gradient(to bottom right, #f3e8ff, #baabfdff);
            min-height: 100vh;
        }

        .card-custom {
            max-width: 420px;
            padding: 30px;
            border-radius: 20px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            background: white;
        }

        .btn-blue {
            background-color: #472fa0ff;
            color: white;
            border-radius: 25px;
            padding: 12px;
            font-size: 17px;
        }

        .btn-blue:hover {
            background-color: #371586ff;
        }

        .form-control {
            border-radius: 25px;
            padding: 12px;
        }

        .title {
            font-weight: 700;
            color: #362ea0ff;
        }

        a {
            text-decoration: none;
            color: #362ea0ff;
        }

        .form-label {
            font-weight: 600;
        }
    </style>

</head>
<body class="d-flex justify-content-center align-items-center p-3">

<div class="card-custom w-100">

    <h3 class="text-center mb-2 title">Create Account</h3>
    <p class="text-center text-muted mb-3" style="font-size:14px;">Join us today</p>

    <?php
    if (isset($_SESSION["error"])) {
        echo "<p class='text-danger text-center'>".$_SESSION["error"]."</p>";
        unset($_SESSION["error"]);
    }
    if (isset($_SESSION["success"])) {
        echo "<p class='text-success text-center'>".$_SESSION["success"]."</p>";
        unset($_SESSION["success"]);
    }
    ?>

    <form action="Register.php" method="POST">

        <label class="form-label mb-1">Username</label>
        <input type="text" name="username" class="form-control mb-3" placeholder="Enter username" required>

        <label class="form-label mb-1">Email</label>
        <input type="email" name="email" class="form-control mb-3" placeholder="Enter email" required>

        <label class="form-label mb-1">Password</label>
        <input type="password" name="password" class="form-control mb-4" placeholder="Enter password" required>

        <button type="submit" class="btn btn-blue w-100">Sign Up</button>
    </form>

    <p class="text-center mt-3">
        Already have an account?  
        <a href="login_page.php" class="fw-bold">Login</a>
    </p>

</div>

</body>
</html>