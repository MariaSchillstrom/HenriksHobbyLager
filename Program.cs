
using HenriksHobbyLager.ProgramManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        var programManager = new HenriksHobbyLagerProgramManager();//Hanterar programmet, Logiken har fått en egen klass 
        programManager.Run();
    }
}
