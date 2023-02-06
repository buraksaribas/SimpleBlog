namespace SimpleBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.MapGet("/", () => "Hello World!");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("Admin_default", "Admin", "admin/{controller}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("Login", "login", new { controller = "Auth", action = "Login" });
                endpoints.MapControllerRoute("Home", "", new { controller = "Posts", action = "Index" });
            });

            app.Run();
        }
    }
}