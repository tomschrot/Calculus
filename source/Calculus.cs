
public sealed class Calculus
{

    public static Calculus operator + (Calculus obj, double value)
    {


        return obj.add (value);
    }

    //-----------------------------------------------------
    // private field

    private double _value = 0D;

    //-----------------------------------------------------
    // property

    public double value => _value;

    //-----------------------------------------------------
    // constructors

    public Calculus () {}

    public Calculus (double value) => setValue (value);

    //-----------------------------------------------------
    // functions

    public Calculus square => this.apply ( _ => _value = (_value * _value) );

    public Calculus sqrt ()
    {
        _value = Math.Sqrt (_value);
        return this;
    }

    public Calculus setValue (double value)
    {
        _value = value;
        return this;
    }

    public Calculus add (double value)
    {
        _value += value;
        return this;
    }

    public Calculus substract (double value)
    {
        _value -= value;
        return this;
    }

    public Calculus multiply (double value)
    {
        _value *= value;
        return this;
    }

    public Calculus divide (double value)
    {
        _value /= value;
        return this;
    }
    //-----------------------------------------------------
}
