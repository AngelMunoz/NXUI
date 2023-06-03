﻿using System.Reflection;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public static class MainGenerator
{
    
    public static void GenerateFSharpExtensions(string outputPath, List<Class> classes)
    {
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
        ExtensionsGenerator.Generate(outputPath, classes, genFSharp:true);
    }
    
    public static void Generate(string outputPath, Predicate<Assembly> assemblyFilter, Predicate<Type> typeFilter, bool genFSharp = false)
    {
        var buildersPath = Path.Combine(outputPath, "Builders");
        var propertiesPath = Path.Combine(outputPath, "Properties");
        var eventsPath = Path.Combine(outputPath, "Events");
        var extensionsPath = Path.Combine(outputPath, "Extensions");
        var settersPath = Path.Combine(outputPath, "Setters");

        var classes = Factory.CreateClasses(assemblyFilter, typeFilter);
        
        if (classes is null)
        {
            return;
        }

        if (genFSharp)
        {
            var fsharpExtensionsPath = Path.Combine(outputPath, "FSharp", "Extensions");
            GenerateFSharpExtensions(fsharpExtensionsPath, classes);
            return;
        }
        
        if (!Directory.Exists(buildersPath))
        {
            Directory.CreateDirectory(buildersPath);
        }
        BuildersGenerator.Generate(buildersPath, classes);

        if (!Directory.Exists(propertiesPath))
        {
            Directory.CreateDirectory(propertiesPath);
        }
        PropertiesGenerator.Generate(propertiesPath, classes);

        if (!Directory.Exists(eventsPath))
        {
            Directory.CreateDirectory(eventsPath);
        }
        EventsGenerator.Generate(eventsPath, classes);

        if (!Directory.Exists(extensionsPath))
        {
            Directory.CreateDirectory(extensionsPath);
        }
        ExtensionsGenerator.Generate(extensionsPath, classes);

        if (!Directory.Exists(settersPath))
        {
            Directory.CreateDirectory(settersPath);
        }
        SettersGenerator.Generate(settersPath, classes);
    }
}
