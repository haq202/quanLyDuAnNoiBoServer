﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace quanLyDuAnNoiBo.BodQuanLyDuAn
{
    public class DuAnAlrealdyExistsException : BusinessException
    {
        public DuAnAlrealdyExistsException()
            : base(quanLyDuAnNoiBoDomainErrorCodes.DuAnAlreadyExists)
        { }
    }
}
