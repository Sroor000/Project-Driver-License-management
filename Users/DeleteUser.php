<?php
require_once "UserDataAccess.php"; 

// 1. Check if ID exists in URL (e.g., DeleteUser.php?id=5)
if (isset($_GET['id'])) {
    $id = intval($_GET['id']); // Secure the ID
    
    // 2. Perform the deletion
    $dbrepo = new UserDataAccess();
    $dbrepo->DeleteUser($id);

    // 3. Go back to the dashboard immediately
    header("Location: user_index.php?msg=deleted");
    exit();
} else {
    // If someone tries to open this file without an ID
    header("Location: user_index.php");
    exit();
}
?>