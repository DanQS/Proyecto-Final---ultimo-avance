<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_registro.aspx.cs" Inherits="ProyectoFina_PrograII.Consulta_registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <?php
// Consultar_estudiante.php

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Recibir el número de cédula del formulario
    $numero_cedula_estudiante = $_POST['numero_cedula_estudiante'];

    // Validar y sanitizar el número de cédula
    $numero_cedula_estudiante = filter_var($numero_cedula_estudiante, FILTER_SANITIZE_STRING);

    // Conexión a la base de datos (ejemplo con MySQLi)
    $conexion = new mysqli('localhost','tablas app de matricula');;

    if ($conexion->connect_error) {
        die("Error de conexión: " . $conexion->connect_error);
    }

    // Consulta del registro en la base de datos
    $sql = "SELECT * FROM estudiantes WHERE numero_cedula = '$numero_cedula_estudiante'";
    $resultado = $conexion->query($sql);

    if ($resultado->num_rows > 0) {
        // Si se encuentra el registro, se muestra la información
        while($fila = $resultado->fetch_assoc()) {
            echo "<h3>Datos del Estudiante:</h3>";
            echo "ID: " . $fila["id"] . "<br>";
            echo "Número de Cédula: " . $fila["numero_cedula"] . "<br>";
            echo "Nombre: " . $fila["nombre"] . "<br>";
            // Otros campos del estudiante...
        }
    } else {
        echo "No se encontró ningún estudiante con ese número de cédula.";
    }

    // Cerrar la conexión
    $conexion->close();
}
?>
