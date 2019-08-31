using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManageSystem.Common
{
    /// <summary>
    ///此类仅用于权限管理中将权限字符串中的字符0或1转为bool型的true或false，简便操作
    /// </summary>
   public static class CCharToBool
    {
       public static bool CharToBool(char character)
       {
           if (character == '0')
           {
               return false;
           }
           else if (character == '1')
           {
               return true;
           }
           else
               return false;
       }
    }

    /// <summary>
    /// 此类用于权限管理中讲开关状态转为0或1
    /// </summary>
   public static class CBoolToChar
   {
       public static char BoolToChar(bool booler)
       {
           if (booler)
           {
               return '1';
           }
           else 
           {
               return '0';
           }
       }
   }
}
