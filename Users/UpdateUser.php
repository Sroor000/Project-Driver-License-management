<?php
// 1. تفعيل ظهور الأخطاء (مهم جداً عشان لو فيه مشكلة تظهر بدل الشاشة البيضاء)
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

// 2. استدعاء الملفات (تأكد أن الأسماء مطابقة لملفاتك 100%)
require_once "UserDataAccess.php";
require_once "UserDTO.php";

// الدالة الخاصة بك (تمام كما هي)
function UpdateUserInfo($User){
    $dbrepo = new UserDataAccess();
    return $dbrepo->UpdateUser($User);
}

// === منطق المعالجة ===

// نتأكد أن الصفحة تم طلبها عن طريق زر الحفظ (POST)
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    
    // أ. استلام البيانات وحمايتها
    // (استخدمنا ?? لمنع الأخطاء لو الحقل فارغ)
    $id       = $_POST['UserID'] ?? 0;
    $username = $_POST['Username'] ?? '';
    $email    = $_POST['Email'] ?? '';
    $password = $_POST['Password'] ?? '';
    $access   = $_POST['Access'] ?? 0;

    // ب. التأكد أن الـ ID موجود
    if ($id == 0) {
        die("Error: User ID is missing.");
    }

    // ج. إنشاء الأوبجكت (DTO)
    $UpdatedUserObject = new UserDTO($id, $username, $email, $password, null, $access, null);

    // د. تنفيذ التحديث
    // (سنضعها في try-catch عشان لو الداتا بيز رفضت، نعرف السبب)
    try {
        UpdateUserInfo($UpdatedUserObject);
        
        // هـ. العودة للداشبورد بعد النجاح
        header("Location: user_index.php?msg=updated");
        exit(); // أمر مهم جداً لإنهاء الكود فوراً

    } catch (Exception $e) {
        die("Database Error: " . $e->getMessage());
    }

} else {
    // لو حد فتح الصفحة دي مباشر من غير ما يدوس حفظ
    header("Location: user_index.php");
    exit();
}
?>