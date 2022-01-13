
WriteLine ("Cleaner C# Code durch Fluent API\nvon Tom Schröter\n");

//-----------------------------------------------------------------------------
WriteLine ("Calculus:");
WriteLine
(
    Calculus
    .create   (2.0D)
    .square
    .root
    .add      (4.0D)
    .multiply (6.0D)
    .operate  (Math.Sqrt)
    .operate  (Math.Pow , 2.0D)
    .operate  (Math.Sin)
    .value
);
//-----------------------------------------------------------------------------
string name = null;

while ( !name.IsValid() )
{
    WriteLine ("enter a valid name: ");
    name = ReadLine ();
}

WriteLine ($"Welcome {name}\n");
//-----------------------------------------------------------------------------
WriteLine ("Example for functional extensions:\n\n1. String.Split");

const StringSplitOptions SPLITOPTIONS =
      StringSplitOptions.None
    | StringSplitOptions.RemoveEmptyEntries
    | StringSplitOptions.TrimEntries
    ;

var text = "Cleaner C# Code With Fluent API";

text
.Split (' ', SPLITOPTIONS)
.each  (word => WriteLine (word) )
;
//-----------------------------------------------------------------------------
WriteLine ("\n2. Reflection");

typeof      (Calculus)
.GetMembers ()
.each       (member => WriteLine (member.Name))
;
//-----------------------------------------------------------------------------
WriteLine ($"\r\nOK @ {DateTime.Now}");
