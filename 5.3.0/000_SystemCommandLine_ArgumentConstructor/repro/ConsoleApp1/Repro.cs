using System.CommandLine;

// Repro: `'Argument<int>' does not contain a constructor that takes 2 arguments`
//        emitted on constructor call below.
var repro = new Argument<int>("name", "description");
