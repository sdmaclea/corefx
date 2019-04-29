// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Globalization;
using Xunit;
using ReferencedClassLib;
using ReferencedClassLibNeutralIsSatellite;

namespace System.Runtime.Loader.Tests
{
    public class SatelliteAssembliesTestsFixture
    {
        public Dictionary<string, AssemblyLoadContext> contexts = new Dictionary<string, AssemblyLoadContext>();
        public SatelliteAssembliesTestsFixture()
        {
            AssemblyLoadContext satelliteAssembliesTests = new AssemblyLoadContext("SatelliteAssembliesTests");
            satelliteAssembliesTests.LoadFromAssemblyPath(typeof(SatelliteAssembliesTests).Assembly.Location);

            AssemblyLoadContext referencedClassLib = new AssemblyLoadContext("ReferencedClassLib");
            referencedClassLib.LoadFromAssemblyPath(typeof(ReferencedClassLib.Program).Assembly.Location);

            AssemblyLoadContext referencedClassLibNeutralIsSatellite = new AssemblyLoadContext("ReferencedClassLibNeutralIsSatellite");
            referencedClassLibNeutralIsSatellite.LoadFromAssemblyPath(typeof(ReferencedClassLibNeutralIsSatellite.Program).Assembly.Location);
            referencedClassLibNeutralIsSatellite.LoadFromAssemblyPath(typeof(ReferencedClassLibNeutralIsSatellite.Program).Assembly.Location);

            new AssemblyLoadContext("Empty");

            AssemblyLoadContext referencedClassLibEn = new AssemblyLoadContext("ReferencedClassLib.en");
            string parentDir = Path.GetDirectoryName(typeof(ReferencedClassLib.Program).Assembly.Location);
            string name = typeof(ReferencedClassLib.Program).Assembly.GetName().Name + ".resources.dll";
            string path = Path.Combine(parentDir, "en", name);
            Console.WriteLine(path);
            // *** The following line is commented out due to #37246 / dotnet/sdk#3185
            //
            // referencedClassLibEn.LoadFromAssemblyPath(Path.Combine(parentDir, "en", name));

            Assembly assembly = Assembly.LoadFile(typeof(SatelliteAssembliesTests).Assembly.Location);
            contexts["LoadFrom"] = AssemblyLoadContext.GetLoadContext(assembly);

            foreach (var alc in AssemblyLoadContext.All)
            {
                if (alc.Name != null)
                    contexts[alc.Name] = alc;
            }
        }
    }

    public class SatelliteAssembliesTests : IClassFixture<SatelliteAssembliesTestsFixture>
    {
        Dictionary<string, AssemblyLoadContext> contexts;
        public SatelliteAssembliesTests(SatelliteAssembliesTestsFixture fixture)
        {
            contexts = fixture.contexts;
        }

        [Theory]
        [InlineData("", "Neutral language Main description 1.0.0")]
        [InlineData("en", "English language Main description 1.0.0")]
        [InlineData("en-US", "English language Main description 1.0.0")]
        [InlineData("es", "Neutral language Main description 1.0.0")]
        [InlineData("es-MX", "Spanish (Mexico) language Main description 1.0.0")]
        [InlineData("fr", "Neutral language Main description 1.0.0")]
        [InlineData("fr-FR", "Neutral language Main description 1.0.0")]
        static public void mainResources(string lang, string expected)
        {
            ResourceManager rm = new ResourceManager(typeof(MainStrings));

            CultureInfo ci = CultureInfo.CreateSpecificCulture(lang);

            Assert.Equal(expected, Describe(lang));
        }

        public static string Describe(string lang)
        {
            ResourceManager rm = new ResourceManager(typeof(MainStrings));

            CultureInfo ci = CultureInfo.CreateSpecificCulture(lang);

            return rm.GetString("Describe", ci);
        }

