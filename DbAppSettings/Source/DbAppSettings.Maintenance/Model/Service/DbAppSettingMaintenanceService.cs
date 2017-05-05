﻿using System.Collections.Generic;
using DbAppSettings.Maintenance.Model.DataAccess.Maintenance.Interfaces;
using DbAppSettings.Maintenance.Model.Service.Interfaces;
using DbAppSettings.Model.DataTransfer;

namespace DbAppSettings.Maintenance.Model.Service
{
    public class DbAppSettingMaintenanceService : IDbAppSettingMaintenanceService
    {
        private readonly IDbAppSettingMaintenanceDao _dbAppSettingMaintenanceDao;

        public DbAppSettingMaintenanceService(IDbAppSettingMaintenanceDao dao)
        {
            _dbAppSettingMaintenanceDao = dao;
        }

        public List<DbAppSettingDto> GetAll()
        {
            return _dbAppSettingMaintenanceDao.GetAll();
        }

        public void SaveDbAppSetting(DbAppSettingDto dto)
        {
            _dbAppSettingMaintenanceDao.SaveDbAppSetting(dto);
        }

        public void DeleteDbAppSetting(DbAppSettingDto dto)
        {
            _dbAppSettingMaintenanceDao.DeleteDbAppSetting(dto);
        }
    }
}