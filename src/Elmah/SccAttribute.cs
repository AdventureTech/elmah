#region License, Terms and Author(s)
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

[assembly: Elmah.Scc("$Id: SccAttribute.cs 640 2009-06-01 17:22:02Z azizatif $")]

namespace Elmah
{
    #region Imports

    using System;

    #endregion

    [ Serializable ]
    [ AttributeUsage(AttributeTargets.Class | AttributeTargets.Assembly, AllowMultiple = true) ]
    public sealed class SccAttribute : Attribute
    {
        private string _id;

        public SccAttribute(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id ?? string.Empty; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return Id;
        }
    }
}
