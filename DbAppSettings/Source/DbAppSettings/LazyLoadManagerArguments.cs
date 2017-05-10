﻿using DbAppSettings.Model.DataAccess.Interfaces;

namespace DbAppSettings
{
    /// <summary>
    /// Allows passing in of initialization parameters into the DbAppSettingCacheManager
    /// </summary>
    public class LazyLoadManagerArguments : CacheManagerArguments
    {
        /// <summary>
        /// Implementation of the data access layer which will lazy load settings as they are hit as opposed to all settings at startup
        /// </summary>
        public ILazyLoadSettingDao DbAppSettingLazyLoadDao { get; set; }

        /// <summary>
        /// Implementation of the data access layer to save new settings that are not currently in the data access
        /// </summary>
        public ISaveNewSettingDao DbAppSettingSaveNewSettingDao { get; set; }
    }
}
