namespace Truckrr_Base_App
{
    public class StartupBase
    {
        public void Configure(IApplicationBuilder app)
        {
            {
                //app.UseNotyf();
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseCookiePolicy();
                //app.UseMultiLingualFeature();
                app.UseRouting();
                app.UseAuthentication();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapRazorPages();
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{area=Dashboard}/{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
    }
}