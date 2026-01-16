<?php
require_once "UserDTO.php"; // Make sure path is correct

class UserDataAccess {
    private $conn;

     public function __construct() {
        $servername = "127.0.0.1";  // XAMPP host
        $port = 3307;                // XAMPP MySQL port
        $username = "root";          // your MySQL username
        $password = "";          // your MySQL password
        $dbname = "ecommercedb";     // your database name

        $dsn = "mysql:host=$servername;port=$port;dbname=$dbname;charset=utf8";

        try {
            $this->conn = new PDO($dsn, $username, $password);
            $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        } catch (PDOException $e) {
            die("DB Connection Failed: " . $e->getMessage());
        }
    }

    // CREATE
  public function AddUser(UserDTO $user) {
    $sql = "INSERT INTO users (Username, Email, Password, ImagePath, Access)
            VALUES (:username, :email, :password, :image, :access)";
    
    $stmt = $this->conn->prepare($sql);

    $result = $stmt->execute([
        ':username' => $user->Username,
        ':email'    => $user->Email,
        ':password' => $user->Password,
        ':image'    => $user->ImagePath,
        ':access'   => $user->Access
    ]);

    if ($result) {
        // Get the auto-generated ID from the database
        $user->UserID = $this->conn->lastInsertId();
    }

    return $result;
}


  public function GetAllUsers() {
    $sql = "SELECT * FROM users";
    $stmt = $this->conn->prepare($sql);
    $stmt->execute();

    $users = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        $users[] = new UserDTO(
            $row['UserID'],
            $row['Username'],
            $row['Email'],
            $row['Password'],
            $row['ImagePath'],
            $row['Access'],
            $row['CreatedAt']
        );
    }
    return $users;
}

 public function GetUserById($id) {
    $sql = "SELECT * FROM users WHERE UserID = :id";
    $stmt = $this->conn->prepare($sql);
    $stmt->execute([':id' => $id]);

    $row = $stmt->fetch(PDO::FETCH_ASSOC);
    if (!$row) return null;

    return new UserDTO(
        $row['UserID'],
        $row['Username'],
        $row['Email'],
        $row['Password'],
        $row['ImagePath'],
        $row['Access'],
        $row['CreatedAt']
    );
}

   public function UpdateUser(UserDTO $user) {
    $sql = "UPDATE users 
            SET Username = :username, 
                Email = :email, 
                Password = :password,
                ImagePath = :image,
                Access = :access
            WHERE UserID = :id";

    $stmt = $this->conn->prepare($sql);

    return $stmt->execute([
        ':username' => $user->Username,
        ':email'    => $user->Email,
        ':password' => $user->Password,
        ':image'    => $user->ImagePath,
        ':access'   => $user->Access,
        ':id'       => $user->UserID
    ]);
}
public function DeleteUser($UserId)
 {
     $sql = "DELETE FROM users WHERE UserID = :id"; 
     $stmt = $this->conn->prepare($sql); 
     return $stmt->execute([':id' => $UserId]); }
}

?>
