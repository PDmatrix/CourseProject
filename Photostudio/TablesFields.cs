// ReSharper disable All
namespace Photostudio
{
    internal static class TablesFields
    {
        //Расширение для Enum
        public static string Name<T>(this T t)
        {
            return t.ToString();
        }

        //Таблицы
        public enum Tables
        {
            ORDERS,
            PHOTOGRAPHERS,
            ASSISTANTS,
            CUSTOMERS,
            SERVICES,
            ASSISTANCE
        }

        //Поля таблицы CUSTOMERS
        public enum CustomerFields
        {
            CUS_Code,
            CUS_Fullname,
            CUS_Adress,
            CUS_Phone
        }

        //Поля таблицы ORDERS
        public enum OrdersFileds
        {
            ORD_Code,
            ORD_CusCode,
            ORD_PhoCode,
            ORD_SerCode,
            ORD_Date,
            ORD_Exec
        }

        //Поля таблицы PHOTOGRAPHERS
        public enum PhotographersFileds
        {
            PHO_Code,
            PHO_Fullname,
            PHO_Experience,
            PHO_Date,
            PHO_Phone,
            PHO_Adress
        }

        //Поля таблицы ASSISTANTS
        public enum AssistantsFileds
        {
            ASS_Code,
            ASS_Fullname,
            ASS_Phone
        }

        //Поля таблицы SERVICES
        public enum ServicesFileds
        {
            SER_Code,
            SER_Description,
            SER_Price
        }

        //Поля таблицы ASSISTANCE
        public enum AssistanceFileds
        {
            ASCE_Code,
            ASCE_AssCode,
            ASCE_OrdCode
        }
    }
}
