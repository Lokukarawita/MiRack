﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaRack.Core.Data.Common
{
    /// <summary>
    /// Synchronization status for local data
    /// </summary>
    [Serializable]
    public enum LocalSyncStatus : int
    {
        /// <summary>
        /// Item is new and not present in remote data storage
        /// </summary>
        NEW,
        /// <summary>
        /// Remote and local data was synced
        /// </summary>
        SYNCED,
        /// <summary>
        /// Local data was changed and a corresponding remote data entry needs to be updated 
        /// </summary>
        CHANGED,
        /// <summary>
        /// Items is marked for deletion
        /// </summary>
        DELETED
    }
}
