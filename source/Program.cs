
WriteLine ("Cleaner C# Code durch Fluent API\nvon Tom Schröter\n");
WriteLine ("Calculus:");

WriteLine
(
    new Calculus  (2.0D)
        .square
        .root
        .add      (4.0D)
        .multiply (6.0D)
        .operate  (Math.Sqrt)
        .operate  (Math.Pow , 2.0D)
        .operate  (Math.Sin)
        .value
);

WriteLine ($"\r\nOK @ {DateTime.Now}");
