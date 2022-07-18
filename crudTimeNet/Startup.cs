using crudTimeNet.Models;
using Microsoft.EntityFrameworkCore;

namespace crudTimeNet {

    public class Startup {

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<Context> (options => options.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection")));
            services.AddControllers();
        }
    }

}