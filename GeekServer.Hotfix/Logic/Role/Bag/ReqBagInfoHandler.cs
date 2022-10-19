﻿namespace Geek.Server.Role
{
    [MsgMapping(typeof(ReqBagInfo))]
    public class ReqBagInfoHandler : RoleCompHandler<BagCompAgent>
    {
        public override async Task ActionAsync()
        {
            await Comp.GetBagInfo(Channel, Msg as ReqBagInfo);
        }
    }
}
