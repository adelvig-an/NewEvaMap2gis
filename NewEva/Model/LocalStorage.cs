﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewEva.Model
{
    public class LocalStorage
    {
        public static IEnumerable<string> TypeCosts =>
            new string[]
            {
                "Определение рыночной стоимости",
                "Определение рыночной и ликвидационной стоимостей объекта оценки для целей ипотечной сделки",
                "Определение рыночной, ликвидационной стоимости имущества для предоставления в органы опеки и попечительства",
                "Определение рыночной, ликвидационной стоимости имущества для предоставления в судебные органы",
                "Определение рыночной, ликвидационной стоимости имущества для рефинансирования",
                "Определение рыночной, ликвидационной стоимости имущества для принятия управленческих решений",
                "Для целей контроля качества и оценки ликвидности объектов недвижимости, находящихся в залоге",
                "Определение рыночной и ликвидационной стоимостей объекта оценки для целей залога",
                "Определение рыночной стоимости для целей залога",
                "Определение инвестиционной стоимости",
                "Определение ликвидационной стоимости",
                "Определение кадастровой стоимости"
            };
        public static IEnumerable<string> Appraisers =>
            new string[]
            {
                "Дельвиг Антон Денисович",
                "Рошка Андрей Ильевич",
                "Шестаков Денис Александрович"
            };
        public static IEnumerable<string> TypeDocs =>
            new string[]
            {
                "Паспорт",
                "Загранпаспорт",
                "Военный билет",
                "Временное удостоверение личности",
                "Свидетельство о рождении",
                "Служебное удостоверение работника прокуратуры",
                "Персональная электронная карта"
            };
        public static IEnumerable<string> OrganizationForm =>
            new string[]
            {
                "ООО",
                "ПАО",
                "АО",
                "ИП"
            };
        public static IEnumerable<string> TypeAttorney =>
            new string[]
            {
                "Устав",
                "Доверенность",
                "Закон"
            };
    }
}
