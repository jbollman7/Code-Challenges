using System;

public class SpaceAge
{
    public int mySeconds;
    public SpaceAge(int seconds)
    {
        mySeconds = seconds;
    }

    public double OnEarth()
    {
        return (((mySeconds / 60) / 60) / 24) / 365.25;
    }

    public double OnMercury()
    {
        return mySeconds / (31557600 * .2408467);
    }

    public double OnVenus()
    {
        return mySeconds / (31557600 * .61519726);
    }

    public double OnMars()
    {
        return mySeconds / (31557600 * 1.8808158);
    }

    public double OnJupiter()
    {
        return mySeconds / (31557600 * 11.862615);
    }

    public double OnSaturn()
    {
        return mySeconds / (31557600 * 29.447498);
    }

    public double OnUranus()
    {
        return mySeconds / (31557600 * 84.016846);
    }

    public double OnNeptune()
    {
        return mySeconds / (31557600 * 164.79132 );
    }
}