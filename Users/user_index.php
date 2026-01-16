<?php
require_once "GetAllUsers.php";
$users = GetAllUsers();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Users Dashboard</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">
    
    <style>
        body { background: #f4f6f9; font-family: sans-serif; }
        .content-area { margin-left: 250px; padding: 30px; }
        @media (max-width: 992px) { .content-area { margin-left: 0; } }
    </style>
</head>
<body>

    <?php include "../includes/side_bar.php"; ?>

    <div class="content-area">
        <?php if (isset($_GET['msg']) && $_GET['msg'] == 'updated'): ?>
            <div class="alert alert-success">User updated successfully!</div>
        <?php elseif (isset($_GET['msg']) && $_GET['msg'] == 'deleted'): ?>
            <div class="alert alert-danger">User deleted successfully!</div>
        <?php endif; ?>

        <h2 class="mb-4">Manage Users</h2>
        
        <table class="table table-bordered bg-white shadow-sm">
            <thead class="table-dark">
                <tr>
                    <th>ID</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Role</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php foreach ($users as $user): ?>
                <tr>
                    <td><?= $user->UserID ?></td>
                    
                    <td><?= $user->Username ?></td>
                    <td><?= $user->Email ?></td>
                    <td>
                        <?= ($user->Access == 1) ? '<span class="badge bg-success">Admin</span>' : '<span class="badge bg-secondary">User</span>' ?>
                    </td>
                    <td>
                        <button type="button" 
                                class="btn btn-warning btn-sm btn-edit"
                                data-bs-toggle="modal" 
                                data-bs-target="#editUserModal"
                                data-id="<?= $user->UserID ?>"
                                data-username="<?= $user->Username ?>"
                                data-email="<?= $user->Email ?>"
                                data-password="<?= $user->Password ?>"
                                data-access="<?= $user->Access ?>">
                            <i class="fas fa-edit"></i> Edit
                        </button>

                        <a href="DeleteUser.php?id=<?= $user->UserID ?>" class="btn btn-danger btn-sm" onclick="return confirm('Delete this user?');">
                            <i class="fas fa-trash-alt"></i> Delete
                        </a>
                    </td>
                </tr>
                <?php endforeach; ?>
            </tbody>
        </table>
    </div>

    <div class="modal fade" id="editUserModal" tabindex="-1" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header bg-warning">
                    <h5 class="modal-title"><i class="fa-solid fa-user-pen"></i> Edit User</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                
                <form action="UpdateUser.php" method="POST">
                    <div class="modal-body">
                        
                        <input type="hidden" name="UserID" id="modal_id">

                        <div class="mb-3">
                            <label>Username</label>
                            <input type="text" name="Username" id="modal_username" class="form-control" required>
                        </div>

                        <div class="mb-3">
                            <label>Email</label>
                            <input type="email" name="Email" id="modal_email" class="form-control" required>
                        </div>

                        <div class="mb-3">
                            <label>Password</label>
                            <input type="text" name="Password" id="modal_password" class="form-control" required>
                        </div>

                        <div class="mb-3">
                            <label>Role</label>
                            <select name="Access" id="modal_access" class="form-select">
                                <option value="0">User</option>
                                <option value="1">Admin</option>
                            </select>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-primary">Save Changes</button>
                    </div>
                </form>

            </div>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>

    <script>
        const editButtons = document.querySelectorAll('.btn-edit');

        editButtons.forEach(button => {
            button.addEventListener('click', () => {
                const id = button.getAttribute('data-id');
                const username = button.getAttribute('data-username');
                const email = button.getAttribute('data-email');
                const password = button.getAttribute('data-password');
                const access = button.getAttribute('data-access');

                document.getElementById('modal_id').value = id;
                document.getElementById('modal_username').value = username;
                document.getElementById('modal_email').value = email;
                document.getElementById('modal_password').value = password;
                document.getElementById('modal_access').value = access;
            });
        });
    </script>

</body>
</html>