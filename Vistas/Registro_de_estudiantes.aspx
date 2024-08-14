<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro_de_estudiantes.aspx.cs" Inherits="ProyectoFina_PrograII.Vistas.Registro_de_estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="../CSS/formularios.css" rel="stylesheet"/>
<head runat="server">
    <title>Registro de Estudiantes</title>

</head>
<body>
    <h1> Registro de Estudiantes</h1>
   <form method="post" action="/Home/Registro_de_estudiantes">
<h3> Datos del estudiante</h3>
 <label for="numero_cedula_estudiante">Numero de cedula del estudiante:</label>
 <input type="text" id="numero_cedula_estudiante" name="Numero de cedula del estudiante" /> <br /><br /> 

 <label for="nombre_estudiante">Nombre del estudiante:</label>
 <input type="text" id="nombre_estudiante" name="Nombre del estudiante" /> <br /><br /> 
       
 <label for="primer_apellido_estudiante">Primer apellido del estudiante:</label>
 <input type="text" id="primer_apellido_estudiante" name="Primer apellido del estudiante" /> <br /><br /> 
       
 <label for="segundo_apellido_estudiante">Segundo apellido del estudiante:</label>
 <input type="text" id="segundo_apellido_estudiante" name="Segundo apellido del estudiante" /> <br /><br />
       
 <label for="fecha_nacimiento_estudiante">Fecha de nacimiento del estudiante:</label>
 <input type="text" id="fecha_nacimiento_estudiante" name="Fecha de nacimiento del estudiante" /> <br /><br /> 
       
 <label for="direccion_estudiante">Direccion de domicilio del estudiante:</label>
 <input type="text" id="direccion_estudiante" name="Direccion de domicilio del estudiante" /> <br /><br />  

 <label for="grado_a_matricular">Seleccione el grado a matricular:</label>
 <select id="grado_a_matricular" name="Seleccione el grado a matricular" >
     <option value="1"> </option>
     <option value="2">Septimo</option>
     <option value="3">Octavo</option>
     <option value="4">Noveno</option>
     <option value="5">Decimo</option>
     <option value="6">Undecimo</option>
 </select> <br /><br />
       
 <label for="adjuntos">Documentos adjuntos (constancia de notas y constancia salarial del padre o encargado?:</label>
 <select id="adjuntos" name="Documentos adjuntos (constancia de notas y constancia salarial del padre o encargado?" >
    <option value="1"> </option>
    <option value="2">Si</option>
    <option value="3">No</option>
</select> <br /><br />
</form>

<form method="post" action="/Home/Registro_de_padres_o_encargados">
 <h3> Datos del Padre o encargado</h3>

<label for="numero_cedula_encargado_legal">Numero de cedula del padre/madre o encargado legal:</label>
<input type="text" id="numero_cedula_encargado_legal" name="Numero de cedula del padre/madre o encargado legal" /> <br /><br /> 

<label for="nombre_encargado_legal">Nombre del padre/madre o encargado legal:</label>
<input type="text" id="nombre_encargado_legal" name="Nombre del padre/madre o encargado legal" /> <br /><br /> 
      
<label for="primer_apellido_encargado_legal">Primer apellido del padre/madre o encargado legal:</label>
<input type="text" id="primer_apellido_encargado_legal" name="Primer apellido del padre/madre o encargado legal" /> <br /><br /> 
      
<label for="segundo_apellido_encargado_legal">Segundo apellido del padre/madre o encargado legal:</label>
<input type="text" id="segundo_apellido_encargado_legal" name="Segundo apellido del padre/madre o encargado legal" /> <br /><br />
      
<label for="datos_trabajo_encargado_legal">Datos del trabajo del padre/madre o encargado legal:</label>
<input type="text" id="datos_trabajo_encargado_legal" name="Datos del trabajo del padre/madre o encargado legal" /> <br /><br /> 
      
<label for="numero_telefonico">Numero telefonico del padre/madre o encargado legal:</label>
<input type="text" id="numero_telefonico" name="Numero telefonico del padre/madre o encargado legal" /> <br /><br /> 
</form>

<form method="post" action="/Home/Beca_Comedor">
 <h3> Beca de comedor</h3>
 <label for="beca_comedor">Solicita beca de comedor?:</label>
 <select id="beca_comedor" name="Solicita beca de comedor?" >
    <option value="1"> </option>
    <option value="2">Si</option>
    <option value="3">No</option>
</select> <br /><br />
</form>

<form method="post" action="/Home/Estado_de_Matricula">
 <h3> Estado de matricula</h3>
 <label for="estado_matricula">Estado actual de matricula:</label>
 <select id="estado_matricula" name="Estado actual de matricula" >
    <option value="1"> </option>
    <option value="2">Activa</option>
    <option value="3">Inactiva</option>
</select> <br /><br />
</form>
<button> 
    <a href="menu_principal.aspx">Menu Principal</a>
</button> 
</body>


</html>
