 using Avtobus1BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
builder.Services.RegisterDependencies();
builder.Services.AddControllersWithViews();
builder.Services.AddMvc().AddMvcOptions(opt => { opt.EnableEndpointRouting = false; });
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

app.UseAuthorization();
app.UseEndpoints(endpoints =>endpoints.MapRazorPages());

app.UseMvc(routes =>
{
    routes.MapRoute("defaut", "{controller=Url}/{action=Index}/{id?}");
});
app.Run();
