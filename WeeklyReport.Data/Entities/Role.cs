﻿
using System.Collections.Generic;
namespace WeeklyReport.Data.Entities
{
   public class Role
   {
      public int Id { get; set; }
      public string RoleName { get; set; }
      public string Description { get; set; }
      public ICollection<User> Users { get; set; }
   }
}
