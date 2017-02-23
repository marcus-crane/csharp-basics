#Disposables!

Hello Sentry!!!!

One of the biggest slip ups people make when writing code like this is to ignore
the unmanaged resources that C# uses. As you may know, Garbage Collection is a
powerful tool that many people rely on. However, C# GC will refuse to collect
a lot of unmanaged resources if any object still holds on to it. There's a name
for it but I forget. This leads to memory leaks.

##IDisposable

Objects that use unmanaged resources will most always inherit from the interface
*IDisposable*. This means that the class has an implementation of the *Dispose()*
method, which will clean up any unmanaged resources the instance is using. Streams
will most likely implement this, and require their resources cleaning up.

##The using keyword
Common practice for using unmanaged resources would be to do something like this:

    TextReader reader;
    try
    {
        reader = new TextReader();
        // Do stuff here
    }
    catch
    {
        // ...
    }
    finally
    {
        reader.Dispose();
    }

As you can imagine, this got super gross. Luckily, C# came up with some nice
syntax : the using statement. The above can be changed to:

    using(TextReader reader = new TextReader())
    {
        // Do stuff here..
    }

And that's it! Of course this doesn't catch exceptions, but if you let the
exception bubble up the stack, it will still call the Dispose();

##Changes

I have rewritten your code to take advantage of the using statements. I'm in
Atom so I dunno if it'll compile if I make a slip up. 
