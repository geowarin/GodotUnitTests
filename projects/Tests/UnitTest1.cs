using System;
using Godot;
using NUnit.Framework;

namespace Tests;

public class Tests
{

    [Test]
    public void Test1()
    {
        Console.WriteLine("Tests");
        var main = ResourceLoader.Load<PackedScene>("res://Main.tscn").Instantiate<Main>();
        Assert.AreEqual(new StringName("Node3D"), main.Name);
    }
}