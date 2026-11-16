namespace AntsVsFlowers.Domain.Tests;

using AntsVsFlowers.Domain;

public class CellTests
{
    [Fact]
    public void NewCell_IsHidden()
    {
        // Arrange
        Cell cell = new Cell();

        // Assert
        Assert.False(cell.IsRevealed);
    }

    [Fact]
    public void Reveal_MakesCellRevealed()
    {
        // Arrange
        Cell cell = new Cell();

        // Act
        cell.Reveal();

        // Assert
        Assert.True(cell.IsRevealed);
    }
}