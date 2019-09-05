﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.API.Models
{
    public class SOPHistHeaderDto
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public short Origtype { get; set; }
        public string Orignumb { get; set; }
        public string Docid { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public DateTime Quotedat { get; set; }
        public DateTime Quoexpda { get; set; }
        public DateTime Ordrdate { get; set; }
        public DateTime Invodate { get; set; }
        public DateTime Backdate { get; set; }
        public DateTime Retudate { get; set; }
        public DateTime ReqShipDate { get; set; }
        public DateTime Fufildat { get; set; }
        public DateTime Actlship { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public byte Repting { get; set; }
        public short Trxfrequ { get; set; }
        public short Timerepd { get; set; }
        public short Timetrep { get; set; }
        public short Dystincr { get; set; }
        public DateTime Dtlstrep { get; set; }
        public string Dstbtch1 { get; set; }
        public string Dstbtch2 { get; set; }
        public string Usdocid1 { get; set; }
        public string Usdocid2 { get; set; }
        public decimal Discfrgt { get; set; }
        public decimal Ordavfrt { get; set; }
        public decimal Discmisc { get; set; }
        public decimal Ordavmsc { get; set; }
        public decimal Disavamt { get; set; }
        public decimal Ordavamt { get; set; }
        public decimal Discrtnd { get; set; }
        public decimal Ordisrtd { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public short Dscpctam { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ordatkn { get; set; }
        public string Pymtrmid { get; set; }
        public string Prclevel { get; set; }
        public string Locncode { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Cstponbr { get; set; }
        public short Prospect { get; set; }
        public int Mstrnumb { get; set; }
        public string Pckslpno { get; set; }
        public string Picticnu { get; set; }
        public decimal Mrkdnamt { get; set; }
        public decimal Ormrkdam { get; set; }
        public string Prbtadcd { get; set; }
        public string Prstadcd { get; set; }
        public string Cntcprsn { get; set; }
        public string ShipToName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Ccode { get; set; }
        public string Country { get; set; }
        public string Phnumbr1 { get; set; }
        public string Phnumbr2 { get; set; }
        public string Phone3 { get; set; }
        public string Faxnumbr { get; set; }
        public short Comappto { get; set; }
        public decimal Commamnt { get; set; }
        public decimal Ocommamt { get; set; }
        public decimal Cmmslamt { get; set; }
        public decimal Orcosamt { get; set; }
        public decimal Ncomamnt { get; set; }
        public decimal Orncmamt { get; set; }
        public string Shipmthd { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Ortdisam { get; set; }
        public short Trdispct { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Orsubtot { get; set; }
        public decimal Remsubto { get; set; }
        public decimal Oremsubt { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Ormiscamt { get; set; }
        public byte Txengcld { get; set; }
        public string Taxexmt1 { get; set; }
        public string Taxexmt2 { get; set; }
        public string Txrgnnum { get; set; }
        public string Taxschid { get; set; }
        public short Txschsrc { get; set; }
        public byte Bsivcttl { get; set; }
        public string Frtschid { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public short Frgttxbl { get; set; }
        public string Mscschid { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public short Misctxbl { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Orbktfrt { get; set; }
        public decimal Bktmscam { get; set; }
        public decimal Orbktmsc { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal Txbtxamt { get; set; }
        public decimal Otaxtamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public byte Ectrx { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Pymtrcvd { get; set; }
        public decimal Orpmtrvd { get; set; }
        public decimal Deprecvd { get; set; }
        public decimal Ordeprvd { get; set; }
        public decimal Codamnt { get; set; }
        public decimal Orcodamt { get; set; }
        public decimal Acctamnt { get; set; }
        public decimal Oractamt { get; set; }
        public string Salsterr { get; set; }
        public string Slprsnid { get; set; }
        public string Upszone { get; set; }
        public short Timesprt { get; set; }
        public short Pstgstus { get; set; }
        public short Voidstts { get; set; }
        public short Allocaby { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public short Mctrxstt { get; set; }
        public string Trxsorce { get; set; }
        public byte[] Sophdre1 { get; set; }
        public byte[] Sophdre2 { get; set; }
        public byte[] Soplnerr { get; set; }
        public byte[] Sophdrfl { get; set; }
        public string Commntid { get; set; }
        public string Refrence { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; }
        public string User2ent { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime TaxDate { get; set; }
        public byte Aplywith { get; set; }
        public decimal Withhamt { get; set; }
        public byte Shppgdoc { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public string Docncorr { get; set; }
        public short Seqncorr { get; set; }
        public DateTime Saledate { get; set; }
        public byte Exceptionaldemand { get; set; }
        public short Flags { get; set; }
        public short Sopstatus { get; set; }
        public byte Shipcomplete { get; set; }
        public byte Directdebit { get; set; }
        public short WorkflowApprStatCreditLm { get; set; }
        public short WorkflowPriorityCreditLm { get; set; }
        public short WorkflowApprStatusQuote { get; set; }
        public short WorkflowPriorityQuote { get; set; }
        public short WorkflowStatus { get; set; }
        public short ContractExchangeRateStat { get; set; }
        public short PrintPhoneNumberGb { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }

        public ICollection<SOPTrackingDto> SOPTrackingNumbers { get; set; }
           = new List<SOPTrackingDto>();

        public ICollection<SOPHistLineDto> SOPHistLines { get; set; }
               = new List<SOPHistLineDto>();
        
    }
}
