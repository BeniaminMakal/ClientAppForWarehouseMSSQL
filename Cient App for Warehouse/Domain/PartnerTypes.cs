using System;

namespace Cient_App_for_Warehouse.Domain
{
    public interface IPartnerTypes
    {
        int TypeID { get; }
        string TypeName { get; }
    }

    public class PartnerTypes : IPartnerTypes
    {
        public int TypeID { get; private set; }
        public string TypeName { get; private set; }
    }
}
