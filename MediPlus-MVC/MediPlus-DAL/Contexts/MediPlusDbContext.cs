﻿using MediPlus_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MediPlus_DAL.Contexts
{
    public class MediPlusDbContext :DbContext
    {
        DbSet<SliderItem> SliderItems { get; set; }
        public MediPlusDbContext(DbContextOptions<MediPlusDbContext> options)
       : base(options)
        {
        }

    }
}
