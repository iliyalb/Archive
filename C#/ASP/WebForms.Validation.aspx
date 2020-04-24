<%@ Page Title="Learning Validation" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="cntHead" ContentPlaceHolderID="cphHead" Runat="Server">
    <style>
        .validator{
            color: red;
        }
    </style>
</asp:Content>
<asp:Content ID="cntMain" ContentPlaceHolderID="cphMain" Runat="Server">
    <asp:ValidationSummary ID="myValidationSummary" runat="server" 
        DisplayMode="BulletList" EnableClientScript="true" ShowMessageBox="false"
        ShowSummary="true" CssClass="validator" HeaderText="Please check the errors below:" />

    <asp:Label ID="lblUsername" runat="server" Text="Username" />
    <asp:TextBox ID="txtUsername" runat="server" />
    <asp:RequiredFieldValidator ID="rfvUsername" runat="server"
        ControlToValidate="txtUsername" Display="Dynamic" SetFocusOnError="true"
        EnableClientScript="true" Text="*" ErrorMessage="Username is required!" CssClass="validator" />
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password" />
    <asp:TextBox ID="txtPassword" runat="server" />
    <asp:RegularExpressionValidator ID="revPassword" runat="server"
        ControlToValidate="txtPassword" Display="Dynamic" SetFocusOnError="true"
        EnableClientScript="true" Text="*" ErrorMessage="Password should contains A-Z & a-z & 1-9 between 8 to 20 chars"
        ValidationExpression="[a-zA-Z0-9]{8,20}" CssClass="validator" />
    <br />
    <asp:Label ID="lblConfirmPassword" runat="server" Text="CPassword" />
    <asp:TextBox ID="txtConfirmPassword" runat="server" />
    <asp:CompareValidator ID="cvConfirmPassword" runat="server" Display="Dynamic"
        ControlToValidate="txtConfirmPassword" SetFocusOnError="true" EnableClientScript="true"
        CssClass="validator" Text="*" ErrorMessage="Confirm Password is not equal to Password"
        ControlToCompare="txtPassword" Operator="Equal" />
    <br />
    <asp:Label ID="lblAge" runat="server" Text="Age" />
    <asp:TextBox ID="txtAge" runat="server" />
    <asp:RangeValidator ID="rvAge" runat="server" Display="Dynamic"
        ControlToValidate="txtAge" CssClass="validator" EnableClientScript="true"
        SetFocusOnError="true" Text="*" ErrorMessage="Age must be between 18 and 80" Type="Integer"
        CultureInvariantValues="true" MinimumValue="18" MaximumValue="80" />

    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click" />
</asp:Content> 

