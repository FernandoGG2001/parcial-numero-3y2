<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <p>
        PARTICIPANTES</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="NOMBRE"></asp:Label>
        :
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="NIVEL DE EXPERIENCIA"></asp:Label>
        :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre del juego<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        VIDEO JUEGOS
    </p>
    <p>
        NOMBRE:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        genero del juego:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="juegos " />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="guardar participante" />
    </p>
    <p>
        &nbsp;</p>

</asp:Content>
