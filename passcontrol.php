<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passcontrol.aspx.cs" Inherits="ProyectoFina_PrograII.passcontrol" %>

<!DOCTYPE html>
<head runat="server">
<?php
// passcontrol.php

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Validacion de usuario y la contraseña
    if ($username == 'admin' && $password == '1234') {
        // Credenciales correctas
        header("Location: dashboard.php");
        exit();
    } else {
        // Credenciales incorrectas
        echo "Usuario o contraseña incorrectos.";
    }
}
?>
</html>
