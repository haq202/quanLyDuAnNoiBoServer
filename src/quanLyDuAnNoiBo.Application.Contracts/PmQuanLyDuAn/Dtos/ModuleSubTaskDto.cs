﻿using quanLyDuAnNoiBo.BoDQuanLyDuAn.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace quanLyDuAnNoiBo.PmQuanLyDuAn.Dtos
{
    public class ModuleSubTaskDto
    {
        public Guid Id { get; set; }
        public string TenModule { get; set; }
        public double PM { get; set; }
        public double Dev { get; set; }
        public double Test { get; set; }
        public double BA { get; set; }
        public double TongThoiGian { get; set; }
        public List<SubtaskInfo> SubTasks { get; set; }
    }
}
