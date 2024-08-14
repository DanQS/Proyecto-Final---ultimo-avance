<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_principal_pre.aspx.cs" Inherits="ProyectoFina_PrograII.Vistas.menu_opciones" %>

<!DOCTYPE html>
<head runat="server">
<title> Aplicacion de Gestion de Matricula Liceo Reginal de Flores</title>
    <link href="../CSS/menu_principal.css" rel="stylesheet" />
</head>
<body>


<h1>
    Aplicacion de Gestion de Matricula 
    Liceo Reginal de Flores
</h1>

<form class="menu_principal" runat="server">

<button>
    <a href="Registro_de_estudiantes.aspx">Registro</a> 
</button> 

<button>
    <a href="Modificacion_de_registro_de_estudiantes.aspx">Modificacion</a>
</button>
    
<button> 
    <a href="Consulta_de_registro_de_estudiantes.aspx">Consulta</a>
</button>
    
</form>
</body>
