using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalShop.SubItems
{
    public enum BaseMode
    {
        NONE,       //아무것도 아닌상태
        INSERT,     //입력 상태
        UPDATE,     //수정 상태
        DELETE,
        SELECT
    }
    class Commens
    {
        public static readonly string CONNSTR = "Data Source=localhost;Port=3306;Database=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";
    }
}
