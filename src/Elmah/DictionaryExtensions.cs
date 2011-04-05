﻿#region License, Terms and Author(s)
//
// ELMAH - Error Logging Modules and Handlers for ASP.NET
// Copyright (c) 2004-9 Atif Aziz. All rights reserved.
//
//  Author(s):
//
//      Atif Aziz, http://www.raboof.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

[assembly: Elmah.Scc("$Id: DictionaryExtensions.cs 645 2009-06-01 21:42:07Z azizatif $")]

namespace Elmah
{
    #region Imports

    using System;
    using System.Collections;
    using System.Collections.Generic;

    #endregion

    static class DictionaryExtensions
    {
        public static V Find<K, V>(this IDictionary<K, V> dict, K key)
        {
            return Find(dict, key, default(V));
        }

        public static V Find<K, V>(this IDictionary<K, V> dict, K key, V @default)
        {
            if (dict == null) throw new ArgumentNullException("dict");
            V value;
            return dict.TryGetValue(key, out value) ? value : @default;
        }

        public static T Find<T>(this IDictionary dict, object key, T @default)
        {
            if (dict == null) throw new ArgumentNullException("dict");
            return (T) (dict[key] ?? @default);
        }
    }
}
