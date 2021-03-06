﻿// 
// Copyright (c) Microsoft.  All rights reserved. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//   http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// 

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Search
{
    public partial interface IIndexerOperations
    {
        /// <summary>
        /// Determines whether or not the given indexer exists in the Azure Search service.
        /// </summary>
        /// <param name="indexerName">
        /// The name of the indexer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// <c>true</c> if the indexer exists; <c>false</c> otherwise.
        /// </returns>
        Task<bool> ExistsAsync(string indexerName, CancellationToken cancellationToken);
    }
}
