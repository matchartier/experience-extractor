﻿//--------------------------------------------------------------------------------------------
// Copyright 2015 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// -------------------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Analytics.Aggregation.Data.Model;
using ExperienceExtractor.Processing.DataSources;

namespace ExperienceExtractor.Tests.Support
{
    class SimpleDataSource : DataSourceBase
    {
        public override long? Count { get { return _src.Length; } }        

        private readonly IVisitAggregationContext[] _src;

        public SimpleDataSource(IEnumerable<IVisitAggregationContext> src)
        {
            _src = src.ToArray();
        }

        public override IEnumerator GetEnumerator()
        {
            return _src.GetEnumerator();
        }


        public override void ApplyUpdateFilter(DateTime? lastSaveDate, DateTime? lastSaveDateEnd)
        {
            throw new NotImplementedException();
        }
    }
}
