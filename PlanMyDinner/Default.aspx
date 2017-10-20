﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PlanMyDinner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PlanMyDinner</h1>
        <p class="lead">Cool slogan</p>
        <p><a href="http://henrik.eideberg.se" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h3>Search</h3>
            <p>
                Enter search string: <asp:TextBox ID="TextBoxSearchInput" runat="server"></asp:TextBox>
            </p>
            <div>
                <asp:CheckBox ID="CheckboxRecipe" runat="server" Text="Recipes" />
                <asp:CheckBox ID="CheckboxIngredient" runat="server" Text="Ingredients" />
            </div>
            <br>
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" onclick="ButtonSubmit_Click" />
            <asp:Button ID="ButtonClear" runat="server" Text="Clear" onclick="ButtonClear_Click" />
        </div>
        <div class="col-md-4">
            <h3>Categories</h3>
            <asp:CheckBox ID="CheckboxPork" runat="server" Text="Pork" />
            <asp:CheckBox ID="CheckboxBeef" runat="server" Text="Beef" />
            <asp:CheckBox ID="CheckboxChicken" runat="server" Text="Chicken" />
            <asp:CheckBox ID="CheckboxFisk" runat="server" Text="Fisk" />
            <asp:CheckBox ID="CheckboxSeafood" runat="server" Text="Seafood" />
            <asp:CheckBox ID="CheckboxVegetarian" runat="server" Text="Vegetarian" />
            <asp:CheckBox ID="CheckboxVegan" runat="server" Text="Vegan" />
            <asp:CheckBox ID="CheckboxPasta" runat="server" Text="Pasta" />
            <asp:CheckBox ID="CheckboxRice" runat="server" Text="Rice" />
            <asp:CheckBox ID="CheckboxPotato" runat="server" Text="Potato" />
            <asp:CheckBox ID="CheckboxSoup" runat="server" Text="Soup" />
            <asp:CheckBox ID="CheckboxPizza" runat="server" Text="Pizza" />
        </div>
        <div class="col-md-4">
            <h3>Context</h3>
            <asp:CheckBox ID="CheckboxKids" runat="server" Text="Kids" />
            <asp:CheckBox ID="CheckboxWeekdays" runat="server" Text="Weekdays" />
            <asp:CheckBox ID="CheckboxWeekends" runat="server" Text="Weekends" />
            <asp:CheckBox ID="CheckboxParty" runat="server" Text="Party" />
            <asp:CheckBox ID="CheckboxStarter" runat="server" Text="Starter" />
        </div>
    </div>
    <hr>
    <div class="col-md-4">
        <h2>Recipes</h2>
        <p>
            <asp:Literal runat="server" ID="ltRecipe" />
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
        <div class="row">
            <h2>Instructions</h2>
            <p>
                <asp:Literal runat="server" ID="ltInstructions" />
            </p>
        </div>
        <div class="row">
            <asp:GridView ID="Gv_imgs"
                CssClass="grid"
                runat="server"
                AutoGenerateColumns="false"
                ShowHeader="false"
                GridLines="None">
                <Columns>
                    <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="200" ControlStyle-Width="300" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="col-md-4">
        <h2>Misc</h2>
        <div class="row">
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
        <div class="row">
            <h3>Categories</h3>
            <asp:GridView runat="server"
                ID="CategoryGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                GridLines="None"
                ShowHeader="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Category" SortExpression="Name" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="row">
            <h3>Contexts</h3>
            <asp:GridView runat="server"
                ID="ContextGridView"
                DataKeyNames="Id"
                AutoGenerateColumns="False"
                GridLines="None"
                ShowHeader="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Context" SortExpression="Name" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="row">
    </div>
</asp:Content>
