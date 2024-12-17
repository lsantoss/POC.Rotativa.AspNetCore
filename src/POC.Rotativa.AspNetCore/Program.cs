using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();
app.UseExceptionHandler("/Error/Error");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute("default", "{controller=Customer}/{action=Index}/{id?}");
RotativaConfiguration.Setup(app.Environment.WebRootPath, "lib/rotativa-aspnetcore");
app.Run();