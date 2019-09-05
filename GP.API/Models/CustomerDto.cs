﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.API.Models
{
    public class CustomerDto
    {
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Custclas { get; set; }
        public string Cprcstnm { get; set; }
        public string Cntcprsn { get; set; }
        public string Stmtname { get; set; }
        public string Shrtname { get; set; }
        public string Adrscode { get; set; }
        public string Upszone { get; set; }
        public string Shipmthd { get; set; }
        public string Taxschid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Prbtadcd { get; set; }
        public string Prstadcd { get; set; }
        public string Staddrcd { get; set; }
        public string Slprsnid { get; set; }
        public string Chekbkid { get; set; }
        public string Pymtrmid { get; set; }
        public short Crlmttyp { get; set; }
        public decimal Crlmtamt { get; set; }
        public short Crlmtper { get; set; }
        public decimal Crlmtpam { get; set; }
        public string Curncyid { get; set; }
        public string Ratetpid { get; set; }
        public short Custdisc { get; set; }
        public string Prclevel { get; set; }
        public short Minpytyp { get; set; }
        public decimal Minpydlr { get; set; }
        public short Minpypct { get; set; }
        public short Fnchatyp { get; set; }
        public short Fnchpcnt { get; set; }
        public decimal Finchdlr { get; set; }
        public short Mxwoftyp { get; set; }
        public decimal Mxwrofam { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public string Taxexmt1 { get; set; }
        public string Taxexmt2 { get; set; }
        public string Txrgnnum { get; set; }
        public short Balnctyp { get; set; }
        public short Stmtcycl { get; set; }
        public string Bankname { get; set; }
        public string Bnkbrnch { get; set; }
        public string Salsterr { get; set; }
        public short Defcacty { get; set; }
        public int Rmcshacc { get; set; }
        public int Rmaracc { get; set; }
        public int Rmslsacc { get; set; }
        public int Rmivacc { get; set; }
        public int Rmcosacc { get; set; }
        public int Rmtakacc { get; set; }
        public int Rmavacc { get; set; }
        public int Rmfcgacc { get; set; }
        public int Rmwracc { get; set; }
        public int Rmsoracc { get; set; }
        public DateTime Frstindt { get; set; }
        public byte Inactive { get; set; }
        public byte Hold { get; set; }
        public string Crcardid { get; set; }
        public string Crcrdnum { get; set; }
        public DateTime Ccrdxpdt { get; set; }
        public byte Kpdsthst { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public byte RevalueCustomer { get; set; }
        public short PostResultsTo { get; set; }
        public string Finchid { get; set; }
        public string Govcrpid { get; set; }
        public string Govindid { get; set; }
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public string Docfmtid { get; set; }
        public byte SendEmailStatements { get; set; }
        public short Userlang { get; set; }
        public string Gpsfointegrationid { get; set; }
        public short Integrationsource { get; set; }
        public string Integrationid { get; set; }
        public short Orderfulfilldefault { get; set; }
        public short Custpriority { get; set; }
        public string Ccode { get; set; }
        public string Declid { get; set; }
        public int RmovrpymtWrtoffAcctIdx { get; set; }
        public byte Shipcomplete { get; set; }
        public byte Cbvat { get; set; }
        public byte Includeindp { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }

        public ICollection<CustomerAddressDto> CustomerAddresses { get; set; }
            = new List<CustomerAddressDto>();
    }
}
