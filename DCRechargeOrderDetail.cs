using System;
using System.Runtime.Serialization;

namespace LRAS.Recharge.Service.DataContract
{
    [DataContract]
    public class DCRechargeOrderDetail
    {
        [DataMember]
        public string RechargeOrderDetailId { get; set; }
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public string ProviderConfirmationNo { get; set; }
        [DataMember]
        public string Provider { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string Operator { get; set; }
        [DataMember]
        public string AccountNo { get; set; }
        [DataMember]
        public string SubscriberNo { get; set; }
        [DataMember]
        public decimal Surcharge { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public decimal TotalAmount { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public DateTime BookingDate { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public DateTime ModifiedOn { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
    }
}
