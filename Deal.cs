//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotarialOffice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deal
    {
        public int id { get; set; }
        public System.DateTime DealDate { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }
        public int ServiceID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Service Service { get; set; }
    }
}
