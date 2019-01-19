using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Repository;
using System;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Common
{

    public static class EnumHelper
    {
        private static CodeRepository codeRepository;
        private static List<Code> codeList;

        static EnumHelper()
        {
            codeRepository = new CodeRepository();
            codeList = codeRepository.SelectAllCode();
        }

        public static object GetEnum(Type enumType, object dbCode)
        {
            string typeName = enumType.Name;
            Code code = codeList.Find(d => d.className == typeName && d.code == dbCode.ToString());

            return System.Enum.Parse(enumType, code.codeName);
        }

        public static object GetDBCode(System.Enum enumValue)
        {
            string typeName = enumValue.GetType().Name;
            Code code = codeList.Find(d => d.className == typeName && d.codeName == enumValue.ToString());

            return code.code;
        }

        public static string GetDescription(System.Enum enumValue)
        {
            string typeName = enumValue.GetType().Name;
            Code code = codeList.Find(d => d.className == typeName && d.codeName == enumValue.ToString());

            return code.codeName;
        }

        public static string GetDescription(Type enumType, object dbCode)
        {
            string typeName = enumType.Name;
            Code code = codeList.Find(d => d.className == typeName && d.code == dbCode.ToString());

            return code.codeName;
        }
    }

}
