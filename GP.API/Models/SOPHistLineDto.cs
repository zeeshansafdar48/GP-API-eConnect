﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.API.Models
{
    public class SOPHistLineDto
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public short Noninven { get; set; }
        public short Dropship { get; set; }
        public string Uofm { get; set; }
        public string Locncode { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Oruntprc { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Oxtndprc { get; set; }
        public decimal Remprice { get; set; }
        public decimal Oreprice { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Mrkdnamt { get; set; }
        public decimal Ormrkdam { get; set; }
        public short Mrkdnpct { get; set; }
        public short Mrkdntyp { get; set; }
        public int Invindx { get; set; }
        public int Cslsindx { get; set; }
        public int Slsindx { get; set; }
        public int Mkdnindx { get; set; }
        public int Rtnsindx { get; set; }
        public int Inusindx { get; set; }
        public int Insrindx { get; set; }
        public int Dmgdindx { get; set; }
        public string Itmtshid { get; set; }
        public short Ivitmtxb { get; set; }
        public decimal Bktslsam { get; set; }
        public decimal Orbktsls { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Txbtxamt { get; set; }
        public decimal Otaxtamt { get; set; }
        public byte Bsivcttl { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Discsale { get; set; }
        public decimal Ordavsls { get; set; }
        public decimal Quantity { get; set; }
        public decimal Atyalloc { get; set; }
        public decimal Qtyinsvc { get; set; }
        public decimal Qtyinuse { get; set; }
        public decimal Qtydmged { get; set; }
        public decimal Qtyrtrnd { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Qtycanot { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtyprbac { get; set; }
        public decimal Qtyprboo { get; set; }
        public decimal Qtyprinv { get; set; }
        public decimal Qtyprord { get; set; }
        public decimal Qtyprvrecvd { get; set; }
        public decimal Qtyrecvd { get; set; }
        public decimal Qtyremai { get; set; }
        public decimal Qtyrembo { get; set; }
        public decimal Qtytbaor { get; set; }
        public decimal Qtytoinv { get; set; }
        public decimal Qtytordr { get; set; }
        public decimal Qtyfulfi { get; set; }
        public decimal Qtyslctd { get; set; }
        public decimal Qtybsuom { get; set; }
        public decimal Extqtyal { get; set; }
        public decimal Extqtysel { get; set; }
        public DateTime ReqShipDate { get; set; }
        public DateTime Fufildat { get; set; }
        public DateTime Actlship { get; set; }
        public string Shipmthd { get; set; }
        public string Salsterr { get; set; }
        public string Slprsnid { get; set; }
        public string Prclevel { get; set; }
        public string Commntid { get; set; }
        public short Brkfld1 { get; set; }
        public short Brkfld2 { get; set; }
        public short Brkfld3 { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; }
        public byte[] Soplnerr { get; set; }
        public string Docncorr { get; set; }
        public int Orgseqnm { get; set; }
        public string Itemcode { get; set; }
        public short Purchstat { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Odecplcu { get; set; }
        public byte Exceptionaldemand { get; set; }
        public string Taxschid { get; set; }
        public short Txschsrc { get; set; }
        public string Prstadcd { get; set; }
        public string ShipToName { get; set; }
        public string Cntcprsn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Ccode { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Faxnumbr { get; set; }
        public short Flags { get; set; }
        public string Contnbr { get; set; }
        public decimal Contlnseqnbr { get; set; }
        public DateTime Contstartdte { get; set; }
        public DateTime Contenddte { get; set; }
        public string Contitemnbr { get; set; }
        public string Contserialnbr { get; set; }
        public byte Islineintra { get; set; }
        public short PrintPhoneNumberGb { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
        
    }
}
