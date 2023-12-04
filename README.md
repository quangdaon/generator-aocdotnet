# generator-aocdotnet

Generator for my [Advent of Code .NET Project](https://github.com/quangdaon/AocDotNet).

## Installation

This generator requires Yeoman. To install it globally:

```
npm i -g yo
```

To install this generator, clone or download this repo and run this command from the root directory:

```
npm link
```

There are no plans on publishing this package to npm.

## Usage

Run the generator from the AdventOfCode solution root like so:

```
yo aocdotnet:processor {year} {day}
```

- `year`: The year of the event, either as the full 4-digit (e.g. `2015`) or the last two digit (e.g. `15`)
- `day`: The challenge day
