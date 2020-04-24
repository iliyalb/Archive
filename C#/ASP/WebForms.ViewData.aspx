<!-- Default.aspx -->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Data in Web Form</title>
</head>
<body>
    <asp:Literal ID="myLiteral" runat="server" />
    <br />
    <asp:Literal ID="myLiteral2" runat="server" />

    <table border="1">
        <tr>
            <th>Username</th>
            <th>Password</th>
            <th>Is User Active?</th>
        </tr>
        <asp:Literal ID="myLiteral3" runat="server" />
    </table>
    <form id="frmMain" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

<!-- Default.aspx.cs -->
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string message = "This is a test text.";
        myLiteral.Text = message;

        Test.UserProfile oUserProfile = new Test.UserProfile();
        oUserProfile.Username = "havij";
        oUserProfile.Password = "12345";
        oUserProfile.IsUserActive = false;

        myLiteral2.Text = string.Format("Username = {0}, Password = {1}, Is User Active? {2}"
            , oUserProfile.Username, oUserProfile.Password, oUserProfile.IsUserActive);



        Test.UserProfile oup1 = new Test.UserProfile();
        oup1.Username = "user1";
        oup1.Password = "pass1";
        oup1.IsUserActive = true;

        Test.UserProfile oup2 = new Test.UserProfile();
        oup2.Username = "user2";
        oup2.Password = "pass2";
        oup2.IsUserActive = true;

        Test.UserProfile oup3 = new Test.UserProfile();
        oup3.Username = "user3";
        oup3.Password = "pass3";
        oup3.IsUserActive = true;

        List<Test.UserProfile> userProfiles = new List<Test.UserProfile>();
        userProfiles.Add(oup1);
        userProfiles.Add(oup2);
        userProfiles.Add(oup3);

        string listMessage = "";
        for (int i = 0; i < userProfiles.Count; i++)
        {
            if(i == 0)
            { 
                listMessage += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
                                             oup1.Username, oup1.Password, oup1.IsUserActive);
            }
            else if(i == 1)
            {
                listMessage += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
                             oup2.Username, oup2.Password, oup2.IsUserActive);
            }
            else if(i == 2)
            {
                listMessage += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
                            oup3.Username, oup3.Password, oup3.IsUserActive);
            }

            myLiteral3.Text = listMessage;
        }
    }
}

<!-- UserProfile.cs -->
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    public class UserProfile
    {
        public UserProfile(){}

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsUserActive { get; set; }
    }
}