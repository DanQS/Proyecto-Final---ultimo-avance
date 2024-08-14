<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_principal.aspx.cs" Inherits="ProyectoFina_PrograII.Vistas.menu_opciones" %>

<!DOCTYPE html>
<head runat="server">
<title> Aplicacion de Gestion de Matricula Liceo Reginal de Flores</title>
    <link href="../CSS/menu_principal.css" rel="stylesheet" />
</head>

    <nav class="nav">
  <input id="menu" type="checkbox">
  <label for="menu">Menu</label>
  <ul class="menu">
    <li>
      <a href="Registro_de_estudiantes.aspx">
        <span>Registro</span>
        <i class="fas fa-tasks" aria-hidden="true"></i>
      </a>
    </li>

    <li>
      <a href="Modificacion_de_registro_de_estudiantes.aspx">
        <span>Modificacion</span>
        <i class="fas fa-users" aria-hidden="true"></i>
      </a>
    </li>
    <li>
      <<a href="Consulta_de_registro_de_estudiantes.aspx">
        <span>Consulta</span>
        <i class="fas fa-envelope-open-text" aria-hidden="true"></i>
      </a>
    </li>
    </ul>
  
</nav>

<p class="notification">Haga click en el boton Menu</p>
<footer class="page-footer">
</footer>
  
<
