namespace AntsVsFlowers.Domain;

public class Cell
{
    public bool IsRevealed { get; private set; }
    public bool HasAnthill { get; }
    public bool IsFlagged { get; private set; }

    public Cell(bool hasAnthill)
    {
        HasAnthill = hasAnthill;
    }

    public void Reveal()
    {
        IsRevealed = true;
    }

    public void ToggleFlag()
    {
        IsFlagged = !IsFlagged;
    }
}
