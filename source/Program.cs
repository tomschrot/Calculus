
WriteLine ("Console Application Template for VS Code\nby Tom Schröter");

WriteLine
(
    new Calculus  (2.0D)
        .square
        .root
        .add      (4.0D)
        .multiply (6.0D)
        .operate  (Math.Sqrt)
        .operate  (Math.Pow , 2.0D)
        .value
);

WriteLine ($"\r\nOK @ {DateTime.Now}");
