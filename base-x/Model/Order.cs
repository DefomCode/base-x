//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace base_x.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Order_code { get; set; }
        public Nullable<int> Client_code { get; set; }
        public Nullable<System.DateTime> Date_order { get; set; }
        public Nullable<int> Bicycle_code { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Bicycle Bicycle { get; set; }
        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
    }
}
