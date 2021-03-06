/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// A parameter used in a SQL statement.
    /// </summary>
    public partial class SqlParameter
    {
        private string _name;
        private TypeHint _typeHint;
        private Field _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TypeHint. 
        /// <para>
        /// A hint that specifies the correct object type for data type mapping.
        /// </para>
        ///  
        /// <para>
        ///  <b>Values:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DECIMAL</code> - The corresponding <code>String</code> parameter value is sent
        /// as an object of <code>DECIMAL</code> type to the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMESTAMP</code> - The corresponding <code>String</code> parameter value is
        /// sent as an object of <code>TIMESTAMP</code> type to the database. The accepted format
        /// is <code>YYYY-MM-DD HH:MM:SS[.FFF]</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIME</code> - The corresponding <code>String</code> parameter value is sent
        /// as an object of <code>TIME</code> type to the database. The accepted format is <code>HH:MM:SS[.FFF]</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DATE</code> - The corresponding <code>String</code> parameter value is sent
        /// as an object of <code>DATE</code> type to the database. The accepted format is <code>YYYY-MM-DD</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TypeHint TypeHint
        {
            get { return this._typeHint; }
            set { this._typeHint = value; }
        }

        // Check to see if TypeHint property is set
        internal bool IsSetTypeHint()
        {
            return this._typeHint != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the parameter.
        /// </para>
        /// </summary>
        public Field Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}