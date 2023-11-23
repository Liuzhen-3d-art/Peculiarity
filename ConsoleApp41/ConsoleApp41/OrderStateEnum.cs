using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApp41
{
   public enum OrderStateEnum
    {
            [Description(description:"待支付")]
            waitpay,
            [Description("待发货")]
            waitSend,
            [Description("待收货")]
            WaitReceive,
            [Description("待评价")]
            WaitComment,
            [Description("已完成")]
            Finish,
            [Description("取消订单")]
            Cancel
    }
}
