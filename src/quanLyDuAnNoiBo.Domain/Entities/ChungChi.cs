﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace quanLyDuAnNoiBo.Entities
{
    public class ChungChi : FullAuditedEntity<Guid>
    {
        [Required]
        [MaxLength(QuanLyDuAnNoiBoConst.MaxCodeLength)]
        public string MaChungChi { get; set; }
        [Required]
        [MaxLength(QuanLyDuAnNoiBoConst.MaxNameLength)]
        public string TenChungChi { get; set; }
    }
}
