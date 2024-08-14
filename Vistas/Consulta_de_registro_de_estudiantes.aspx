<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_de_registro_de_estudiantes.aspx.cs" Inherits="ProyectoFina_PrograII.Vistas.Registro_de_estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="../CSS/formularios.css" rel="stylesheet" />
<head runat="server">
    <title>Consulta de registro de Estudiantes</title>

</head>
<body>
    <h1> Consulta de registro de estudiantes</h1>
   <form method="post" action="/Home/Registro_de_estudiantes">
<h2> Datos del estudiante</h2>
 <label for="numero_cedula_estudiante">Número de cédula del estudiante:</label>
 <input type="text" id="numero_cedula_estudiante" name="numero_cedula_estudiante" required ="" /><br /><br />
    </form>

<button> 
    <a href="menu_principal.aspx">Menu Principal</a>
</button>

</body>


</html>
