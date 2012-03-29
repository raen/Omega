using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;

namespace Omega
{
    public class EnumUtils
    {
        /// <summary>
        /// Zwraca tekst z atrybutu Description umieszczonego nad podanym enumem.
        /// Jeśli enum nie ma atrybutu Description zwracana jest jego wartość tekstowa - enumValue.ToString().
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumDescription(Enum enumValue)
        {

            DescriptionAttribute descAttr = GetEnumAttribute(enumValue, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (descAttr == null)
            {
                return enumValue.ToString();
            }
            return descAttr.Description;
        }

        /// <summary>
        /// Zwraca atrybut zadanego typu (instancję klasy pochodnej od Attribute) od zadanego enuma.
        /// Trzeba samemu rzutować zwracany obiekt na typ podany w parametrze.
        /// Jeśli jest więcej atrybutów tego samego typu zwracany jest pierwszy.
        /// Jesli enum nie ma takiego atrybutu zwracany jest null.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public static Attribute GetEnumAttribute(Enum enumValue, Type attributeType)
        {
            Attribute[] attrs = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttributes(attributeType, false) as Attribute[];
            if (attrs != null && attrs.Length > 0)
            {
                return attrs[0];
            }
            return null;
        }

        /// <summary>
        /// Wypelnie podanej tabeli enumami.
        /// </summary>
        /// <param name="enumType">Typ enuma</param>
        /// <param name="dataTable">Tabela do wypelnienia</param>
        /// <param name="enumIntValueColumnName">Nazwa kolumny w ktorej wpisana bedzie wartosc liczbowa enuma (w przypadku podania pustej nazwy kolumna bedzie pominieta)</param>
        /// <param name="enumStringValueColumnName">Nazwa kolumny w ktorej wpisana bedzie wartosc string'owa enuma (w przypadku podania pustej nazwy kolumna bedzie pominieta)</param>
        /// <param name="enumDescriptionColumnName">Nazwa kolumny w ktorej wpisana bedzie wartosc atrybutu Description (w przypadku podania pustej nazwy kolumna bedzie pominieta).
        /// Jesli enum nie posiada atrybutu Description zostanie pobranie string'owa wartosc enum'a</param>
        /// <param name="excludedItems">elemety ktore maja byc pominiete</param>
        public static void FillDataTableWithEnum(Type enumType, DataTable dataTable, string enumIntValueColumnName,
            string enumStringValueColumnName, string enumDescriptionColumnName, params Enum[] excludedItems)
        {
            List<Enum> excludedEnums = new List<Enum>();
            excludedEnums.AddRange(excludedItems);

            foreach (Enum enumItem in System.Enum.GetValues(enumType))
            {

                if (excludedEnums.Contains(enumItem)) continue;

                DataRow row = dataTable.NewRow();

                if (!String.IsNullOrEmpty(enumIntValueColumnName)) row[enumIntValueColumnName] = Convert.ToInt32(enumItem);
                if (!String.IsNullOrEmpty(enumStringValueColumnName)) row[enumStringValueColumnName] = enumItem.ToString();
                if (!String.IsNullOrEmpty(enumDescriptionColumnName)) row[enumDescriptionColumnName] = GetEnumDescription(enumItem);

                dataTable.Rows.Add(row);
            }

        }

        public static void ColumnNameValueToEnumDescription(DataTable dataTable, DataColumn dataColumn, Type enumType)
        {
            ColumnNameValueToEnumDescription(dataTable, dataColumn, dataColumn, enumType);
        }

        public static void ColumnNameValueToEnumDescription(DataTable dataTable, DataColumn sourceColumn, DataColumn destColumn, Type enumType)
        {
            foreach (DataRow dataRow in dataTable.Select())
            {
                if (dataRow.IsNull(sourceColumn))
                    continue;

                Enum enumName = enumType.GetField(dataRow[sourceColumn.ColumnName].ToString()).GetValue(null) as Enum;
                dataRow[destColumn] = EnumUtils.GetEnumDescription(enumName);
            }
        }

        /// <summary>
        /// Zwraca Enum odpowiadajacy podanej nazwie enum'a
        /// </summary>
        /// <param name="enumType">typ Enuma, ktorego nazwe podajemy jako parametr</param>
        /// <param name="enumName">nazwa enuma</param>
        /// <returns>obiekt typu Enum</returns>
        public static Enum StringToEnum(Type enumType, string enumName)
        {

            return ((Enum)Enum.Parse(enumType, enumName));
        }
    }


}
