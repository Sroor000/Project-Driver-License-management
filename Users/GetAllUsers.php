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
//return Type is list of $Users objects from UserDTO  
 function GetallUsers(){
    $db = new UserDataAccess();

    return $db->GetAllUsers();
}

/*
$db = new UserDataAccess();
$users = $db->GetAllUsers();

// Check if user exists
if ($users) {
    echo "The operation getallUsers info is Success!". "<br>";
} else {
    echo "The operation getallUsers is  failed!". "<br>";
}
if (!$users) {
    die(" no Users Exist to Show them");
}

foreach($users as $users){
// DTO properties (use correct names from your class)
echo $user->UserID . "<br>";
echo $user->Username .  "<br>";
echo $user->Email . "<br>";
echo $user->Password . "<br>";
echo  "<br>";
}

 */
?>