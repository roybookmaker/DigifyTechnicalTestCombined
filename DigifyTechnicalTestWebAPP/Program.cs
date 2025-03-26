var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Register HttpClient
builder.Services.AddHttpClient();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Registration/Error");
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/Registration/Error", "?statusCode={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Registration}/{action=Index}/{id?}");

app.Run();
