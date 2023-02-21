using Xunit;
using stapel;

public class StapelTest{
    [Fact]
    public void DuwTest(){
        // Arrange
        var stapel = new Stapel<int>();

        // Act
        stapel.Duw(1);

        // Assert
        Assert.Equal(1, stapel.Pak());
    }

    [Fact]
    public void PakLeegTest(){
        // Arrange
        var stapel = new Stapel<int>();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => stapel.Pak());
    }

    [Fact]
    public void Pak_ReturnsElementsInLastInFirstOutOrder(){
        // Arrange
        var stapel = new Stapel<int>();
        stapel.Duw(1);
        stapel.Duw(2);
        stapel.Duw(3);

        // Act & Assert
        Assert.Equal(3, stapel.Pak());
        Assert.Equal(2, stapel.Pak());
        Assert.Equal(1, stapel.Pak());
    }
}