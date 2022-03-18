var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/quiz/Error");
    app.UseDeveloperExceptionPage();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{ //app.UseExceptionHandler("/Home/mypage");
    app.UseHsts();
}
//app.UseStatusCodePages();
app.UseStatusCodePagesWithRedirects("/quiz/myerrorpage");
//app.UseStatusCodePagesWithReExecute("/Home/myerrorpage");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=quiz}/{action=Login}/{id?}");

app.Run();
