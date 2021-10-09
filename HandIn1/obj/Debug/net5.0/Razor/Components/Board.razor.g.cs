#pragma checksum "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6366a6d635ccee06cc1d2d44ddb705a1d9b0985e"
// <auto-generated/>
#pragma warning disable 1591
namespace HandIn1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
using System.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
using HandIn1.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/board")]
    public partial class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
  
    var gameStatus = Helper.CalculateGameStatus(values);
    string status;
    if (gameStatus == Helper.GameStatus.X_wins)
    {
        status = "Winner:X";
    }
    else if (gameStatus == Helper.GameStatus.O_wins)
    {
        status = "Winner_O";
    }
    else if (gameStatus == Helper.GameStatus.Draw)
    {
        status = "Draw !";
    }
    else
    {
        char nextPlayer = xIsNext ? 'X' : 'O';
        status = $"Next player: {nextPlayer}";
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 25 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
         status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "board");
#nullable restore
#line 30 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
     for (int i = 0; i < 9; i++)
    {
        int squareNumber = i;

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HandIn1.Components.Square>(4);
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Char>(
#nullable restore
#line 33 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
                                        values[squareNumber]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ClickHandler", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
                                                                             () => HandleClick(squareNumber)

#line default
#line hidden
#nullable disable
            )));
            __builder.SetKey(
#nullable restore
#line 33 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
                     squareNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
#nullable restore
#line 34 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "id", "buttons");
            __builder.AddAttribute(10, "class", "btn btn-outline-dark");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
                                                             PlayAgainHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "New Game");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.AddMarkupContent(14, @"<style scoped>
    .board{
    display:grid;
    grid-template-columns: auto auto auto;
    background-color: #0a8efa;
    padding: 10px;
    width: 200px;
    height: 200px;
    border-radius: 10%;
    }
    button{
    border-radius: 10%;
    margin: 10px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Components\Board.razor"
       
    private char[] values = new char[9];
    private bool xIsNext;

    protected override void OnInitialized()
    {
        InitState();
    }

    private void PlayAgainHandler()
    {
        InitState();
    }

    private void InitState()
    {
        values = new char[9]
        {
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };
        xIsNext = true;
    }


    private void HandleClick(int i)
    {
        if (values[i] != ' ')
        {
            return;
        }
        bool isGameFinished = Helper.CalculateGameStatus(values) != Helper.GameStatus.NotYetFinished;
        if (isGameFinished)
        {
            return;
        }
        bool xToPlay = xIsNext;
        values[i] = xToPlay ? 'X' : 'O';
        xIsNext = !xToPlay;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
