// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    public partial class Probe
    {
        private string _host;
        
        /// <summary>
        /// Optional. Host name to send probe to.
        /// </summary>
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }
        
        private uint _interval;
        
        /// <summary>
        /// Optional. Probe interval in seconds. This is the time interval
        /// between two consecutive probes.
        /// </summary>
        public uint Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the Probe.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _path;
        
        /// <summary>
        /// Optional. Relative path of probe. Valid path starts from '/'. Probe
        /// is sent to <Protocol>://<host>:<port><path>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Optional. Protocol used to send probe. Http and Https are valid
        /// protocols.
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        private uint _timeout;
        
        /// <summary>
        /// Optional. Probe timeout in seconds. Probe marked as failed if valid
        /// response is not received with this timeout period.
        /// </summary>
        public uint Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }
        
        private uint _unhealthyThreshold;
        
        /// <summary>
        /// Optional. Probe retry count. Backend server is marked down after
        /// consecutive probe failure count reaches UnhealthyThreshold.
        /// </summary>
        public uint UnhealthyThreshold
        {
            get { return this._unhealthyThreshold; }
            set { this._unhealthyThreshold = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Probe class.
        /// </summary>
        public Probe()
        {
        }
    }
}
