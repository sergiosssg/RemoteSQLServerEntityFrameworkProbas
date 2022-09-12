using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMSSQLServerEntityFrameworkProba
{
    [Table("TEL_VID_CONNECT")]
    public partial class PO_TEL_VID_CONNECT
    {
        [Required]
        [Key]
        [Column("ID_CONNECT")]
        public int IDConnect
        { // ID_CONNECT   - идентификатор вида связи
            get;
            set;
        }

        [Column("KOD_CONNECT")]
        [MaxLength(1)]
        public string KodOfConnect
        { // KOD_CONNECT  - код вида связи
            get;
            set;
        }

        [Column("NAME_CONNECT")]
        [MaxLength(50)]
        public string NameOfConnect
        { // MAME_CONNECT - наименование связи
            get;
            set;
        }



        public PO_TEL_VID_CONNECT()
        {
            this.IDConnect = 0;
            this.KodOfConnect = string.Empty;
            this.NameOfConnect = string.Empty;
            //this.TelefonOperators = new List<PO_TEL_OPERATOR>();
        }

        public bool isIamEmpty()
        {
            if (IDConnect == 0 && KodOfConnect.Equals(string.Empty) && NameOfConnect.Equals(string.Empty))
            {
                return true;
            }

            return false;
            throw new NotImplementedException();
        }


/*
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/



    }
}
