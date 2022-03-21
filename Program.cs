using MiniTodo.Data;
using MiniTodo.Model;
using MiniTodo.Model.ViewModels;

var builder = WebApplication.CreateBuilder(args);

//AddDbContext, garante conexão seja fechada após a necessidade
builder.Services.AddDbContext<AppDbContext>();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("v1/todos", (AppDbContext context) =>
{
    //var todo = new Todo(Guid.NewGuid(), "Ir a academia", false);
    var todos = context.Todos.ToList();
    return Results.Ok(todos);
}).Produces<Todo>();

app.MapPost("v1/todos", (
    AppDbContext context,
    CreateTodoViewModel model) =>
{
    var todo = model.MapTo();
    if (!model.IsValid)
        return Results.BadRequest(model.Notifications);

    context.Todos.Add(todo);
    context.SaveChanges();
    return Results.Created($"/v1/todos/{todo.Id}", todo);

});

app.Run();
