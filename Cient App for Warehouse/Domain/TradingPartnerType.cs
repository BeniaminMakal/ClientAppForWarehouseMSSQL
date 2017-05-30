using System;

namespace Cient_App_for_Warehouse.Domain
{
    public interface ITradingPartnerType
    {
        int TradingPartnerTypeID { get; }
        TradingPartners TrafingPartnerID { get; }
        PartnerTypes PartnerTypesID { get; }
    }

    public class TradingPartnerType : ITradingPartnerType
    {
        public int TradingPartnerTypeID { get; private set; }

        public TradingPartners TrafingPartnerID { get; private set; }

        public PartnerTypes PartnerTypesID { get; private set; }
    }
}
