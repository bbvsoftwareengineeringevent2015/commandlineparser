﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandLineConfiguration.cs" company="Appccelerate">
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

namespace Appccelerate.CommandLineParser
{
    using System.Collections.Generic;

    public class CommandLineConfiguration
    {
        public CommandLineConfiguration(
            IEnumerable<IArgument> arguments, 
            IDictionary<string, IArgumentWithName> longAliases,
            IEnumerable<IArgument> requiredArguments,
            IDictionary<IArgument, Help> help)
        {
            this.Arguments = arguments;
            this.LongAliases = longAliases;
            this.RequiredArguments = requiredArguments;
            this.Help = help;
        }

        public IEnumerable<IArgument> Arguments { get; private set; }

        public IDictionary<string, IArgumentWithName> LongAliases { get; private set; }

        public IEnumerable<IArgument> RequiredArguments { get; private set; }

        public IDictionary<IArgument, Help> Help { get; private set; }
    }
}