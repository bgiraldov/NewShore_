<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WEBAPP.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>NewShore</title>
    <!-- Bootstrap core CSS -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>

    <div class="container">
        <div class="py-5 text-center">
            <img class="d-block mx-auto mb-4" src="https://www.fib.upc.edu/sites/fib/files/logo_newshore_500x120.png" alt="" width="450" height="90"/>
            <h2>Prueba Acceso NewShore</h2>
        </div>

        <form class="needs-validation" id="form1" runat="server">
            <div class="row">
                <div class="col-md-12 order-md-1">
                
                        <div class="row">
                            <div class="col-md-6 mb-3">
                                <label>Contenido</label>
                                <asp:FileUpload ID="fileContenido" CssClass="form-control" runat="server"></asp:FileUpload>
                                <br />
                                <label>Registrados</label>
                                <asp:FileUpload ID="fileRegistrado" CssClass="form-control" runat="server"></asp:FileUpload>
                                <br />
                                <asp:Button CssClass="btn btn-primary" Text="Cargar" ID="btnCargarArchivos" OnClick="btnCargarArchivos_Click" runat="server" />
                                <asp:Button CssClass="btn btn-success" Text="Descargar" ID="btnDescargar" OnClick="btnDescargar_Click" runat="server" />
                            </div>
                            <div class="col-md-6 mb-3">
                                <label>Resultados</label>
                                <asp:GridView CssClass="table table-striped" ID="grvResultado" runat="server"></asp:GridView>
                            </div>                     
                        </div>
                </div>
            </div>
        </form>

      <footer class="my-5 pt-5 text-muted text-center text-small">
        <p class="mb-1">&copy; 2018 Bryam Giraldo Valencia</p>
      </footer>
    </div>
</body>
</html>
