using System;
using System.Collections.Generic;

namespace Cient_App_for_Warehouse.Repositories
{
    public interface ITradingPartnerRepository
    {
        TradingPartners Get(string partnerName);

        TradingPartners Get(Guid partnerID);

        IEnumerable<TradingPartners> GetAll();

        void Add(TradingPartners tradingPartner);

        void Update(TradingPartners tradingPartner);

        void Remowe(Guid tradingPartnerID);
    }


}
