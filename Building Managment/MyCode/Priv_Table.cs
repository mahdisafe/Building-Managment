namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Priv_Table
    {
        public int? Priv_User_ID { get; set; }

        public int? Priv_Screen_No { get; set; }

        public bool? Priv_Display { get; set; }

        public bool? Priv_Add { get; set; }

        public bool? Priv_Edit { get; set; }

        public bool? Priv_Delete { get; set; }

        public int ID { get; set; }

        public virtual Screen_Priv_Table Screen_Priv_Table { get; set; }

        public virtual User_Table User_Table { get; set; }
    }
}
