<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login</title>

    <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>

        /* ----- BACKGROUND ----- */
        body {
            background: linear-gradient(to bottom right, #f3e8ff, #baabfdff);
            min-height: 100vh;
            width: 100%;
            overflow-x: hidden;
        }

        /* ----- CARD ----- */
        .login-card {
            background: white;
            padding: 35px;
            border-radius: 20px;
            max-width: 420px;
            width: 100%;
            box-shadow: 0 0 25px rgba(0,0,0,0.1);
        }

        .btn-login {
            background: #472fa0ff;
            border-radius: 25px;
            padding: 12px;
        }

        .btn-login:hover {
            background: #371586ff;
        }

        .form-control {
            border-radius: 12px;
            padding: 12px;
        }

        .form-label {
            font-weight: 600;
        }

        .login-title {
            font-weight: bold;
            font-size: 28px;
            color: #472d82ff;
        }

        /* ----- RESPONSIVE ----- */

        @media (max-width: 576px) {
            body {
                display: flex;
                justify-content: center;
                align-items: center;
                padding: 20px;
            }

            .login-card {
                margin: 0 !important;
            }
        }

    </style>

</head>

<body class="d-flex justify-content-center align-items-center">

<div class="login-card">

    <h2 class="login-title text-center mb-2">Welcome back</h2>
    <p class="text-center text-muted mb-3">Use your credentials below and login to your account</p>

    <?php
    if (isset($_SESSION["error"])) {
        echo "<p class='text-danger text-center mb-2'>".$_SESSION["error"]."</p>";
        unset($_SESSION["error"]);
    }

    if (isset($_SESSION["success"])) {
        echo "<p class='text-success text-center mb-2'>".$_SESSION["success"]."</p>";
        unset($_SESSION["success"]);
    }
    ?>

    <form action="Login.php" method="POST">

        <label class="form-label">Email</label>
        <input type="email" name="email" class="form-control" placeholder="Email here" required>

        <label class="form-label mt-3">Password</label>
        <input type="password" name="password" class="form-control" placeholder="Password here" required>

        <div class="d-flex flex-column flex-sm-row justify-content-between align-items-center mt-3 gap-2">

            <div class="form-check m-0">
                <input class="form-check-input" type="checkbox" id="remember">
                <label class="form-check-label" for="remember">Remember me</label>
            </div>

            <a href="#" class="text-decoration-none" style="color:#362ea0ff;">Forgot password?</a>
        </div>

        <button type="submit" class="btn btn-login text-white w-100 mt-4">Sign In</button>

    </form>

    <p class="signup-link text-center mt-3">
        Don't have an account?
        <a href="register_page.php" style="color:#362ea0ff; font-weight:bold;">Sign Up</a>
    </p>

</div>

</body>
</html>