﻿namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos.Live;

public class JoinTianXuanResponse
{
    public long Discount_id { get; set; }

    public long Gold { get; set; }

    public long Silver { get; set; }

    public long Cur_gift_num { get; set; }

    public long Goods_id { get; set; }

    public required string New_order_id { get; set; }
}
