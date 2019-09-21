<% Page Language="C#" AutoEventWireup="true" CodeFile="WebForms.SeperateCode.aspx.cs" %>

<!DOCTYPE HTML>

<!-- Script is seperated in a aspx.cs file -->

<!-- <script runat="server"></script> -->

<HTML xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Default Page</title>
</head>

<body>
    <header style="height: 200px; width: 100%; background-color: red;">
        <!-- Header -->
    </header>

    <form id="form1" runat="server">
            <div>
                <%-- ViewState --%>
                <asp:Label ID="lblNumber1" runat="server" Text="Number1" />
                <asp:TextBox ID="txtNumber1" runat="server" />
                <br />
                <asp:Label ID="lblNumber2" runat="server" Text="Number2" />
                <asp:TextBox ID="txtNumber2" runat="server" />
                <br />
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Sum" OnClick="btnSubmit_Click" />
                <input type="reset" value="reset" />
                <br />
                <br />
                <asp:Label ID="lblSum" runat="server" Text="Sum" />
                <asp:TextBox ID="txtSum" runat="server" />
            </div>
        </form>

    <footer style="height: 200px; width: 100%; background-color: red;">
        <!-- Footer -->
    </footer>
</body>

</HTML>