using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LRAS.Recharge.Service.DataContract
{
    [DataContract]
    public class DCCommonOrderDetail
    {
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public string RequestId { get; set; }
        [DataMember]
        public string OrderNo { get; set; }
        [DataMember]
        public string IPAddress { get; set; }
        [DataMember]
        public string UserAgent { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string ModuleId { get; set; }
        [DataMember]
        public string ModuleName { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public bool? IsGuest { get; set; }
        [DataMember]
        public bool? IsManual { get; set; }
        [DataMember]
        public string ApplicationId { get; set; }
        [DataMember]
        public string MemberUniqueId { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public DateTime? ModifiedOn { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public DCRechargeOrderDetail RechargeDetail { get; set; }
        [DataMember]
        public IEnumerable<DCCommonOrderContactDetail> OrderContactDetails { get; set; }
    }

    [DataContract]
    public class DCCommonOrderContactDetail
    {
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public string OrderNo { get; set; }
        [DataMember]
        public string Prefix { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string Telephone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public DateTime? ModifiedOn { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
    }
}
