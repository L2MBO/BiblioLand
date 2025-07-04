﻿namespace Biblio.Classes.SaveUserSettings
{
    internal class SaveUserFilter
    {
        public class FilterState
        {
            public int SortIndex { get; set; }
            public bool IsDescending { get; set; }
            public string SearchQuery { get; set; }
            public int GenreIndex { get; set; }
        }

        public static class FilterContext
        {
            public static FilterState _currentFilterState { get; set; } = new FilterState
            {
                SortIndex = 2, // По умолчанию
                IsDescending = true, // По умолчанию
                SearchQuery = "", // По умолчанию
                GenreIndex = 0 // По умолчанию (не выбрано)
            };

            public static FilterState CurrentFilterState
            {
                get => _currentFilterState;
                set => _currentFilterState = value ?? new FilterState();
            }
        }
    }
}
