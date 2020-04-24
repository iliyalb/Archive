<% Page Language="C#" %>

<!DOCTYPE HTML>

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int number1 = System.Convert.ToInt32(txtNumber1.Text);
        int number2 = System.Convert.ToInt32(txtNumber2.Text);
        int sum = number1 + number2;

        txtSum.Text = sum.ToString();
    }

</script>

<HTML xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Default Page</title>
</head>

<body>
    <form id="mainForm" runat="server">
        <div>
            <!-- HTML Method -->

            <!-- <label for="number1">Number1</label>
            <input type="text" name="number1" id="number1" />
            <br />
            <label for="number2">Number2</label>
            <input type="text" name="number2" id="number2" />
            <br />
            <br />
            <input type="submit" />
            <br />
            <br />
            <label for="sum">Sum</label>
            <input type="text" name="sum" id="sum" /> -->

            <!-- ViewState -->

            <asp:Label ID="lblNumber1" runat="server" Text="Number1" />
            <asp:TextBox ID="txtNumber1" runat="server" />
            <br/>
            <asp:Label ID="lblNumber2" runat="server" Text="Number2" />
            <asp:TextBox ID="txtNumber2" runat="server" />
            <br/>
            <br/>
            <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" />
            <!-- Reset to last postback state -->
            <input type="reset" value="reset" />
            <br/>
            <br/>
            <asp:Label ID="lblSum" runat="server" Text="Result" />
            <asp:TextBox ID="txtSum" runat="server" />
        </div>
    </form>
</body>

</HTML>