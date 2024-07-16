namespace Fundamentos_Blazor.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IDependencyDemo dependencyDemo;

        public WeatherForecastService(IDependencyDemo dependencyDemo)
        {
            this.dependencyDemo = dependencyDemo;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            // Dependency injection demo
            Random Random = new Random();
            int edad = dependencyDemo.returnEdad();

            return Task.FromResult(Enumerable.Range(1, edad).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
