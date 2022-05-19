using System;
using System.ComponentModel.DataAnnotations;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds informations about Users
    /// </summary>
    public class Users
    {
        [Key]
        public int USERSID { get; set; }
        [StringLength(20)]
        public string NAME { get; set; }
        [StringLength(20)]
        public string LASTNAME { get; set; }
        [StringLength(20)]
        public string MAIL { get; set; }
        [StringLength(20)]
        public string PHONE { get; set; }
        public DateTime BIRTHDAY { get; set; }
        public int USERCATEGORYID { get; set; }
        public int COMPANYID { get; set; }

    }
}
