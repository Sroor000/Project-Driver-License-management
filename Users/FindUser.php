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
//$UserID int 
//return Type is $User object from UserDTO  
 function GetUserInfoByID($UserID){
    $dbrepo= new UserDataAccess();
    return $dbrepo->GetUserById($UserID);
}





/* $searchUserID = 1;

$db = new UserDataAccess();
$user = $db->getUserById($searchUserID);

// Check if user exists
if ($user) {
    echo "The operation search is Success!". "<br>";
} else {
    echo "The operation search is  failed!". "<br>";
}
if (!$user) {
    die("User not found!");
}

// DTO properties (use correct names from your class)
echo $user->UserID . "<br>";
echo $user->Username .  "<br>";
echo $user->Email . "<br>";
echo $user->Password . "<br>";
 */


?>