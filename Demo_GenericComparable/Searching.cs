using System;

namespace GenericSortSearch
{
    public static class Searching
    {
        /// <summary>
        /// Tìm kiếm tuyến tính (Linear Search) trên mảng IComparable
        /// </summary>
        public static IComparable? LinearSearch(IComparable[] list, IComparable target)
        {
            int index = 0;
            bool found = false;

            while (!found && index < list.Length)
            {
                if (list[index].CompareTo(target) == 0)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }

            return found ? list[index] : null;
        }

        /// <summary>
        /// Tìm kiếm nhị phân (Binary Search) trên mảng IComparable đã sắp xếp
        /// </summary>
        public static IComparable? BinarySearch(IComparable[] list, IComparable target)
        {
            int min = 0;
            int max = list.Length - 1;
            int mid = 0;
            bool found = false;

            while (!found && min <= max)
            {
                mid = (min + max) / 2;
                int cmp = list[mid].CompareTo(target);

                if (cmp == 0)
                {
                    found = true;
                }
                else if (target.CompareTo(list[mid]) < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return found ? list[mid] : null;
        }

        /// <summary>
        /// Generic Linear Search
        /// </summary>
        public static T? GenericLinearSearch<T>(T[] list, T target) where T : IComparable<T>
        {
            int index = 0;
            bool found = false;

            while (!found && index < list.Length)
            {
                if (list[index].CompareTo(target) == 0)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }

            return found ? list[index] : default;
        }

        /// <summary>
        /// Generic Binary Search
        /// </summary>
        public static T? GenericBinarySearch<T>(T[] list, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = list.Length - 1;
            int mid = 0;
            bool found = false;

            while (!found && min <= max)
            {
                mid = (min + max) / 2;
                int cmp = target.CompareTo(list[mid]);

                if (cmp == 0)
                {
                    found = true;
                }
                else if (cmp < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return found ? list[mid] : default;
        }
    }
}
