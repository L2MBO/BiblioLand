using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Classes.SaveUserSettings
{
    internal class SaveAdminFilter
    {
        public class FilterState
        {
            public int SortIndex { get; set; }
            public bool IsDescending { get; set; }
            public string SearchQuery { get; set; }
            public int DescriptionIndex { get; set; }
        }

        public static class FilterContext
        {
            public static FilterState _currentFilterState { get; set; } = new FilterState
            {
                SortIndex = 2, // По умолчанию
                IsDescending = true, // По умолчанию
                SearchQuery = "", // По умолчанию
                DescriptionIndex = 0 // По умолчанию (не выбрано)
            };

            public static FilterState CurrentFilterState
            {
                get => _currentFilterState;
                set => _currentFilterState = value ?? new FilterState();
            }
        }
    }
}
