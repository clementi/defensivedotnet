---
layout: main
---

## Defend Yourself!

Have you ever found yourself guarding against null or otherwise invalid parameters, like this:

    public void SomeCoolMethodIWrote(string input)
    {
        if (input == null)
            throw new ArgumentNullException("input");

        // Do something interesting with the input
    }

That exception-throwing code, while short, is kinda ugly. Widh Defensive.NET, now you can do this:

    public void SomeCoolMethodIWrote(string input)
    {
        Defend.AgainstNullParameter(input, "input");

        // Do something interesting with the input
    }

You can also defend against parameters that meet any arbitrary condition:

    public void SomeCoolMethodIWrote(int input)
    {
        Defend.Against(input < 0, "input");
    }

## Get It!

You can get it the following ways:

### On GitHub

Just clone it from [GitHub][] and build it:

    git clone git@github.com:clementi/defensivedotnet.git

## Acknowledgements

Defensive.NET is based on code by Loren Whitney.

[github]: http://github.com/clementi/defensivedotnet
