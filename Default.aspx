<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="CricketOnline._Default" %>
  
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="HeadContent" runat="server" ContentPlaceHolderID="HeadContent">

    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>

</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <table class="style1">
        <tr>
            <td>
          
                &nbsp;</td>
            <td>
 
  <asp:Accordion   
    ID="Accordion1"   
    runat="server" CssClass="clear" HeaderCssClass="accordionHeader" 
        HeaderSelectedCssClass="accordionHeaderSelected" 
        ContentCssClass="accordionContent" Width="277px">  

<Panes>  
    <asp:AccordionPane ID="AccordionPane1" runat="server">  
        <Header>Leagues</Header>
        <Content>  
        Leagues you are associated with
        </Content>  
    </asp:AccordionPane>  
    <asp:AccordionPane ID="AccordionPane2" runat="server">  
        <Header>Competitions</Header>
        <Content>  
        League competitions List
        </Content>  
    </asp:AccordionPane>  
    <asp:AccordionPane ID="AccordionPane3" runat="server">  
        <Header>Clubs</Header>  
        <Content>  
        Club details
        </Content>  
    </asp:AccordionPane>  
</Panes>  
</asp:Accordion>  
    <asp:DropShadowExtender ID="Accordion1_DropShadowExtender" runat="server" 
        Enabled="True" Opacity="0.25" Radius="6" Rounded="True" 
        TargetControlID="Accordion1" TrackPosition="True">
    </asp:DropShadowExtender>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
  
    </asp:Content>
