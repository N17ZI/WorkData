//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkData
{
    using System;
    using System.Collections.Generic;
    
    public partial class circus_program
    {
        public int Id_program { get; set; }
        public int presentation { get; set; }
        public System.DateTime data_premiere { get; set; }
        public System.DateTime period { get; set; }
        public System.DateTime daysandtimes { get; set; }
        public int cost_ticket { get; set; }
    
        public virtual presentation presentation1 { get; set; }
    }
}