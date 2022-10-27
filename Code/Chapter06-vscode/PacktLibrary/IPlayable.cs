namespace Packt.Shared;
using static System.Console;

public interface IPlayable
{
    void Play();
    void Pause();

    // default implementation
    void Stop()
    {
        WriteLine("Default implementation of Stop");
    }
}