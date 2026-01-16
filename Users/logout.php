<?php
session_start();

// حذف جميع بيانات الجلسة (Session)
session_unset();

// تدمير الجلسة بالكامل
session_destroy();

// إعادة التوجيه للـ Login page مع رسالة نجاح
session_start();
$_SESSION['success'] = "You have been logged out successfully.";
header("Location: ../Pages/home_page.php");
exit();
?>