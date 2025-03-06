using Microsoft.Extensions.DependencyInjection;
using WebApi.Core;
using WebApi.Data;
using WebApi.Data.Repositories;
namespace WebApi.Di;

public static class DiData {
   public static IServiceCollection AddData(
      this IServiceCollection services
   ){
      services.AddSingleton<IPeopleRepository, PeopleRepository>();
      services.AddSingleton<ICarsRepository, CarsRepository>();
      services.AddSingleton<IDataContext, DataContext>();
      return services;
   }
}