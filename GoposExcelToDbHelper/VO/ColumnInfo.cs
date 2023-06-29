using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.VO
{
    public struct ColumnInfo
    {
        public string name;
        public string type;
        public bool isNotNull;
        public bool isPk;
        public bool isFk;
        public bool isUnique;
        public bool isIndex;
        public string comment;
        public string defaults;
    }
}
