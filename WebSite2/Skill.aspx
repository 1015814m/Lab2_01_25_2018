<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Skill.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
        <br />
        <asp:Label ID="lblSkillName" runat="server" Text="Skill Name: " Width="10%"></asp:Label>
        <asp:TextBox required="" ID="txtSkillName" runat="server" CssClass="inputText" MaxLength="35"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSkillDescription" runat="server" Text="Skill Description: " Width="10%"></asp:Label>
        <asp:TextBox required="" ID="txtSkillDescription" runat="server" CssClass="inputText" MaxLength="90"></asp:TextBox>
    </p>
    <p>
        <asp:Button CssClass="btn" ID="btnCommitSkill" runat="server" Text="Commit" OnClick="btnCommitSkill_Click" />
        <asp:Button  CssClass="btn" ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" formnovalidate="false"/>
    </p>
    <p>
        <asp:Label ID="lblAlert" runat="server" Text=""></asp:Label>
    </p>

</asp:Content>

