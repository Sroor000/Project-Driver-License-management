<?php
require_once "UserDataAccess.php";
require_once "UserDTO.php";






/*
UserDTO Sturcture 
 public $UserID;
    public $Username;
    public $Email;
    public $Password;
    public $ImagePath;
    public $Access;
    public $CreatedAt;


*/ 
//$User object from UserDTO 
 function AddUser($User){
    $dbrepo= new UserDataAccess();
    return
    $dbrepo->AddUser($User);
}

// Create DTO
/* $user = new UserDTO(null, "Amr", "amr@example.com", "1234");

// Create database object
$db = new UserDataAccess();

// Call addUser and check the result
if ($db->addUser($user)) {
    echo "The operation ADD is Success!";
} else {
    echo "The operation ADD failed!";
} */
?>
