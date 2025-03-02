using Microsoft.Extensions.DependencyInjection;
using WebApi.Core;
using WebApi.Data;
using WebApi.Data.Repositories;
namespace WebApi.Di;

public static class DiData {
   public static IServiceCollection AddData(
      this IServiceCollection services
   ){
      services.AddSingleton<IPersonRepository, PersonRepository>();
      services.AddSingleton<ICarRepository, CarRepository>();
      services.AddSingleton<IDataContext, DataContext>();
      return services;
   }
}