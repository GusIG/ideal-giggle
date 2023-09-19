namespace Automata;

public class State
{
    public const char Epsilon='\0'; 
    public bool Accepting;
    public Dictionary<char, List<State>> Transitions = new();
}