        [Theory]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "",      "Neutral language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en",    "English language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en-US", "English language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es",    "Neutral language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es-MX", "Spanish (Mexico) language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr",    "Neutral language Main description 1.0.0")]
        [InlineData("Default", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr-FR", "Neutral language Main description 1.0.0")]
        public void describeLib(string alc, string type, string culture, string expected)
        {
            string result = "Oops";
            try
            {
                using (contexts[alc].EnterContextualReflection())
                {
                    Type describeType = Type.GetType(type);

                    result = (String)describeType.InvokeMember("Describe", BindingFlags.InvokeMethod, null, null, new object[] { culture });
                }

            }
            catch
            {
                result = "threw";
            }

            Assert.Equal(expected, result);
        }

        [Theory]
        [ActiveIssue("dotnet/coreclr#24191")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "",      "Neutral language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en",    "English language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en-US", "English language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es",    "Neutral language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es-MX", "Spanish (Mexico) language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr",    "Neutral language Main description 1.0.0")]
        [InlineData("SatelliteAssembliesTests", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr-FR", "Neutral language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "",      "Neutral language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en",    "English language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "en-US", "English language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es",    "Neutral language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "es-MX", "Spanish (Mexico) language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr",    "Neutral language Main description 1.0.0")]
        [InlineData("LoadFrom", "System.Runtime.Loader.Tests.SatelliteAssembliesTests", "fr-FR", "Neutral language Main description 1.0.0")]
        public void describeLib24191(string alc, string type, string culture, string expected)
        {
            describeLib(alc, type, culture, expected);
        }

        [Theory]
        [ActiveIssue("dotnet/sdk#3185")]
        [ActiveIssue("dotnet/corefx#37246")]
        [ActiveIssue("dotnet/coreclr#24191")]
        [InlineData("ReferencedClassLib", "ReferencedClassLib.Program", "",        "Neutral language ReferencedClassLib description 1.0.0")]
        [InlineData("ReferencedClassLib", "ReferencedClassLib.Program", "en",      "English language ReferencedClassLib description 1.0.0")]
        [InlineData("ReferencedClassLib", "ReferencedClassLib.Program", "en-US",   "English language ReferencedClassLib description 1.0.0")]
        [InlineData("ReferencedClassLib", "ReferencedClassLib.Program", "es",      "Neutral language ReferencedClassLib description 1.0.0")]
        [InlineData("ReferencedClassLibNeutralIsSatellite", "ReferencedClassLibNeutralIsSatellite.Program", "",        "Neutral (es) language ReferencedClassLibNeutralIsSatellite description 1.0.0")]
        [InlineData("ReferencedClassLibNeutralIsSatellite", "ReferencedClassLibNeutralIsSatellite.Program", "en",      "English language ReferencedClassLibNeutralIsSatellite description 1.0.0")]
        [InlineData("ReferencedClassLibNeutralIsSatellite", "ReferencedClassLibNeutralIsSatellite.Program", "en-US",   "English language ReferencedClassLibNeutralIsSatellite description 1.0.0")]
        [InlineData("ReferencedClassLibNeutralIsSatellite", "ReferencedClassLibNeutralIsSatellite.Program", "es",      "Neutral (es) language ReferencedClassLibNeutralIsSatellite description 1.0.0")]
        public void describeLib3185(string alc, string type, string culture, string expected)
        {
            describeLib(alc, type, culture, expected);
        }

        [Theory]
        [InlineData("Default", "System.Runtime.Loader.Tests.resources", "en")]
        [InlineData("Default", "System.Runtime.Loader.Tests.resources", "es-MX")]
        public void SatelliteLoadsCorrectly(string alc, string assemblyName, string culture)
        {
        }

        [InlineData("Default", "ReferencedClassLib.resources", "en")]
        [InlineData("Default", "ReferencedClassLibNeutralIsSatellite.resources", "en")]
        [InlineData("Default", "ReferencedClassLibNeutralIsSatellite.resources", "es")]
        public void SatelliteLoadsCorrectly3185(string alc, string assemblyName, string culture)
        {
            SatelliteLoadsCorrectly(alc, assemblyName, culture);
        }

    }

    class MainStrings
    {
    }
}

