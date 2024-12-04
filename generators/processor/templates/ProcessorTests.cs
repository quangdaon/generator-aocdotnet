using AdventOfCode.App.Challenges;
using Xunit;

namespace AdventOfCode.App.Tests.Challenges;

public class Aoc<%= year %>Day<%= dayFormatted %>ProcessorTest : ChallengeProcessorTests
{
  private readonly Aoc<%= year %>Day<%= dayFormatted %>Processor _processor;
  public Aoc<%= year %>Day<%= dayFormatted %>ProcessorTest() : base(<%= year %>, <%= day %>)
  {
    _processor = new Aoc<%= year %>Day<%= dayFormatted %>Processor();
  }

  [Fact]
  public void ProcessPart1Solution_GivenSampleInputs_ReturnsProvidedResult()
  {
    var input = GetSampleInput();

    var result = _processor.ProcessPart1Solution(input);

    Assert.Equal("???", result);
  }


  [Fact]
  public void ProcessPart2Solution_GivenSampleInputs_ReturnsProvidedResult()
  {
    var input = GetSampleInput();

    var result = _processor.ProcessPart2Solution(input);

    Assert.Equal("???", result);
  }
}
