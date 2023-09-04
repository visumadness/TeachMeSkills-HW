using ConsoleApp1.Logger;
using E1.Logger;
using E2.Builder;
using E2.ProgramBuilder;
using System.Security.Cryptography.X509Certificates;

internal class CheckBuilders
{
    private static void Main(string[] args)
    {
        BaseBuilder baseBuilder = new GlassHouse("Artem");
        baseBuilder.HouseBuild();

        var service = new ServiceBuildLogger(new CompositeLogger(new ConsoleLogger(), new FileLogger("test.txt")), baseBuilder);
    }
}