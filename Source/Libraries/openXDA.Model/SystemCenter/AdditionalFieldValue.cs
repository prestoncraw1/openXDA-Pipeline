﻿//******************************************************************************************************
//  AdditionalFieldValue.cs - Gbtc
//
//  Copyright © 2020, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  01/28/2020 - Billy Ernest
//       Generated original version of source code.
//
//******************************************************************************************************
using GSF.Data.Model;

namespace SystemCenter.Model
{
    [UseEscapedName, TableName("AdditionalFieldValue")]
    [AllowSearch]
    [PatchRoles("Administrator, Transmission SME")]
    [PostRoles("Administrator, Transmission SME")]
    [DeleteRoles("Administrator, Transmission SME")]
    public class AdditionalFieldValue
    {
        [PrimaryKey(true)]
        public int ID { get; set; }
        [ParentKey(typeof(int))]
        public int ParentTableID { get; set; }
        public int AdditionalFieldID { get; set; }
        public string Value { get; set; }
    }
}