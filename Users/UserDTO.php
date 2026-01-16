<?php

class UserDTO {
    public $UserID;
    public $Username;
    public $Email;
    public $Password;
    public $ImagePath;
    public $Access;
    public $CreatedAt;

    public function __construct(
        $UserID,
        $Username,
        $Email,
        $Password,
        $ImagePath = null,
        $Access = 0,
        $CreatedAt = null
    ) {
        $this->UserID = $UserID;
        $this->Username = $Username;
        $this->Email = $Email;
        $this->Password = $Password;
        $this->ImagePath = $ImagePath;
        $this->Access = $Access;
        $this->CreatedAt = $CreatedAt;
    }
}
?>
