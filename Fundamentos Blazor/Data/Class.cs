namespace Fundamentos_Blazor.Data
{
    public class DependencyDemo : IDependencyDemo
    {
        private int edad;

        public DependencyDemo()
        {
            Random random = new Random();
            edad = random.Next(1, 5);
        }

        public int returnEdad()
        {
            return edad;
        }
    }
}
