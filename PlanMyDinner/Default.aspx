<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PlanMyDinner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PlanMyDinner</h1>
        <p class="lead">Cool slogan</p>
        <p><a href="http://henrik.eideberg.se" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Recipes</h2>
            <p>
                Showing all available recipes
            </p>
            <asp:GridView runat="server"
                ID="RecipeGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                AutoGenerateSelectButton="True"
                OnSelectedIndexChanged="RecipeGridView_SelectedIndexChanged"
                GridLines="None">
                <Columns>
                    <asp:BoundField DataField="Name" SortExpression="Name" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-4">
            <h2>Instructions</h2>
            <p>
                <asp:Literal runat="server" ID="ltInstructions" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Ingredients</h2>
            <p>
                text...
            </p>
            <asp:GridView runat="server"
                ID="IngredientGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                GridLines="None">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Ingredient" SortExpression="Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="Measure" HeaderText="Measure" SortExpression="Measure" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Search</h2>
            <p>
                Add search functionality
            </p>
        </div>
        <div class="col-md-4">
            <h2>H2</h2>
            <p>
                text
            </p>
        </div>
        <div class="col-md-4">
            <h2>Category</h2>
            <p>
                text...
            </p>
            <asp:GridView runat="server"
                ID="CategoryGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                GridLines="None">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Category" SortExpression="Name" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>H2</h2>
            <p>
                text...
            </p>
        </div>
        <div class="col-md-4">
            <h2>H2</h2>
            <p>
                text
            </p>
        </div>
        <div class="col-md-4">
            <h2>Context</h2>
            <p>
                text...
            </p>
            <asp:GridView runat="server"
                ID="ContextGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                GridLines="None">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Context" SortExpression="Name" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
