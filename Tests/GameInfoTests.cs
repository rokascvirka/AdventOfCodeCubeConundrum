using AdventOfCodeCubeConundrum.Models;
using AdventOfCodeCubeConundrum;

public class GameInfoTests
{
    [Fact]
    public void IsGamePossible_ShouldReturnTrue_WhenAllBallsAreWithinLimits()
    {
        // Arrange
        var balls = new List<Balls>
        {
            new Balls(10, 10, 10),
            new Balls(12, 13, 14)  
        };
        var gameInfo = new GameInfo(1, balls);

        // Act
        var result = gameInfo.IsPosible;

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsGamePossible_ShouldReturnFalse_WhenAnyBallExceedsLimits()
    {
        // Arrange
        var balls = new List<Balls>
        {
            new Balls(13, 10, 10),
            new Balls(2, 14, 14), 
            new Balls(1, 1, 16), 
        };
        var gameInfo = new GameInfo(1, balls);

        // Act
        var result = gameInfo.IsPosible;

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void GetPossibleGamesSum_ShouldReturnCorrectSum_WhenGamesArePossible()
    {
        // Arrange
        var gameInfoList = new List<GameInfo>
        {
            new GameInfo(1, new List<Balls> { new Balls(10, 10, 10) }),
            new GameInfo(2, new List<Balls> { new Balls(5, 5, 5) })
        };

        // Act
        var sum = Calculator.GetPossibleGamesSum(gameInfoList);

        // Assert
        Assert.Equal(3, sum); 
    }

    [Fact]
    public void GetPossibleGamesSum_ShouldReturnZero_WhenNoGamesArePossible()
    {
        // Arrange
        var gameInfoList = new List<GameInfo>
        {
            new GameInfo(1, new List<Balls> { new Balls(13, 10, 10) }),
            new GameInfo(2, new List<Balls> { new Balls(14, 10, 10) })  
        };

        // Act
        var sum = Calculator.GetPossibleGamesSum(gameInfoList);

        // Assert
        Assert.Equal(0, sum);
    }

    [Fact]
    public void GetPossibleGamesSum_ShouldReturnCorrectSum_WithMixedPossibleAndImpossibleGames()
    {
        // Arrange
        var gameInfoList = new List<GameInfo>
        {
            new GameInfo(1, new List<Balls> { new Balls(10, 10, 10) }), 
            new GameInfo(2, new List<Balls> { new Balls(14, 10, 10) }), 
            new GameInfo(3, new List<Balls> { new Balls(5, 5, 5) })     
        };

        // Act
        var sum = Calculator.GetPossibleGamesSum(gameInfoList);

        // Assert
        Assert.Equal(4, sum); 
    }

    [Fact]
    public void GetPossibleGamesSum_ShouldReturnZero_WhenListIsEmpty()
    {
        // Arrange
        var gameInfoList = new List<GameInfo>();

        // Act
        var sum = Calculator.GetPossibleGamesSum(gameInfoList);

        // Assert
        Assert.Equal(0, sum);
    }
}


