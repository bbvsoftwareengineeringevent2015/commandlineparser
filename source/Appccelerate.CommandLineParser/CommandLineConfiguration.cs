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
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandLineConfiguration
    {
        private readonly IEnumerable<Action<string>> unnamed;

        private readonly IEnumerable<Tuple<string, Action<string>>> named;

        private readonly IEnumerable<Tuple<string, Action>> switches;

        public CommandLineConfiguration(
            IEnumerable<Action<string>> unnamed,
            IEnumerable<Tuple<string, Action>> switches,
            IEnumerable<Tuple<string, Action<string>>> named)
        {
            this.unnamed = unnamed;
            this.switches = switches;
            this.named = named;
        }

        public IEnumerable<Action<string>> Unnamed
        {
            get
            {
                return this.unnamed;
            }
        }

        public IEnumerable<Tuple<string, Action>> Switches
        {
            get
            {
                return this.switches;
            }
        }

        public IEnumerable<Tuple<string, Action<string>>> Named
        {
            get
            {
                return this.named;
            }
        }
    }
}