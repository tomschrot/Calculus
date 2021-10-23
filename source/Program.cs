

WriteLine ("Console Application Template for VS Code\nby Tom Schröter");

var c = new Calculus  ()
            .setValue (2D)
            .add      (4D)
            .multiply (6D)
            .sqrt     ()
            .square
            ;

c+= 10D;

WriteLine ( c.value );

WriteLine ($"\r\nOK @ {DateTime.Now}");

