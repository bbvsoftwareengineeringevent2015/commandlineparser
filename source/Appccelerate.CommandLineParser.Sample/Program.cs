﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Appccelerate">
//   Copyright (c) 2008-2015
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Appccelerate.CommandLineParser.Sample
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string output = null;
            bool debug = false;
            string path = null;

            var parser = CommandLineParserConfigurator
                .Create()
                    .WithNamed("o", v => output = v)
                        .HavingLongAlias("output")
                    .WithSwitch("d", () => debug = true)
                        .HavingLongAlias("debug")
                    .WithUnnamed(v => path = v)
                        .Required()
                .BuildParser();

            var parseResult = parser.Parse(args);

            Console.WriteLine(parseResult.Succeeded ? 
                "parsed successfully: path = " + path + ", output = " + output + ", debug = " + debug : 
                "parsing failed: " + parseResult.Message);
        }
    }
}
