"use strict";
import Generator from "yeoman-generator";

export default class extends Generator {
  constructor(args, opts) {
    super(args, opts);

    this.argument("year", {
      alias: "y",
      type: Number,
      required: true
    });

    this.argument("day", {
      alias: "d",
      type: Number,
      required: true
    });
  }

  writing() {
    const year =
      this.options.year > 1000 ? this.options.year : this.options.year + 2000;
    const day = this.options.day;
    const dayFormatted = day.toString().padStart(2, "0");

    const appname = "AdventOfCode.App";
    const processorPath = `${appname}/Challenges/${year}/Day${dayFormatted}Processor.cs`;
    const processorTestPath = `${appname}.Tests/Challenges/${year}/Day${dayFormatted}ProcessorTests.cs`;

    const data = { year, day, dayFormatted };

    this.fs.copyTpl(
      this.templatePath("Processor.cs"),
      this.destinationPath(processorPath),
      data
    );
    this.fs.copyTpl(
      this.templatePath("ProcessorTests.cs"),
      this.destinationPath(processorTestPath),
      data
    );
  }
}
