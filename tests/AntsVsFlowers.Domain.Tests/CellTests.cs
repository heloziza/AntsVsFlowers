namespace AntsVsFlowers.Domain.Tests;

using AntsVsFlowers.Domain;

public class CellTests
{
    [Fact]
    public void NewCell_IsHidden()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: false);

        // Assert
        Assert.False(cell.IsRevealed);
    }

    [Fact]
    public void Reveal_MakesCellRevealed()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: false);

        // Act
        cell.Reveal();

        // Assert
        Assert.True(cell.IsRevealed);
    }

    [Fact]
    public void NewCell_WithAnthill_HasAnthill()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: true);

        // Assert
        Assert.True(cell.HasAnthill);
    }

    [Fact]
    public void ToggleFlag_OnHiddenCell_FlagsCell()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: false);

        // Act
        cell.ToggleFlag();

        // Assert
        Assert.True(cell.IsFlagged);
    }

    [Fact]
    public void ToggleFlag_OnFlaggedCell_RemovesFlag()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: false);
        cell.ToggleFlag();

        // Act
        cell.ToggleFlag();

        // Assert
        Assert.False(cell.IsFlagged);
    }

    [Fact]
    public void Reveal_OnFlaggedCell_DoesNotReveal()
    {
        // Arrange
        Cell cell = new Cell(hasAnthill: false);
        cell.ToggleFlag();

        // Act
        cell.Reveal();

        // Assert
        Assert.False(cell.IsRevealed);
    }
}