using ToDoListWithUsersBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<ApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:7292");
});
builder.Services.AddSingleton<UserServiceUi>();
builder.Services.AddSingleton<TaskListServiceUi>();
builder.Services.AddSingleton<CategoryServiceUi>();
builder.Services.AddSingleton<TaskServiceUi>();
builder.Services.AddSingleton<SubTaskServiceUi>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
