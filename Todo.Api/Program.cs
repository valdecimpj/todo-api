using System.Net;
using Todo.Api.Application.Controllers.Requests;
using Todo.Api.Application.Exceptions;
using Todo.Api.Application.Models;
using Todo.Api.Application.Ports.In.Controllers;
using Todo.Api.DependencyInjectionModule;

var builder = WebApplication.CreateBuilder(args);
new TodoApiDependencyInjectionModule()
    .RegisterAllModules(builder);
var app = builder.Build();

app.MapPost("/", 
    (NewTodoItemModel newTodoItemModel, INewTodoItemController newTodoItemController) =>
    {
        try
        {
            newTodoItemController.SaveNewTodoItem(newTodoItemModel);
            return Results.Ok();
        }
        catch (InvalidNewTodoItemException invalidNewTodoItemException)
        {
            return Results.BadRequest(invalidNewTodoItemException.Message);
        }
    });
app.MapGet("/", 
    (int pageSize, int page, IQueryAllTodoItemsController queryAllTodoItemsController) => {
        try
        {
            return Results.Json(queryAllTodoItemsController
                .QueryAllTodoItemsByPage(new QueryAllTodoitemsByPageRequest(page, pageSize)));
        }
        catch (QueryAllTodoitemsByPageRequestException queryAllTodoitemsByPageRequestException)
        {
            return Results.BadRequest(queryAllTodoitemsByPageRequestException.Message);
        }
    });

app.Run();
