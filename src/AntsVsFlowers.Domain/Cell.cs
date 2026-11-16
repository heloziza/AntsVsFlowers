namespace AntsVsFlowers.Domain;

public class Cell
{
    public bool IsRevealed { get; private set; }
    public bool HasAnthill { get; }

    public Cell(bool hasAnthill)
    {
        HasAnthill = hasAnthill;
    }

    public void Reveal()
    {
        IsRevealed = true;
    }
}
