namespace Automata;

public class NFA
{
    public State inState, outSate;


    public static NFA concatenation(NFA first, NFA second)
    {
        first.outSate.Accepting = false;
        first.outSate.Transitions.Add(State.Epsilon, new List<State>{ second.inState });
        return first;
    }

    public static NFA union(NFA a, NFA b)
    {
        var sState = new State();
        sState.Accepting = false;

    }


}
