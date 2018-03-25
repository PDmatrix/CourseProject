using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photostudio
{
    public static class TablesClass
    {
        public static string SelectedTable = "ORDERS";

        public static readonly Dictionary<string, string> Table = new Dictionary<string, string> {
            { "ORDERS", "Заказы" },
            { "PHOTOGRAPHERS", "Фотографы" },
            { "ASSISTANTS", "Ассистенты" },
            { "CUSTOMERS", "Заказчики" },
            { "SERVICES", "Услуги" },
            { "ASSISTANCE", "Помощь" }
        };

        public static readonly Dictionary<string, string> TableDescription = new Dictionary<string, string>
        {
            { "ORDERS", "Таблица представляет собой заказы фотостудии. Содержит код заказа, " +
                "клиента, фотографа, ассистента если имеется, услугу, дату выполнения и выполнен ли заказ." },
            { "PHOTOGRAPHERS", "Таблица представляет собой фотографов. Содержит код фотографа, " +
                "фамилию, имя, отчество, стаж работы, дату рождения, телефон и адрес." },
            { "ASSISTANTS", "Таблица представляет собой ассистентов. Содержит код ассистента, " +
                "фамилию, имя, отчество и телефон." },
            { "CUSTOMERS", "Таблица представляет собой заказчиков. Содержит код заказчика, " +
                "фамилию, имя, отчество, адрес и телефон." },
            { "SERVICES", "Таблица представляет собой услуги фотостудии. Содержит код услуги, " +
                "описание и цену." },
            { "ASSISTANCE", "Таблица представляет собой помощь ассистентов в заказе. Содержит код помощи, " +
                "ассистента и заказ." }
        };


        public static void ShowGroupBox(Control.ControlCollection cc)
        {
            cc.Find(SelectedTable[0] + SelectedTable.ToLower().Remove(0, 1) + "GB", false)[0].Visible = true;
        }
    }
}
