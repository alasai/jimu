﻿using MiniDDD.UnitOfWork;
using System;

namespace Jimu.Server.Repository.MiniDDD.DapperIntegration
{
    public class MiniDDDDapperOptions
    {
        public string ConnectionString { get; set; }
        public DbType DbType { get; set; }

        /// <summary>
        /// enable logging sql, this will effect lower perfermance, always just using in debug
        /// </summary>
        //public bool OpenLogTrace { get; set; }
    }
}
