using System;

namespace GenericSortSearch
{
    public static class Sorting
    {
        /// <summary>
        /// Sắp xếp chọn (Selection Sort) sử dụng IComparable
        /// </summary>
        public static void SelectionSort(IComparable[] list)
        {
            int min;
            IComparable temp;

            for (int index = 0; index < list.Length - 1; index++)
            {
                min = index;
                for (int scan = index + 1; scan < list.Length; scan++)
                {
                    if (list[scan].CompareTo(list[min]) < 0)
                    {
                        min = scan;
                    }
                }
                // Hoán đổi
                temp = list[min];
                list[min] = list[index];
                list[index] = temp;
            }
        }

        /// <summary>
        /// Sắp xếp chèn (Insertion Sort) sử dụng IComparable
        /// </summary>
        public static void InsertionSort(IComparable[] list)
        {
            for (int index = 1; index < list.Length; index++)
            {
                IComparable key = list[index];
                int position = index;

                // Dịch chuyển các phần tử lớn hơn sang phải
                while (position > 0 && key.CompareTo(list[position - 1]) < 0)
                {
                    list[position] = list[position - 1];
                    position--;
                }

                list[position] = key;
            }
        }

        /// <summary>
        /// Generic Selection Sort
        /// </summary>
        public static void GenericSelectionSort<T>(T[] list) where T : IComparable<T>
        {
            int min;
            T temp;

            for (int index = 0; index < list.Length - 1; index++)
            {
                min = index;
                for (int scan = index + 1; scan < list.Length; scan++)
                {
                    if (list[scan].CompareTo(list[min]) < 0)
                    {
                        min = scan;
                    }
                }
                temp = list[min];
                list[min] = list[index];
                list[index] = temp;
            }
        }

        /// <summary>
        /// Generic Insertion Sort
        /// </summary>
        public static void GenericInsertionSort<T>(T[] list) where T : IComparable<T>
        {
            for (int index = 1; index < list.Length; index++)
            {
                T key = list[index];
                int position = index;

                while (position > 0 && key.CompareTo(list[position - 1]) < 0)
                {
                    list[position] = list[position - 1];
                    position--;
                }

                list[position] = key;
            }
        }
    }
}
