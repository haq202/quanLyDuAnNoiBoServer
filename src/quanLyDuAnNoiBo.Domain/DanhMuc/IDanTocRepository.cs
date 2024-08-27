﻿using quanLyDuAnNoiBo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace quanLyDuAnNoiBo.DanhMuc
{
    public interface IDanTocRepository : IRepository<DanToc>
    {
        Task<List<DanToc>> GetAll();
    }
}
