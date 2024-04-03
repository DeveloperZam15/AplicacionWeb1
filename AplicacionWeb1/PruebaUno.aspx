<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaUno.aspx.cs" Inherits="AplicacionWeb1.PruebaUno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link rel="shortcut icon" href="/media/icon.png" type="image/x-icon"/>

    <link rel="stylesheet" href="styles/css/bootstrap.css"/>
    <script src="styles/js/bootstrap.bundle.js"></script>

    <title>Evaluación</title>
</head>

<body>
    <form id="form1" runat="server">

        <div class="container-fluid bg-color-tuvch p-4">

            <div class="col d-flex flex-column justify-content-center align-items-center">

                <div class="row text-center bg-white text-tuvch d-flex rounded p-2" style=" width:100%; min-width: 100px; max-width: 350px">

                    <div class="h2 mb-2">
                        <p class="title">Evaluador TUVCH</p>
                    </div>

                    <div class="form mb-3">                        
                        <label class="form-label" > Valor obtenido en el examen:</label><br/>
                        <asp:TextBox type="text" id="examenVal" runat="server" CssClass="text-center form-control"></asp:TextBox>
                        <asp:Label type="text" id="alert1" runat="server" ></asp:Label>                
                    </div>

                    <div class="form mb-3">
                        <label class="form-label">Valor obtenido en las prácticas:</label><br/>
                        <asp:TextBox type="text" id="practicasVal" runat="server" CssClass="text-center form-control"></asp:TextBox>
                        <asp:Label type="text" id="alert2" runat="server"></asp:Label>
                    </div>
      
                    <div class="form mb-3">
                        <label class="form-label">Valor obtenido en las tareas:</label><br/>
                        <asp:TextBox type="text" id="tareasVal" runat="server" CssClass="text-center form-control"></asp:TextBox>
                        <asp:Label type="text" id="alert3" runat="server"></asp:Label>
                    </div>
                
                    <div class="form-group m-auto">
                        <asp:Button type="submit" id="btnEnv" runat="server" Text="ENVIAR" OnClick="btnEnv_Click" CssClass="btn btn-primary btn-md"/>
                    </div>
               
                </div>


                <div class="row d-flex bg-color-tuvch3 text-white m-3 rounded">
                   <h3>TOTAL : <asp:Label type="text" id="totalText" runat="server"></asp:Label>%</h3>               
                </div>

            </div>

        </div>

    </form>
</body>
</html>

