﻿using System.Security.Cryptography;
using System.Text;

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
        public static string CONNSTR = "Data Source=localhost;Port=3306;Database=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";
        /// <summary>
        /// MD5 암호화 메서드
        /// </summary>
        /// <param name="md5Hash">해시키값</param>
        /// <param name="input">평문 문자열</param>
        /// <returns>암호화된 문자열</returns>
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sbuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("x2"));
            }

            return sbuilder.ToString();
        }
    }
}
