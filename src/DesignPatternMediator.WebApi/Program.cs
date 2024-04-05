using DesignPatternMediator.Dominio.Servicos;
using DesignPatternMediator.Infra.Servicos;

namespace DesignPatternMediator.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;

            services.AddScoped<IServicoNotificacao, ServicoNotificacao>();
            services.AddScoped<IServicoShopping, ServicoShopping>();
            services.AddScoped<IServicoProduto, ServicoProduto>();
            services.AddScoped<IShoppingMediator, ShoppingMediator>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
