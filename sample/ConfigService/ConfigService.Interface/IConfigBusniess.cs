﻿using ConfigService.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService.Interface
{
    public interface IConfigBusniess
    {
        /// <summary>
        /// 查询项目配置信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<QueryConfigOutput> QueryConfig(QueryConfigInput input);
    }
}
