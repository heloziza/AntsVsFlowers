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
}