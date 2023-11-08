using AdventOfCode.App.Challenges;
using Xunit;

namespace AdventOfCode.App.Tests.Challenges;

public class Aoc<%= year %>Day<%= dayFormatted %>ProcessorTest : ChallengeProcessorTests
{
  private readonly Aoc<%= year %>Day<%= dayFormatted %>Processor processor;
  public Aoc<%= year %>Day<%= dayFormatted %>ProcessorTest() : base(<%= year %>, <%= day %>)
  {
    processor = new Aoc<%= year %>Day<%= dayFormatted %>Processor();
  }
}
