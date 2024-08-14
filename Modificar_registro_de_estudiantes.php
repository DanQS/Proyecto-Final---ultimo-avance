<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passcontrol.aspx.cs" Inherits="ProyectoFina_PrograII.passcontrol" %>

<!DOCTYPE html>
<head runat="server">
<?php
// Modificacion de registro

if if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Recibir los datos del formulario
    $id_estudiante = $_POST['id_estudiante'];
    $numero_cedula_estudiante = $_POST['numero_cedula_estudiante'];
    $numero_cedula_estudiante = filter_var($numero_cedula_estudiante, FILTER_SANITIZE_STRING);

    $nombre_estudiante = $_POST['nombre_estudiante'];
    $nombre_estudiante = filter_var($nombre_estudiante, FILTER_SANITIZE_STRING);

    $primer_apellido_estudiante = $_POST['primer_apellido_estudiante'];
    $primer_apellido_estudiante = filter_var($primer_apellido_estudiante, FILTER_SANITIZE_STRING);

    $segundo_apellido_estudiante = $_POST['segundo_apellido_estudiante'];
    $segundo_apellido_estudiante = filter_var($segundo_apellido_estudiante, FILTER_SANITIZE_STRING);

    $fecha_nacimiento_estudiante = $_POST['fecha_nacimiento_estudiante'];
    $fecha_nacimiento_estudiante = filter_var($fecha_nacimiento_estudiante, FILTER_SANITIZE_STRING);

    $direccion_estudiante = $_POST['direccion_estudiante'];
    $direccion_estudiante = filter_var($direccion_estudiante, FILTER_SANITIZE_STRING);

    $grado_a_matricular = $_POST['grado_a_matricular'];
    $grado_a_matricular = filter_var($grado_a_matricular, FILTER_SANITIZE_STRING);

    $adjuntos = $_POST['adjuntos'];
    $adjuntos = filter_var($adjuntos, FILTER_SANITIZE_STRING);

    $numero_cedula_encargado_legal = $_POST['numero_cedula_encargado_legal'];
    $numero_cedula_encargado_legal = filter_var($numero_cedula_encargado_legal, FILTER_SANITIZE_STRING);

    $nombre_encargado_legal = $_POST['nombre_encargado_legalgal'];
    $nombre_encargado_legal = filter_var($nombre_encargado_legal, FILTER_SANITIZE_STRING);

    $primer_apellido_encargado_legal = $_POST['primer_apellido_encargado_legal'];
    $primer_apellido_encargado_legal = filter_var($primer_apellido_encargado_legal, FILTER_SANITIZE_STRING);

    $segundo_apellido_encargado_legal = $_POST['segundo_apellido_encargado_legal'];
    $segundo_apellido_encargado_legal = filter_var($segundo_apellido_encargado_legal, FILTER_SANITIZE_STRING);

    $datos_trabajo_encargado_legal = $_POST['datos_trabajo_encargado_legal'];
    $datos_trabajo_encargado_legal = filter_var($datos_trabajo_encargado_legal, FILTER_SANITIZE_STRING);

    $numero_telefonico = $_POST['numero_telefonico'];
    $numero_telefonico = filter_var($numero_telefonico, FILTER_SANITIZE_STRING);

    $beca_comedor = $_POST['beca_comedor'];
    $beca_comedor = filter_var($beca_comedor, FILTER_SANITIZE_STRING);

    $estado_matricula = $_POST['estado_matricula'];
    $estado_matricula = filter_var($estado_matricula, FILTER_SANITIZE_STRING);
}

{
    $conexion = new mysqli('localhost','tablas app de matricula');

    if ($conexion->connect_error) {
        die("Error de conexión: " . $conexion->connect_error);
    }

    // Actualizar el registro en la base de datos
    $sql = "UPDATE estudiantes SET 
                numero_cedula = '$numero_cedula_estudiante', 
                nombre = '$nombre_estudiante'
            WHERE id = $id_estudiante";

    if ($conexion->query($sql) === TRUE) {
        echo "Registro modificado exitosamente";
    } else {
        echo "Error al modificar el registro: " . $conexion->error;
    }

    $conexion->close();
}
?>
}
?>
</html>
