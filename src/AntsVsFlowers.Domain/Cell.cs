namespace AntsVsFlowers.Domain;

public class Cell
{
    public bool IsRevealed { get; private set; }

    public void Reveal()
    {
        IsRevealed = true;
    }
}
