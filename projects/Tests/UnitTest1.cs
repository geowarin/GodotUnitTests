using System;
using Godot;
using NUnit.Framework;

namespace Tests;

public class Tests
{

    [Test]
    public void Test1()
    {
        int i = 0;
        Console.WriteLine("Testsss");
        GD.Print("NUnitTest");
        var main = ResourceLoader.Load<PackedScene>("res://Main.tscn").Instantiate<Main>();
        Assert.AreEqual("Main", main.Name);
    }
}