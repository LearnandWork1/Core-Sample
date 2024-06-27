namespace CoreSample.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureSQLcontext(this IServiceCollection services,IConfiguration iConfig)
        {
          //  var conString = config["sqlconnection:connsectionstring"];

            //services.AddDbContext
        }
    }
}
